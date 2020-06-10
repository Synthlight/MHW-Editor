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
    public partial class CustomPartsR {
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

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => $"{Id}|{Weapon_Type}";

            protected byte Weapon_Type_raw;
            public const string Weapon_Type_displayName = "Weapon Type";
            public const int Weapon_Type_sortIndex = 50;
            [SortOrder(Weapon_Type_sortIndex)]
            [DisplayName(Weapon_Type_displayName)]
            [IsReadOnly]
            public virtual MHW_Template.Weapons.WeaponType Weapon_Type {
                get => (MHW_Template.Weapons.WeaponType) Weapon_Type_raw;
                set {
                    if ((MHW_Template.Weapons.WeaponType) Weapon_Type_raw == value) return;
                    Weapon_Type_raw = (byte) value;
                    ChangedItems.Add(nameof(Weapon_Type));
                    OnPropertyChanged(nameof(Weapon_Type));
                }
            }

            protected uint Id_raw;
            public const string Id_displayName = "Id";
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    ChangedItems.Add(nameof(Id));
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected ushort Needed_Item_Id_to_Unlock_raw;
            public const string Needed_Item_Id_to_Unlock_displayName = "Needed Item Id to Unlock";
            public const int Needed_Item_Id_to_Unlock_sortIndex = 150;
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

            protected int Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 200;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual int Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected int Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 250;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual int Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
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

            protected ushort Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 700;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual ushort Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected ushort Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 750;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual ushort Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected ushort Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 800;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual ushort Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected ushort Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 850;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual ushort Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected ushort Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 900;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual ushort Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            protected ushort Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 950;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual ushort Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            protected ushort Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 1000;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual ushort Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            protected ushort Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 1050;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual ushort Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            protected ushort Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 1100;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual ushort Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            protected ushort Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 1150;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual ushort Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            protected ushort Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 1200;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual ushort Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            protected ushort Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 1250;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual ushort Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            public const int lastSortIndex = 1300;

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
                data.Weapon_Type_raw = reader.ReadByte();
                data.Id_raw = reader.ReadUInt32();
                data.Needed_Item_Id_to_Unlock_raw = reader.ReadUInt16();
                data.Unk_1_raw = reader.ReadInt32();
                data.Unk_2_raw = reader.ReadInt32();
                data.Mat_1_Id_raw = reader.ReadUInt16();
                data.Mat_1_Count_raw = reader.ReadByte();
                data.Mat_2_Id_raw = reader.ReadUInt16();
                data.Mat_2_Count_raw = reader.ReadByte();
                data.Mat_3_Id_raw = reader.ReadUInt16();
                data.Mat_3_Count_raw = reader.ReadByte();
                data.Mat_4_Id_raw = reader.ReadUInt16();
                data.Mat_4_Count_raw = reader.ReadByte();
                data.Unk_3_raw = reader.ReadUInt16();
                data.Unk_4_raw = reader.ReadUInt16();
                data.Unk_5_raw = reader.ReadUInt16();
                data.Unk_6_raw = reader.ReadUInt16();
                data.Unk_7_raw = reader.ReadUInt16();
                data.Unk_8_raw = reader.ReadUInt16();
                data.Unk_9_raw = reader.ReadUInt16();
                data.Unk_10_raw = reader.ReadUInt16();
                data.Unk_11_raw = reader.ReadUInt16();
                data.Unk_12_raw = reader.ReadUInt16();
                data.Unk_13_raw = reader.ReadUInt16();
                data.Unk_14_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Weapon_Type_raw);
                writer.Write(Id_raw);
                writer.Write(Needed_Item_Id_to_Unlock_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Mat_1_Id_raw);
                writer.Write(Mat_1_Count_raw);
                writer.Write(Mat_2_Id_raw);
                writer.Write(Mat_2_Count_raw);
                writer.Write(Mat_3_Id_raw);
                writer.Write(Mat_3_Count_raw);
                writer.Write(Mat_4_Id_raw);
                writer.Write(Mat_4_Count_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Unk_10_raw);
                writer.Write(Unk_11_raw);
                writer.Write(Unk_12_raw);
                writer.Write(Unk_13_raw);
                writer.Write(Unk_14_raw);
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