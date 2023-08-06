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

namespace MHW_Editor.Structs.Weapons {
    public partial class CustomOuterRecipe {
        public override string EncryptionKey => "PCEBFfRCbwIdy6AZIoNA5lXV6FEki0yBEyW4FPXZUyWgeauqY8PYeZkM";

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
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected byte Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 50;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual byte Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    ChangedItems.Add(nameof(Unk1));
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected ushort Needed_Item_Id_to_Unlock_raw;
            public const string Needed_Item_Id_to_Unlock_displayName = "Needed Item Id to Unlock";
            public const int Needed_Item_Id_to_Unlock_sortIndex = 100;
            [SortOrder(Needed_Item_Id_to_Unlock_sortIndex)]
            [DisplayName(Needed_Item_Id_to_Unlock_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Needed_Item_Id_to_Unlock {
                get => Needed_Item_Id_to_Unlock_raw;
                set {
                    if (Needed_Item_Id_to_Unlock_raw == value) return;
                    Needed_Item_Id_to_Unlock_raw = value;
                    ChangedItems.Add(nameof(Needed_Item_Id_to_Unlock));
                    OnPropertyChanged(nameof(Needed_Item_Id_to_Unlock));
                    OnPropertyChanged(nameof(Needed_Item_Id_to_Unlock_button));
                }
            }

            [SortOrder(Needed_Item_Id_to_Unlock_sortIndex)]
            [DisplayName(Needed_Item_Id_to_Unlock_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Needed_Item_Id_to_Unlock_button => DataHelper.itemNames[MainWindow.locale].TryGet(Needed_Item_Id_to_Unlock).ToStringWithId(Needed_Item_Id_to_Unlock);

            protected int Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 150;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual int Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    ChangedItems.Add(nameof(Unk3));
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected int Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual int Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    ChangedItems.Add(nameof(Unk4));
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected uint Cost_raw;
            public const string Cost_displayName = "Cost";
            public const int Cost_sortIndex = 250;
            [SortOrder(Cost_sortIndex)]
            [DisplayName(Cost_displayName)]
            public virtual uint Cost {
                get => Cost_raw;
                set {
                    if (Cost_raw == value) return;
                    Cost_raw = value;
                    ChangedItems.Add(nameof(Cost));
                    OnPropertyChanged(nameof(Cost));
                }
            }

            protected ushort Mat_1_Id_raw;
            public const string Mat_1_Id_displayName = "Mat 1 Id";
            public const int Mat_1_Id_sortIndex = 300;
            [SortOrder(Mat_1_Id_sortIndex)]
            [DisplayName(Mat_1_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Mat_1_Id {
                get => Mat_1_Id_raw;
                set {
                    if (Mat_1_Id_raw == value) return;
                    Mat_1_Id_raw = value;
                    ChangedItems.Add(nameof(Mat_1_Id));
                    OnPropertyChanged(nameof(Mat_1_Id));
                    OnPropertyChanged(nameof(Mat_1_Id_button));
                }
            }

            [SortOrder(Mat_1_Id_sortIndex)]
            [DisplayName(Mat_1_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_1_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_1_Id).ToStringWithId(Mat_1_Id);

            protected byte Mat_1_Count_raw;
            public const string Mat_1_Count_displayName = "Mat 1 Count";
            public const int Mat_1_Count_sortIndex = 350;
            [SortOrder(Mat_1_Count_sortIndex)]
            [DisplayName(Mat_1_Count_displayName)]
            public virtual byte Mat_1_Count {
                get => Mat_1_Count_raw;
                set {
                    if (Mat_1_Count_raw == value) return;
                    Mat_1_Count_raw = value;
                    ChangedItems.Add(nameof(Mat_1_Count));
                    OnPropertyChanged(nameof(Mat_1_Count));
                }
            }

            protected ushort Mat_2_Id_raw;
            public const string Mat_2_Id_displayName = "Mat 2 Id";
            public const int Mat_2_Id_sortIndex = 400;
            [SortOrder(Mat_2_Id_sortIndex)]
            [DisplayName(Mat_2_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Mat_2_Id {
                get => Mat_2_Id_raw;
                set {
                    if (Mat_2_Id_raw == value) return;
                    Mat_2_Id_raw = value;
                    ChangedItems.Add(nameof(Mat_2_Id));
                    OnPropertyChanged(nameof(Mat_2_Id));
                    OnPropertyChanged(nameof(Mat_2_Id_button));
                }
            }

            [SortOrder(Mat_2_Id_sortIndex)]
            [DisplayName(Mat_2_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_2_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_2_Id).ToStringWithId(Mat_2_Id);

            protected byte Mat_2_Count_raw;
            public const string Mat_2_Count_displayName = "Mat 2 Count";
            public const int Mat_2_Count_sortIndex = 450;
            [SortOrder(Mat_2_Count_sortIndex)]
            [DisplayName(Mat_2_Count_displayName)]
            public virtual byte Mat_2_Count {
                get => Mat_2_Count_raw;
                set {
                    if (Mat_2_Count_raw == value) return;
                    Mat_2_Count_raw = value;
                    ChangedItems.Add(nameof(Mat_2_Count));
                    OnPropertyChanged(nameof(Mat_2_Count));
                }
            }

            protected ushort Mat_3_Id_raw;
            public const string Mat_3_Id_displayName = "Mat 3 Id";
            public const int Mat_3_Id_sortIndex = 500;
            [SortOrder(Mat_3_Id_sortIndex)]
            [DisplayName(Mat_3_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Mat_3_Id {
                get => Mat_3_Id_raw;
                set {
                    if (Mat_3_Id_raw == value) return;
                    Mat_3_Id_raw = value;
                    ChangedItems.Add(nameof(Mat_3_Id));
                    OnPropertyChanged(nameof(Mat_3_Id));
                    OnPropertyChanged(nameof(Mat_3_Id_button));
                }
            }

            [SortOrder(Mat_3_Id_sortIndex)]
            [DisplayName(Mat_3_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_3_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_3_Id).ToStringWithId(Mat_3_Id);

            protected byte Mat_3_Count_raw;
            public const string Mat_3_Count_displayName = "Mat 3 Count";
            public const int Mat_3_Count_sortIndex = 550;
            [SortOrder(Mat_3_Count_sortIndex)]
            [DisplayName(Mat_3_Count_displayName)]
            public virtual byte Mat_3_Count {
                get => Mat_3_Count_raw;
                set {
                    if (Mat_3_Count_raw == value) return;
                    Mat_3_Count_raw = value;
                    ChangedItems.Add(nameof(Mat_3_Count));
                    OnPropertyChanged(nameof(Mat_3_Count));
                }
            }

            protected ushort Mat_4_Id_raw;
            public const string Mat_4_Id_displayName = "Mat 4 Id";
            public const int Mat_4_Id_sortIndex = 600;
            [SortOrder(Mat_4_Id_sortIndex)]
            [DisplayName(Mat_4_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Mat_4_Id {
                get => Mat_4_Id_raw;
                set {
                    if (Mat_4_Id_raw == value) return;
                    Mat_4_Id_raw = value;
                    ChangedItems.Add(nameof(Mat_4_Id));
                    OnPropertyChanged(nameof(Mat_4_Id));
                    OnPropertyChanged(nameof(Mat_4_Id_button));
                }
            }

            [SortOrder(Mat_4_Id_sortIndex)]
            [DisplayName(Mat_4_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_4_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_4_Id).ToStringWithId(Mat_4_Id);

            protected byte Mat_4_Count_raw;
            public const string Mat_4_Count_displayName = "Mat 4 Count";
            public const int Mat_4_Count_sortIndex = 650;
            [SortOrder(Mat_4_Count_sortIndex)]
            [DisplayName(Mat_4_Count_displayName)]
            public virtual byte Mat_4_Count {
                get => Mat_4_Count_raw;
                set {
                    if (Mat_4_Count_raw == value) return;
                    Mat_4_Count_raw = value;
                    ChangedItems.Add(nameof(Mat_4_Count));
                    OnPropertyChanged(nameof(Mat_4_Count));
                }
            }

            protected byte Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 700;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual byte Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    ChangedItems.Add(nameof(Unk5));
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            protected byte Unk6_raw;
            public const string Unk6_displayName = "Unk6";
            public const int Unk6_sortIndex = 750;
            [SortOrder(Unk6_sortIndex)]
            [DisplayName(Unk6_displayName)]
            public virtual byte Unk6 {
                get => Unk6_raw;
                set {
                    if (Unk6_raw == value) return;
                    Unk6_raw = value;
                    ChangedItems.Add(nameof(Unk6));
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            protected byte Unk7_raw;
            public const string Unk7_displayName = "Unk7";
            public const int Unk7_sortIndex = 800;
            [SortOrder(Unk7_sortIndex)]
            [DisplayName(Unk7_displayName)]
            public virtual byte Unk7 {
                get => Unk7_raw;
                set {
                    if (Unk7_raw == value) return;
                    Unk7_raw = value;
                    ChangedItems.Add(nameof(Unk7));
                    OnPropertyChanged(nameof(Unk7));
                }
            }

            protected byte Unk8_raw;
            public const string Unk8_displayName = "Unk8";
            public const int Unk8_sortIndex = 850;
            [SortOrder(Unk8_sortIndex)]
            [DisplayName(Unk8_displayName)]
            public virtual byte Unk8 {
                get => Unk8_raw;
                set {
                    if (Unk8_raw == value) return;
                    Unk8_raw = value;
                    ChangedItems.Add(nameof(Unk8));
                    OnPropertyChanged(nameof(Unk8));
                }
            }

            public const int lastSortIndex = 900;

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
                data.Unk1_raw = reader.ReadByte();
                data.Needed_Item_Id_to_Unlock_raw = reader.ReadUInt16();
                data.Unk3_raw = reader.ReadInt32();
                data.Unk4_raw = reader.ReadInt32();
                data.Cost_raw = reader.ReadUInt32();
                data.Mat_1_Id_raw = reader.ReadUInt16();
                data.Mat_1_Count_raw = reader.ReadByte();
                data.Mat_2_Id_raw = reader.ReadUInt16();
                data.Mat_2_Count_raw = reader.ReadByte();
                data.Mat_3_Id_raw = reader.ReadUInt16();
                data.Mat_3_Count_raw = reader.ReadByte();
                data.Mat_4_Id_raw = reader.ReadUInt16();
                data.Mat_4_Count_raw = reader.ReadByte();
                data.Unk5_raw = reader.ReadByte();
                data.Unk6_raw = reader.ReadByte();
                data.Unk7_raw = reader.ReadByte();
                data.Unk8_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk1_raw);
                writer.Write(Needed_Item_Id_to_Unlock_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Cost_raw);
                writer.Write(Mat_1_Id_raw);
                writer.Write(Mat_1_Count_raw);
                writer.Write(Mat_2_Id_raw);
                writer.Write(Mat_2_Count_raw);
                writer.Write(Mat_3_Id_raw);
                writer.Write(Mat_3_Count_raw);
                writer.Write(Mat_4_Id_raw);
                writer.Write(Mat_4_Count_raw);
                writer.Write(Unk5_raw);
                writer.Write(Unk6_raw);
                writer.Write(Unk7_raw);
                writer.Write(Unk8_raw);
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