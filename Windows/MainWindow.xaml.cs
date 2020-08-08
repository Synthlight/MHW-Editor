using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using JetBrains.Annotations;
using MHW_Editor.Assets;
using MHW_Editor.Controls;
using MHW_Editor.Json;
using MHW_Editor.Models;
using MHW_Editor.Structs.Armors;
using MHW_Editor.Structs.Gems;
using MHW_Editor.Structs.GuildCard;
using MHW_Editor.Structs.Items;
using MHW_Editor.Structs.Items.TimeGate;
using MHW_Editor.Structs.Misc;
using MHW_Editor.Structs.Monsters;
using MHW_Editor.Structs.PlData;
using MHW_Editor.Structs.Skills;
using MHW_Editor.Structs.Weapons;
using MHW_Editor.Util;
using MHW_Template;
using Microsoft.Win32;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.X509;

namespace MHW_Editor.Windows {
    public partial class MainWindow {
#if DEBUG
        private const bool ENABLE_CHEAT_BUTTONS = true;
#else
        private const bool ENABLE_CHEAT_BUTTONS = false;
        public const bool SHOW_RAW_BYTES = false;
#endif
        private const string TITLE     = "MHW Editor";
        public const  double FONT_SIZE = 20;

        public static LangMap skillDatLookup = new LangMap();

        [CanBeNull] private CancellationTokenSource savedTimer;

        public static string file_name = "none";

        public         string              targetFile     { get; private set; }
        public         Type                targetFileType { get; private set; }
        private static ulong               targetFileLength;
        private        IMhwMultiStructFile fileData;

        public bool unlockFields { get; }

        public static string locale = "eng";
        public string Locale {
            get => locale;
            set {
                locale = value;
                foreach (var item in fileData.GetAllEnumerableOfType<IOnPropertyChanged>()) {
                    item.OnPropertyChanged("Name",
                                           nameof(SkillDat.Entries.Description),
                                           nameof(SkillDat.Entries.Name_And_Id),
                                           nameof(MusicSkill.Entries.Song_And_Id));

                    item.OnPropertyChanged(ButtonTypeInfo.BUTTON_NAMES);
                }

                foreach (UIElement child in sub_grids.Children) {
                    if (child is MhwDataGrid grid) {
                        foreach (var entry in grid.ItemsSource) {
                            if (entry is IOnPropertyChanged propEntry) {
                                // ReSharper disable once UseNameofExpression
                                propEntry.OnPropertyChanged("Name");
                            }
                        }
                    }
                }
            }
        }

        public static bool showIdBeforeName = true;
        public bool ShowIdBeforeName {
            get => showIdBeforeName;
            set {
                showIdBeforeName = value;
                foreach (var item in fileData.GetAllEnumerableOfType<IOnPropertyChanged>()) {
                    item.OnPropertyChanged(nameof(SkillDat.Entries.Name_And_Id),
                                           nameof(MusicSkill.Entries.Song_And_Id));

                    item.OnPropertyChanged(ButtonTypeInfo.BUTTON_NAMES);
                }
            }
        }

        public bool SingleClickToEditMode { get; set; } = false;

        public MainWindow() {
            var args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                foreach (var arg in args.Skip(1).ToArray())
                {
                    if (arg.Length == 0)
                        return;

                    string iPath = Path.GetDirectoryName(arg);
                    string iFileName = Path.GetFileName(arg).Replace(".", "_");
                    string oPath = Path.Combine(iPath, "_Json");
                    string oFileName = iFileName + ".json";
                    System.IO.Directory.CreateDirectory(oPath);
                    string target = Path.Combine(oPath, oFileName);
                    BatchLoad(arg);
                    ExportJson(target);
                }
                System.Environment.Exit(0);
            }

            /*
            if (args.Length >= 2) {
                if (args.ContainsIgnoreCase("-unlock")) {
                    unlockFields = true;
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
            */

            InitializeComponent();
            Title = TITLE;

            cbx_localization.ItemsSource = Global.LANGUAGE_NAME_LOOKUP;

            Width  = SystemParameters.MaximizedPrimaryScreenWidth * 0.8;
            Height = SystemParameters.MaximizedPrimaryScreenHeight * 0.5;

            UpdateCheck.Run(this);

            // TryLoad(args);
        }

        private async void TryLoad(string[] args) {
            if (args.Length >= 2) {
                var file = args.Last();
                if (file.StartsWith("-")) return;

                // Tiny delay so the UI is visible to the user before we load.
                await Task.Delay(10);
                Load(file);
            }
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) {
            var scv = (ScrollViewer) sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void FillSkillDatDictionary(IEnumerable<SkillDat.Entries> entries) {
            // Makes the lookup table for skill dat unlock columns which reference themselves by index.
            skillDatLookup = new LangMap();
            var items = entries.ToList();
            foreach (var lang in Global.LANGUAGES) {
                skillDatLookup[lang] = new Dictionary<uint, string>();
                foreach (var item in items) {
                    var name = DataHelper.skillNames[lang].TryGet(item.Id);
                    skillDatLookup[lang][(uint) item.Index] = name;
                }
            }
        }

        public MhwDataGrid AddDataGrid<T>(IEnumerable<T> itemSource) {
            var dataGrid = new MhwDataGridGeneric<T>();
            dataGrid.SetItems(this, itemSource is ObservableCollection<T> source ? source : new ObservableCollection<T>(itemSource));
            sub_grids.AddControl(dataGrid);
            return dataGrid;
        }

        public MhwDataGrid AddMainDataGrid(Type gridType) {
            var genericType = typeof(MhwDataGridGeneric<>).MakeGenericType(gridType);
            var dataGrid    = (MhwDataGrid) Activator.CreateInstance(genericType);
            dataGrid.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            dataGrid.VerticalScrollBarVisibility   = ScrollBarVisibility.Auto;

            main_grid.AddControl(dataGrid);

            Grid.SetRow(dataGrid, 1);
            Grid.SetColumn(dataGrid, 0);
            Grid.SetColumnSpan(dataGrid, 3);

            main_grid.UpdateLayout();

            return dataGrid;
        }

        public void ClearDataGrids(Panel panel) {
            var grids = new List<UIElement>();
            foreach (UIElement child in main_grid.Children) {
                if (child is MhwDataGrid mhwGrid) {
                    grids.Add(child);
                    mhwGrid.SetItems(null, null);
                }
            }

            foreach (var grid in grids) {
                panel.Children.Remove(grid);
            }

            if (grids.Count > 0) {
                panel.UpdateLayout();
            }
        }
        private void ExportJson(string oFile = null)
        {
            if (string.IsNullOrEmpty(targetFile)) return;

            file_name = Path.GetFileName(oFile);

            var json = JsonConvert.SerializeObject(fileData, Formatting.Indented);
            if (oFile == null)
            {
                var target = GetSaveTarget();
                if (string.IsNullOrEmpty(target)) return;
                File.WriteAllText(target, json);
            }
            else
            {
                File.WriteAllText(oFile, json);
            }
        }

        private void BatchLoad(string file)
        {
            try
            {
                var target = file;
                if (string.IsNullOrEmpty(target)) return;

                targetFile = target;
                targetFileType = GetFileType(targetFile);
                Title = Path.GetFileName(targetFile);

                Debug.Assert(targetFile != null, nameof(targetFile) + " != null");

                GC.Collect();

                BatchLoadTarget();
            }
            catch (Exception e) when (!Debugger.IsAttached)
            {
                ShowError(e, "Load Error");
            }
        }
        private void BatchLoadTarget()
        {
            CheckHashAndSize(targetFile);

            var loadData = targetFileType.GetMethod("LoadData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            Debug.Assert(loadData != null, nameof(loadData) + " != null");
            fileData = (IMhwMultiStructFile)loadData.Invoke(null, new object[] { targetFile });

            switch (fileData)
            {
                case Collision col:
                    col.Init(targetFile);
                    break;
                case GcData gcData:
                    gcData.Init(targetFile);
                    break;
                case Melee melee:
                    melee.Init(targetFile);
                    break;
                case Ranged ranged:
                    ranged.Init(targetFile);
                    break;
                case SkillDat skillDat:
                    FillSkillDatDictionary(skillDat.GetSingleStructList());
                    break;
            }
        }

        private void Load(string file = null) {
            try {
                var target = file ?? GetOpenTarget($"MHW Data Files (See mod description for full list.)|{string.Join(";", Global.FILE_TYPES)}");
                if (string.IsNullOrEmpty(target)) return;

                targetFile     = target;
                targetFileType = GetFileType(targetFile);
                Title          = Path.GetFileName(targetFile);

                Debug.Assert(targetFile != null, nameof(targetFile) + " != null");

                sub_grids.Children.Clear();
                sub_grids.UpdateLayout();

                ClearDataGrids(main_grid);
                ClearDataGrids(sub_grids);

                GC.Collect();

                LoadTarget();

                UpdateButtonVisibility();
            } catch (Exception e) when (!Debugger.IsAttached) {
                ShowError(e, "Load Error");
            }
        }

        private void LoadTarget() {
            CheckHashAndSize(targetFile);

            var loadData = targetFileType.GetMethod("LoadData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            Debug.Assert(loadData != null, nameof(loadData) + " != null");
            fileData = (IMhwMultiStructFile)loadData.Invoke(null, new object[] {targetFile});

            switch (fileData) {
                case Collision col:
                    col.Init(targetFile);
                    break;
                case GcData gcData:
                    gcData.Init(targetFile);
                    break;
                case Melee melee:
                    melee.Init(targetFile);
                    break;
                case Ranged ranged:
                    ranged.Init(targetFile);
                    break;
                case SkillDat skillDat:
                    FillSkillDatDictionary(skillDat.GetSingleStructList());
                    break;
            }

            scroll_viewer.Visibility = fileData is IShowAsSingleStruct ? Visibility.Collapsed : Visibility.Visible;

            if (fileData is IShowAsSingleStruct singleStruct) {
                scroll_viewer.Visibility = Visibility.Collapsed;

                var structType    = singleStruct.GetSingleStructType();
                var getStructList = targetFileType.GetMethod("GetStructList", BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy)?.MakeGenericMethod(structType);
                var mainDataGrid  = AddMainDataGrid(structType);

                var items = getStructList?.Invoke(fileData, null) ?? throw new Exception("getStructList failure.");
                mainDataGrid.SetItems(this, items);
                mainDataGrid.IsAddingAllowed = singleStruct.GetSingleStructContainer().IsAddingAllowed;
            } else {
                scroll_viewer.Visibility = Visibility.Visible;

                var setupViews = targetFileType.GetMethod("SetupViews", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                Debug.Assert(setupViews != null, nameof(setupViews) + " != null");
                setupViews.Invoke(null, new object[] {fileData, sub_grids, this});
            }
        }

        public static void CheckHashAndSize(string targetFile) {
            var       nameWithoutExt = Path.GetFileName(targetFile);
            var       fileName       = nameWithoutExt;
            using var file           = File.OpenRead(targetFile);
            var       sha512         = file.SHA512();
            ulong     properLength;

            targetFileLength = (ulong) file.Length;

            if (DataHelper.FILE_SIZE_MAP.ContainsKey(nameWithoutExt)) properLength = DataHelper.FILE_SIZE_MAP[nameWithoutExt];
            else return;

            // Look for known bad hashes first to ensure it's not an unedited file from a previous chunk.
            foreach (var pair in DataHelper.BAD_FILE_HASH_MAP) {
                foreach (var fileAndHash in pair.Value) {
                    if (fileName == fileAndHash.Key && fileAndHash.Value.Contains(sha512)) {
                        var newChunk = DataHelper.GOOD_CHUNK_MAP.TryGet(fileName);
                        MessageBox.Show($"This file ({fileName}) is from {pair.Key} and is obsolete.\r\n" +
                                        $"The newest version of the file is in {newChunk}.\r\n\r\n" +
                                        "Using obsolete files is known to cause anything from blackscreens to crashes or incorrect data.\r\n\r\n" +
                                        "The editor will attempt to load the file, but understand, it may fail due to obsolete data.", "Obsolete File Detected", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                }
            }

            // Length check as a fallback.
            if (targetFileLength == properLength) return;

            MessageBox.Show($"The file size of {fileName} does not match the known file size in v{Global.CURRENT_GAME_VERSION}.\r\n" +
                            $"Expected: {properLength}\r\n" +
                            $"Found: {targetFileLength}\r\n" +
                            "Please make sure you've extracted the file from the highest numbered chunk that contains it.", "File Size Mismatch", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private async void Save() {
            if (string.IsNullOrEmpty(targetFile)) return;

            try {
                var saveData = targetFileType.GetMethod("SaveData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                Debug.Assert(saveData != null, nameof(saveData) + " != null");
                saveData.Invoke(null, new object[] {fileData, targetFile});

                await ShowChangesSaved(true);
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
                                                              typeof(Melee),
                                                              typeof(Ranged))
                                                          .VisibleIfTrue();

                btn_skill_level_cheat.Visibility = targetFileType.Is(typeof(Armor),
                                                                     typeof(Gem))
                                                                 .VisibleIfTrue();

                btn_set_bonus_cheat.Visibility = targetFileType.Is(typeof(Armor)).VisibleIfTrue();

                btn_cost_cheat.Visibility = targetFileType.Is(typeof(Armor),
                                                              typeof(CustomOuterRecipe),
                                                              typeof(CustomParts),
                                                              typeof(CustomPartsR),
                                                              typeof(EqCrt),
                                                              typeof(EqCus),
                                                              typeof(Item),
                                                              typeof(LimitBreakMaterialBase),
                                                              typeof(LimitBreakMaterialSkill),
                                                              typeof(Melee),
                                                              typeof(NewLimitBreak),
                                                              typeof(NewLimitBreakR),
                                                              typeof(Ranged),
                                                              typeof(RodInsect))
                                                          .VisibleIfTrue();

                btn_damage_cheat.Visibility = targetFileType.Is(typeof(Melee),
                                                                typeof(OtomoWeaponDat),
                                                                typeof(Ranged))
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

        private void CreateJson() {
            if (string.IsNullOrEmpty(targetFile)) return;

            try {
                var target = GetOpenTarget($"Matching File|{Path.GetFileName(targetFile)}");
                if (string.IsNullOrEmpty(target)) return;

                var       otherFileName   = Path.GetFileName(target);
                using var otherFile       = File.OpenRead(target);
                var       otherFileLength = (ulong) otherFile.Length;

                if (otherFileLength != targetFileLength) {
                    MessageBox.Show($"The file size of {otherFileName} does not match the file size of our current file.\r\n" +
                                    $"Cannot guess changes since they aren't from the same chunk.", "File Size Mismatch", MessageBoxButton.OK, MessageBoxImage.Error);

                    return;
                }

                // Type must be the same.
                var loadData = targetFileType.GetMethod("LoadData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                Debug.Assert(loadData != null, nameof(loadData) + " != null");
                var otherFileData = (IMhwMultiStructFile) loadData.Invoke(null, new object[] {target});

                var ourData   = fileData.GetAllEnumerableOfType<IJsonItem>().ToList();
                var otherData = otherFileData.GetAllEnumerableOfType<IJsonItem>().ToList();

                for (var i = 0; i < otherData.Count; i++) {
                    var ourObj   = ourData[i];
                    var otherObj = otherData[i];

                    foreach (var property in ourObj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy)) {
                        var getMethod = property.GetGetMethod();
                        var setMethod = property.GetSetMethod();

                        if (setMethod == null) continue;

                        var value = getMethod.Invoke(otherObj, null);

                        setMethod.Invoke(ourObj, new[] {value});
                    }
                }
            } catch (Exception e) when (!Debugger.IsAttached) {
                ShowError(e, "Load Error");
            }
        }

        [CanBeNull]
        private string CreateWildcardRegex(string uniqueId)
        {
            if (!uniqueId.Contains('|')) return null;
            var split = uniqueId.Split('|');
            for (var i = 0; i < split.Length; i++)
            {
                split[i] = $@"({split[i]}|\*)";
            }
            return $"^{string.Join(@"\|", split)}$";
        }

        private void LoadJson() {
            if (string.IsNullOrEmpty(targetFile)) return;

            try {
                var target = GetOpenTarget($"JSON|*{Path.GetExtension(targetFile)}.json");
                if (string.IsNullOrEmpty(target)) return;

                var fileName = Path.GetFileName(targetFile);

                var json          = File.ReadAllText(target);
                var changesToLoad = JsonMigrations.Migrate(json, fileName, fileData);

                if (!changesToLoad.changesV3.Any()) return;
                if (fileName != changesToLoad.targetFile && changesToLoad.targetFile != "*") return;

                const BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

                // For all entries in all structs as a single enumerable.
                foreach (var item in fileData.GetAllEnumerableOfType<IJsonItem>()) {
                    var itemUniqueId   = item.UniqueId;
                    var itemType       = item.GetType();
                    var structTypeName = itemType.Name;
                    var wildJson       = CreateWildcardRegex(itemUniqueId);

                    // For each struct we have changes for.
                    if (changesToLoad.changesV3.ContainsKey(structTypeName)) {
                        foreach (var x in changesToLoad.changesV3[structTypeName]) {
                            var jsonUniqueId = x.Key;
                            var changes      = x.Value;

                            // If the uniqueId computation matches, or wildcard.
                            if (jsonUniqueId == itemUniqueId || jsonUniqueId == "*" || wildJson != null && (Regex.IsMatch(jsonUniqueId, wildJson))) {
                                // For each change.
                                foreach (var change in changes) {
                                    var targetField  = change.Key;
                                    var targetValue  = change.Value;
                                    var propertyInfo = itemType.GetProperty(targetField, flags);

                                    // ReSharper disable once PossibleNullReferenceException
                                    if (propertyInfo.PropertyType.IsEnum) {
                                        var value = Enum.ToObject(propertyInfo.PropertyType, targetValue);
                                        propertyInfo.SetValue(item, value);
                                    } else {
                                        var value = Convert.ChangeType(targetValue, propertyInfo.PropertyType);
                                        propertyInfo.SetValue(item, value);
                                    }
                                }
                            }
                        }
                    }
                }

                foreach (UIElement child in sub_grids.Children) {
                    if (child is MhwDataGrid mhwGrid) {
                        foreach (var type in mhwGrid.GetType().GenericTypeArguments) {
                            if (type.Is(typeof(MultiStructItemCustomView))) {
                                mhwGrid.Refresh();
                            }
                        }
                    }
                }
            } catch (Exception e) when (!Debugger.IsAttached) {
                ShowError(e, "Load Error");
            }
        }

        private async void SaveJson(bool mergeWithTarget) {
            if (string.IsNullOrEmpty(targetFile)) return;

            try {
                var fileName = Path.GetFileName(targetFile);
                JsonChanges changesToSave = null;

                if (mergeWithTarget) {
                    try {
                        var target = GetOpenTarget($"JSON|*{Path.GetExtension(targetFile)}.json");
                        // Should migrate the loaded changes too.
                        changesToSave = JsonMigrations.Migrate(File.ReadAllText(target), fileName, fileData);
                    } catch (Exception) {
                        // Don't care. If it doesn't exist or can't be read, it gets overwritten.
                    }
                }

                if (changesToSave == null) {
                    changesToSave = new JsonChanges {
                        targetFile = fileName,
                        version    = JsonMigrations.CURRENT_VERSION
                    };
                } else {
                    // Set target & version explicitly in case the user is merging into a different wp_dat or something.
                    changesToSave.targetFile = fileName;
                }

                changesToSave.changesV3 ??= new Dictionary<string, Dictionary<string, Dictionary<string, object>>>();

                // For all entries in all structs as a single enumerable.
                foreach (var item in fileData.GetAllEnumerableOfType<IJsonItem>()) {
                    var itemUniqueId   = item.UniqueId;
                    var itemType       = item.GetType();
                    var structTypeName = itemType.Name;
                    var changed        = item.ChangedItems;

                    if (changed.Count == 0) continue;

                    if (!changesToSave.changesV3.ContainsKey(structTypeName)) {
                        changesToSave.changesV3[structTypeName] = new Dictionary<string, Dictionary<string, object>>();
                    }

                    if (!changesToSave.changesV3[structTypeName].ContainsKey(itemUniqueId)) {
                        changesToSave.changesV3[structTypeName][itemUniqueId] = new Dictionary<string, object>();
                    }

                    foreach (var changedItem in changed) {
                        // Ignore. it's always 'changed' since it's computed.
                        if (changedItem == nameof(IMhwStructItem.Index)) continue;

                        // ReSharper disable once PossibleNullReferenceException
                        var value = itemType.GetProperty(changedItem, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(item);
                        changesToSave.changesV3[structTypeName][itemUniqueId][changedItem] = value;
                    }
                }

                // Removes empty entries.
                CleanDictionary(changesToSave.changesV3);

                if (changesToSave.changesV3.Any()) {
                    // Get file after checking for what to save else we show a dialog even if there are no changes.
                    var target = GetSaveTarget();
                    if (string.IsNullOrEmpty(target)) return;

                    var json = JsonConvert.SerializeObject(changesToSave, Formatting.Indented);
                    File.WriteAllText(target, json);

                    // Not `await ShowChangesSaved(changesSaved)` since we may cancel the dialog.
                    await ShowChangesSaved(true);
                } else {
                    await ShowChangesSaved(false);
                }
            } catch (Exception e) when (!Debugger.IsAttached) {
                ShowError(e, "Save Error");
            }
        }

        private bool CleanDictionary(dynamic dict) {
            var toRemove         = new List<string>();
            var effectivelyEmpty = true;

            foreach (var key in dict.Keys) {
                var value = dict[key];
                if (((Type) value.GetType()).Is(typeof(IEnumerable))) {
                    var innerEmpty = false;
                    if (value.Count > 0) {
                        innerEmpty = CleanDictionary(value);
                    }
                    // We've cleaned, now we check again.
                    if (value.Count == 0 || innerEmpty) {
                        toRemove.Add(key);
                    } else {
                        effectivelyEmpty = false;
                    }
                } else {
                    effectivelyEmpty = false;
                }
            }

            foreach (var key in toRemove) {
                dict.Remove(key);
            }

            return effectivelyEmpty;
        }

        private string GetOpenTarget(string filter) {
            var ofdResult = new OpenFileDialog {
                Filter           = filter,
                Multiselect      = false,
                InitialDirectory = targetFile == null ? string.Empty : Path.GetDirectoryName(targetFile) ?? string.Empty
            };
            ofdResult.ShowDialog();

            return ofdResult.FileName;
        }

        private string GetSaveTarget() {
            var sfdResult = new SaveFileDialog {
                Filter           = $"JSON|*{Path.GetExtension(targetFile)}.json",
                FileName         = $"{Path.GetFileNameWithoutExtension(targetFile)}",
                InitialDirectory = targetFile == null ? string.Empty : Path.GetDirectoryName(targetFile) ?? string.Empty,
                AddExtension     = true
            };
            return sfdResult.ShowDialog() == true ? sfdResult.FileName : null;
        }

        public static Type GetFileType(string targetFile) {
            var fileName = Path.GetFileName(targetFile).ToLower();
            Debug.Assert(fileName != null, nameof(fileName) + " != null");

            if (fileName.EndsWith(".aeq")) return typeof(ArenaEquipment);
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
            if (fileName.EndsWith(".dtt_dif")) return typeof(MonsterDifficulty);
            if (fileName.EndsWith(".dtt_eda")) return typeof(MonsterDamageAttributes);
            if (fileName.EndsWith(".dtt_epg")) return typeof(MonsterParts);
            if (fileName.EndsWith(".dtt_rsz")) return typeof(MonsterRandomSize);
            if (fileName.EndsWith(".dtt_sta")) return typeof(MonsterStamina);
            if (fileName.EndsWith(".ecp")) return typeof(MonsterCommonParam);
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
            if (fileName.EndsWith(".eq_crt")) return typeof(EqCrt);
            if (fileName.EndsWith(".eq_cus")) return typeof(EqCus);
            if (fileName.EndsWith(".gcod")) return typeof(GcData);
            if (fileName.EndsWith(".gip")) return typeof(ScoutflyData);
            if (fileName.EndsWith(".gun_rd")) return typeof(GunnerReload);
            if (fileName.EndsWith(".gun_sd")) return typeof(GunnerShoot);
            if (fileName.EndsWith(".imk")) return typeof(ItemMake);
            if (fileName.EndsWith(".itlist")) return typeof(ItemList);
            if (fileName.EndsWith(".itlot")) return typeof(ItemLottery);
            if (fileName.EndsWith(".itm")) return typeof(Item);
            if (fileName.EndsWith(".kire")) return typeof(Sharpness);
            if (fileName.EndsWith(".lbm_base")) return typeof(LimitBreakMaterialBase);
            if (fileName.EndsWith(".lbm_skill")) return typeof(LimitBreakMaterialSkill);
            if (fileName.EndsWith(".mbd")) return typeof(MotionBlendData);
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
            if (fileName.EndsWith(".ranml")) return typeof(RoomAnimal);
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
            if (fileName.EndsWith(".w00p")) return typeof(Wp00Param);
            if (fileName.EndsWith(".w01p")) return typeof(Wp01Param);
            if (fileName.EndsWith(".w02p")) return typeof(Wp02Param);
            if (fileName.EndsWith(".w03p")) return typeof(Wp03Param);
            if (fileName.EndsWith(".w04p")) return typeof(Wp04Param);
            if (fileName.EndsWith(".w05p")) return typeof(Wp05Param);
            if (fileName.EndsWith(".w06p")) return typeof(Wp06Param);
            if (fileName.EndsWith(".w07p")) return typeof(Wp07Param);
            if (fileName.EndsWith(".w08p")) return typeof(Wp08Param);
            if (fileName.EndsWith(".w09p")) return typeof(Wp09Param);
            if (fileName.EndsWith(".w10p")) return typeof(Wp10Param);
            if (fileName.EndsWith(".w11p")) return typeof(Wp11Param);
            if (fileName.EndsWith(".w12p")) return typeof(Wp12Param);
            if (fileName.EndsWith(".w13p")) return typeof(Wp13Param);
            if (fileName.EndsWith(".wep_glan")) return typeof(WeaponGunLance);
            if (fileName.EndsWith(".wep_saxe")) return typeof(WeaponSwitchAxe);
            if (fileName.EndsWith(".wep_wsd")) return typeof(WeaponWSword);
            if (fileName.EndsWith(".wep_wsl")) return typeof(WeaponWhistle);
            if (fileName.EndsWith(".wp_dat")) return typeof(Melee);
            if (fileName.EndsWith(".wp_dat_g")) return typeof(Ranged);

            // Special Cases
            if (fileName == "block_26.bin") return typeof(TimeGate);

            throw new Exception($"No type found for: {fileName}");
        }

        public static void ShowError(Exception err, string title) {
            var errMsg = "Error occurred. Press Ctrl+C to copy the contents of th.s window and report to the developer.\r\n\r\n";

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