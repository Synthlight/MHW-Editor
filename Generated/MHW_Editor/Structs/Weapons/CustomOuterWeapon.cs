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
    public partial class CustomOuterWeapon {
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

            protected uint Entry_Index_raw;
            public const string Entry_Index_displayName = "Entry Index";
            public const int Entry_Index_sortIndex = 50;
            [SortOrder(Entry_Index_sortIndex)]
            [DisplayName(Entry_Index_displayName)]
            public virtual uint Entry_Index {
                get => Entry_Index_raw;
                set {
                    if (Entry_Index_raw == value) return;
                    Entry_Index_raw = value;
                    ChangedItems.Add(nameof(Entry_Index));
                    OnPropertyChanged(nameof(Entry_Index));
                }
            }

            protected uint Recipe_ID_raw;
            public const string Recipe_ID_displayName = "Recipe ID";
            public const int Recipe_ID_sortIndex = 100;
            [SortOrder(Recipe_ID_sortIndex)]
            [DisplayName(Recipe_ID_displayName)]
            public virtual uint Recipe_ID {
                get => Recipe_ID_raw;
                set {
                    if (Recipe_ID_raw == value) return;
                    Recipe_ID_raw = value;
                    ChangedItems.Add(nameof(Recipe_ID));
                    OnPropertyChanged(nameof(Recipe_ID));
                }
            }

            protected int Series_Name_raw;
            public const string Series_Name_displayName = "Series Name";
            public const int Series_Name_sortIndex = 150;
            [SortOrder(Series_Name_sortIndex)]
            [DisplayName(Series_Name_displayName)]
            public virtual int Series_Name {
                get => Series_Name_raw;
                set {
                    if (Series_Name_raw == value) return;
                    Series_Name_raw = value;
                    ChangedItems.Add(nameof(Series_Name));
                    OnPropertyChanged(nameof(Series_Name));
                }
            }

            protected uint Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual uint Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    ChangedItems.Add(nameof(Unk4));
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected int Weapon_ID_raw;
            public const string Weapon_ID_displayName = "Weapon ID";
            public const int Weapon_ID_sortIndex = 250;
            [SortOrder(Weapon_ID_sortIndex)]
            [DisplayName(Weapon_ID_displayName)]
            public virtual int Weapon_ID {
                get => Weapon_ID_raw;
                set {
                    if (Weapon_ID_raw == value) return;
                    Weapon_ID_raw = value;
                    ChangedItems.Add(nameof(Weapon_ID));
                    OnPropertyChanged(nameof(Weapon_ID));
                }
            }

            protected int Parts_Base_raw;
            public const string Parts_Base_displayName = "Parts Base";
            public const int Parts_Base_sortIndex = 300;
            [SortOrder(Parts_Base_sortIndex)]
            [DisplayName(Parts_Base_displayName)]
            public virtual int Parts_Base {
                get => Parts_Base_raw;
                set {
                    if (Parts_Base_raw == value) return;
                    Parts_Base_raw = value;
                    ChangedItems.Add(nameof(Parts_Base));
                    OnPropertyChanged(nameof(Parts_Base));
                }
            }

            protected int Parts_Decoration_raw;
            public const string Parts_Decoration_displayName = "Parts Decoration";
            public const int Parts_Decoration_sortIndex = 350;
            [SortOrder(Parts_Decoration_sortIndex)]
            [DisplayName(Parts_Decoration_displayName)]
            public virtual int Parts_Decoration {
                get => Parts_Decoration_raw;
                set {
                    if (Parts_Decoration_raw == value) return;
                    Parts_Decoration_raw = value;
                    ChangedItems.Add(nameof(Parts_Decoration));
                    OnPropertyChanged(nameof(Parts_Decoration));
                }
            }

            protected int Unique_Model_raw;
            public const string Unique_Model_displayName = "Unique Model";
            public const int Unique_Model_sortIndex = 400;
            [SortOrder(Unique_Model_sortIndex)]
            [DisplayName(Unique_Model_displayName)]
            public virtual int Unique_Model {
                get => Unique_Model_raw;
                set {
                    if (Unique_Model_raw == value) return;
                    Unique_Model_raw = value;
                    ChangedItems.Add(nameof(Unique_Model));
                    OnPropertyChanged(nameof(Unique_Model));
                }
            }

            protected short Bowgun_Data_Flag_raw;
            public const string Bowgun_Data_Flag_displayName = "Bowgun Data Flag";
            public const int Bowgun_Data_Flag_sortIndex = 450;
            [SortOrder(Bowgun_Data_Flag_sortIndex)]
            [DisplayName(Bowgun_Data_Flag_displayName)]
            public virtual short Bowgun_Data_Flag {
                get => Bowgun_Data_Flag_raw;
                set {
                    if (Bowgun_Data_Flag_raw == value) return;
                    Bowgun_Data_Flag_raw = value;
                    ChangedItems.Add(nameof(Bowgun_Data_Flag));
                    OnPropertyChanged(nameof(Bowgun_Data_Flag));
                }
            }

            protected uint Unk11_raw;
            public const string Unk11_displayName = "Unk11";
            public const int Unk11_sortIndex = 500;
            [SortOrder(Unk11_sortIndex)]
            [DisplayName(Unk11_displayName)]
            public virtual uint Unk11 {
                get => Unk11_raw;
                set {
                    if (Unk11_raw == value) return;
                    Unk11_raw = value;
                    ChangedItems.Add(nameof(Unk11));
                    OnPropertyChanged(nameof(Unk11));
                }
            }

            protected byte Unk12_raw;
            public const string Unk12_displayName = "Unk12";
            public const int Unk12_sortIndex = 550;
            [SortOrder(Unk12_sortIndex)]
            [DisplayName(Unk12_displayName)]
            public virtual byte Unk12 {
                get => Unk12_raw;
                set {
                    if (Unk12_raw == value) return;
                    Unk12_raw = value;
                    ChangedItems.Add(nameof(Unk12));
                    OnPropertyChanged(nameof(Unk12));
                }
            }

            public const int lastSortIndex = 600;

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
                data.Entry_Index_raw = reader.ReadUInt32();
                data.Recipe_ID_raw = reader.ReadUInt32();
                data.Series_Name_raw = reader.ReadInt32();
                data.Unk4_raw = reader.ReadUInt32();
                data.Weapon_ID_raw = reader.ReadInt32();
                data.Parts_Base_raw = reader.ReadInt32();
                data.Parts_Decoration_raw = reader.ReadInt32();
                data.Unique_Model_raw = reader.ReadInt32();
                data.Bowgun_Data_Flag_raw = reader.ReadInt16();
                data.Unk11_raw = reader.ReadUInt32();
                data.Unk12_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Entry_Index_raw);
                writer.Write(Recipe_ID_raw);
                writer.Write(Series_Name_raw);
                writer.Write(Unk4_raw);
                writer.Write(Weapon_ID_raw);
                writer.Write(Parts_Base_raw);
                writer.Write(Parts_Decoration_raw);
                writer.Write(Unique_Model_raw);
                writer.Write(Bowgun_Data_Flag_raw);
                writer.Write(Unk11_raw);
                writer.Write(Unk12_raw);
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