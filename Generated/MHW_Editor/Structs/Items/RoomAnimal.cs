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
    public partial class RoomAnimal {
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

            protected ushort Entry_Count_raw;
            public const string Entry_Count_displayName = "Entry Count";
            public const int Entry_Count_sortIndex = 150;
            [SortOrder(Entry_Count_sortIndex)]
            [DisplayName(Entry_Count_displayName)]
            [IsReadOnly]
            public virtual ushort Entry_Count {
                get => Entry_Count_raw;
                set {
                    if (Entry_Count_raw == value) return;
                    Entry_Count_raw = value;
                    ChangedItems.Add(nameof(Entry_Count));
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            protected byte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 200;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            [IsReadOnly]
            public virtual byte Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            public const int lastSortIndex = 250;

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
                data.Entry_Count_raw = reader.ReadUInt16();
                data.Unk_1_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Entry_Count_raw);
                writer.Write(Unk_1_raw);
            }
        }

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => $"{Index}";

            protected byte Display_Multiplier_raw;
            public const string Display_Multiplier_displayName = "Display Multiplier";
            public const int Display_Multiplier_sortIndex = 50;
            [SortOrder(Display_Multiplier_sortIndex)]
            [DisplayName(Display_Multiplier_displayName)]
            public virtual byte Display_Multiplier {
                get => Display_Multiplier_raw;
                set {
                    if (Display_Multiplier_raw == value) return;
                    Display_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Display_Multiplier));
                    OnPropertyChanged(nameof(Display_Multiplier));
                }
            }

            protected uint Item_Id_raw;
            public const string Item_Id_displayName = "Item Id";
            public const int Item_Id_sortIndex = 100;
            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id {
                get => Item_Id_raw;
                set {
                    if (Item_Id_raw == value) return;
                    Item_Id_raw = value;
                    ChangedItems.Add(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id_button));
                }
            }

            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

            protected byte Slot_1_raw;
            public const string Slot_1_displayName = "Slot 1";
            public const int Slot_1_sortIndex = 150;
            [SortOrder(Slot_1_sortIndex)]
            [DisplayName(Slot_1_displayName)]
            public virtual byte Slot_1 {
                get => Slot_1_raw;
                set {
                    if (Slot_1_raw == value) return;
                    Slot_1_raw = value;
                    ChangedItems.Add(nameof(Slot_1));
                    OnPropertyChanged(nameof(Slot_1));
                }
            }

            protected byte Slot_2_raw;
            public const string Slot_2_displayName = "Slot 2";
            public const int Slot_2_sortIndex = 200;
            [SortOrder(Slot_2_sortIndex)]
            [DisplayName(Slot_2_displayName)]
            public virtual byte Slot_2 {
                get => Slot_2_raw;
                set {
                    if (Slot_2_raw == value) return;
                    Slot_2_raw = value;
                    ChangedItems.Add(nameof(Slot_2));
                    OnPropertyChanged(nameof(Slot_2));
                }
            }

            protected byte Slot_3_raw;
            public const string Slot_3_displayName = "Slot 3";
            public const int Slot_3_sortIndex = 250;
            [SortOrder(Slot_3_sortIndex)]
            [DisplayName(Slot_3_displayName)]
            public virtual byte Slot_3 {
                get => Slot_3_raw;
                set {
                    if (Slot_3_raw == value) return;
                    Slot_3_raw = value;
                    ChangedItems.Add(nameof(Slot_3));
                    OnPropertyChanged(nameof(Slot_3));
                }
            }

            protected byte Slot_4_raw;
            public const string Slot_4_displayName = "Slot 4";
            public const int Slot_4_sortIndex = 300;
            [SortOrder(Slot_4_sortIndex)]
            [DisplayName(Slot_4_displayName)]
            public virtual byte Slot_4 {
                get => Slot_4_raw;
                set {
                    if (Slot_4_raw == value) return;
                    Slot_4_raw = value;
                    ChangedItems.Add(nameof(Slot_4));
                    OnPropertyChanged(nameof(Slot_4));
                }
            }

            protected byte Slot_5_raw;
            public const string Slot_5_displayName = "Slot 5";
            public const int Slot_5_sortIndex = 350;
            [SortOrder(Slot_5_sortIndex)]
            [DisplayName(Slot_5_displayName)]
            public virtual byte Slot_5 {
                get => Slot_5_raw;
                set {
                    if (Slot_5_raw == value) return;
                    Slot_5_raw = value;
                    ChangedItems.Add(nameof(Slot_5));
                    OnPropertyChanged(nameof(Slot_5));
                }
            }

            protected byte Slot_6_raw;
            public const string Slot_6_displayName = "Slot 6";
            public const int Slot_6_sortIndex = 400;
            [SortOrder(Slot_6_sortIndex)]
            [DisplayName(Slot_6_displayName)]
            public virtual byte Slot_6 {
                get => Slot_6_raw;
                set {
                    if (Slot_6_raw == value) return;
                    Slot_6_raw = value;
                    ChangedItems.Add(nameof(Slot_6));
                    OnPropertyChanged(nameof(Slot_6));
                }
            }

            protected byte Slot_7_raw;
            public const string Slot_7_displayName = "Slot 7";
            public const int Slot_7_sortIndex = 450;
            [SortOrder(Slot_7_sortIndex)]
            [DisplayName(Slot_7_displayName)]
            public virtual byte Slot_7 {
                get => Slot_7_raw;
                set {
                    if (Slot_7_raw == value) return;
                    Slot_7_raw = value;
                    ChangedItems.Add(nameof(Slot_7));
                    OnPropertyChanged(nameof(Slot_7));
                }
            }

            protected byte Slot_8_raw;
            public const string Slot_8_displayName = "Slot 8";
            public const int Slot_8_sortIndex = 500;
            [SortOrder(Slot_8_sortIndex)]
            [DisplayName(Slot_8_displayName)]
            public virtual byte Slot_8 {
                get => Slot_8_raw;
                set {
                    if (Slot_8_raw == value) return;
                    Slot_8_raw = value;
                    ChangedItems.Add(nameof(Slot_8));
                    OnPropertyChanged(nameof(Slot_8));
                }
            }

            protected byte Slot_9_raw;
            public const string Slot_9_displayName = "Slot 9";
            public const int Slot_9_sortIndex = 550;
            [SortOrder(Slot_9_sortIndex)]
            [DisplayName(Slot_9_displayName)]
            public virtual byte Slot_9 {
                get => Slot_9_raw;
                set {
                    if (Slot_9_raw == value) return;
                    Slot_9_raw = value;
                    ChangedItems.Add(nameof(Slot_9));
                    OnPropertyChanged(nameof(Slot_9));
                }
            }

            protected byte Slot_10_raw;
            public const string Slot_10_displayName = "Slot 10";
            public const int Slot_10_sortIndex = 600;
            [SortOrder(Slot_10_sortIndex)]
            [DisplayName(Slot_10_displayName)]
            public virtual byte Slot_10 {
                get => Slot_10_raw;
                set {
                    if (Slot_10_raw == value) return;
                    Slot_10_raw = value;
                    ChangedItems.Add(nameof(Slot_10));
                    OnPropertyChanged(nameof(Slot_10));
                }
            }

            protected byte Slot_11_raw;
            public const string Slot_11_displayName = "Slot 11";
            public const int Slot_11_sortIndex = 650;
            [SortOrder(Slot_11_sortIndex)]
            [DisplayName(Slot_11_displayName)]
            public virtual byte Slot_11 {
                get => Slot_11_raw;
                set {
                    if (Slot_11_raw == value) return;
                    Slot_11_raw = value;
                    ChangedItems.Add(nameof(Slot_11));
                    OnPropertyChanged(nameof(Slot_11));
                }
            }

            protected byte Slot_12_raw;
            public const string Slot_12_displayName = "Slot 12";
            public const int Slot_12_sortIndex = 700;
            [SortOrder(Slot_12_sortIndex)]
            [DisplayName(Slot_12_displayName)]
            public virtual byte Slot_12 {
                get => Slot_12_raw;
                set {
                    if (Slot_12_raw == value) return;
                    Slot_12_raw = value;
                    ChangedItems.Add(nameof(Slot_12));
                    OnPropertyChanged(nameof(Slot_12));
                }
            }

            protected byte Slot_13_raw;
            public const string Slot_13_displayName = "Slot 13";
            public const int Slot_13_sortIndex = 750;
            [SortOrder(Slot_13_sortIndex)]
            [DisplayName(Slot_13_displayName)]
            public virtual byte Slot_13 {
                get => Slot_13_raw;
                set {
                    if (Slot_13_raw == value) return;
                    Slot_13_raw = value;
                    ChangedItems.Add(nameof(Slot_13));
                    OnPropertyChanged(nameof(Slot_13));
                }
            }

            protected byte Slot_14_raw;
            public const string Slot_14_displayName = "Slot 14";
            public const int Slot_14_sortIndex = 800;
            [SortOrder(Slot_14_sortIndex)]
            [DisplayName(Slot_14_displayName)]
            public virtual byte Slot_14 {
                get => Slot_14_raw;
                set {
                    if (Slot_14_raw == value) return;
                    Slot_14_raw = value;
                    ChangedItems.Add(nameof(Slot_14));
                    OnPropertyChanged(nameof(Slot_14));
                }
            }

            protected byte Slot_15_raw;
            public const string Slot_15_displayName = "Slot 15";
            public const int Slot_15_sortIndex = 850;
            [SortOrder(Slot_15_sortIndex)]
            [DisplayName(Slot_15_displayName)]
            public virtual byte Slot_15 {
                get => Slot_15_raw;
                set {
                    if (Slot_15_raw == value) return;
                    Slot_15_raw = value;
                    ChangedItems.Add(nameof(Slot_15));
                    OnPropertyChanged(nameof(Slot_15));
                }
            }

            protected byte Slot_16_raw;
            public const string Slot_16_displayName = "Slot 16";
            public const int Slot_16_sortIndex = 900;
            [SortOrder(Slot_16_sortIndex)]
            [DisplayName(Slot_16_displayName)]
            public virtual byte Slot_16 {
                get => Slot_16_raw;
                set {
                    if (Slot_16_raw == value) return;
                    Slot_16_raw = value;
                    ChangedItems.Add(nameof(Slot_16));
                    OnPropertyChanged(nameof(Slot_16));
                }
            }

            protected byte Slot_17_raw;
            public const string Slot_17_displayName = "Slot 17";
            public const int Slot_17_sortIndex = 950;
            [SortOrder(Slot_17_sortIndex)]
            [DisplayName(Slot_17_displayName)]
            public virtual byte Slot_17 {
                get => Slot_17_raw;
                set {
                    if (Slot_17_raw == value) return;
                    Slot_17_raw = value;
                    ChangedItems.Add(nameof(Slot_17));
                    OnPropertyChanged(nameof(Slot_17));
                }
            }

            protected byte Slot_18_raw;
            public const string Slot_18_displayName = "Slot 18";
            public const int Slot_18_sortIndex = 1000;
            [SortOrder(Slot_18_sortIndex)]
            [DisplayName(Slot_18_displayName)]
            public virtual byte Slot_18 {
                get => Slot_18_raw;
                set {
                    if (Slot_18_raw == value) return;
                    Slot_18_raw = value;
                    ChangedItems.Add(nameof(Slot_18));
                    OnPropertyChanged(nameof(Slot_18));
                }
            }

            protected byte Slot_19_raw;
            public const string Slot_19_displayName = "Slot 19";
            public const int Slot_19_sortIndex = 1050;
            [SortOrder(Slot_19_sortIndex)]
            [DisplayName(Slot_19_displayName)]
            public virtual byte Slot_19 {
                get => Slot_19_raw;
                set {
                    if (Slot_19_raw == value) return;
                    Slot_19_raw = value;
                    ChangedItems.Add(nameof(Slot_19));
                    OnPropertyChanged(nameof(Slot_19));
                }
            }

            protected byte Slot_20_raw;
            public const string Slot_20_displayName = "Slot 20";
            public const int Slot_20_sortIndex = 1100;
            [SortOrder(Slot_20_sortIndex)]
            [DisplayName(Slot_20_displayName)]
            public virtual byte Slot_20 {
                get => Slot_20_raw;
                set {
                    if (Slot_20_raw == value) return;
                    Slot_20_raw = value;
                    ChangedItems.Add(nameof(Slot_20));
                    OnPropertyChanged(nameof(Slot_20));
                }
            }

            protected byte Slot_21_raw;
            public const string Slot_21_displayName = "Slot 21";
            public const int Slot_21_sortIndex = 1150;
            [SortOrder(Slot_21_sortIndex)]
            [DisplayName(Slot_21_displayName)]
            public virtual byte Slot_21 {
                get => Slot_21_raw;
                set {
                    if (Slot_21_raw == value) return;
                    Slot_21_raw = value;
                    ChangedItems.Add(nameof(Slot_21));
                    OnPropertyChanged(nameof(Slot_21));
                }
            }

            protected byte Slot_22_raw;
            public const string Slot_22_displayName = "Slot 22";
            public const int Slot_22_sortIndex = 1200;
            [SortOrder(Slot_22_sortIndex)]
            [DisplayName(Slot_22_displayName)]
            public virtual byte Slot_22 {
                get => Slot_22_raw;
                set {
                    if (Slot_22_raw == value) return;
                    Slot_22_raw = value;
                    ChangedItems.Add(nameof(Slot_22));
                    OnPropertyChanged(nameof(Slot_22));
                }
            }

            protected byte Slot_23_raw;
            public const string Slot_23_displayName = "Slot 23";
            public const int Slot_23_sortIndex = 1250;
            [SortOrder(Slot_23_sortIndex)]
            [DisplayName(Slot_23_displayName)]
            public virtual byte Slot_23 {
                get => Slot_23_raw;
                set {
                    if (Slot_23_raw == value) return;
                    Slot_23_raw = value;
                    ChangedItems.Add(nameof(Slot_23));
                    OnPropertyChanged(nameof(Slot_23));
                }
            }

            protected byte Slot_24_raw;
            public const string Slot_24_displayName = "Slot 24";
            public const int Slot_24_sortIndex = 1300;
            [SortOrder(Slot_24_sortIndex)]
            [DisplayName(Slot_24_displayName)]
            public virtual byte Slot_24 {
                get => Slot_24_raw;
                set {
                    if (Slot_24_raw == value) return;
                    Slot_24_raw = value;
                    ChangedItems.Add(nameof(Slot_24));
                    OnPropertyChanged(nameof(Slot_24));
                }
            }

            protected byte Slot_25_raw;
            public const string Slot_25_displayName = "Slot 25";
            public const int Slot_25_sortIndex = 1350;
            [SortOrder(Slot_25_sortIndex)]
            [DisplayName(Slot_25_displayName)]
            public virtual byte Slot_25 {
                get => Slot_25_raw;
                set {
                    if (Slot_25_raw == value) return;
                    Slot_25_raw = value;
                    ChangedItems.Add(nameof(Slot_25));
                    OnPropertyChanged(nameof(Slot_25));
                }
            }

            protected byte Slot_26_raw;
            public const string Slot_26_displayName = "Slot 26";
            public const int Slot_26_sortIndex = 1400;
            [SortOrder(Slot_26_sortIndex)]
            [DisplayName(Slot_26_displayName)]
            public virtual byte Slot_26 {
                get => Slot_26_raw;
                set {
                    if (Slot_26_raw == value) return;
                    Slot_26_raw = value;
                    ChangedItems.Add(nameof(Slot_26));
                    OnPropertyChanged(nameof(Slot_26));
                }
            }

            protected byte Slot_27_raw;
            public const string Slot_27_displayName = "Slot 27";
            public const int Slot_27_sortIndex = 1450;
            [SortOrder(Slot_27_sortIndex)]
            [DisplayName(Slot_27_displayName)]
            public virtual byte Slot_27 {
                get => Slot_27_raw;
                set {
                    if (Slot_27_raw == value) return;
                    Slot_27_raw = value;
                    ChangedItems.Add(nameof(Slot_27));
                    OnPropertyChanged(nameof(Slot_27));
                }
            }

            protected byte Slot_28_raw;
            public const string Slot_28_displayName = "Slot 28";
            public const int Slot_28_sortIndex = 1500;
            [SortOrder(Slot_28_sortIndex)]
            [DisplayName(Slot_28_displayName)]
            public virtual byte Slot_28 {
                get => Slot_28_raw;
                set {
                    if (Slot_28_raw == value) return;
                    Slot_28_raw = value;
                    ChangedItems.Add(nameof(Slot_28));
                    OnPropertyChanged(nameof(Slot_28));
                }
            }

            protected byte Slot_29_raw;
            public const string Slot_29_displayName = "Slot 29";
            public const int Slot_29_sortIndex = 1550;
            [SortOrder(Slot_29_sortIndex)]
            [DisplayName(Slot_29_displayName)]
            public virtual byte Slot_29 {
                get => Slot_29_raw;
                set {
                    if (Slot_29_raw == value) return;
                    Slot_29_raw = value;
                    ChangedItems.Add(nameof(Slot_29));
                    OnPropertyChanged(nameof(Slot_29));
                }
            }

            protected byte Slot_30_raw;
            public const string Slot_30_displayName = "Slot 30";
            public const int Slot_30_sortIndex = 1600;
            [SortOrder(Slot_30_sortIndex)]
            [DisplayName(Slot_30_displayName)]
            public virtual byte Slot_30 {
                get => Slot_30_raw;
                set {
                    if (Slot_30_raw == value) return;
                    Slot_30_raw = value;
                    ChangedItems.Add(nameof(Slot_30));
                    OnPropertyChanged(nameof(Slot_30));
                }
            }

            protected byte Slot_31_raw;
            public const string Slot_31_displayName = "Slot 31";
            public const int Slot_31_sortIndex = 1650;
            [SortOrder(Slot_31_sortIndex)]
            [DisplayName(Slot_31_displayName)]
            public virtual byte Slot_31 {
                get => Slot_31_raw;
                set {
                    if (Slot_31_raw == value) return;
                    Slot_31_raw = value;
                    ChangedItems.Add(nameof(Slot_31));
                    OnPropertyChanged(nameof(Slot_31));
                }
            }

            protected byte Slot_32_raw;
            public const string Slot_32_displayName = "Slot 32";
            public const int Slot_32_sortIndex = 1700;
            [SortOrder(Slot_32_sortIndex)]
            [DisplayName(Slot_32_displayName)]
            public virtual byte Slot_32 {
                get => Slot_32_raw;
                set {
                    if (Slot_32_raw == value) return;
                    Slot_32_raw = value;
                    ChangedItems.Add(nameof(Slot_32));
                    OnPropertyChanged(nameof(Slot_32));
                }
            }

            protected byte Slot_33_raw;
            public const string Slot_33_displayName = "Slot 33";
            public const int Slot_33_sortIndex = 1750;
            [SortOrder(Slot_33_sortIndex)]
            [DisplayName(Slot_33_displayName)]
            public virtual byte Slot_33 {
                get => Slot_33_raw;
                set {
                    if (Slot_33_raw == value) return;
                    Slot_33_raw = value;
                    ChangedItems.Add(nameof(Slot_33));
                    OnPropertyChanged(nameof(Slot_33));
                }
            }

            protected byte Slot_34_raw;
            public const string Slot_34_displayName = "Slot 34";
            public const int Slot_34_sortIndex = 1800;
            [SortOrder(Slot_34_sortIndex)]
            [DisplayName(Slot_34_displayName)]
            public virtual byte Slot_34 {
                get => Slot_34_raw;
                set {
                    if (Slot_34_raw == value) return;
                    Slot_34_raw = value;
                    ChangedItems.Add(nameof(Slot_34));
                    OnPropertyChanged(nameof(Slot_34));
                }
            }

            protected byte Slot_35_raw;
            public const string Slot_35_displayName = "Slot 35";
            public const int Slot_35_sortIndex = 1850;
            [SortOrder(Slot_35_sortIndex)]
            [DisplayName(Slot_35_displayName)]
            public virtual byte Slot_35 {
                get => Slot_35_raw;
                set {
                    if (Slot_35_raw == value) return;
                    Slot_35_raw = value;
                    ChangedItems.Add(nameof(Slot_35));
                    OnPropertyChanged(nameof(Slot_35));
                }
            }

            protected byte Slot_36_raw;
            public const string Slot_36_displayName = "Slot 36";
            public const int Slot_36_sortIndex = 1900;
            [SortOrder(Slot_36_sortIndex)]
            [DisplayName(Slot_36_displayName)]
            public virtual byte Slot_36 {
                get => Slot_36_raw;
                set {
                    if (Slot_36_raw == value) return;
                    Slot_36_raw = value;
                    ChangedItems.Add(nameof(Slot_36));
                    OnPropertyChanged(nameof(Slot_36));
                }
            }

            protected byte Slot_37_raw;
            public const string Slot_37_displayName = "Slot 37";
            public const int Slot_37_sortIndex = 1950;
            [SortOrder(Slot_37_sortIndex)]
            [DisplayName(Slot_37_displayName)]
            public virtual byte Slot_37 {
                get => Slot_37_raw;
                set {
                    if (Slot_37_raw == value) return;
                    Slot_37_raw = value;
                    ChangedItems.Add(nameof(Slot_37));
                    OnPropertyChanged(nameof(Slot_37));
                }
            }

            protected byte Slot_38_raw;
            public const string Slot_38_displayName = "Slot 38";
            public const int Slot_38_sortIndex = 2000;
            [SortOrder(Slot_38_sortIndex)]
            [DisplayName(Slot_38_displayName)]
            public virtual byte Slot_38 {
                get => Slot_38_raw;
                set {
                    if (Slot_38_raw == value) return;
                    Slot_38_raw = value;
                    ChangedItems.Add(nameof(Slot_38));
                    OnPropertyChanged(nameof(Slot_38));
                }
            }

            protected byte Slot_39_raw;
            public const string Slot_39_displayName = "Slot 39";
            public const int Slot_39_sortIndex = 2050;
            [SortOrder(Slot_39_sortIndex)]
            [DisplayName(Slot_39_displayName)]
            public virtual byte Slot_39 {
                get => Slot_39_raw;
                set {
                    if (Slot_39_raw == value) return;
                    Slot_39_raw = value;
                    ChangedItems.Add(nameof(Slot_39));
                    OnPropertyChanged(nameof(Slot_39));
                }
            }

            protected byte Slot_40_raw;
            public const string Slot_40_displayName = "Slot 40";
            public const int Slot_40_sortIndex = 2100;
            [SortOrder(Slot_40_sortIndex)]
            [DisplayName(Slot_40_displayName)]
            public virtual byte Slot_40 {
                get => Slot_40_raw;
                set {
                    if (Slot_40_raw == value) return;
                    Slot_40_raw = value;
                    ChangedItems.Add(nameof(Slot_40));
                    OnPropertyChanged(nameof(Slot_40));
                }
            }

            protected byte Slot_41_raw;
            public const string Slot_41_displayName = "Slot 41";
            public const int Slot_41_sortIndex = 2150;
            [SortOrder(Slot_41_sortIndex)]
            [DisplayName(Slot_41_displayName)]
            public virtual byte Slot_41 {
                get => Slot_41_raw;
                set {
                    if (Slot_41_raw == value) return;
                    Slot_41_raw = value;
                    ChangedItems.Add(nameof(Slot_41));
                    OnPropertyChanged(nameof(Slot_41));
                }
            }

            protected byte Slot_42_raw;
            public const string Slot_42_displayName = "Slot 42";
            public const int Slot_42_sortIndex = 2200;
            [SortOrder(Slot_42_sortIndex)]
            [DisplayName(Slot_42_displayName)]
            public virtual byte Slot_42 {
                get => Slot_42_raw;
                set {
                    if (Slot_42_raw == value) return;
                    Slot_42_raw = value;
                    ChangedItems.Add(nameof(Slot_42));
                    OnPropertyChanged(nameof(Slot_42));
                }
            }

            protected byte Slot_43_raw;
            public const string Slot_43_displayName = "Slot 43";
            public const int Slot_43_sortIndex = 2250;
            [SortOrder(Slot_43_sortIndex)]
            [DisplayName(Slot_43_displayName)]
            public virtual byte Slot_43 {
                get => Slot_43_raw;
                set {
                    if (Slot_43_raw == value) return;
                    Slot_43_raw = value;
                    ChangedItems.Add(nameof(Slot_43));
                    OnPropertyChanged(nameof(Slot_43));
                }
            }

            protected byte Slot_44_raw;
            public const string Slot_44_displayName = "Slot 44";
            public const int Slot_44_sortIndex = 2300;
            [SortOrder(Slot_44_sortIndex)]
            [DisplayName(Slot_44_displayName)]
            public virtual byte Slot_44 {
                get => Slot_44_raw;
                set {
                    if (Slot_44_raw == value) return;
                    Slot_44_raw = value;
                    ChangedItems.Add(nameof(Slot_44));
                    OnPropertyChanged(nameof(Slot_44));
                }
            }

            protected byte Slot_45_raw;
            public const string Slot_45_displayName = "Slot 45";
            public const int Slot_45_sortIndex = 2350;
            [SortOrder(Slot_45_sortIndex)]
            [DisplayName(Slot_45_displayName)]
            public virtual byte Slot_45 {
                get => Slot_45_raw;
                set {
                    if (Slot_45_raw == value) return;
                    Slot_45_raw = value;
                    ChangedItems.Add(nameof(Slot_45));
                    OnPropertyChanged(nameof(Slot_45));
                }
            }

            protected byte Slot_46_raw;
            public const string Slot_46_displayName = "Slot 46";
            public const int Slot_46_sortIndex = 2400;
            [SortOrder(Slot_46_sortIndex)]
            [DisplayName(Slot_46_displayName)]
            public virtual byte Slot_46 {
                get => Slot_46_raw;
                set {
                    if (Slot_46_raw == value) return;
                    Slot_46_raw = value;
                    ChangedItems.Add(nameof(Slot_46));
                    OnPropertyChanged(nameof(Slot_46));
                }
            }

            protected byte Slot_47_raw;
            public const string Slot_47_displayName = "Slot 47";
            public const int Slot_47_sortIndex = 2450;
            [SortOrder(Slot_47_sortIndex)]
            [DisplayName(Slot_47_displayName)]
            public virtual byte Slot_47 {
                get => Slot_47_raw;
                set {
                    if (Slot_47_raw == value) return;
                    Slot_47_raw = value;
                    ChangedItems.Add(nameof(Slot_47));
                    OnPropertyChanged(nameof(Slot_47));
                }
            }

            protected byte Slot_48_raw;
            public const string Slot_48_displayName = "Slot 48";
            public const int Slot_48_sortIndex = 2500;
            [SortOrder(Slot_48_sortIndex)]
            [DisplayName(Slot_48_displayName)]
            public virtual byte Slot_48 {
                get => Slot_48_raw;
                set {
                    if (Slot_48_raw == value) return;
                    Slot_48_raw = value;
                    ChangedItems.Add(nameof(Slot_48));
                    OnPropertyChanged(nameof(Slot_48));
                }
            }

            protected byte Slot_49_raw;
            public const string Slot_49_displayName = "Slot 49";
            public const int Slot_49_sortIndex = 2550;
            [SortOrder(Slot_49_sortIndex)]
            [DisplayName(Slot_49_displayName)]
            public virtual byte Slot_49 {
                get => Slot_49_raw;
                set {
                    if (Slot_49_raw == value) return;
                    Slot_49_raw = value;
                    ChangedItems.Add(nameof(Slot_49));
                    OnPropertyChanged(nameof(Slot_49));
                }
            }

            protected byte Slot_50_raw;
            public const string Slot_50_displayName = "Slot 50";
            public const int Slot_50_sortIndex = 2600;
            [SortOrder(Slot_50_sortIndex)]
            [DisplayName(Slot_50_displayName)]
            public virtual byte Slot_50 {
                get => Slot_50_raw;
                set {
                    if (Slot_50_raw == value) return;
                    Slot_50_raw = value;
                    ChangedItems.Add(nameof(Slot_50));
                    OnPropertyChanged(nameof(Slot_50));
                }
            }

            protected byte Slot_51_raw;
            public const string Slot_51_displayName = "Slot 51";
            public const int Slot_51_sortIndex = 2650;
            [SortOrder(Slot_51_sortIndex)]
            [DisplayName(Slot_51_displayName)]
            public virtual byte Slot_51 {
                get => Slot_51_raw;
                set {
                    if (Slot_51_raw == value) return;
                    Slot_51_raw = value;
                    ChangedItems.Add(nameof(Slot_51));
                    OnPropertyChanged(nameof(Slot_51));
                }
            }

            protected byte Slot_52_raw;
            public const string Slot_52_displayName = "Slot 52";
            public const int Slot_52_sortIndex = 2700;
            [SortOrder(Slot_52_sortIndex)]
            [DisplayName(Slot_52_displayName)]
            public virtual byte Slot_52 {
                get => Slot_52_raw;
                set {
                    if (Slot_52_raw == value) return;
                    Slot_52_raw = value;
                    ChangedItems.Add(nameof(Slot_52));
                    OnPropertyChanged(nameof(Slot_52));
                }
            }

            protected byte Slot_53_raw;
            public const string Slot_53_displayName = "Slot 53";
            public const int Slot_53_sortIndex = 2750;
            [SortOrder(Slot_53_sortIndex)]
            [DisplayName(Slot_53_displayName)]
            public virtual byte Slot_53 {
                get => Slot_53_raw;
                set {
                    if (Slot_53_raw == value) return;
                    Slot_53_raw = value;
                    ChangedItems.Add(nameof(Slot_53));
                    OnPropertyChanged(nameof(Slot_53));
                }
            }

            public const int lastSortIndex = 2800;

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
                data.Display_Multiplier_raw = reader.ReadByte();
                data.Item_Id_raw = reader.ReadUInt32();
                data.Slot_1_raw = reader.ReadByte();
                data.Slot_2_raw = reader.ReadByte();
                data.Slot_3_raw = reader.ReadByte();
                data.Slot_4_raw = reader.ReadByte();
                data.Slot_5_raw = reader.ReadByte();
                data.Slot_6_raw = reader.ReadByte();
                data.Slot_7_raw = reader.ReadByte();
                data.Slot_8_raw = reader.ReadByte();
                data.Slot_9_raw = reader.ReadByte();
                data.Slot_10_raw = reader.ReadByte();
                data.Slot_11_raw = reader.ReadByte();
                data.Slot_12_raw = reader.ReadByte();
                data.Slot_13_raw = reader.ReadByte();
                data.Slot_14_raw = reader.ReadByte();
                data.Slot_15_raw = reader.ReadByte();
                data.Slot_16_raw = reader.ReadByte();
                data.Slot_17_raw = reader.ReadByte();
                data.Slot_18_raw = reader.ReadByte();
                data.Slot_19_raw = reader.ReadByte();
                data.Slot_20_raw = reader.ReadByte();
                data.Slot_21_raw = reader.ReadByte();
                data.Slot_22_raw = reader.ReadByte();
                data.Slot_23_raw = reader.ReadByte();
                data.Slot_24_raw = reader.ReadByte();
                data.Slot_25_raw = reader.ReadByte();
                data.Slot_26_raw = reader.ReadByte();
                data.Slot_27_raw = reader.ReadByte();
                data.Slot_28_raw = reader.ReadByte();
                data.Slot_29_raw = reader.ReadByte();
                data.Slot_30_raw = reader.ReadByte();
                data.Slot_31_raw = reader.ReadByte();
                data.Slot_32_raw = reader.ReadByte();
                data.Slot_33_raw = reader.ReadByte();
                data.Slot_34_raw = reader.ReadByte();
                data.Slot_35_raw = reader.ReadByte();
                data.Slot_36_raw = reader.ReadByte();
                data.Slot_37_raw = reader.ReadByte();
                data.Slot_38_raw = reader.ReadByte();
                data.Slot_39_raw = reader.ReadByte();
                data.Slot_40_raw = reader.ReadByte();
                data.Slot_41_raw = reader.ReadByte();
                data.Slot_42_raw = reader.ReadByte();
                data.Slot_43_raw = reader.ReadByte();
                data.Slot_44_raw = reader.ReadByte();
                data.Slot_45_raw = reader.ReadByte();
                data.Slot_46_raw = reader.ReadByte();
                data.Slot_47_raw = reader.ReadByte();
                data.Slot_48_raw = reader.ReadByte();
                data.Slot_49_raw = reader.ReadByte();
                data.Slot_50_raw = reader.ReadByte();
                data.Slot_51_raw = reader.ReadByte();
                data.Slot_52_raw = reader.ReadByte();
                data.Slot_53_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Display_Multiplier_raw);
                writer.Write(Item_Id_raw);
                writer.Write(Slot_1_raw);
                writer.Write(Slot_2_raw);
                writer.Write(Slot_3_raw);
                writer.Write(Slot_4_raw);
                writer.Write(Slot_5_raw);
                writer.Write(Slot_6_raw);
                writer.Write(Slot_7_raw);
                writer.Write(Slot_8_raw);
                writer.Write(Slot_9_raw);
                writer.Write(Slot_10_raw);
                writer.Write(Slot_11_raw);
                writer.Write(Slot_12_raw);
                writer.Write(Slot_13_raw);
                writer.Write(Slot_14_raw);
                writer.Write(Slot_15_raw);
                writer.Write(Slot_16_raw);
                writer.Write(Slot_17_raw);
                writer.Write(Slot_18_raw);
                writer.Write(Slot_19_raw);
                writer.Write(Slot_20_raw);
                writer.Write(Slot_21_raw);
                writer.Write(Slot_22_raw);
                writer.Write(Slot_23_raw);
                writer.Write(Slot_24_raw);
                writer.Write(Slot_25_raw);
                writer.Write(Slot_26_raw);
                writer.Write(Slot_27_raw);
                writer.Write(Slot_28_raw);
                writer.Write(Slot_29_raw);
                writer.Write(Slot_30_raw);
                writer.Write(Slot_31_raw);
                writer.Write(Slot_32_raw);
                writer.Write(Slot_33_raw);
                writer.Write(Slot_34_raw);
                writer.Write(Slot_35_raw);
                writer.Write(Slot_36_raw);
                writer.Write(Slot_37_raw);
                writer.Write(Slot_38_raw);
                writer.Write(Slot_39_raw);
                writer.Write(Slot_40_raw);
                writer.Write(Slot_41_raw);
                writer.Write(Slot_42_raw);
                writer.Write(Slot_43_raw);
                writer.Write(Slot_44_raw);
                writer.Write(Slot_45_raw);
                writer.Write(Slot_46_raw);
                writer.Write(Slot_47_raw);
                writer.Write(Slot_48_raw);
                writer.Write(Slot_49_raw);
                writer.Write(Slot_50_raw);
                writer.Write(Slot_51_raw);
                writer.Write(Slot_52_raw);
                writer.Write(Slot_53_raw);
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