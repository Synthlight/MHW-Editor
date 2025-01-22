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
    public partial class ExpeditionRewards {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem, IWriteData {
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
                    ChangedItems.Add(nameof(Magic_1));
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
                    ChangedItems.Add(nameof(Magic_2));
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
                    ChangedItems.Add(nameof(Entry_Count));
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Header> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Header>();
                const ulong count = 1UL;
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

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

            protected uint Unk_1_uint__raw;
            public const string Unk_1_uint__displayName = "Unk 1 (uint)";
            public const int Unk_1_uint__sortIndex = 50;
            [SortOrder(Unk_1_uint__sortIndex)]
            [DisplayName(Unk_1_uint__displayName)]
            public virtual uint Unk_1_uint_ {
                get => Unk_1_uint__raw;
                set {
                    if (Unk_1_uint__raw == value) return;
                    Unk_1_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_1_uint_));
                    OnPropertyChanged(nameof(Unk_1_uint_));
                }
            }

            protected sbyte Unk_2_sbyte__raw;
            public const string Unk_2_sbyte__displayName = "Unk 2 (sbyte)";
            public const int Unk_2_sbyte__sortIndex = 100;
            [SortOrder(Unk_2_sbyte__sortIndex)]
            [DisplayName(Unk_2_sbyte__displayName)]
            public virtual sbyte Unk_2_sbyte_ {
                get => Unk_2_sbyte__raw;
                set {
                    if (Unk_2_sbyte__raw == value) return;
                    Unk_2_sbyte__raw = value;
                    ChangedItems.Add(nameof(Unk_2_sbyte_));
                    OnPropertyChanged(nameof(Unk_2_sbyte_));
                }
            }

            protected byte Pad_1_raw;
            public const string Pad_1_displayName = "Pad 1";
            public const int Pad_1_sortIndex = 150;
            [SortOrder(Pad_1_sortIndex)]
            [DisplayName(Pad_1_displayName)]
            private byte Pad_1 {
                get => Pad_1_raw;
                set {
                    if (Pad_1_raw == value) return;
                    Pad_1_raw = value;
                    ChangedItems.Add(nameof(Pad_1));
                    OnPropertyChanged(nameof(Pad_1));
                }
            }

            protected byte Pad_2_raw;
            public const string Pad_2_displayName = "Pad 2";
            public const int Pad_2_sortIndex = 200;
            [SortOrder(Pad_2_sortIndex)]
            [DisplayName(Pad_2_displayName)]
            private byte Pad_2 {
                get => Pad_2_raw;
                set {
                    if (Pad_2_raw == value) return;
                    Pad_2_raw = value;
                    ChangedItems.Add(nameof(Pad_2));
                    OnPropertyChanged(nameof(Pad_2));
                }
            }

            protected byte Pad_3_raw;
            public const string Pad_3_displayName = "Pad 3";
            public const int Pad_3_sortIndex = 250;
            [SortOrder(Pad_3_sortIndex)]
            [DisplayName(Pad_3_displayName)]
            private byte Pad_3 {
                get => Pad_3_raw;
                set {
                    if (Pad_3_raw == value) return;
                    Pad_3_raw = value;
                    ChangedItems.Add(nameof(Pad_3));
                    OnPropertyChanged(nameof(Pad_3));
                }
            }

            protected uint Unk_3_uint__raw;
            public const string Unk_3_uint__displayName = "Unk 3 (uint)";
            public const int Unk_3_uint__sortIndex = 300;
            [SortOrder(Unk_3_uint__sortIndex)]
            [DisplayName(Unk_3_uint__displayName)]
            public virtual uint Unk_3_uint_ {
                get => Unk_3_uint__raw;
                set {
                    if (Unk_3_uint__raw == value) return;
                    Unk_3_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_3_uint_));
                    OnPropertyChanged(nameof(Unk_3_uint_));
                }
            }

            protected byte Unk_a1_byte__raw;
            public const string Unk_a1_byte__displayName = "Unk a1 (byte)";
            public const int Unk_a1_byte__sortIndex = 350;
            [SortOrder(Unk_a1_byte__sortIndex)]
            [DisplayName(Unk_a1_byte__displayName)]
            public virtual byte Unk_a1_byte_ {
                get => Unk_a1_byte__raw;
                set {
                    if (Unk_a1_byte__raw == value) return;
                    Unk_a1_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a1_byte_));
                    OnPropertyChanged(nameof(Unk_a1_byte_));
                }
            }

            protected byte Weight_1_raw;
            public const string Weight_1_displayName = "Weight 1";
            public const int Weight_1_sortIndex = 400;
            [SortOrder(Weight_1_sortIndex)]
            [DisplayName(Weight_1_displayName)]
            public virtual byte Weight_1 {
                get => Weight_1_raw;
                set {
                    if (Weight_1_raw == value) return;
                    Weight_1_raw = value;
                    ChangedItems.Add(nameof(Weight_1));
                    OnPropertyChanged(nameof(Weight_1));
                }
            }

            protected uint Item_Id_1_raw;
            public const string Item_Id_1_displayName = "Item Id 1";
            public const int Item_Id_1_sortIndex = 450;
            [SortOrder(Item_Id_1_sortIndex)]
            [DisplayName(Item_Id_1_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_1 {
                get => Item_Id_1_raw;
                set {
                    if (Item_Id_1_raw == value) return;
                    Item_Id_1_raw = value;
                    ChangedItems.Add(nameof(Item_Id_1));
                    OnPropertyChanged(nameof(Item_Id_1));
                    OnPropertyChanged(nameof(Item_Id_1_button));
                }
            }

            [SortOrder(Item_Id_1_sortIndex)]
            [DisplayName(Item_Id_1_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_1_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_1).ToStringWithId(Item_Id_1);

            protected byte Unk_a2_byte__raw;
            public const string Unk_a2_byte__displayName = "Unk a2 (byte)";
            public const int Unk_a2_byte__sortIndex = 500;
            [SortOrder(Unk_a2_byte__sortIndex)]
            [DisplayName(Unk_a2_byte__displayName)]
            public virtual byte Unk_a2_byte_ {
                get => Unk_a2_byte__raw;
                set {
                    if (Unk_a2_byte__raw == value) return;
                    Unk_a2_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a2_byte_));
                    OnPropertyChanged(nameof(Unk_a2_byte_));
                }
            }

            protected byte Weight_2_raw;
            public const string Weight_2_displayName = "Weight 2";
            public const int Weight_2_sortIndex = 550;
            [SortOrder(Weight_2_sortIndex)]
            [DisplayName(Weight_2_displayName)]
            public virtual byte Weight_2 {
                get => Weight_2_raw;
                set {
                    if (Weight_2_raw == value) return;
                    Weight_2_raw = value;
                    ChangedItems.Add(nameof(Weight_2));
                    OnPropertyChanged(nameof(Weight_2));
                }
            }

            protected uint Item_Id_2_raw;
            public const string Item_Id_2_displayName = "Item Id 2";
            public const int Item_Id_2_sortIndex = 600;
            [SortOrder(Item_Id_2_sortIndex)]
            [DisplayName(Item_Id_2_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_2 {
                get => Item_Id_2_raw;
                set {
                    if (Item_Id_2_raw == value) return;
                    Item_Id_2_raw = value;
                    ChangedItems.Add(nameof(Item_Id_2));
                    OnPropertyChanged(nameof(Item_Id_2));
                    OnPropertyChanged(nameof(Item_Id_2_button));
                }
            }

            [SortOrder(Item_Id_2_sortIndex)]
            [DisplayName(Item_Id_2_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_2_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_2).ToStringWithId(Item_Id_2);

            protected byte Unk_a3_byte__raw;
            public const string Unk_a3_byte__displayName = "Unk a3 (byte)";
            public const int Unk_a3_byte__sortIndex = 650;
            [SortOrder(Unk_a3_byte__sortIndex)]
            [DisplayName(Unk_a3_byte__displayName)]
            public virtual byte Unk_a3_byte_ {
                get => Unk_a3_byte__raw;
                set {
                    if (Unk_a3_byte__raw == value) return;
                    Unk_a3_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a3_byte_));
                    OnPropertyChanged(nameof(Unk_a3_byte_));
                }
            }

            protected byte Weight_3_raw;
            public const string Weight_3_displayName = "Weight 3";
            public const int Weight_3_sortIndex = 700;
            [SortOrder(Weight_3_sortIndex)]
            [DisplayName(Weight_3_displayName)]
            public virtual byte Weight_3 {
                get => Weight_3_raw;
                set {
                    if (Weight_3_raw == value) return;
                    Weight_3_raw = value;
                    ChangedItems.Add(nameof(Weight_3));
                    OnPropertyChanged(nameof(Weight_3));
                }
            }

            protected uint Item_Id_3_raw;
            public const string Item_Id_3_displayName = "Item Id 3";
            public const int Item_Id_3_sortIndex = 750;
            [SortOrder(Item_Id_3_sortIndex)]
            [DisplayName(Item_Id_3_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_3 {
                get => Item_Id_3_raw;
                set {
                    if (Item_Id_3_raw == value) return;
                    Item_Id_3_raw = value;
                    ChangedItems.Add(nameof(Item_Id_3));
                    OnPropertyChanged(nameof(Item_Id_3));
                    OnPropertyChanged(nameof(Item_Id_3_button));
                }
            }

            [SortOrder(Item_Id_3_sortIndex)]
            [DisplayName(Item_Id_3_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_3_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_3).ToStringWithId(Item_Id_3);

            protected byte Unk_a4_byte__raw;
            public const string Unk_a4_byte__displayName = "Unk a4 (byte)";
            public const int Unk_a4_byte__sortIndex = 800;
            [SortOrder(Unk_a4_byte__sortIndex)]
            [DisplayName(Unk_a4_byte__displayName)]
            public virtual byte Unk_a4_byte_ {
                get => Unk_a4_byte__raw;
                set {
                    if (Unk_a4_byte__raw == value) return;
                    Unk_a4_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a4_byte_));
                    OnPropertyChanged(nameof(Unk_a4_byte_));
                }
            }

            protected byte Weight_4_raw;
            public const string Weight_4_displayName = "Weight 4";
            public const int Weight_4_sortIndex = 850;
            [SortOrder(Weight_4_sortIndex)]
            [DisplayName(Weight_4_displayName)]
            public virtual byte Weight_4 {
                get => Weight_4_raw;
                set {
                    if (Weight_4_raw == value) return;
                    Weight_4_raw = value;
                    ChangedItems.Add(nameof(Weight_4));
                    OnPropertyChanged(nameof(Weight_4));
                }
            }

            protected uint Item_Id_4_raw;
            public const string Item_Id_4_displayName = "Item Id 4";
            public const int Item_Id_4_sortIndex = 900;
            [SortOrder(Item_Id_4_sortIndex)]
            [DisplayName(Item_Id_4_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_4 {
                get => Item_Id_4_raw;
                set {
                    if (Item_Id_4_raw == value) return;
                    Item_Id_4_raw = value;
                    ChangedItems.Add(nameof(Item_Id_4));
                    OnPropertyChanged(nameof(Item_Id_4));
                    OnPropertyChanged(nameof(Item_Id_4_button));
                }
            }

            [SortOrder(Item_Id_4_sortIndex)]
            [DisplayName(Item_Id_4_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_4_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_4).ToStringWithId(Item_Id_4);

            protected byte Unk_a5_byte__raw;
            public const string Unk_a5_byte__displayName = "Unk a5 (byte)";
            public const int Unk_a5_byte__sortIndex = 950;
            [SortOrder(Unk_a5_byte__sortIndex)]
            [DisplayName(Unk_a5_byte__displayName)]
            public virtual byte Unk_a5_byte_ {
                get => Unk_a5_byte__raw;
                set {
                    if (Unk_a5_byte__raw == value) return;
                    Unk_a5_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a5_byte_));
                    OnPropertyChanged(nameof(Unk_a5_byte_));
                }
            }

            protected byte Weight_5_raw;
            public const string Weight_5_displayName = "Weight 5";
            public const int Weight_5_sortIndex = 1000;
            [SortOrder(Weight_5_sortIndex)]
            [DisplayName(Weight_5_displayName)]
            public virtual byte Weight_5 {
                get => Weight_5_raw;
                set {
                    if (Weight_5_raw == value) return;
                    Weight_5_raw = value;
                    ChangedItems.Add(nameof(Weight_5));
                    OnPropertyChanged(nameof(Weight_5));
                }
            }

            protected uint Item_Id_5_raw;
            public const string Item_Id_5_displayName = "Item Id 5";
            public const int Item_Id_5_sortIndex = 1050;
            [SortOrder(Item_Id_5_sortIndex)]
            [DisplayName(Item_Id_5_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_5 {
                get => Item_Id_5_raw;
                set {
                    if (Item_Id_5_raw == value) return;
                    Item_Id_5_raw = value;
                    ChangedItems.Add(nameof(Item_Id_5));
                    OnPropertyChanged(nameof(Item_Id_5));
                    OnPropertyChanged(nameof(Item_Id_5_button));
                }
            }

            [SortOrder(Item_Id_5_sortIndex)]
            [DisplayName(Item_Id_5_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_5_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_5).ToStringWithId(Item_Id_5);

            protected byte Unk_a6_byte__raw;
            public const string Unk_a6_byte__displayName = "Unk a6 (byte)";
            public const int Unk_a6_byte__sortIndex = 1100;
            [SortOrder(Unk_a6_byte__sortIndex)]
            [DisplayName(Unk_a6_byte__displayName)]
            public virtual byte Unk_a6_byte_ {
                get => Unk_a6_byte__raw;
                set {
                    if (Unk_a6_byte__raw == value) return;
                    Unk_a6_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a6_byte_));
                    OnPropertyChanged(nameof(Unk_a6_byte_));
                }
            }

            protected byte Weight_6_raw;
            public const string Weight_6_displayName = "Weight 6";
            public const int Weight_6_sortIndex = 1150;
            [SortOrder(Weight_6_sortIndex)]
            [DisplayName(Weight_6_displayName)]
            public virtual byte Weight_6 {
                get => Weight_6_raw;
                set {
                    if (Weight_6_raw == value) return;
                    Weight_6_raw = value;
                    ChangedItems.Add(nameof(Weight_6));
                    OnPropertyChanged(nameof(Weight_6));
                }
            }

            protected uint Item_Id_6_raw;
            public const string Item_Id_6_displayName = "Item Id 6";
            public const int Item_Id_6_sortIndex = 1200;
            [SortOrder(Item_Id_6_sortIndex)]
            [DisplayName(Item_Id_6_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_6 {
                get => Item_Id_6_raw;
                set {
                    if (Item_Id_6_raw == value) return;
                    Item_Id_6_raw = value;
                    ChangedItems.Add(nameof(Item_Id_6));
                    OnPropertyChanged(nameof(Item_Id_6));
                    OnPropertyChanged(nameof(Item_Id_6_button));
                }
            }

            [SortOrder(Item_Id_6_sortIndex)]
            [DisplayName(Item_Id_6_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_6_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_6).ToStringWithId(Item_Id_6);

            protected byte Unk_a7_byte__raw;
            public const string Unk_a7_byte__displayName = "Unk a7 (byte)";
            public const int Unk_a7_byte__sortIndex = 1250;
            [SortOrder(Unk_a7_byte__sortIndex)]
            [DisplayName(Unk_a7_byte__displayName)]
            public virtual byte Unk_a7_byte_ {
                get => Unk_a7_byte__raw;
                set {
                    if (Unk_a7_byte__raw == value) return;
                    Unk_a7_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a7_byte_));
                    OnPropertyChanged(nameof(Unk_a7_byte_));
                }
            }

            protected byte Weight_7_raw;
            public const string Weight_7_displayName = "Weight 7";
            public const int Weight_7_sortIndex = 1300;
            [SortOrder(Weight_7_sortIndex)]
            [DisplayName(Weight_7_displayName)]
            public virtual byte Weight_7 {
                get => Weight_7_raw;
                set {
                    if (Weight_7_raw == value) return;
                    Weight_7_raw = value;
                    ChangedItems.Add(nameof(Weight_7));
                    OnPropertyChanged(nameof(Weight_7));
                }
            }

            protected uint Item_Id_7_raw;
            public const string Item_Id_7_displayName = "Item Id 7";
            public const int Item_Id_7_sortIndex = 1350;
            [SortOrder(Item_Id_7_sortIndex)]
            [DisplayName(Item_Id_7_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_7 {
                get => Item_Id_7_raw;
                set {
                    if (Item_Id_7_raw == value) return;
                    Item_Id_7_raw = value;
                    ChangedItems.Add(nameof(Item_Id_7));
                    OnPropertyChanged(nameof(Item_Id_7));
                    OnPropertyChanged(nameof(Item_Id_7_button));
                }
            }

            [SortOrder(Item_Id_7_sortIndex)]
            [DisplayName(Item_Id_7_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_7_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_7).ToStringWithId(Item_Id_7);

            protected byte Unk_a8_byte__raw;
            public const string Unk_a8_byte__displayName = "Unk a8 (byte)";
            public const int Unk_a8_byte__sortIndex = 1400;
            [SortOrder(Unk_a8_byte__sortIndex)]
            [DisplayName(Unk_a8_byte__displayName)]
            public virtual byte Unk_a8_byte_ {
                get => Unk_a8_byte__raw;
                set {
                    if (Unk_a8_byte__raw == value) return;
                    Unk_a8_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a8_byte_));
                    OnPropertyChanged(nameof(Unk_a8_byte_));
                }
            }

            protected byte Weight_8_raw;
            public const string Weight_8_displayName = "Weight 8";
            public const int Weight_8_sortIndex = 1450;
            [SortOrder(Weight_8_sortIndex)]
            [DisplayName(Weight_8_displayName)]
            public virtual byte Weight_8 {
                get => Weight_8_raw;
                set {
                    if (Weight_8_raw == value) return;
                    Weight_8_raw = value;
                    ChangedItems.Add(nameof(Weight_8));
                    OnPropertyChanged(nameof(Weight_8));
                }
            }

            protected uint Item_Id_8_raw;
            public const string Item_Id_8_displayName = "Item Id 8";
            public const int Item_Id_8_sortIndex = 1500;
            [SortOrder(Item_Id_8_sortIndex)]
            [DisplayName(Item_Id_8_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_8 {
                get => Item_Id_8_raw;
                set {
                    if (Item_Id_8_raw == value) return;
                    Item_Id_8_raw = value;
                    ChangedItems.Add(nameof(Item_Id_8));
                    OnPropertyChanged(nameof(Item_Id_8));
                    OnPropertyChanged(nameof(Item_Id_8_button));
                }
            }

            [SortOrder(Item_Id_8_sortIndex)]
            [DisplayName(Item_Id_8_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_8_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_8).ToStringWithId(Item_Id_8);

            protected byte Unk_a9_byte__raw;
            public const string Unk_a9_byte__displayName = "Unk a9 (byte)";
            public const int Unk_a9_byte__sortIndex = 1550;
            [SortOrder(Unk_a9_byte__sortIndex)]
            [DisplayName(Unk_a9_byte__displayName)]
            public virtual byte Unk_a9_byte_ {
                get => Unk_a9_byte__raw;
                set {
                    if (Unk_a9_byte__raw == value) return;
                    Unk_a9_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a9_byte_));
                    OnPropertyChanged(nameof(Unk_a9_byte_));
                }
            }

            protected byte Weight_9_raw;
            public const string Weight_9_displayName = "Weight 9";
            public const int Weight_9_sortIndex = 1600;
            [SortOrder(Weight_9_sortIndex)]
            [DisplayName(Weight_9_displayName)]
            public virtual byte Weight_9 {
                get => Weight_9_raw;
                set {
                    if (Weight_9_raw == value) return;
                    Weight_9_raw = value;
                    ChangedItems.Add(nameof(Weight_9));
                    OnPropertyChanged(nameof(Weight_9));
                }
            }

            protected uint Item_Id_9_raw;
            public const string Item_Id_9_displayName = "Item Id 9";
            public const int Item_Id_9_sortIndex = 1650;
            [SortOrder(Item_Id_9_sortIndex)]
            [DisplayName(Item_Id_9_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_9 {
                get => Item_Id_9_raw;
                set {
                    if (Item_Id_9_raw == value) return;
                    Item_Id_9_raw = value;
                    ChangedItems.Add(nameof(Item_Id_9));
                    OnPropertyChanged(nameof(Item_Id_9));
                    OnPropertyChanged(nameof(Item_Id_9_button));
                }
            }

            [SortOrder(Item_Id_9_sortIndex)]
            [DisplayName(Item_Id_9_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_9_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_9).ToStringWithId(Item_Id_9);

            protected byte Unk_a10_byte__raw;
            public const string Unk_a10_byte__displayName = "Unk a10 (byte)";
            public const int Unk_a10_byte__sortIndex = 1700;
            [SortOrder(Unk_a10_byte__sortIndex)]
            [DisplayName(Unk_a10_byte__displayName)]
            public virtual byte Unk_a10_byte_ {
                get => Unk_a10_byte__raw;
                set {
                    if (Unk_a10_byte__raw == value) return;
                    Unk_a10_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a10_byte_));
                    OnPropertyChanged(nameof(Unk_a10_byte_));
                }
            }

            protected byte Weight_10_raw;
            public const string Weight_10_displayName = "Weight 10";
            public const int Weight_10_sortIndex = 1750;
            [SortOrder(Weight_10_sortIndex)]
            [DisplayName(Weight_10_displayName)]
            public virtual byte Weight_10 {
                get => Weight_10_raw;
                set {
                    if (Weight_10_raw == value) return;
                    Weight_10_raw = value;
                    ChangedItems.Add(nameof(Weight_10));
                    OnPropertyChanged(nameof(Weight_10));
                }
            }

            protected uint Item_Id_10_raw;
            public const string Item_Id_10_displayName = "Item Id 10";
            public const int Item_Id_10_sortIndex = 1800;
            [SortOrder(Item_Id_10_sortIndex)]
            [DisplayName(Item_Id_10_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_10 {
                get => Item_Id_10_raw;
                set {
                    if (Item_Id_10_raw == value) return;
                    Item_Id_10_raw = value;
                    ChangedItems.Add(nameof(Item_Id_10));
                    OnPropertyChanged(nameof(Item_Id_10));
                    OnPropertyChanged(nameof(Item_Id_10_button));
                }
            }

            [SortOrder(Item_Id_10_sortIndex)]
            [DisplayName(Item_Id_10_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_10_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_10).ToStringWithId(Item_Id_10);

            protected byte Unk_a11_byte__raw;
            public const string Unk_a11_byte__displayName = "Unk a11 (byte)";
            public const int Unk_a11_byte__sortIndex = 1850;
            [SortOrder(Unk_a11_byte__sortIndex)]
            [DisplayName(Unk_a11_byte__displayName)]
            public virtual byte Unk_a11_byte_ {
                get => Unk_a11_byte__raw;
                set {
                    if (Unk_a11_byte__raw == value) return;
                    Unk_a11_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a11_byte_));
                    OnPropertyChanged(nameof(Unk_a11_byte_));
                }
            }

            protected byte Weight_11_raw;
            public const string Weight_11_displayName = "Weight 11";
            public const int Weight_11_sortIndex = 1900;
            [SortOrder(Weight_11_sortIndex)]
            [DisplayName(Weight_11_displayName)]
            public virtual byte Weight_11 {
                get => Weight_11_raw;
                set {
                    if (Weight_11_raw == value) return;
                    Weight_11_raw = value;
                    ChangedItems.Add(nameof(Weight_11));
                    OnPropertyChanged(nameof(Weight_11));
                }
            }

            protected uint Item_Id_11_raw;
            public const string Item_Id_11_displayName = "Item Id 11";
            public const int Item_Id_11_sortIndex = 1950;
            [SortOrder(Item_Id_11_sortIndex)]
            [DisplayName(Item_Id_11_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_11 {
                get => Item_Id_11_raw;
                set {
                    if (Item_Id_11_raw == value) return;
                    Item_Id_11_raw = value;
                    ChangedItems.Add(nameof(Item_Id_11));
                    OnPropertyChanged(nameof(Item_Id_11));
                    OnPropertyChanged(nameof(Item_Id_11_button));
                }
            }

            [SortOrder(Item_Id_11_sortIndex)]
            [DisplayName(Item_Id_11_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_11_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_11).ToStringWithId(Item_Id_11);

            protected byte Unk_a12_byte__raw;
            public const string Unk_a12_byte__displayName = "Unk a12 (byte)";
            public const int Unk_a12_byte__sortIndex = 2000;
            [SortOrder(Unk_a12_byte__sortIndex)]
            [DisplayName(Unk_a12_byte__displayName)]
            public virtual byte Unk_a12_byte_ {
                get => Unk_a12_byte__raw;
                set {
                    if (Unk_a12_byte__raw == value) return;
                    Unk_a12_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a12_byte_));
                    OnPropertyChanged(nameof(Unk_a12_byte_));
                }
            }

            protected byte Weight_12_raw;
            public const string Weight_12_displayName = "Weight 12";
            public const int Weight_12_sortIndex = 2050;
            [SortOrder(Weight_12_sortIndex)]
            [DisplayName(Weight_12_displayName)]
            public virtual byte Weight_12 {
                get => Weight_12_raw;
                set {
                    if (Weight_12_raw == value) return;
                    Weight_12_raw = value;
                    ChangedItems.Add(nameof(Weight_12));
                    OnPropertyChanged(nameof(Weight_12));
                }
            }

            protected uint Item_Id_12_raw;
            public const string Item_Id_12_displayName = "Item Id 12";
            public const int Item_Id_12_sortIndex = 2100;
            [SortOrder(Item_Id_12_sortIndex)]
            [DisplayName(Item_Id_12_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_12 {
                get => Item_Id_12_raw;
                set {
                    if (Item_Id_12_raw == value) return;
                    Item_Id_12_raw = value;
                    ChangedItems.Add(nameof(Item_Id_12));
                    OnPropertyChanged(nameof(Item_Id_12));
                    OnPropertyChanged(nameof(Item_Id_12_button));
                }
            }

            [SortOrder(Item_Id_12_sortIndex)]
            [DisplayName(Item_Id_12_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_12_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_12).ToStringWithId(Item_Id_12);

            protected byte Unk_a13_byte__raw;
            public const string Unk_a13_byte__displayName = "Unk a13 (byte)";
            public const int Unk_a13_byte__sortIndex = 2150;
            [SortOrder(Unk_a13_byte__sortIndex)]
            [DisplayName(Unk_a13_byte__displayName)]
            public virtual byte Unk_a13_byte_ {
                get => Unk_a13_byte__raw;
                set {
                    if (Unk_a13_byte__raw == value) return;
                    Unk_a13_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a13_byte_));
                    OnPropertyChanged(nameof(Unk_a13_byte_));
                }
            }

            protected byte Weight_13_raw;
            public const string Weight_13_displayName = "Weight 13";
            public const int Weight_13_sortIndex = 2200;
            [SortOrder(Weight_13_sortIndex)]
            [DisplayName(Weight_13_displayName)]
            public virtual byte Weight_13 {
                get => Weight_13_raw;
                set {
                    if (Weight_13_raw == value) return;
                    Weight_13_raw = value;
                    ChangedItems.Add(nameof(Weight_13));
                    OnPropertyChanged(nameof(Weight_13));
                }
            }

            protected uint Item_Id_13_raw;
            public const string Item_Id_13_displayName = "Item Id 13";
            public const int Item_Id_13_sortIndex = 2250;
            [SortOrder(Item_Id_13_sortIndex)]
            [DisplayName(Item_Id_13_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_13 {
                get => Item_Id_13_raw;
                set {
                    if (Item_Id_13_raw == value) return;
                    Item_Id_13_raw = value;
                    ChangedItems.Add(nameof(Item_Id_13));
                    OnPropertyChanged(nameof(Item_Id_13));
                    OnPropertyChanged(nameof(Item_Id_13_button));
                }
            }

            [SortOrder(Item_Id_13_sortIndex)]
            [DisplayName(Item_Id_13_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_13_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_13).ToStringWithId(Item_Id_13);

            protected byte Unk_a14_byte__raw;
            public const string Unk_a14_byte__displayName = "Unk a14 (byte)";
            public const int Unk_a14_byte__sortIndex = 2300;
            [SortOrder(Unk_a14_byte__sortIndex)]
            [DisplayName(Unk_a14_byte__displayName)]
            public virtual byte Unk_a14_byte_ {
                get => Unk_a14_byte__raw;
                set {
                    if (Unk_a14_byte__raw == value) return;
                    Unk_a14_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a14_byte_));
                    OnPropertyChanged(nameof(Unk_a14_byte_));
                }
            }

            protected byte Weight_14_raw;
            public const string Weight_14_displayName = "Weight 14";
            public const int Weight_14_sortIndex = 2350;
            [SortOrder(Weight_14_sortIndex)]
            [DisplayName(Weight_14_displayName)]
            public virtual byte Weight_14 {
                get => Weight_14_raw;
                set {
                    if (Weight_14_raw == value) return;
                    Weight_14_raw = value;
                    ChangedItems.Add(nameof(Weight_14));
                    OnPropertyChanged(nameof(Weight_14));
                }
            }

            protected uint Item_Id_14_raw;
            public const string Item_Id_14_displayName = "Item Id 14";
            public const int Item_Id_14_sortIndex = 2400;
            [SortOrder(Item_Id_14_sortIndex)]
            [DisplayName(Item_Id_14_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_14 {
                get => Item_Id_14_raw;
                set {
                    if (Item_Id_14_raw == value) return;
                    Item_Id_14_raw = value;
                    ChangedItems.Add(nameof(Item_Id_14));
                    OnPropertyChanged(nameof(Item_Id_14));
                    OnPropertyChanged(nameof(Item_Id_14_button));
                }
            }

            [SortOrder(Item_Id_14_sortIndex)]
            [DisplayName(Item_Id_14_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_14_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_14).ToStringWithId(Item_Id_14);

            protected byte Unk_a15_byte__raw;
            public const string Unk_a15_byte__displayName = "Unk a15 (byte)";
            public const int Unk_a15_byte__sortIndex = 2450;
            [SortOrder(Unk_a15_byte__sortIndex)]
            [DisplayName(Unk_a15_byte__displayName)]
            public virtual byte Unk_a15_byte_ {
                get => Unk_a15_byte__raw;
                set {
                    if (Unk_a15_byte__raw == value) return;
                    Unk_a15_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_a15_byte_));
                    OnPropertyChanged(nameof(Unk_a15_byte_));
                }
            }

            protected byte Weight_15_raw;
            public const string Weight_15_displayName = "Weight 15";
            public const int Weight_15_sortIndex = 2500;
            [SortOrder(Weight_15_sortIndex)]
            [DisplayName(Weight_15_displayName)]
            public virtual byte Weight_15 {
                get => Weight_15_raw;
                set {
                    if (Weight_15_raw == value) return;
                    Weight_15_raw = value;
                    ChangedItems.Add(nameof(Weight_15));
                    OnPropertyChanged(nameof(Weight_15));
                }
            }

            protected uint Item_Id_15_raw;
            public const string Item_Id_15_displayName = "Item Id 15";
            public const int Item_Id_15_sortIndex = 2550;
            [SortOrder(Item_Id_15_sortIndex)]
            [DisplayName(Item_Id_15_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_15 {
                get => Item_Id_15_raw;
                set {
                    if (Item_Id_15_raw == value) return;
                    Item_Id_15_raw = value;
                    ChangedItems.Add(nameof(Item_Id_15));
                    OnPropertyChanged(nameof(Item_Id_15));
                    OnPropertyChanged(nameof(Item_Id_15_button));
                }
            }

            [SortOrder(Item_Id_15_sortIndex)]
            [DisplayName(Item_Id_15_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_15_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_15).ToStringWithId(Item_Id_15);

            protected ushort Unk_4_uint16__raw;
            public const string Unk_4_uint16__displayName = "Unk 4 (uint16)";
            public const int Unk_4_uint16__sortIndex = 2600;
            [SortOrder(Unk_4_uint16__sortIndex)]
            [DisplayName(Unk_4_uint16__displayName)]
            public virtual ushort Unk_4_uint16_ {
                get => Unk_4_uint16__raw;
                set {
                    if (Unk_4_uint16__raw == value) return;
                    Unk_4_uint16__raw = value;
                    ChangedItems.Add(nameof(Unk_4_uint16_));
                    OnPropertyChanged(nameof(Unk_4_uint16_));
                }
            }

            public const int lastSortIndex = 2650;

            public static ObservableMhwStructCollection<Entries> LoadData(BinaryReader reader, ObservableMhwStructCollection<Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Entries>();
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
                data.Unk_1_uint__raw = reader.ReadUInt32();
                data.Unk_2_sbyte__raw = reader.ReadSByte();
                data.Pad_1_raw = reader.ReadByte();
                data.Pad_2_raw = reader.ReadByte();
                data.Pad_3_raw = reader.ReadByte();
                data.Unk_3_uint__raw = reader.ReadUInt32();
                data.Unk_a1_byte__raw = reader.ReadByte();
                data.Weight_1_raw = reader.ReadByte();
                data.Item_Id_1_raw = reader.ReadUInt32();
                data.Unk_a2_byte__raw = reader.ReadByte();
                data.Weight_2_raw = reader.ReadByte();
                data.Item_Id_2_raw = reader.ReadUInt32();
                data.Unk_a3_byte__raw = reader.ReadByte();
                data.Weight_3_raw = reader.ReadByte();
                data.Item_Id_3_raw = reader.ReadUInt32();
                data.Unk_a4_byte__raw = reader.ReadByte();
                data.Weight_4_raw = reader.ReadByte();
                data.Item_Id_4_raw = reader.ReadUInt32();
                data.Unk_a5_byte__raw = reader.ReadByte();
                data.Weight_5_raw = reader.ReadByte();
                data.Item_Id_5_raw = reader.ReadUInt32();
                data.Unk_a6_byte__raw = reader.ReadByte();
                data.Weight_6_raw = reader.ReadByte();
                data.Item_Id_6_raw = reader.ReadUInt32();
                data.Unk_a7_byte__raw = reader.ReadByte();
                data.Weight_7_raw = reader.ReadByte();
                data.Item_Id_7_raw = reader.ReadUInt32();
                data.Unk_a8_byte__raw = reader.ReadByte();
                data.Weight_8_raw = reader.ReadByte();
                data.Item_Id_8_raw = reader.ReadUInt32();
                data.Unk_a9_byte__raw = reader.ReadByte();
                data.Weight_9_raw = reader.ReadByte();
                data.Item_Id_9_raw = reader.ReadUInt32();
                data.Unk_a10_byte__raw = reader.ReadByte();
                data.Weight_10_raw = reader.ReadByte();
                data.Item_Id_10_raw = reader.ReadUInt32();
                data.Unk_a11_byte__raw = reader.ReadByte();
                data.Weight_11_raw = reader.ReadByte();
                data.Item_Id_11_raw = reader.ReadUInt32();
                data.Unk_a12_byte__raw = reader.ReadByte();
                data.Weight_12_raw = reader.ReadByte();
                data.Item_Id_12_raw = reader.ReadUInt32();
                data.Unk_a13_byte__raw = reader.ReadByte();
                data.Weight_13_raw = reader.ReadByte();
                data.Item_Id_13_raw = reader.ReadUInt32();
                data.Unk_a14_byte__raw = reader.ReadByte();
                data.Weight_14_raw = reader.ReadByte();
                data.Item_Id_14_raw = reader.ReadUInt32();
                data.Unk_a15_byte__raw = reader.ReadByte();
                data.Weight_15_raw = reader.ReadByte();
                data.Item_Id_15_raw = reader.ReadUInt32();
                data.Unk_4_uint16__raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_uint__raw);
                writer.Write(Unk_2_sbyte__raw);
                writer.Write(Pad_1_raw);
                writer.Write(Pad_2_raw);
                writer.Write(Pad_3_raw);
                writer.Write(Unk_3_uint__raw);
                writer.Write(Unk_a1_byte__raw);
                writer.Write(Weight_1_raw);
                writer.Write(Item_Id_1_raw);
                writer.Write(Unk_a2_byte__raw);
                writer.Write(Weight_2_raw);
                writer.Write(Item_Id_2_raw);
                writer.Write(Unk_a3_byte__raw);
                writer.Write(Weight_3_raw);
                writer.Write(Item_Id_3_raw);
                writer.Write(Unk_a4_byte__raw);
                writer.Write(Weight_4_raw);
                writer.Write(Item_Id_4_raw);
                writer.Write(Unk_a5_byte__raw);
                writer.Write(Weight_5_raw);
                writer.Write(Item_Id_5_raw);
                writer.Write(Unk_a6_byte__raw);
                writer.Write(Weight_6_raw);
                writer.Write(Item_Id_6_raw);
                writer.Write(Unk_a7_byte__raw);
                writer.Write(Weight_7_raw);
                writer.Write(Item_Id_7_raw);
                writer.Write(Unk_a8_byte__raw);
                writer.Write(Weight_8_raw);
                writer.Write(Item_Id_8_raw);
                writer.Write(Unk_a9_byte__raw);
                writer.Write(Weight_9_raw);
                writer.Write(Item_Id_9_raw);
                writer.Write(Unk_a10_byte__raw);
                writer.Write(Weight_10_raw);
                writer.Write(Item_Id_10_raw);
                writer.Write(Unk_a11_byte__raw);
                writer.Write(Weight_11_raw);
                writer.Write(Item_Id_11_raw);
                writer.Write(Unk_a12_byte__raw);
                writer.Write(Weight_12_raw);
                writer.Write(Item_Id_12_raw);
                writer.Write(Unk_a13_byte__raw);
                writer.Write(Weight_13_raw);
                writer.Write(Item_Id_13_raw);
                writer.Write(Unk_a14_byte__raw);
                writer.Write(Weight_14_raw);
                writer.Write(Item_Id_14_raw);
                writer.Write(Unk_a15_byte__raw);
                writer.Write(Weight_15_raw);
                writer.Write(Item_Id_15_raw);
                writer.Write(Unk_4_uint16__raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer<Entries, Header>(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}