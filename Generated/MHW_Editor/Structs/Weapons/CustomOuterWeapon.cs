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
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Unused_raw;
            public const string Unused_displayName = "Unused";
            public const int Unused_sortIndex = 50;
            [SortOrder(Unused_sortIndex)]
            [DisplayName(Unused_displayName)]
            public virtual uint Unused {
                get => Unused_raw;
                set {
                    if (Unused_raw == value) return;
                    Unused_raw = value;
                    ChangedItems.Add(nameof(Unused));
                    OnPropertyChanged(nameof(Unused));
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

            protected int Sort_Order_raw;
            public const string Sort_Order_displayName = "Sort Order";
            public const int Sort_Order_sortIndex = 150;
            [SortOrder(Sort_Order_sortIndex)]
            [DisplayName(Sort_Order_displayName)]
            public virtual int Sort_Order {
                get => Sort_Order_raw;
                set {
                    if (Sort_Order_raw == value) return;
                    Sort_Order_raw = value;
                    ChangedItems.Add(nameof(Sort_Order));
                    OnPropertyChanged(nameof(Sort_Order));
                }
            }

            protected uint Weapon_Id_raw;
            public const string Weapon_Id_displayName = "Weapon Id";
            public const int Weapon_Id_sortIndex = 200;
            [SortOrder(Weapon_Id_sortIndex)]
            [DisplayName(Weapon_Id_displayName)]
            [DataSource(DataSourceType.WeaponsById)]
            public virtual uint Weapon_Id {
                get => Weapon_Id_raw;
                set {
                    if (Weapon_Id_raw == value) return;
                    Weapon_Id_raw = value;
                    ChangedItems.Add(nameof(Weapon_Id));
                    OnPropertyChanged(nameof(Weapon_Id));
                    OnPropertyChanged(nameof(Weapon_Id_button));
                }
            }

            [SortOrder(Weapon_Id_sortIndex)]
            [DisplayName(Weapon_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Weapon_Id_button => DataHelper.weaponIdNameLookup[GetWeaponType()][MainWindow.locale].TryGet(Weapon_Id).ToStringWithId(Weapon_Id);

            protected int Weapon_Type_raw;
            public const string Weapon_Type_displayName = "Weapon Type";
            public const int Weapon_Type_sortIndex = 250;
            [SortOrder(Weapon_Type_sortIndex)]
            [DisplayName(Weapon_Type_displayName)]
            public virtual MHW_Template.Weapons.WeaponType Weapon_Type {
                get => (MHW_Template.Weapons.WeaponType) Weapon_Type_raw;
                set {
                    if ((MHW_Template.Weapons.WeaponType) Weapon_Type_raw == value) return;
                    Weapon_Type_raw = (int) value;
                    ChangedItems.Add(nameof(Weapon_Type));
                    OnPropertyChanged(nameof(Weapon_Type));
                    OnPropertyChanged(nameof(Weapon_Id_button));
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

            protected uint Color_Id_raw;
            public const string Color_Id_displayName = "Color Id";
            public const int Color_Id_sortIndex = 500;
            [SortOrder(Color_Id_sortIndex)]
            [DisplayName(Color_Id_displayName)]
            public virtual uint Color_Id {
                get => Color_Id_raw;
                set {
                    if (Color_Id_raw == value) return;
                    Color_Id_raw = value;
                    ChangedItems.Add(nameof(Color_Id));
                    OnPropertyChanged(nameof(Color_Id));
                }
            }

            protected byte Padding_raw;
            public const string Padding_displayName = "Padding";
            public const int Padding_sortIndex = 550;
            [SortOrder(Padding_sortIndex)]
            [DisplayName(Padding_displayName)]
            public virtual byte Padding {
                get => Padding_raw;
                set {
                    if (Padding_raw == value) return;
                    Padding_raw = value;
                    ChangedItems.Add(nameof(Padding));
                    OnPropertyChanged(nameof(Padding));
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
                data.Unused_raw = reader.ReadUInt32();
                data.Recipe_ID_raw = reader.ReadUInt32();
                data.Sort_Order_raw = reader.ReadInt32();
                data.Weapon_Id_raw = reader.ReadUInt32();
                data.Weapon_Type_raw = reader.ReadInt32();
                data.Parts_Base_raw = reader.ReadInt32();
                data.Parts_Decoration_raw = reader.ReadInt32();
                data.Unique_Model_raw = reader.ReadInt32();
                data.Bowgun_Data_Flag_raw = reader.ReadInt16();
                data.Color_Id_raw = reader.ReadUInt32();
                data.Padding_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unused_raw);
                writer.Write(Recipe_ID_raw);
                writer.Write(Sort_Order_raw);
                writer.Write(Weapon_Id_raw);
                writer.Write(Weapon_Type_raw);
                writer.Write(Parts_Base_raw);
                writer.Write(Parts_Decoration_raw);
                writer.Write(Unique_Model_raw);
                writer.Write(Bowgun_Data_Flag_raw);
                writer.Write(Color_Id_raw);
                writer.Write(Padding_raw);
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