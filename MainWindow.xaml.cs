using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using JetBrains.Annotations;
using MHW_Editor.Armors;
using MHW_Editor.Assets;
using MHW_Editor.Gems;
using MHW_Editor.Items;
using MHW_Editor.Models;
using MHW_Editor.Monsters;
using MHW_Editor.PlData;
using MHW_Editor.Skills;
using MHW_Editor.Weapons;
using MHW_Editor.Weapons.Collision;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Weapons;
using Microsoft.Win32;
using Newtonsoft.Json;
using NotifyIcon = System.Windows.Forms.NotifyIcon;
using SystemIcons = System.Drawing.SystemIcons;
using ToolTipIcon = System.Windows.Forms.ToolTipIcon;

namespace MHW_Editor {
    public partial class MainWindow {
#if DEBUG
        private const bool ENABLE_CHEAT_BUTTONS = true;
        private const bool SHOW_RAW_BYTES = true;
#else
        private const bool ENABLE_CHEAT_BUTTONS = false;
        private const bool SHOW_RAW_BYTES = false;
#endif
        private const string NEXUS_LINK = "https://www.nexusmods.com/monsterhunterworld/mods/2068";
        private const string CURRENT_GAME_VERSION = "13.0X.XX";
        private const string TITLE = "MHW Editor";
        public const double FONT_SIZE = 20;

        private readonly ObservableCollection<dynamic> items = new ObservableCollection<dynamic>();
        private string targetFile;
        private Type targetFileType;
        private Dictionary<object, Dictionary<string, ColumnHolder>> columnMap;
        [CanBeNull]
        private DataGridRow coloredRow;
        private bool isManualEditCommit;
        public static LangMap skillDatLookup = new LangMap();
        [CanBeNull]
        private CancellationTokenSource savedTimer;
        private readonly Brush backgroundBrush = (Brush) new BrushConverter().ConvertFrom("#c0e1fb");
        [CanBeNull]
        private NotifyIcon notifyIcon;
        private readonly bool unlockFields;
        private readonly List<DataGrid> dataGrids = new List<DataGrid>();
        private dynamic customFileData;
        public static bool showAll;

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

        private DataGrid mainDataGrid => (DataGrid) content_control.Content;

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
                        var action = args[1].ToLower();
                        var inFile = args[2];
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
                    MessageBox.Show($"Error: {e}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                Close();
                return;
            }

            InitializeComponent();
            Title = TITLE;

            mainDataGrid.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            mainDataGrid.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;

            cbx_localization.ItemsSource = Global.LANGUAGE_NAME_LOOKUP;

            Width = SystemParameters.MaximizedPrimaryScreenWidth * 0.8;
            Height = SystemParameters.MaximizedPrimaryScreenHeight * 0.5;

            DoUpdateCheck();
        }

        private async void DoUpdateCheck() {
            await Task.Run(() => {
                try {
                    var json = GetHttpText("http://brutsches.com/MHW-Editor.version.json");
                    var currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    var newestVersion = JsonConvert.DeserializeObject<VersionCheck>(json).latest;

                    if (currentVersion != newestVersion) {
                        RunOnUiThread(() => {
                            notifyIcon = new NotifyIcon {
                                Icon = SystemIcons.Application,
                                Visible = false,
                                Text = "MHW Editor\r\n" +
                                       "Update Available.\r\n" +
                                       "Click to go to the mod page."
                            };
                            //notifyIcon.BalloonTipClosed += (s, e) => notifyIcon.Visible = false;
                            notifyIcon.MouseClick += (sender, args) => { Process.Start(NEXUS_LINK); };

                            notifyIcon.Visible = true;
                            notifyIcon.ShowBalloonTip(10000, "Update Available", "A newer version has been detected.\r\n" +
                                                                                 $"Your Version: {currentVersion}\r\n" +
                                                                                 $"Newer Version: {newestVersion}", ToolTipIcon.Info);
                        });
                    }
                } catch (Exception e) {
                    Console.Error.Write(e);
                }
            });
        }

        // ReSharper disable once UnusedMethodReturnValue.Local
        private DispatcherOperation RunOnUiThread(Action action) {
            return Dispatcher?.InvokeAsync(action);
        }

        private string GetHttpText(string url) {
            var request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";

            using var response = (HttpWebResponse) request.GetResponse();
            using var reader = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException());
            return reader.ReadToEnd();
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e) {
            var scv = (ScrollViewer) sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void Dg_items_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e) {
            Debug.Assert(e.PropertyName != null, "e.PropertyName != null");
            var fileName = Path.GetFileNameWithoutExtension(targetFile);

            switch (e.PropertyName) {
                case nameof(IMhwItem.Bytes):
                case nameof(IMhwItem.UniqueId):
                case nameof(Melee.GMD_Name_Index):
                case nameof(Melee.GMD_Description_Index):
                    e.Cancel = true; // Internal.
                    break;
                case nameof(IMhwItem.Raw_Data):
                    e.Cancel = !SHOW_RAW_BYTES; // Only for debug builds.
                    break;
                case nameof(Ranged.Barrel_Type):
                case nameof(Ranged.Deviation):
                case nameof(Ranged.Magazine_Type):
                case nameof(Ranged.Muzzle_Type):
                case nameof(Ranged.Scope_Type):
                case nameof(Ranged.Shell_Type_Id):
                    e.Cancel = targetFileType.Is(typeof(Bow));
                    break;
                case nameof(IMhwItem.Name):
                    if (targetFileType.Is(typeof(EqCrt))) {
                        if (fileName != "charm") {
                            e.Cancel = true;
                        }
                    }

                    break;
                case nameof(SkillDat.Id):
                    e.Cancel = targetFileType.Is(typeof(SkillDat));
                    break;
                case nameof(SkillDat.Index):
                    e.Cancel = targetFileType.Is(typeof(DecoGradeLottery),
                                                 typeof(DecoLottery),
                                                 typeof(Gem));
                    break;
                default:
                    e.Cancel = e.PropertyName.EndsWith("Raw");
                    break;
            }

            // Cancel for _button columns as we will use a text version with onClick opening a selector.
            if (ButtonTypeInfo.BUTTON_BASE_NAMES.Contains(e.PropertyName)) {
                e.Cancel = true;
            }

            if (e.Cancel) return;

            switch (e.PropertyName) {
                case nameof(EqCrt.Equipment_Category): {
                    if (!EqCrt.categoryLookup.ContainsKey(fileName ?? throw new InvalidOperationException())) break;

                    var cb = new DataGridComboBoxColumn {
                        Header = e.Column.Header,
                        ItemsSource = EqCrt.categoryLookup[fileName],
                        SelectedValueBinding = new Binding(e.PropertyName) {
                            Mode = BindingMode.OneWay
                        },
                        SelectedValuePath = "Key",
                        DisplayMemberPath = "Value",
                        CanUserSort = true
                    };
                    e.Column = cb;
                    break;
                }
                case nameof(ShellTable.Armor_Rec_Amnt):
                case nameof(ShellTable.Cluster_1_Rec_Amnt):
                case nameof(ShellTable.Cluster_2_Rec_Amnt):
                case nameof(ShellTable.Cluster_3_Rec_Amnt):
                case nameof(ShellTable.Demon_Rec_Amnt):
                case nameof(ShellTable.Dragon_Rec_Amnt):
                case nameof(ShellTable.Exhaust_1_Rec_Amnt):
                case nameof(ShellTable.Exhaust_2_Rec_Amnt):
                case nameof(ShellTable.Flaming_Rec_Amnt):
                case nameof(ShellTable.Freeze_Rec_Amnt):
                case nameof(ShellTable.Normal_1_Rec_Amnt):
                case nameof(ShellTable.Normal_2_Rec_Amnt):
                case nameof(ShellTable.Normal_3_Rec_Amnt):
                case nameof(ShellTable.Paralysis_1_Rec_Amnt):
                case nameof(ShellTable.Paralysis_2_Rec_Amnt):
                case nameof(ShellTable.Pierce_1_Rec_Amnt):
                case nameof(ShellTable.Pierce_2_Rec_Amnt):
                case nameof(ShellTable.Pierce_3_Rec_Amnt):
                case nameof(ShellTable.Poison_1_Rec_Amnt):
                case nameof(ShellTable.Poison_2_Rec_Amnt):
                case nameof(ShellTable.Recover_1_Rec_Amnt):
                case nameof(ShellTable.Recover_2_Rec_Amnt):
                case nameof(ShellTable.Sleep_1_Rec_Amnt):
                case nameof(ShellTable.Sleep_2_Rec_Amnt):
                case nameof(ShellTable.Slicing_Rec_Amnt):
                case nameof(ShellTable.Spread_1_Rec_Amnt):
                case nameof(ShellTable.Spread_2_Rec_Amnt):
                case nameof(ShellTable.Spread_3_Rec_Amnt):
                case nameof(ShellTable.Sticky_1_Rec_Amnt):
                case nameof(ShellTable.Sticky_2_Rec_Amnt):
                case nameof(ShellTable.Sticky_3_Rec_Amnt):
                case nameof(ShellTable.Thunder_Rec_Amnt):
                case nameof(ShellTable.Tranq_Rec_Amnt):
                case nameof(ShellTable.Water_Rec_Amnt):
                case nameof(ShellTable.Wyvern_Rec_Amnt): {
                    var cb = new DataGridComboBoxColumn {
                        Header = e.Column.Header,
                        ItemsSource = ShellTable.recoilLookup,
                        SelectedValueBinding = new Binding(e.PropertyName),
                        SelectedValuePath = "Key",
                        DisplayMemberPath = "Value",
                        CanUserSort = true
                    };
                    e.Column = cb;
                    break;
                }
                case nameof(ShellTable.Armor_Rel_Spd):
                case nameof(ShellTable.Cluster_1_Rel_Spd):
                case nameof(ShellTable.Cluster_2_Rel_Spd):
                case nameof(ShellTable.Cluster_3_Rel_Spd):
                case nameof(ShellTable.Demon_Rel_Spd):
                case nameof(ShellTable.Dragon_Rel_Spd):
                case nameof(ShellTable.Exhaust_1_Rel_Spd):
                case nameof(ShellTable.Exhaust_2_Rel_Spd):
                case nameof(ShellTable.Flaming_Rel_Spd):
                case nameof(ShellTable.Freeze_Rel_Spd):
                case nameof(ShellTable.Normal_1_Rel_Spd):
                case nameof(ShellTable.Normal_2_Rel_Spd):
                case nameof(ShellTable.Normal_3_Rel_Spd):
                case nameof(ShellTable.Paralysis_1_Rel_Spd):
                case nameof(ShellTable.Paralysis_2_Rel_Spd):
                case nameof(ShellTable.Pierce_1_Rel_Spd):
                case nameof(ShellTable.Pierce_2_Rel_Spd):
                case nameof(ShellTable.Pierce_3_Rel_Spd):
                case nameof(ShellTable.Poison_1_Rel_Spd):
                case nameof(ShellTable.Poison_2_Rel_Spd):
                case nameof(ShellTable.Recover_1_Rel_Spd):
                case nameof(ShellTable.Recover_2_Rel_Spd):
                case nameof(ShellTable.Sleep_1_Rel_Spd):
                case nameof(ShellTable.Sleep_2_Rel_Spd):
                case nameof(ShellTable.Slicing_Rel_Spd):
                case nameof(ShellTable.Spread_1_Rel_Spd):
                case nameof(ShellTable.Spread_2_Rel_Spd):
                case nameof(ShellTable.Spread_3_Rel_Spd):
                case nameof(ShellTable.Sticky_1_Rel_Spd):
                case nameof(ShellTable.Sticky_2_Rel_Spd):
                case nameof(ShellTable.Sticky_3_Rel_Spd):
                case nameof(ShellTable.Thunder_Rel_Spd):
                case nameof(ShellTable.Tranq_Rel_Spd):
                case nameof(ShellTable.Water_Rel_Spd):
                case nameof(ShellTable.Wyvern_Rel_Spd): {
                    var cb = new DataGridComboBoxColumn {
                        Header = e.Column.Header,
                        ItemsSource = ShellTable.reloadLookup,
                        SelectedValueBinding = new Binding(e.PropertyName),
                        SelectedValuePath = "Key",
                        DisplayMemberPath = "Value",
                        CanUserSort = true
                    };
                    e.Column = cb;
                    break;
                }
                case nameof(GunnerReload.No_Mods):
                case nameof(GunnerReload.Mod_1):
                case nameof(GunnerReload.Mod_2):
                case nameof(GunnerReload.Mod_3):
                case nameof(GunnerReload.Mod_4): {
                    Dictionary<byte, IdNamePair<byte>> source = null;
                    if (targetFileType.Is(typeof(GunnerReload))) {
                        source = GunnerReload.reloadLookup;
                    } else if (targetFileType.Is(typeof(GunnerShoot))) {
                        source = GunnerShoot.recoilLookup;
                    }

                    var cb = new DataGridComboBoxColumn {
                        Header = e.Column.Header,
                        ItemsSource = source,
                        SelectedValueBinding = new Binding(e.PropertyName),
                        SelectedValuePath = "Key",
                        DisplayMemberPath = "Value",
                        CanUserSort = true
                    };
                    e.Column = cb;
                    break;
                }
            }

            if (e.PropertyName.EndsWith("_percent")) {
                var cb = new DataGridTextColumn {
                    Header = e.Column.Header,
                    Binding = new Binding(e.PropertyName) {
                        StringFormat = "{0:0.##%;-0.##%;\"\"}" // Can't be negative, but needed to hide all 0 cases.
                    },
                    CanUserSort = true,
                    IsReadOnly = true
                };
                e.Column = cb;
            }

            e.Column.CanUserSort = true;

            // Use [DisplayName] attribute for the column header text.
            // Use [SortOrder] attribute to control the position. Generated fields have spacing so it's easy to say 'generated_field_sortOrder + 1'.
            // Use [CustomSorter] to define an IComparer class to control sorting.
            Type sourceClassType = ((dynamic) e.PropertyDescriptor).ComponentType;
            var propertyInfo = sourceClassType.GetProperties().FirstOrDefault(info => info.Name == e.PropertyName);

            var displayName = ((DisplayNameAttribute) propertyInfo?.GetCustomAttribute(typeof(DisplayNameAttribute), true))?.DisplayName;
            var sortOrder = ((SortOrderAttribute) propertyInfo?.GetCustomAttribute(typeof(SortOrderAttribute), true))?.sortOrder;
            var customSorterType = ((CustomSorterAttribute) propertyInfo?.GetCustomAttribute(typeof(CustomSorterAttribute), true))?.customSorterType;
            var isReadOnly = (IsReadOnlyAttribute) propertyInfo?.GetCustomAttribute(typeof(IsReadOnlyAttribute), true) != null;
            ICustomSorter customSorter = null;

            if (displayName != null) {
                if (displayName == "") { // Use empty DisplayName as a way to hide columns.
                    e.Cancel = true;
                    return;
                }

                e.Column.Header = displayName;
            }

            if (customSorterType != null) {
                customSorter = (ICustomSorter) Activator.CreateInstance(customSorterType);
                if (customSorter is ICustomSorterWithPropertyName csWithName) {
                    csWithName.PropertyName = e.PropertyName;
                }
            }

            if (isReadOnly) {
                e.Column.IsReadOnly = !unlockFields;
            }

            columnMap.GetOrCreate(sender)[e.PropertyName] = new ColumnHolder(e.Column, sortOrder ?? -1, customSorter);

            // TODO: Fix enum value display at some point.
        }

        private void Dg_items_AutoGeneratedColumns(object sender, EventArgs e) {
            var columns = columnMap[sender].Values.ToList();
            columns.Sort((c1, c2) => c1.sortOrder.CompareTo(c2.sortOrder));
            for (var i = 0; i < columns.Count; i++) {
                columns[i].column.DisplayIndex = i;
            }
        }

        private void Dg_items_GotFocus(object sender, RoutedEventArgs e) {
#if !DEBUG
            try {
#endif
            // Lookup for the source to be DataGridCell
            if (e.OriginalSource is DataGridCell cell) {
                if (coloredRow != null) coloredRow.Background = Brushes.White;
                coloredRow = cell.GetParent<DataGridRow>();
                // ReSharper disable once PossibleNullReferenceException
                coloredRow.Background = backgroundBrush;

                if (SingleClickToEditMode) {
                    // Needs to only happen when it's a button. If not, we stop regular fields from working.
                    if (CheckCellForButtonTypeAndHandleClick(sender, cell)) return;

                    // We're past the _button check, now we just want to avoid a normal drop-down set to read only.
                    if (cell.IsReadOnly) return;

                    // Starts the Edit on the row;
                    ((DataGrid) sender).BeginEdit(e);

                    if (cell.Content is ComboBox cbx) {
                        cbx.IsDropDownOpen = true;
                    }
                }
            }
#if !DEBUG
            } catch (Exception err) {
                MessageBox.Show("Error occured. Press Ctrl+C to copy the contents of ths window and report to the developer.\r\n\r\n" + err, "Error Occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
#endif
        }

        private void Dg_items_cell_MouseClick(object sender, MouseButtonEventArgs e) {
#if !DEBUG
            try {
#endif
            if (sender is DataGridCell cell) {
                // We come here on both single & double click. If we don't check for focus, this hijacks the click and prevents focusing.
                if (e?.ClickCount == 1 && !cell.IsFocused) return;

                CheckCellForButtonTypeAndHandleClick(sender, cell);
            }
#if !DEBUG
            } catch (Exception err) {
                MessageBox.Show("Error occured. Press Ctrl+C to copy the contents of ths window and report to the developer.\r\n\r\n" + err, "Error Occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
#endif
        }

        private bool CheckCellForButtonTypeAndHandleClick(object sender, DataGridCell cell) {
            if (!(cell.Content is TextBlock)) return false;
            var dataGrid = ((DependencyObject) sender).GetParent<DataGrid>();

            // Have to loop though our column list to file the original property name.
            foreach (var propertyName in columnMap[dataGrid].Keys.Where(key => key.Contains("_button"))) {
                if (cell.Column != columnMap[dataGrid][propertyName].column) continue;

                EditSelectedItemId(cell, propertyName);
                return true;
            }

            return false;
        }

        private void EditSelectedItemId(FrameworkElement cell, string propertyName) {
            var obj = (IOnPropertyChanged) cell.DataContext;
            var property = obj.GetType().GetProperty(propertyName.Replace("_button", ""), BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            Debug.Assert(property != null, nameof(property) + " != null");
            var propertyType = property.PropertyType;
            var value = property.GetValue(obj);
            var dataSourceType = ((DataSourceAttribute) property.GetCustomAttribute(typeof(DataSourceAttribute), true))?.dataType;

            dynamic dataSource = dataSourceType switch {
                DataSourceType.Items => DataHelper.itemNames[locale],
                DataSourceType.Skills => DataHelper.skillNames[locale],
                DataSourceType.SkillDat => skillDatLookup[locale],
                DataSourceType.CategorizedWeapons => DataHelper.weaponIdNameLookup[GetWeaponType(cell)][locale],
                _ => throw new ArgumentOutOfRangeException(dataSourceType.ToString())
            };

            var getNewItemId = new GetNewItemId(value, dataSource);

            getNewItemId.ShowDialog();

            if (!getNewItemId.Cancelled) {
                property.SetValue(obj, Convert.ChangeType(getNewItemId.CurrentItem, propertyType));
                obj.OnPropertyChanged(propertyName);
            }
        }

        private static WeaponTypeOnlyWeapons GetWeaponType(FrameworkElement cell) {
            var obj = (MhwItem) cell.DataContext;
            var property = obj.GetType().GetProperty("Weapon_Type", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            Debug.Assert(property != null, nameof(property) + " != null");
            var value = property.GetValue(obj);
            return (WeaponTypeOnlyWeapons) value;
        }

        private void Dg_items_Sorting(object sender, DataGridSortingEventArgs e) {
#if !DEBUG
            try {
#endif
            // Does the column we're sorting define a custom sorter?
            var matches = columnMap[sender].Where(pair => pair.Value.column == e.Column && pair.Value.customSorter != null).ToList();
            if (!matches.Any()) return;
            var customSorter = matches.First().Value.customSorter;

            e.Column.SortDirection = customSorter.SortDirection = (e.Column.SortDirection != ListSortDirection.Ascending) ? ListSortDirection.Ascending : ListSortDirection.Descending;

            var listColView = (ListCollectionView) ((DataGrid) sender).ItemsSource;
            listColView.CustomSort = customSorter;

            e.Handled = true;
#if !DEBUG
            } catch (Exception err) {
                MessageBox.Show("Error occured. Press Ctrl+C to copy the contents of ths window and report to the developer.\r\n\r\n" + err, "Error Occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
#endif
        }

        private void Dg_items_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e) {
#if !DEBUG
            try {
#endif
            // Commit as cell edit ends instead of DG waiting till we leave the row.
            if (!isManualEditCommit) {
                isManualEditCommit = true;
                ((DataGrid) sender).CommitEdit(DataGridEditingUnit.Row, true);
                isManualEditCommit = false;
            }

            CalculatePercents();
#if !DEBUG
            } catch (Exception err) {
                MessageBox.Show("Error occured. Press Ctrl+C to copy the contents of ths window and report to the developer.\r\n\r\n" + err, "Error Occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
#endif
        }

        private void CalculatePercents() {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (targetFileType.Is(typeof(DecoLottery))) {
                var dict = new Dictionary<int, uint>();
                for (var i = 0; i <= 10; i++) {
                    dict[i] = 0;
                }

                foreach (DecoLottery item in items) {
                    dict[0] += item.Grade_1;
                    dict[1] += item.Grade_2;
                    dict[2] += item.Grade_3;
                    dict[3] += item.Grade_4;
                    dict[4] += item.Grade_5;
                    dict[5] += item.Grade_6;
                    dict[6] += item.Grade_7;
                    dict[7] += item.Grade_8;
                    dict[8] += item.Grade_9;
                    dict[9] += item.Stream_R6_;
                    dict[10] += item.Stream_R8_;
                }

                foreach (DecoLottery item in items) {
                    item.Grade_1_percent = item.Grade_1 > 0f ? (float) item.Grade_1 / dict[0] : 0f;
                    item.Grade_2_percent = item.Grade_2 > 0f ? (float) item.Grade_2 / dict[1] : 0f;
                    item.Grade_3_percent = item.Grade_3 > 0f ? (float) item.Grade_3 / dict[2] : 0f;
                    item.Grade_4_percent = item.Grade_4 > 0f ? (float) item.Grade_4 / dict[3] : 0f;
                    item.Grade_5_percent = item.Grade_5 > 0f ? (float) item.Grade_5 / dict[4] : 0f;
                    item.Grade_6_percent = item.Grade_6 > 0f ? (float) item.Grade_6 / dict[5] : 0f;
                    item.Grade_7_percent = item.Grade_7 > 0f ? (float) item.Grade_7 / dict[6] : 0f;
                    item.Grade_8_percent = item.Grade_8 > 0f ? (float) item.Grade_8 / dict[7] : 0f;
                    item.Grade_9_percent = item.Grade_9 > 0f ? (float) item.Grade_9 / dict[8] : 0f;
                    item.Stream_R6__percent = item.Stream_R6_ > 0f ? (float) item.Stream_R6_ / dict[9] : 0f;
                    item.Stream_R8__percent = item.Stream_R8_ > 0f ? (float) item.Stream_R8_ / dict[10] : 0f;
                }
            } else if (targetFileType.Is(typeof(DecoGradeLottery))) {
                foreach (DecoGradeLottery item in items) {
                    var total = item.Grade_1
                                + item.Grade_2
                                + item.Grade_3
                                + item.Grade_4
                                + item.Grade_5
                                + item.Grade_6
                                + item.Grade_7
                                + item.Grade_8
                                + item.Grade_9
                                + item.Stream_R6_
                                + item.Stream_R8_;

                    item.Grade_1_percent = item.Grade_1 > 0f ? (float) item.Grade_1 / total : 0f;
                    item.Grade_2_percent = item.Grade_2 > 0f ? (float) item.Grade_2 / total : 0f;
                    item.Grade_3_percent = item.Grade_3 > 0f ? (float) item.Grade_3 / total : 0f;
                    item.Grade_4_percent = item.Grade_4 > 0f ? (float) item.Grade_4 / total : 0f;
                    item.Grade_5_percent = item.Grade_5 > 0f ? (float) item.Grade_5 / total : 0f;
                    item.Grade_6_percent = item.Grade_6 > 0f ? (float) item.Grade_6 / total : 0f;
                    item.Grade_7_percent = item.Grade_7 > 0f ? (float) item.Grade_7 / total : 0f;
                    item.Grade_8_percent = item.Grade_8 > 0f ? (float) item.Grade_8 / total : 0f;
                    item.Grade_9_percent = item.Grade_9 > 0f ? (float) item.Grade_9 / total : 0f;
                    item.Stream_R6__percent = item.Stream_R6_ > 0f ? (float) item.Stream_R6_ / total : 0f;
                    item.Stream_R8__percent = item.Stream_R8_ > 0f ? (float) item.Stream_R8_ / total : 0f;
                }
            }
        }

        private void FillSkillDatDictionary() {
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

        private void Load() {
            var target = GetOpenTarget($"MHW Data Files (See mod description for full list.)|{string.Join(";", Global.FILE_TYPES)}");
            if (string.IsNullOrEmpty(target)) return;

            targetFile = target;
            targetFileType = GetFileType();
            items.Clear();
            Title = Path.GetFileName(targetFile);

            grid.Children.Clear();
            grid.UpdateLayout();

            foreach (var dg in dataGrids) {
                dg.ItemsSource = null;
            }

            dataGrids.Clear();

            columnMap = new Dictionary<object, Dictionary<string, ColumnHolder>>();
            coloredRow = null;

            GC.Collect();

#if !DEBUG
            try {
#endif
            if (targetFileType.Is(typeof(ICustomSaveLoad))) { // Custom save/load.
                scroll_viewer.Visibility = Visibility.Visible;
                mainDataGrid.Visibility = Visibility.Collapsed;

                var loadData = targetFileType.GetMethod("LoadData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                Debug.Assert(loadData != null, nameof(loadData) + " != null");
                customFileData = loadData.Invoke(null, new object[] {targetFile});

                var setupViews = targetFileType.GetMethod("SetupViews", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                Debug.Assert(setupViews != null, nameof(setupViews) + " != null");
                setupViews.Invoke(null, new object[] {customFileData, grid, this});
                return;
            }
#if !DEBUG
            } catch (Exception e) {
                MessageBox.Show(this, e.Message, "Load Error");
            }
#endif

            LoadFile();

            if (targetFileType.Is(typeof(SkillDat))) {
                FillSkillDatDictionary();
            }

            dataGrids.Add(mainDataGrid);
            scroll_viewer.Visibility = Visibility.Collapsed;
            mainDataGrid.Visibility = Visibility.Visible;

            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (targetFileType.IsGeneric(typeof(IHasCustomView<>))) {
                mainDataGrid.ItemsSource = new ListCollectionView(items[0].GetCustomView());
            } else {
                mainDataGrid.ItemsSource = new ListCollectionView(items);
            }

            if (targetFileType.Is(typeof(DecoGradeLottery), typeof(DecoLottery))) {
                CalculatePercents();
            }
        }

        public void AddDataGrid<T>(IEnumerable<T> itemSource) {
            var control = new ContentControl {Content = Resources["ItemDataGrid"]};
            grid.AddControl(control);
            var dataGrid = ((DataGrid) control.Content);
            dataGrid.ItemsSource = new ObservableCollection<T>(itemSource);
            dataGrids.Add(dataGrid);
        }

        private void LoadFile() {
            Debug.Assert(targetFile != null, nameof(targetFile) + " != null");

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;
            // ReSharper disable PossibleNullReferenceException
            var initialOffset = (ulong) targetFileType.GetField(nameof(Armor.InitialOffset), flags).GetValue(null);
            var structSize = (uint) targetFileType.GetField(nameof(Armor.StructSize), flags).GetValue(null);
            var entryCountOffset = (long) targetFileType.GetField(nameof(Armor.EntryCountOffset), flags).GetValue(null);
            var encryptionKey = (string) targetFileType.GetField(nameof(Armor.EncryptionKey), flags).GetValue(null);

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
                                                              typeof(EqCrt),
                                                              typeof(EqCus),
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
                                                                   typeof(MusicSkill),
                                                                   typeof(QuestReward),
                                                                   typeof(SkillDat),
                                                                   typeof(SkillPointData))
                                                 || ButtonTypeInfo.TYPES_WITH_BUTTONS.Contains(targetFileType.Name)).VisibleIfTrue();

            var weaponFilename = Path.GetFileNameWithoutExtension(targetFile);

#if !DEBUG
            try {
#endif
            using (var file = File.OpenRead(targetFile)) {
                var ourLength = (ulong) file.Length;
                var properLength = DataHelper.FILE_SIZE_MAP.TryGet(Path.GetFileName(targetFile), (ulong) 0);
                var sha512 = file.SHA512();

                // Look for known bad hashes first to ensure it's not an unedited file from a previous chunk.
                foreach (var pair in DataHelper.BAD_FILE_HASH_MAP) {
                    // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
                    foreach (var fileAndHash in pair.Value) {
                        if (Title == fileAndHash.Key && fileAndHash.Value.Contains(sha512)) {
                            var newChunk = DataHelper.GOOD_CHUNK_MAP.TryGet(Title);
                            MessageBox.Show($"This file ({Title}) is from {pair.Key} and is obsolete.\r\n" +
                                            $"The newest version of the file is in {newChunk}.\r\n\r\n" +
                                            "Using obsolete files is known to cause anything from blackscreens to crashes or incorrect data.", "Obsolete File Detected", MessageBoxButton.OK, MessageBoxImage.Warning);
                            goto skipOut;
                        }
                    }
                }

                // Length check as a fallback.
                if (ourLength != properLength) {
                    MessageBox.Show($"The file size of {Title} does not match the known file size in v{CURRENT_GAME_VERSION}.\r\n" +
                                    $"Expected: {properLength}\r\n" +
                                    $"Found: {ourLength}\r\n" +
                                    "Please make sure you've extracted the file from the highest numbered chunk that contains it.", "File Size Mismatch", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

            skipOut:
            if (encryptionKey != null) {
                // Read & decrypt file.
                var encryptedBytes = File.ReadAllBytes(targetFile);
                var decryptedBytes = EncryptionHelper.Decrypt(encryptionKey, encryptedBytes);

                using (var dat = new MemoryStream()) {
                    // Write to a stream for the loader. Leave base stream OPEN.
                    using (var writer = new BinaryWriter(dat, Encoding.Default, true)) {
                        writer.Write(decryptedBytes);
                    }

                    // Load as normal.
                    using (var reader = new BinaryReader(dat)) {
                        ReadStructs(reader, structSize, initialOffset, weaponFilename, entryCountOffset);
                    }
                }
            } else { // No encryption, just open, read, & close.
                using (var dat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read))) {
                    ReadStructs(dat, structSize, initialOffset, weaponFilename, entryCountOffset);
                }
            }
#if !DEBUG
            } catch (Exception e) {
                MessageBox.Show(this, e.Message, "Load Error");
            }
#endif
        }

        private void ReadStructs(BinaryReader dat, uint structSize, ulong initialOffset, string weaponFilename, long entryCountOffset) {
            if (entryCountOffset >= 0) {
                ReadStructsAsKnownLength(dat, structSize, initialOffset, weaponFilename, entryCountOffset);
            } else {
                ReadStructsAsUnknownLength(dat, structSize, initialOffset, weaponFilename);
            }
        }

        private void ReadStructsAsKnownLength(BinaryReader dat, uint structSize, ulong initialOffset, string weaponFilename, long entryCountOffset) {
            dat.BaseStream.Seek(entryCountOffset, SeekOrigin.Begin);
            var count = dat.ReadUInt32();

            dat.BaseStream.Seek((long) initialOffset, SeekOrigin.Begin);

            for (var i = 0; i < count; i++) {
                var position = dat.BaseStream.Position;

                if (position + structSize > dat.BaseStream.Length) {
                    throw new IOException("Malformed file. Entry count goes past the end of the file.");
                }

                var buff = dat.ReadBytes((int) structSize);

                object obj;
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (targetFileType.Is(typeof(IWeapon), typeof(EqCrt))) {
                    obj = Activator.CreateInstance(targetFileType, buff, (ulong) position, weaponFilename);
                } else {
                    obj = Activator.CreateInstance(targetFileType, buff, (ulong) position);
                }

                if (obj == null) return;

                items.Add(obj);
            }
        }

        private void ReadStructsAsUnknownLength(BinaryReader dat, uint structSize, ulong offset, string weaponFilename) {
            var len = (ulong) dat.BaseStream.Length;
            do {
                var buff = new byte[structSize];
                dat.BaseStream.Seek((long) offset, SeekOrigin.Begin);
                dat.Read(buff, 0, (int) structSize);

                object obj;
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (targetFileType.Is(typeof(IWeapon), typeof(EqCrt))) {
                    obj = Activator.CreateInstance(targetFileType, buff, offset, weaponFilename);
                } else {
                    obj = Activator.CreateInstance(targetFileType, buff, offset);
                }

                if (obj == null) return;

                items.Add(obj);

                offset += structSize;
            } while (offset + structSize <= len);
        }

        private async void Save() {
            if (string.IsNullOrEmpty(targetFile)) return;

#if !DEBUG
            try {
#endif
            if (targetFileType.Is(typeof(ICustomSaveLoad))) { // Custom save/load.
                var saveData = targetFileType.GetMethod("SaveData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                Debug.Assert(saveData != null, nameof(saveData) + " != null");
                saveData.Invoke(null, new object[] {customFileData, targetFile});

                await ShowChangesSaved(true);
                return;
            }

            bool changesSaved;
            var encryptionKey = (string) targetFileType.GetField(nameof(Armor.EncryptionKey), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).GetValue(null);

            if (encryptionKey != null) {
                // Read & decrypt file.
                var encryptedBytes = File.ReadAllBytes(targetFile);
                var decryptedBytes = EncryptionHelper.Decrypt(encryptionKey, encryptedBytes);

                using (var dat = new MemoryStream()) {
                    // Write to a stream for the loader. Leave base stream OPEN.
                    using (var writer = new BinaryWriter(dat, Encoding.Default, true)) {
                        writer.Write(decryptedBytes);
                    }

                    // Save as normal. Leave base stream OPEN.
                    using (var writer = new BinaryWriter(dat, Encoding.Default, true)) {
                        changesSaved = WriteChanges(writer);
                    }

                    // If there are no changes, then we don't need to write the result back out.
                    if (changesSaved) {
                        // Re-encrypt and write it back out.
                        decryptedBytes = dat.ToArray();
                        encryptedBytes = EncryptionHelper.Encrypt(encryptionKey, decryptedBytes);
                        File.WriteAllBytes(targetFile, encryptedBytes);
                    }
                }
            } else { // No encryption, just open, write, & close.
                using (var dat = new BinaryWriter(new FileStream(targetFile, FileMode.Open, FileAccess.Write))) {
                    changesSaved = WriteChanges(dat);
                }
            }

            await ShowChangesSaved(changesSaved);
#if !DEBUG
            } catch (Exception e) {
                MessageBox.Show(this, e.Message, "Save Error");
            }
#endif
        }

        private async Task ShowChangesSaved(bool changesSaved) {
            savedTimer?.Cancel();
            savedTimer = new CancellationTokenSource();
            lbl_saved.Visibility = changesSaved.VisibleIfTrue();
            lbl_no_changes.Visibility = changesSaved ? Visibility.Collapsed : Visibility.Visible;
            try {
                await Task.Delay(3000, savedTimer.Token);
                lbl_saved.Visibility = lbl_no_changes.Visibility = Visibility.Hidden;
            } catch (TaskCanceledException) {
            }
        }

        private bool WriteChanges(BinaryWriter dat) {
            var changesSaved = false;

            foreach (MhwItem item in items) {
                if (item.changed.Count == 0) continue;

                dat.BaseStream.Seek((long) item.Offset, SeekOrigin.Begin);
                dat.Write(item.Bytes);

                item.changed.Clear();
                changesSaved = true;
            }

            return changesSaved;
        }

        private void LoadJson() {
            if (string.IsNullOrEmpty(targetFile)) return;

#if !DEBUG
            try {
#endif
            var target = GetOpenTarget($"JSON|*{Path.GetExtension(targetFile)}.json");
            if (string.IsNullOrEmpty(target)) return;

            var fileName = Path.GetFileName(targetFile);

            var json = File.ReadAllText(target);
            var changesToLoad = JsonMigrations.Migrate(json, fileName, items);

            if (!changesToLoad.changes.Any()) return;
            if (fileName != changesToLoad.targetFile && changesToLoad.targetFile != "*") return;

            foreach (MhwItem item in items) {
                var id = item.UniqueId;
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
#if !DEBUG
            } catch (Exception e) {
                MessageBox.Show(this, e.Message, "Load Error");
            }
#endif
        }

        private async void SaveJson(bool mergeWithTarget) {
            if (string.IsNullOrEmpty(targetFile)) return;

#if !DEBUG
            try {
#endif
            var fileName = Path.GetFileName(targetFile);
            JsonChanges changesToSave = null;

            if (mergeWithTarget) {
                try {
                    var target = GetOpenTarget($"JSON|*{Path.GetExtension(targetFile)}.json");
                    // Should migrate the loaded changes too.
                    changesToSave = JsonMigrations.Migrate(File.ReadAllText(target), fileName, items);
                } catch (Exception) {
                    // Don't care. If it doesn't exist or can't be read, it gets overwritten.
                }
            }

            if (changesToSave == null) {
                changesToSave = new JsonChanges {
                    targetFile = fileName,
                    version = JsonMigrations.VERSION_MAP.TryGet(fileName, (uint) 1)
                };
            } else {
                // Set target & version explicitly in case the user is merging into a different wp_dat or something.
                changesToSave.targetFile = fileName;
                changesToSave.version = JsonMigrations.VERSION_MAP.TryGet(fileName, (uint) 1);
            }

            foreach (MhwItem item in items) {
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
#if !DEBUG
            } catch (Exception e) {
                MessageBox.Show(this, e.Message, "Save Error");
            }
#endif
        }

        private string GetOpenTarget(string filter) {
            var ofdResult = new OpenFileDialog {
                Filter = filter,
                Multiselect = false
            };
            ofdResult.ShowDialog();

            return ofdResult.FileName;
        }

        private string GetSaveTarget() {
            var sfdResult = new SaveFileDialog {
                Filter = $"JSON|*{Path.GetExtension(targetFile)}.json",
                FileName = $"{Path.GetFileNameWithoutExtension(targetFile)}",
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
            if (fileName.EndsWith(".dtt_dif")) return typeof(MonsterDifficulty);
            if (fileName.EndsWith(".dtt_rsz")) return typeof(MonsterRandomSize);
            if (fileName.EndsWith(".dtt_sta")) return typeof(MonsterStamina);
            if (fileName.EndsWith(".em104exp")) return typeof(AwakenedExp);
            if (fileName.EndsWith(".em104iot")) return typeof(SafiItemLottery);
            if (fileName.EndsWith(".em104lb")) return typeof(AwakenedLimitBreak);
            if (fileName.EndsWith(".em104lbr")) return typeof(AwakenedLimitBreakR);
            if (fileName.EndsWith(".em104wcd")) return typeof(AwakenedWpCustom);
            if (fileName.EndsWith(".em104wud")) return typeof(AwakenedWpUpgrade);
            if (fileName.EndsWith(".emst")) return typeof(EnemySort);
            if (fileName.EndsWith(".eq_crt")) return typeof(EqCrt);
            if (fileName.EndsWith(".eq_cus")) return typeof(EqCus);
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

            throw new Exception($"No type found for: {fileName}");
        }

        protected override void OnClosed(EventArgs e) {
            if (notifyIcon != null) {
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
            }

            base.OnClosed(e);
        }
    }
}