using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Items {
    public partial class ItemLottery {
        public override string EncryptionKey => "D7N88VEGEnRl0HEHTO0xMQkbeMb37arJF488lREp90WYojAONkLoxfMt";

        public partial class Header : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual uint Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected ushort Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual ushort Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Entry_Count_raw;
            public const string Entry_Count_displayName = "Entry Count";
            public const int Entry_Count_sortIndex = 150;
            [SortOrder(Entry_Count_sortIndex)]
            [DisplayName(Entry_Count_displayName)]
            [IsReadOnly]
            public virtual uint Entry_Count {
                get => Entry_Count_raw;
                set {
                    if (Entry_Count_raw == value) return;
                    Entry_Count_raw = value;
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Header LoadData(BinaryReader reader, ulong i) {
                var data = new Header();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt16();
                data.Entry_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

            protected ushort Item_1_Id_raw;
            public const string Item_1_Id_displayName = "Item 1 Id";
            [SortOrder(Item_1_Id_sortIndex)]
            [DisplayName(Item_1_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_1_Id {
                get => Item_1_Id_raw;
                set {
                    if (Item_1_Id_raw == value) return;
                    Item_1_Id_raw = value;
                    OnPropertyChanged(nameof(Item_1_Id));
                    OnPropertyChanged(nameof(Item_1_Id_button));
                }
            }

            [SortOrder(Item_1_Id_sortIndex)]
            [DisplayName(Item_1_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_1_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_1_Id).ToStringWithId(Item_1_Id);

            protected ushort Item_2_Id_raw;
            public const string Item_2_Id_displayName = "Item 2 Id";
            [SortOrder(Item_2_Id_sortIndex)]
            [DisplayName(Item_2_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_2_Id {
                get => Item_2_Id_raw;
                set {
                    if (Item_2_Id_raw == value) return;
                    Item_2_Id_raw = value;
                    OnPropertyChanged(nameof(Item_2_Id));
                    OnPropertyChanged(nameof(Item_2_Id_button));
                }
            }

            [SortOrder(Item_2_Id_sortIndex)]
            [DisplayName(Item_2_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_2_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_2_Id).ToStringWithId(Item_2_Id);

            protected ushort Item_3_Id_raw;
            public const string Item_3_Id_displayName = "Item 3 Id";
            [SortOrder(Item_3_Id_sortIndex)]
            [DisplayName(Item_3_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_3_Id {
                get => Item_3_Id_raw;
                set {
                    if (Item_3_Id_raw == value) return;
                    Item_3_Id_raw = value;
                    OnPropertyChanged(nameof(Item_3_Id));
                    OnPropertyChanged(nameof(Item_3_Id_button));
                }
            }

            [SortOrder(Item_3_Id_sortIndex)]
            [DisplayName(Item_3_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_3_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_3_Id).ToStringWithId(Item_3_Id);

            protected ushort Item_4_Id_raw;
            public const string Item_4_Id_displayName = "Item 4 Id";
            [SortOrder(Item_4_Id_sortIndex)]
            [DisplayName(Item_4_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_4_Id {
                get => Item_4_Id_raw;
                set {
                    if (Item_4_Id_raw == value) return;
                    Item_4_Id_raw = value;
                    OnPropertyChanged(nameof(Item_4_Id));
                    OnPropertyChanged(nameof(Item_4_Id_button));
                }
            }

            [SortOrder(Item_4_Id_sortIndex)]
            [DisplayName(Item_4_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_4_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_4_Id).ToStringWithId(Item_4_Id);

            protected ushort Item_5_Id_raw;
            public const string Item_5_Id_displayName = "Item 5 Id";
            [SortOrder(Item_5_Id_sortIndex)]
            [DisplayName(Item_5_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_5_Id {
                get => Item_5_Id_raw;
                set {
                    if (Item_5_Id_raw == value) return;
                    Item_5_Id_raw = value;
                    OnPropertyChanged(nameof(Item_5_Id));
                    OnPropertyChanged(nameof(Item_5_Id_button));
                }
            }

            [SortOrder(Item_5_Id_sortIndex)]
            [DisplayName(Item_5_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_5_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_5_Id).ToStringWithId(Item_5_Id);

            protected ushort Item_6_Id_raw;
            public const string Item_6_Id_displayName = "Item 6 Id";
            [SortOrder(Item_6_Id_sortIndex)]
            [DisplayName(Item_6_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_6_Id {
                get => Item_6_Id_raw;
                set {
                    if (Item_6_Id_raw == value) return;
                    Item_6_Id_raw = value;
                    OnPropertyChanged(nameof(Item_6_Id));
                    OnPropertyChanged(nameof(Item_6_Id_button));
                }
            }

            [SortOrder(Item_6_Id_sortIndex)]
            [DisplayName(Item_6_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_6_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_6_Id).ToStringWithId(Item_6_Id);

            protected ushort Item_7_Id_raw;
            public const string Item_7_Id_displayName = "Item 7 Id";
            [SortOrder(Item_7_Id_sortIndex)]
            [DisplayName(Item_7_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_7_Id {
                get => Item_7_Id_raw;
                set {
                    if (Item_7_Id_raw == value) return;
                    Item_7_Id_raw = value;
                    OnPropertyChanged(nameof(Item_7_Id));
                    OnPropertyChanged(nameof(Item_7_Id_button));
                }
            }

            [SortOrder(Item_7_Id_sortIndex)]
            [DisplayName(Item_7_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_7_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_7_Id).ToStringWithId(Item_7_Id);

            protected ushort Item_8_Id_raw;
            public const string Item_8_Id_displayName = "Item 8 Id";
            [SortOrder(Item_8_Id_sortIndex)]
            [DisplayName(Item_8_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_8_Id {
                get => Item_8_Id_raw;
                set {
                    if (Item_8_Id_raw == value) return;
                    Item_8_Id_raw = value;
                    OnPropertyChanged(nameof(Item_8_Id));
                    OnPropertyChanged(nameof(Item_8_Id_button));
                }
            }

            [SortOrder(Item_8_Id_sortIndex)]
            [DisplayName(Item_8_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_8_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_8_Id).ToStringWithId(Item_8_Id);

            protected ushort Item_9_Id_raw;
            public const string Item_9_Id_displayName = "Item 9 Id";
            [SortOrder(Item_9_Id_sortIndex)]
            [DisplayName(Item_9_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_9_Id {
                get => Item_9_Id_raw;
                set {
                    if (Item_9_Id_raw == value) return;
                    Item_9_Id_raw = value;
                    OnPropertyChanged(nameof(Item_9_Id));
                    OnPropertyChanged(nameof(Item_9_Id_button));
                }
            }

            [SortOrder(Item_9_Id_sortIndex)]
            [DisplayName(Item_9_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_9_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_9_Id).ToStringWithId(Item_9_Id);

            protected ushort Item_10_Id_raw;
            public const string Item_10_Id_displayName = "Item 10 Id";
            [SortOrder(Item_10_Id_sortIndex)]
            [DisplayName(Item_10_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_10_Id {
                get => Item_10_Id_raw;
                set {
                    if (Item_10_Id_raw == value) return;
                    Item_10_Id_raw = value;
                    OnPropertyChanged(nameof(Item_10_Id));
                    OnPropertyChanged(nameof(Item_10_Id_button));
                }
            }

            [SortOrder(Item_10_Id_sortIndex)]
            [DisplayName(Item_10_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_10_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_10_Id).ToStringWithId(Item_10_Id);

            protected byte Item_1_Count_raw;
            public const string Item_1_Count_displayName = "Item 1 Count";
            [SortOrder(Item_1_Count_sortIndex)]
            [DisplayName(Item_1_Count_displayName)]
            public virtual byte Item_1_Count {
                get => Item_1_Count_raw;
                set {
                    if (Item_1_Count_raw == value) return;
                    Item_1_Count_raw = value;
                    OnPropertyChanged(nameof(Item_1_Count));
                }
            }

            protected byte Item_2_Count_raw;
            public const string Item_2_Count_displayName = "Item 2 Count";
            [SortOrder(Item_2_Count_sortIndex)]
            [DisplayName(Item_2_Count_displayName)]
            public virtual byte Item_2_Count {
                get => Item_2_Count_raw;
                set {
                    if (Item_2_Count_raw == value) return;
                    Item_2_Count_raw = value;
                    OnPropertyChanged(nameof(Item_2_Count));
                }
            }

            protected byte Item_3_Count_raw;
            public const string Item_3_Count_displayName = "Item 3 Count";
            [SortOrder(Item_3_Count_sortIndex)]
            [DisplayName(Item_3_Count_displayName)]
            public virtual byte Item_3_Count {
                get => Item_3_Count_raw;
                set {
                    if (Item_3_Count_raw == value) return;
                    Item_3_Count_raw = value;
                    OnPropertyChanged(nameof(Item_3_Count));
                }
            }

            protected byte Item_4_Count_raw;
            public const string Item_4_Count_displayName = "Item 4 Count";
            [SortOrder(Item_4_Count_sortIndex)]
            [DisplayName(Item_4_Count_displayName)]
            public virtual byte Item_4_Count {
                get => Item_4_Count_raw;
                set {
                    if (Item_4_Count_raw == value) return;
                    Item_4_Count_raw = value;
                    OnPropertyChanged(nameof(Item_4_Count));
                }
            }

            protected byte Item_5_Count_raw;
            public const string Item_5_Count_displayName = "Item 5 Count";
            [SortOrder(Item_5_Count_sortIndex)]
            [DisplayName(Item_5_Count_displayName)]
            public virtual byte Item_5_Count {
                get => Item_5_Count_raw;
                set {
                    if (Item_5_Count_raw == value) return;
                    Item_5_Count_raw = value;
                    OnPropertyChanged(nameof(Item_5_Count));
                }
            }

            protected byte Item_6_Count_raw;
            public const string Item_6_Count_displayName = "Item 6 Count";
            [SortOrder(Item_6_Count_sortIndex)]
            [DisplayName(Item_6_Count_displayName)]
            public virtual byte Item_6_Count {
                get => Item_6_Count_raw;
                set {
                    if (Item_6_Count_raw == value) return;
                    Item_6_Count_raw = value;
                    OnPropertyChanged(nameof(Item_6_Count));
                }
            }

            protected byte Item_7_Count_raw;
            public const string Item_7_Count_displayName = "Item 7 Count";
            [SortOrder(Item_7_Count_sortIndex)]
            [DisplayName(Item_7_Count_displayName)]
            public virtual byte Item_7_Count {
                get => Item_7_Count_raw;
                set {
                    if (Item_7_Count_raw == value) return;
                    Item_7_Count_raw = value;
                    OnPropertyChanged(nameof(Item_7_Count));
                }
            }

            protected byte Item_8_Count_raw;
            public const string Item_8_Count_displayName = "Item 8 Count";
            [SortOrder(Item_8_Count_sortIndex)]
            [DisplayName(Item_8_Count_displayName)]
            public virtual byte Item_8_Count {
                get => Item_8_Count_raw;
                set {
                    if (Item_8_Count_raw == value) return;
                    Item_8_Count_raw = value;
                    OnPropertyChanged(nameof(Item_8_Count));
                }
            }

            protected byte Item_9_Count_raw;
            public const string Item_9_Count_displayName = "Item 9 Count";
            [SortOrder(Item_9_Count_sortIndex)]
            [DisplayName(Item_9_Count_displayName)]
            public virtual byte Item_9_Count {
                get => Item_9_Count_raw;
                set {
                    if (Item_9_Count_raw == value) return;
                    Item_9_Count_raw = value;
                    OnPropertyChanged(nameof(Item_9_Count));
                }
            }

            protected byte Item_10_Count_raw;
            public const string Item_10_Count_displayName = "Item 10 Count";
            [SortOrder(Item_10_Count_sortIndex)]
            [DisplayName(Item_10_Count_displayName)]
            public virtual byte Item_10_Count {
                get => Item_10_Count_raw;
                set {
                    if (Item_10_Count_raw == value) return;
                    Item_10_Count_raw = value;
                    OnPropertyChanged(nameof(Item_10_Count));
                }
            }

            protected byte Item_1__raw;
            public const string Item_1__displayName = "Item 1 %";
            [SortOrder(Item_1__sortIndex)]
            [DisplayName(Item_1__displayName)]
            public virtual byte Item_1_ {
                get => Item_1__raw;
                set {
                    if (Item_1__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_1__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_1_));
                }
            }

            protected byte Item_2__raw;
            public const string Item_2__displayName = "Item 2 %";
            [SortOrder(Item_2__sortIndex)]
            [DisplayName(Item_2__displayName)]
            public virtual byte Item_2_ {
                get => Item_2__raw;
                set {
                    if (Item_2__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_2__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_2_));
                }
            }

            protected byte Item_3__raw;
            public const string Item_3__displayName = "Item 3 %";
            [SortOrder(Item_3__sortIndex)]
            [DisplayName(Item_3__displayName)]
            public virtual byte Item_3_ {
                get => Item_3__raw;
                set {
                    if (Item_3__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_3__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_3_));
                }
            }

            protected byte Item_4__raw;
            public const string Item_4__displayName = "Item 4 %";
            [SortOrder(Item_4__sortIndex)]
            [DisplayName(Item_4__displayName)]
            public virtual byte Item_4_ {
                get => Item_4__raw;
                set {
                    if (Item_4__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_4__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_4_));
                }
            }

            protected byte Item_5__raw;
            public const string Item_5__displayName = "Item 5 %";
            [SortOrder(Item_5__sortIndex)]
            [DisplayName(Item_5__displayName)]
            public virtual byte Item_5_ {
                get => Item_5__raw;
                set {
                    if (Item_5__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_5__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_5_));
                }
            }

            protected byte Item_6__raw;
            public const string Item_6__displayName = "Item 6 %";
            [SortOrder(Item_6__sortIndex)]
            [DisplayName(Item_6__displayName)]
            public virtual byte Item_6_ {
                get => Item_6__raw;
                set {
                    if (Item_6__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_6__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_6_));
                }
            }

            protected byte Item_7__raw;
            public const string Item_7__displayName = "Item 7 %";
            [SortOrder(Item_7__sortIndex)]
            [DisplayName(Item_7__displayName)]
            public virtual byte Item_7_ {
                get => Item_7__raw;
                set {
                    if (Item_7__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_7__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_7_));
                }
            }

            protected byte Item_8__raw;
            public const string Item_8__displayName = "Item 8 %";
            [SortOrder(Item_8__sortIndex)]
            [DisplayName(Item_8__displayName)]
            public virtual byte Item_8_ {
                get => Item_8__raw;
                set {
                    if (Item_8__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_8__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_8_));
                }
            }

            protected byte Item_9__raw;
            public const string Item_9__displayName = "Item 9 %";
            [SortOrder(Item_9__sortIndex)]
            [DisplayName(Item_9__displayName)]
            public virtual byte Item_9_ {
                get => Item_9__raw;
                set {
                    if (Item_9__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_9__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_9_));
                }
            }

            protected byte Item_10__raw;
            public const string Item_10__displayName = "Item 10 %";
            [SortOrder(Item_10__sortIndex)]
            [DisplayName(Item_10__displayName)]
            public virtual byte Item_10_ {
                get => Item_10__raw;
                set {
                    if (Item_10__raw == value.Clamp((byte) 0, (byte) 100)) return;
                    Item_10__raw = value.Clamp((byte) 0, (byte) 100);
                    OnPropertyChanged(nameof(Item_10_));
                }
            }

            protected byte Item_1_Carve_Animation_raw;
            public const string Item_1_Carve_Animation_displayName = "Item 1 Carve Animation";
            [SortOrder(Item_1_Carve_Animation_sortIndex)]
            [DisplayName(Item_1_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_1_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_1_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_1_Carve_Animation_raw == value) return;
                    Item_1_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_1_Carve_Animation));
                }
            }

            protected byte Item_2_Carve_Animation_raw;
            public const string Item_2_Carve_Animation_displayName = "Item 2 Carve Animation";
            [SortOrder(Item_2_Carve_Animation_sortIndex)]
            [DisplayName(Item_2_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_2_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_2_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_2_Carve_Animation_raw == value) return;
                    Item_2_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_2_Carve_Animation));
                }
            }

            protected byte Item_3_Carve_Animation_raw;
            public const string Item_3_Carve_Animation_displayName = "Item 3 Carve Animation";
            [SortOrder(Item_3_Carve_Animation_sortIndex)]
            [DisplayName(Item_3_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_3_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_3_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_3_Carve_Animation_raw == value) return;
                    Item_3_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_3_Carve_Animation));
                }
            }

            protected byte Item_4_Carve_Animation_raw;
            public const string Item_4_Carve_Animation_displayName = "Item 4 Carve Animation";
            [SortOrder(Item_4_Carve_Animation_sortIndex)]
            [DisplayName(Item_4_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_4_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_4_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_4_Carve_Animation_raw == value) return;
                    Item_4_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_4_Carve_Animation));
                }
            }

            protected byte Item_5_Carve_Animation_raw;
            public const string Item_5_Carve_Animation_displayName = "Item 5 Carve Animation";
            [SortOrder(Item_5_Carve_Animation_sortIndex)]
            [DisplayName(Item_5_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_5_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_5_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_5_Carve_Animation_raw == value) return;
                    Item_5_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_5_Carve_Animation));
                }
            }

            protected byte Item_6_Carve_Animation_raw;
            public const string Item_6_Carve_Animation_displayName = "Item 6 Carve Animation";
            [SortOrder(Item_6_Carve_Animation_sortIndex)]
            [DisplayName(Item_6_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_6_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_6_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_6_Carve_Animation_raw == value) return;
                    Item_6_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_6_Carve_Animation));
                }
            }

            protected byte Item_7_Carve_Animation_raw;
            public const string Item_7_Carve_Animation_displayName = "Item 7 Carve Animation";
            [SortOrder(Item_7_Carve_Animation_sortIndex)]
            [DisplayName(Item_7_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_7_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_7_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_7_Carve_Animation_raw == value) return;
                    Item_7_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_7_Carve_Animation));
                }
            }

            protected byte Item_8_Carve_Animation_raw;
            public const string Item_8_Carve_Animation_displayName = "Item 8 Carve Animation";
            [SortOrder(Item_8_Carve_Animation_sortIndex)]
            [DisplayName(Item_8_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_8_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_8_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_8_Carve_Animation_raw == value) return;
                    Item_8_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_8_Carve_Animation));
                }
            }

            protected byte Item_9_Carve_Animation_raw;
            public const string Item_9_Carve_Animation_displayName = "Item 9 Carve Animation";
            [SortOrder(Item_9_Carve_Animation_sortIndex)]
            [DisplayName(Item_9_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_9_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_9_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_9_Carve_Animation_raw == value) return;
                    Item_9_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_9_Carve_Animation));
                }
            }

            protected byte Item_10_Carve_Animation_raw;
            public const string Item_10_Carve_Animation_displayName = "Item 10 Carve Animation";
            [SortOrder(Item_10_Carve_Animation_sortIndex)]
            [DisplayName(Item_10_Carve_Animation_displayName)]
            public virtual MHW_Template.Items.CarveAnimation Item_10_Carve_Animation {
                get => (MHW_Template.Items.CarveAnimation) Item_10_Carve_Animation_raw;
                set {
                    if ((MHW_Template.Items.CarveAnimation) Item_10_Carve_Animation_raw == value) return;
                    Item_10_Carve_Animation_raw = (byte) value;
                    OnPropertyChanged(nameof(Item_10_Carve_Animation));
                }
            }

            public const int lastSortIndex = 2050;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Header) lastStruct.Last();
                var count = (ulong) countTarget.Entry_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Entries LoadData(BinaryReader reader, ulong i) {
                var data = new Entries();
                data.Index = i;
                data.Item_1_Id_raw = reader.ReadUInt16();
                data.Item_2_Id_raw = reader.ReadUInt16();
                data.Item_3_Id_raw = reader.ReadUInt16();
                data.Item_4_Id_raw = reader.ReadUInt16();
                data.Item_5_Id_raw = reader.ReadUInt16();
                data.Item_6_Id_raw = reader.ReadUInt16();
                data.Item_7_Id_raw = reader.ReadUInt16();
                data.Item_8_Id_raw = reader.ReadUInt16();
                data.Item_9_Id_raw = reader.ReadUInt16();
                data.Item_10_Id_raw = reader.ReadUInt16();
                data.Item_1_Count_raw = reader.ReadByte();
                data.Item_2_Count_raw = reader.ReadByte();
                data.Item_3_Count_raw = reader.ReadByte();
                data.Item_4_Count_raw = reader.ReadByte();
                data.Item_5_Count_raw = reader.ReadByte();
                data.Item_6_Count_raw = reader.ReadByte();
                data.Item_7_Count_raw = reader.ReadByte();
                data.Item_8_Count_raw = reader.ReadByte();
                data.Item_9_Count_raw = reader.ReadByte();
                data.Item_10_Count_raw = reader.ReadByte();
                data.Item_1__raw = reader.ReadByte();
                data.Item_2__raw = reader.ReadByte();
                data.Item_3__raw = reader.ReadByte();
                data.Item_4__raw = reader.ReadByte();
                data.Item_5__raw = reader.ReadByte();
                data.Item_6__raw = reader.ReadByte();
                data.Item_7__raw = reader.ReadByte();
                data.Item_8__raw = reader.ReadByte();
                data.Item_9__raw = reader.ReadByte();
                data.Item_10__raw = reader.ReadByte();
                data.Item_1_Carve_Animation_raw = reader.ReadByte();
                data.Item_2_Carve_Animation_raw = reader.ReadByte();
                data.Item_3_Carve_Animation_raw = reader.ReadByte();
                data.Item_4_Carve_Animation_raw = reader.ReadByte();
                data.Item_5_Carve_Animation_raw = reader.ReadByte();
                data.Item_6_Carve_Animation_raw = reader.ReadByte();
                data.Item_7_Carve_Animation_raw = reader.ReadByte();
                data.Item_8_Carve_Animation_raw = reader.ReadByte();
                data.Item_9_Carve_Animation_raw = reader.ReadByte();
                data.Item_10_Carve_Animation_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Item_1_Id_raw);
                writer.Write(Item_2_Id_raw);
                writer.Write(Item_3_Id_raw);
                writer.Write(Item_4_Id_raw);
                writer.Write(Item_5_Id_raw);
                writer.Write(Item_6_Id_raw);
                writer.Write(Item_7_Id_raw);
                writer.Write(Item_8_Id_raw);
                writer.Write(Item_9_Id_raw);
                writer.Write(Item_10_Id_raw);
                writer.Write(Item_1_Count_raw);
                writer.Write(Item_2_Count_raw);
                writer.Write(Item_3_Count_raw);
                writer.Write(Item_4_Count_raw);
                writer.Write(Item_5_Count_raw);
                writer.Write(Item_6_Count_raw);
                writer.Write(Item_7_Count_raw);
                writer.Write(Item_8_Count_raw);
                writer.Write(Item_9_Count_raw);
                writer.Write(Item_10_Count_raw);
                writer.Write(Item_1__raw);
                writer.Write(Item_2__raw);
                writer.Write(Item_3__raw);
                writer.Write(Item_4__raw);
                writer.Write(Item_5__raw);
                writer.Write(Item_6__raw);
                writer.Write(Item_7__raw);
                writer.Write(Item_8__raw);
                writer.Write(Item_9__raw);
                writer.Write(Item_10__raw);
                writer.Write(Item_1_Carve_Animation_raw);
                writer.Write(Item_2_Carve_Animation_raw);
                writer.Write(Item_3_Carve_Animation_raw);
                writer.Write(Item_4_Carve_Animation_raw);
                writer.Write(Item_5_Carve_Animation_raw);
                writer.Write(Item_6_Carve_Animation_raw);
                writer.Write(Item_7_Carve_Animation_raw);
                writer.Write(Item_8_Carve_Animation_raw);
                writer.Write(Item_9_Carve_Animation_raw);
                writer.Write(Item_10_Carve_Animation_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer(Header.LoadData(reader, null), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}