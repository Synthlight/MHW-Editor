using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using JetBrains.Annotations;
using MHW_Editor.Armors;
using MHW_Editor.Assets;
using MHW_Editor.Controls;
using MHW_Editor.Gems;
using MHW_Editor.GuildCard;
using MHW_Editor.Items;
using MHW_Editor.Items.TimeGate;
using MHW_Editor.Models;
using MHW_Editor.Monsters;
using MHW_Editor.PlData;
using MHW_Editor.Skills;
using MHW_Editor.Weapons;
using MHW_Editor.Weapons.Collision;
using MHW_Template;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace MHW_Editor {
    public partial class MainWindow {
#if DEBUG
        private const bool ENABLE_CHEAT_BUTTONS = true;
        public const  bool SHOW_RAW_BYTES       = true;
#else
        private const bool ENABLE_CHEAT_BUTTONS = false;
        public const bool SHOW_RAW_BYTES = false;
#endif
        public const  string CURRENT_GAME_VERSION = "13.5X.XX";
        private const string TITLE                = "MHW Editor";
        public const  double FONT_SIZE            = 20;

        public static LangMap skillDatLookup = new LangMap();

        [CanBeNull] private CancellationTokenSource savedTimer;

        private readonly List<MhwDataGrid> dataGrids = new List<MhwDataGrid>();

        public  string  targetFile     { get; private set; }
        public  Type    targetFileType { get; private set; }
        private dynamic customFileData;

        public bool unlockFields { get; }
        public bool showAll      { get; }

        public static string locale = "eng";
        public string Locale {
            get => locale;
            set {
                locale = value;
                foreach (var dataGrid in dataGrids) {
                    foreach (MhwItem item in dataGrid.Items) {
                        item.OnPropertyChanged(nameof(IMhwItem.Name),
                                               nameof(SkillDat.Description),
                                               nameof(SkillDat.Name_And_Id),
                                               nameof(MusicSkill.Song_And_Id));

                        item.OnPropertyChanged(ButtonTypeInfo.BUTTON_NAMES);
                    }
                }
            }
        }

        public static bool showIdBeforeName = true;
        public bool ShowIdBeforeName {
            get => showIdBeforeName;
            set {
                showIdBeforeName = value;
                foreach (var dataGrid in dataGrids) {
                    foreach (MhwItem item in dataGrid.Items) {
                        item.OnPropertyChanged(nameof(SkillDat.Name_And_Id),
                                               nameof(MusicSkill.Song_And_Id));

                        item.OnPropertyChanged(ButtonTypeInfo.BUTTON_NAMES);
                    }
                }
            }
        }

        public bool SingleClickToEditMode { get; set; } = true;

        public MainWindow() {
            var args = Environment.GetCommandLineArgs();

            if (args.Length >= 2) {
                if (args.ContainsIgnoreCase("-unlock")) {
                    unlockFields = true;
                }

                if (args.ContainsIgnoreCase("-showAll")) {
                    showAll = true;
                }
            }

            if (args.Length >= 4) {
                try {
                    if (args.ContainsIgnoreCase("-decrypt") || args.ContainsIgnoreCase("-encrypt")) {
                        var action  = args[1].ToLower();
                        var inFile  = args[2];
                        var outFile = args[3];

                        var ext = Path.GetExtension(inFile);
                        var key = args.Length == 5 ? args[4] : EncryptionKeys.FILE_EXT_KEY_LOOKUP.TryGet(ext, null);

                        if (key == null) {
                            MessageBox.Show($"Unknown Key for: {ext}", "Unknown Key", MessageBoxButton.OK, MessageBoxImage.Error);
                            Close();
                            return;
                        }

                        switch (action) {
                            case "-decrypt":
                                EncryptionHelper.Decrypt(key, inFile, outFile);
                                break;
                            case "-encrypt":
                                EncryptionHelper.Encrypt(key, inFile, outFile);
                                break;
                        }
                    }
                } catch (Exception e) {
                    ShowError(e, "Error");
                }

                Close();
                return;
            }

            InitializeComponent();
            Title = TITLE;

            main_grid.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            main_grid.VerticalScrollBarVisibility   = ScrollBarVisibility.Auto;

            cbx_localization.ItemsSource = Global.LANGUAGE_NAME_LOOKUP;

            Width  = SystemParameters.MaximizedPrimaryScreenWidth * 0.8;
            Height = SystemParameters.MaximizedPrimaryScreenHeight * 0.5;

            UpdateCheck.Run(this);
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) {
            var scv = (ScrollViewer) sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void FillSkillDatDictionary(ObservableCollection<dynamic> items) {
            // Makes the lookup table for skill dat unlock columns which reference themselves by index.
            skillDatLookup = new LangMap();
            foreach (var lang in Global.LANGUAGES) {
                skillDatLookup[lang] = new Dictionary<uint, string>();
                foreach (SkillDat item in items) {
                    var name = DataHelper.skillNames[lang].TryGet(item.Id);
                    skillDatLookup[lang][(uint) item.Index] = name;
                }
            }
        }

        public DataGrid AddDataGrid<T>(IEnumerable<T> itemSource) {
            var dataGrid = new MhwDataGrid();
            dataGrid.SetItems(this, itemSource is ObservableCollection<dynamic> source ? source : new ObservableCollection<dynamic>((dynamic) itemSource));
            dataGrids.Add(dataGrid);
            grid.AddControl(dataGrid);
            return dataGrid;
        }

        private void Load() {
            try {
                var target = GetOpenTarget($"MHW Data Files (See mod description for full list.)|{string.Join(";", Global.FILE_TYPES)}");
                if (string.IsNullOrEmpty(target)) return;

                targetFile     = target;
                targetFileType = GetFileType();
                Title          = Path.GetFileName(targetFile);

                Debug.Assert(targetFile != null, nameof(targetFile) + " != null");

                grid.Children.Clear();
                grid.UpdateLayout();

                foreach (var dg in dataGrids) {
                    dg.SetItems(null, null);
                }

                dataGrids.Clear();

                GC.Collect();

                var hasCustomLoad = targetFileType.Is(typeof(ICustomSaveLoad));

                scroll_viewer.Visibility = hasCustomLoad ? Visibility.Visible : Visibility.Collapsed;
                main_grid.Visibility     = hasCustomLoad ? Visibility.Collapsed : Visibility.Visible;

                if (hasCustomLoad) { // Custom save/load.
                    LoadCustom();
                } else {
                    LoadSingleStruct();
                }

                UpdateButtonVisibility();
            } catch (Exception e) when (!Debugger.IsAttached) {
                ShowError(e, "Load Error");
            }
        }

        private void LoadCustom() {
            SaveLoad.CheckHashAndSize(targetFile, true);

            var loadData = targetFileType.GetMethod("LoadData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            Debug.Assert(loadData != null, nameof(loadData) + " != null");
            customFileData = loadData.Invoke(null, new object[] {targetFile});

            var setupViews = targetFileType.GetMethod("SetupViews", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            Debug.Assert(setupViews != null, nameof(setupViews) + " != null");
            setupViews.Invoke(null, new object[] {customFileData, grid, this});
        }

        private void LoadSingleStruct() {
            var items = SaveLoad.LoadFile(targetFile, targetFileType);
            if (items == null) return;

            if (targetFileType.Is(typeof(SkillDat))) {
                FillSkillDatDictionary(items);
            }

            dataGrids.Add(main_grid);
            main_grid.SetItems(this, items);
        }

        private async void Save() {
            if (string.IsNullOrEmpty(targetFile)) return;

            try {
                if (targetFileType.Is(typeof(ICustomSaveLoad))) { // Custom save/load.
                    var saveData = targetFileType.GetMethod("SaveData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                    Debug.Assert(saveData != null, nameof(saveData) + " != null");
                    saveData.Invoke(null, new object[] {customFileData, targetFile});

                    await ShowChangesSaved(true);
                    return;
                }

                var changesSaved = SaveLoad.SaveFile(targetFile, targetFileType, main_grid.Items);

                await ShowChangesSaved(changesSaved);
            } catch (Exception e) when (!Debugger.IsAttached) {
                ShowError(e, "Save Error");
            }
        }

        private async Task ShowChangesSaved(bool changesSaved) {
            savedTimer?.Cancel();
            savedTimer                = new CancellationTokenSource();
            lbl_saved.Visibility      = changesSaved.VisibleIfTrue();
            lbl_no_changes.Visibility = changesSaved ? Visibility.Collapsed : Visibility.Visible;
            try {
                await Task.Delay(3000, savedTimer.Token);
                lbl_saved.Visibility = lbl_no_changes.Visibility = Visibility.Hidden;
            } catch (TaskCanceledException) {
            }
        }

        private void UpdateButtonVisibility() {
            if (string.IsNullOrEmpty(targetFile)) return;

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
#pragma warning disable 162
            if (ENABLE_CHEAT_BUTTONS) {
                btn_customize.Visibility = targetFileType.Is(typeof(Armor),
                                                             typeof(SkillDat))
                                                         .VisibleIfTrue();

                btn_slot_cheat.Visibility = targetFileType.Is(typeof(Armor),
                                                              typeof(ASkill),
                                                              typeof(IWeapon))
                                                          .VisibleIfTrue();

                btn_skill_level_cheat.Visibility = targetFileType.Is(typeof(Armor),
                                                                     typeof(Gem))
                                                                 .VisibleIfTrue();

                btn_set_bonus_cheat.Visibility = targetFileType.Is(typeof(Armor)).VisibleIfTrue();

                btn_cost_cheat.Visibility = targetFileType.Is(typeof(Armor),
                                                              typeof(CustomOuterRecipe),
                                                              typeof(CustomParts),
                                                              typeof(CustomPartsR),
                                                              typeof(EqCrt_Base),
                                                              typeof(EqCus_Base),
                                                              typeof(Item),
                                                              typeof(IWeapon),
                                                              typeof(NewLimitBreak),
                                                              typeof(NewLimitBreakR),
                                                              typeof(RodInsect))
                                                          .VisibleIfTrue();

                btn_damage_cheat.Visibility = targetFileType.Is(typeof(IWeapon),
                                                                typeof(OtomoWeaponDat))
                                                            .VisibleIfTrue();

                btn_enable_all_coatings_cheat.Visibility = targetFileType.Is(typeof(BottleTable)).VisibleIfTrue();

                btn_max_sharpness_cheat.Visibility = targetFileType.Is(typeof(Melee),
                                                                       typeof(Sharpness))
                                                                   .VisibleIfTrue();

                btn_unlock_skill_limit_cheat.Visibility = targetFileType.Is(typeof(SkillDat)).VisibleIfTrue();

                btn_fast_reload_rapid_fire_cheat.Visibility = targetFileType.Is(typeof(ShellTable)).VisibleIfTrue();
            }
#pragma warning restore 162

            btn_sort_jewel_order_by_name.Visibility = targetFileType.Is(typeof(Item)).VisibleIfTrue();

            cb_show_id_before_name.Visibility = (targetFileType.Is(typeof(DecoGradeLottery),
                                                                   typeof(DecoLottery),
                                                                   typeof(KulveGradeLottery),
                                                                   typeof(MusicSkill),
                                                                   typeof(QuestReward),
                                                                   typeof(SafiItemGradeLottery),
                                                                   typeof(SkillDat),
                                                                   typeof(SkillPointData))
                                                 || ButtonTypeInfo.TYPES_WITH_BUTTONS.Contains(targetFileType.Name)).VisibleIfTrue();
        }

        private void LoadJson() {
            if (string.IsNullOrEmpty(targetFile)) return;

            try {
                var target = GetOpenTarget($"JSON|*{Path.GetExtension(targetFile)}.json");
                if (string.IsNullOrEmpty(target)) return;

                var fileName = Path.GetFileName(targetFile);

                var json          = File.ReadAllText(target);
                var changesToLoad = JsonMigrations.Migrate(json, fileName, main_grid.Items);

                if (!changesToLoad.changes.Any()) return;
                if (fileName != changesToLoad.targetFile && changesToLoad.targetFile != "*") return;

                foreach (MhwItem item in main_grid.Items) {
                    var id           = item.UniqueId;
                    var changedItems = changesToLoad.changes.TryGet(id, null);
                    if (changedItems == null) {
                        // Try for wildcard option.
                        changedItems = changesToLoad.changes.TryGet("*", null);
                        if (changedItems == null) continue;
                    }

                    foreach (var changedItem in changedItems) {
                        var propertyInfo = item.GetType().GetProperty(changedItem.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                        if (propertyInfo.PropertyType.IsEnum) {
                            var value = Enum.ToObject(propertyInfo.PropertyType, changedItem.Value);
                            propertyInfo.SetValue(item, value);
                        } else {
                            var value = Convert.ChangeType(changedItem.Value, propertyInfo.PropertyType);
                            propertyInfo.SetValue(item, value);
                        }
                    }
                }

                if (targetFileType.IsGeneric(typeof(IHasCustomView<>))) {
                    foreach (var dataGrid in dataGrids) {
                        ((ListCollectionView) dataGrid.ItemsSource).Refresh();
                    }
                }
            } catch (Exception e) when (!Debugger.IsAttached) {
                ShowError(e, "Load Error");
            }
        }

        private async void SaveJson(bool mergeWithTarget) {
            if (string.IsNullOrEmpty(targetFile)) return;

            try {
                var         fileName      = Path.GetFileName(targetFile);
                JsonChanges changesToSave = null;

                if (mergeWithTarget) {
                    try {
                        var target = GetOpenTarget($"JSON|*{Path.GetExtension(targetFile)}.json");
                        // Should migrate the loaded changes too.
                        changesToSave = JsonMigrations.Migrate(File.ReadAllText(target), fileName, main_grid.Items);
                    } catch (Exception) {
                        // Don't care. If it doesn't exist or can't be read, it gets overwritten.
                    }
                }

                if (changesToSave == null) {
                    changesToSave = new JsonChanges {
                        targetFile = fileName,
                        version    = JsonMigrations.VERSION_MAP.TryGet(fileName, (uint) 1)
                    };
                } else {
                    // Set target & version explicitly in case the user is merging into a different wp_dat or something.
                    changesToSave.targetFile = fileName;
                    changesToSave.version    = JsonMigrations.VERSION_MAP.TryGet(fileName, (uint) 1);
                }

                foreach (MhwItem item in main_grid.Items) {
                    if (item.changed.Count == 0) continue;

                    var id = item.UniqueId;

                    if (!changesToSave.changes.ContainsKey(id)) {
                        changesToSave.changes[id] = new Dictionary<string, object>();
                    }

                    foreach (var changedItem in item.changed) {
                        var value = item.GetType().GetProperty(changedItem, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(item);
                        changesToSave.changes[id][changedItem] = value;
                    }
                }

                var changesSaved = changesToSave.changes.Any();

                if (changesSaved) {
                    // Get file after checking for what to save else we show a dialog even if there are no changes.
                    var target = GetSaveTarget();
                    if (string.IsNullOrEmpty(target)) return;

                    var json = JsonConvert.SerializeObject(changesToSave, Formatting.Indented);
                    File.WriteAllText(target, json);
                }

                await ShowChangesSaved(changesSaved);
            } catch (Exception e) when (!Debugger.IsAttached) {
                ShowError(e, "Save Error");
            }
        }

        private string GetOpenTarget(string filter) {
            var ofdResult = new OpenFileDialog {
                Filter      = filter,
                Multiselect = false
            };
            ofdResult.ShowDialog();

            return ofdResult.FileName;
        }

        private string GetSaveTarget() {
            var sfdResult = new SaveFileDialog {
                Filter       = $"JSON|*{Path.GetExtension(targetFile)}.json",
                FileName     = $"{Path.GetFileNameWithoutExtension(targetFile)}",
                AddExtension = true
            };
            sfdResult.ShowDialog();

            return sfdResult.FileName;
        }

        private Type GetFileType() {
            var fileName = Path.GetFileName(targetFile).ToLower();
            Debug.Assert(fileName != null, nameof(fileName) + " != null");

            if (fileName.EndsWith(".am_dat")) return typeof(Armor);
            if (fileName.EndsWith(".arm_up")) return typeof(ArmUp);
            if (fileName.EndsWith(".ask")) return typeof(ASkill);
            if (fileName.EndsWith(".asp")) return typeof(PlMantleParam);
            if (fileName.EndsWith(".bbtbl")) return typeof(BottleTable);
            if (fileName.EndsWith(".ch_dat")) return typeof(PendantData);
            if (fileName.EndsWith(".col")) return typeof(Collision);
            if (fileName.EndsWith(".cus_otr")) return typeof(CustomOuterRecipe);
            if (fileName.EndsWith(".cus_ou")) return typeof(CustomOuterWeapon);
            if (fileName.EndsWith(".cus_pa")) return typeof(CustomParts);
            if (fileName.EndsWith(".cus_par")) return typeof(CustomPartsR);
            if (fileName.EndsWith(".dglt")) return typeof(DecoGradeLottery);
            if (fileName.EndsWith(".diot")) return typeof(DecoLottery);
            if (fileName.EndsWith(".dtt_agr")) return typeof(MonsterEnrage);
            if (fileName.EndsWith(".dtt_clawc")) return typeof(MonsterClawGrab);
            if (fileName.EndsWith(".dtt_dif")) return typeof(MonsterDifficulty);
            if (fileName.EndsWith(".dtt_rsz")) return typeof(MonsterRandomSize);
            if (fileName.EndsWith(".dtt_sta")) return typeof(MonsterStamina);
            if (fileName.EndsWith(".em104exp")) return typeof(AwakenedExp);
            if (fileName.EndsWith(".em104glt")) return typeof(SafiItemGradeLottery);
            if (fileName.EndsWith(".em104iot")) return typeof(SafiItemLottery);
            if (fileName.EndsWith(".em104lb")) return typeof(AwakenedLimitBreak);
            if (fileName.EndsWith(".em104lbr")) return typeof(AwakenedLimitBreakR);
            if (fileName.EndsWith(".em104wcd")) return typeof(AwakenedWpCustom);
            if (fileName.EndsWith(".em104wud")) return typeof(AwakenedWpUpgrade);
            if (fileName.EndsWith(".em117glt")) return typeof(KulveGradeLottery);
            if (fileName.EndsWith(".em117iot")) return typeof(KulveItemLottery);
            if (fileName.EndsWith(".emst")) return typeof(EnemySort);
            if (fileName.EndsWith(".em_ss")) return typeof(SmallMonsterSizeParams);

            if (fileName.EndsWith(".eq_crt")) {
                if (fileName.StartsWith("armor")) return typeof(EqCrt_Armor);
                if (fileName.StartsWith("charm")) return typeof(EqCrt_Charm);
                if (fileName.StartsWith("ot_equip")) return typeof(EqCrt_Palico);
                if (fileName.StartsWith("weapon")) return typeof(EqCrt_Weapon);
            }

            if (fileName.EndsWith(".eq_cus")) {
                if (fileName.StartsWith("equip_custom")) return typeof(EqCus_Armor);
                if (fileName.StartsWith("insect_element")) return typeof(EqCus_Misc);
                if (fileName.StartsWith("insect")) return typeof(EqCus_Misc);
                if (fileName.StartsWith("weapon")) return typeof(EqCus_Weapon);
            }

            if (fileName.EndsWith(".gcod")) {
                if (fileName.StartsWith("gc_data_bg")) return typeof(GcData_Backgrounds);
                if (fileName.StartsWith("gc_data_face")) return typeof(GcData_Expressions);
                if (fileName.StartsWith("gc_data_pose")) return typeof(GcData_Poses);
                if (fileName.StartsWith("gc_data_title1")) return typeof(GcData_Title1);
                if (fileName.StartsWith("gc_data_title2")) return typeof(GcData_Title2);
            }

            if (fileName.EndsWith(".gcod")) return typeof(GcData);
            if (fileName.EndsWith(".gun_rd")) return typeof(GunnerReload);
            if (fileName.EndsWith(".gun_sd")) return typeof(GunnerShoot);
            if (fileName.EndsWith(".imk")) return typeof(ItemMake);
            if (fileName.EndsWith(".itlist")) return typeof(ItemList);
            if (fileName.EndsWith(".itlot")) return typeof(ItemLottery);
            if (fileName.EndsWith(".itm")) return typeof(Item);
            if (fileName.EndsWith(".kire")) return typeof(Sharpness);
            if (fileName.EndsWith(".lbm_base")) return typeof(LimitBreakMaterialBase);
            if (fileName.EndsWith(".lbm_skill")) return typeof(LimitBreakMaterialSkill);
            if (fileName.EndsWith(".mkex")) return typeof(MelderExchange);
            if (fileName.EndsWith(".mkit")) return typeof(MelderItem);
            if (fileName.EndsWith(".msk")) return typeof(MusicSkill);
            if (fileName.EndsWith(".mske")) return typeof(PlMusicSkillParam);
            if (fileName.EndsWith(".new_lb")) return typeof(NewLimitBreak);
            if (fileName.EndsWith(".new_lbr")) return typeof(NewLimitBreakR);
            if (fileName.EndsWith(".odr")) return typeof(Bounty);
            if (fileName.EndsWith(".oam_dat")) return typeof(OtomoArmorDat);
            if (fileName.EndsWith(".owp_dat")) return typeof(OtomoWeaponDat);
            if (fileName.EndsWith(".plfe")) return typeof(PlantFertilizer);
            if (fileName.EndsWith(".plip")) return typeof(PlItemParam);
            if (fileName.EndsWith(".plit")) return typeof(PlantItem);
            if (fileName.EndsWith(".plp")) return typeof(PlPlayerParam);
            if (fileName.EndsWith(".plsp")) return typeof(PlSkillParam);
            if (fileName.EndsWith(".rod_inse")) return typeof(RodInsect);
            if (fileName.EndsWith(".ransz")) return typeof(AnimalSize);
            if (fileName.EndsWith(".rem")) return typeof(QuestReward);
            if (fileName.EndsWith(".rfur")) return typeof(RoomFurniture);
            if (fileName.EndsWith(".sed")) return typeof(ShopSed);
            if (fileName.EndsWith(".sgpa")) return typeof(Gem);
            if (fileName.EndsWith(".shl_tbl")) return typeof(ShellTable);
            if (fileName.EndsWith(".skl_dat")) return typeof(SkillDat);
            if (fileName.EndsWith(".skl_pt_dat")) return typeof(SkillPointData);
            if (fileName.EndsWith(".shlp")) return typeof(ShellParam);
            if (fileName.EndsWith(".slt")) return typeof(ShopList);
            if (fileName.EndsWith(".srl")) return typeof(SteamRewardList);
            if (fileName.EndsWith(".stmp")) return typeof(ItemDelivery);
            if (fileName.EndsWith(".supp")) return typeof(SupplyData);
            if (fileName.EndsWith(".swer")) return typeof(SwapEnemyRate);
            if (fileName.EndsWith(".swpc")) return typeof(SwapC);
            if (fileName.EndsWith(".swpi")) return typeof(SwapItem);
            if (fileName.EndsWith(".swpn")) return typeof(SwapN);
            if (fileName.EndsWith(".trdr")) return typeof(ValueTrader);
            if (fileName.EndsWith(".trsr")) return typeof(Treasure);
            if (fileName.EndsWith(".w10p")) return typeof(Wp10Param);
            if (fileName.EndsWith(".w11p")) return typeof(Wp11Param);
            if (fileName.EndsWith(".w12p")) return typeof(Wp12Param);
            if (fileName.EndsWith(".w13p")) return typeof(Wp13Param);
            if (fileName.EndsWith(".wep_glan")) return typeof(WeaponGunLance);
            if (fileName.EndsWith(".wep_saxe")) return typeof(WeaponSwitchAxe);
            if (fileName.EndsWith(".wep_wsd")) return typeof(WeaponWSword);
            if (fileName.EndsWith(".wep_wsl")) return typeof(WeaponWhistle);
            if (fileName.EndsWith(".wp_dat")) return typeof(Melee);
            if (fileName.EndsWith(".wp_dat_g")) {
                if (fileName.StartsWith("bow")) return typeof(Bow);
                if (fileName.StartsWith("lbg") || fileName.StartsWith("hbg")) return typeof(BowGun);
            }

            // Special Cases
            if (fileName == "block_26.bin") return typeof(TimeGate);

            throw new Exception($"No type found for: {fileName}");
        }

        public static void ShowError(Exception err, string title) {
            var errMsg = "Error occured. Press Ctrl+C to copy the contents of ths window and report to the developer.\r\n\r\n";

            if (title == "Load Error") {
                errMsg += "If this is the result of ignoring the obsolete data warning, it is safe to ignore.\r\n\r\n";
            }

            MessageBox.Show(errMsg + err, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        protected override void OnClosed(EventArgs e) {
            if (UpdateCheck.notifyIcon != null) {
                UpdateCheck.notifyIcon.Visible = false;
                UpdateCheck.notifyIcon.Dispose();
            }

            base.OnClosed(e);
        }
    }
}