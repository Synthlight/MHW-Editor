using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Ranged {
        public override string EncryptionKey => null;

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
            public override string UniqueId => "{Id}";

            protected uint Index_raw;
            public const string Index_displayName = "Index";
            public const int Index_sortIndex = 50;
            [SortOrder(Index_sortIndex)]
            [DisplayName(Index_displayName)]
            [IsReadOnly]
            public override ulong Index {
                get => (ulong) Index_raw;
                set {
                    if ((ulong) Index_raw == value) return;
                    Index_raw = (uint) value;
                    OnPropertyChanged(nameof(Index));
                }
            }

            protected short Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 100;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual short Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected short Base_Model_Id_raw;
            public const string Base_Model_Id_displayName = "Base Model Id";
            public const int Base_Model_Id_sortIndex = 150;
            [SortOrder(Base_Model_Id_sortIndex)]
            [DisplayName(Base_Model_Id_displayName)]
            public virtual short Base_Model_Id {
                get => Base_Model_Id_raw;
                set {
                    if (Base_Model_Id_raw == value) return;
                    Base_Model_Id_raw = value;
                    OnPropertyChanged(nameof(Base_Model_Id));
                }
            }

            protected short Part_1_Id_raw;
            public const string Part_1_Id_displayName = "Part 1 Id";
            public const int Part_1_Id_sortIndex = 200;
            [SortOrder(Part_1_Id_sortIndex)]
            [DisplayName(Part_1_Id_displayName)]
            public virtual short Part_1_Id {
                get => Part_1_Id_raw;
                set {
                    if (Part_1_Id_raw == value) return;
                    Part_1_Id_raw = value;
                    OnPropertyChanged(nameof(Part_1_Id));
                }
            }

            protected short Part_2_Id_raw;
            public const string Part_2_Id_displayName = "Part 2 Id";
            public const int Part_2_Id_sortIndex = 250;
            [SortOrder(Part_2_Id_sortIndex)]
            [DisplayName(Part_2_Id_displayName)]
            public virtual short Part_2_Id {
                get => Part_2_Id_raw;
                set {
                    if (Part_2_Id_raw == value) return;
                    Part_2_Id_raw = value;
                    OnPropertyChanged(nameof(Part_2_Id));
                }
            }

            protected byte Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 300;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual byte Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected byte Color_raw;
            public const string Color_displayName = "Color";
            public const int Color_sortIndex = 350;
            [SortOrder(Color_sortIndex)]
            [DisplayName(Color_displayName)]
            public virtual byte Color {
                get => Color_raw;
                set {
                    if (Color_raw == value) return;
                    Color_raw = value;
                    OnPropertyChanged(nameof(Color));
                }
            }

            protected byte Tree_Id_raw;
            public const string Tree_Id_displayName = "Tree Id";
            [SortOrder(Tree_Id_sortIndex)]
            [DisplayName(Tree_Id_displayName)]
            public virtual byte Tree_Id {
                get => Tree_Id_raw;
                set {
                    if (Tree_Id_raw == value) return;
                    Tree_Id_raw = value;
                    OnPropertyChanged(nameof(Tree_Id));
                }
            }

            protected byte Is_Fixed_Upgrade_raw;
            public const string Is_Fixed_Upgrade_displayName = "Is Fixed Upgrade";
            public const int Is_Fixed_Upgrade_sortIndex = 450;
            [SortOrder(Is_Fixed_Upgrade_sortIndex)]
            [DisplayName(Is_Fixed_Upgrade_displayName)]
            public virtual bool Is_Fixed_Upgrade {
                get => (bool) Convert.ToBoolean(Is_Fixed_Upgrade_raw);
                set {
                    if (Convert.ToBoolean(Is_Fixed_Upgrade_raw) == value) return;
                    Is_Fixed_Upgrade_raw = Convert.ToByte(value);
                    OnPropertyChanged(nameof(Is_Fixed_Upgrade));
                }
            }

            protected byte Muzzle_Type_raw;
            public const string Muzzle_Type_displayName = "Muzzle Type";
            public const int Muzzle_Type_sortIndex = 500;
            [SortOrder(Muzzle_Type_sortIndex)]
            [DisplayName(Muzzle_Type_displayName)]
            public virtual MHW_Template.Weapons.MuzzleType Muzzle_Type {
                get => (MHW_Template.Weapons.MuzzleType) Muzzle_Type_raw;
                set {
                    if ((MHW_Template.Weapons.MuzzleType) Muzzle_Type_raw == value) return;
                    Muzzle_Type_raw = (byte) value;
                    OnPropertyChanged(nameof(Muzzle_Type));
                }
            }

            protected byte Barrel_Type_raw;
            public const string Barrel_Type_displayName = "Barrel Type";
            public const int Barrel_Type_sortIndex = 550;
            [SortOrder(Barrel_Type_sortIndex)]
            [DisplayName(Barrel_Type_displayName)]
            public virtual MHW_Template.Weapons.BarrelType Barrel_Type {
                get => (MHW_Template.Weapons.BarrelType) Barrel_Type_raw;
                set {
                    if ((MHW_Template.Weapons.BarrelType) Barrel_Type_raw == value) return;
                    Barrel_Type_raw = (byte) value;
                    OnPropertyChanged(nameof(Barrel_Type));
                }
            }

            protected byte Magazine_Type_raw;
            public const string Magazine_Type_displayName = "Magazine Type";
            public const int Magazine_Type_sortIndex = 600;
            [SortOrder(Magazine_Type_sortIndex)]
            [DisplayName(Magazine_Type_displayName)]
            public virtual MHW_Template.Weapons.MagazineType Magazine_Type {
                get => (MHW_Template.Weapons.MagazineType) Magazine_Type_raw;
                set {
                    if ((MHW_Template.Weapons.MagazineType) Magazine_Type_raw == value) return;
                    Magazine_Type_raw = (byte) value;
                    OnPropertyChanged(nameof(Magazine_Type));
                }
            }

            protected byte Scope_Type_raw;
            public const string Scope_Type_displayName = "Scope Type";
            public const int Scope_Type_sortIndex = 650;
            [SortOrder(Scope_Type_sortIndex)]
            [DisplayName(Scope_Type_displayName)]
            public virtual MHW_Template.Weapons.ScopeType Scope_Type {
                get => (MHW_Template.Weapons.ScopeType) Scope_Type_raw;
                set {
                    if ((MHW_Template.Weapons.ScopeType) Scope_Type_raw == value) return;
                    Scope_Type_raw = (byte) value;
                    OnPropertyChanged(nameof(Scope_Type));
                }
            }

            protected uint Cost_raw;
            public const string Cost_displayName = "Cost";
            public const int Cost_sortIndex = 700;
            [SortOrder(Cost_sortIndex)]
            [DisplayName(Cost_displayName)]
            public virtual uint Cost {
                get => Cost_raw;
                set {
                    if (Cost_raw == value) return;
                    Cost_raw = value;
                    OnPropertyChanged(nameof(Cost));
                }
            }

            protected byte Rarity_raw;
            public const string Rarity_displayName = "Rarity";
            public const int Rarity_sortIndex = 750;
            [SortOrder(Rarity_sortIndex)]
            [DisplayName(Rarity_displayName)]
            public virtual byte Rarity {
                get => Rarity_raw;
                set {
                    if (Rarity_raw == value) return;
                    Rarity_raw = value;
                    OnPropertyChanged(nameof(Rarity));
                }
            }

            protected ushort Damage_raw;
            public const string Damage_displayName = "Damage";
            public const int Damage_sortIndex = 800;
            [SortOrder(Damage_sortIndex)]
            [DisplayName(Damage_displayName)]
            public virtual ushort Damage {
                get => Damage_raw;
                set {
                    if (Damage_raw == value) return;
                    Damage_raw = value;
                    OnPropertyChanged(nameof(Damage));
                }
            }

            protected ushort Defense_raw;
            public const string Defense_displayName = "Defense";
            public const int Defense_sortIndex = 850;
            [SortOrder(Defense_sortIndex)]
            [DisplayName(Defense_displayName)]
            public virtual ushort Defense {
                get => Defense_raw;
                set {
                    if (Defense_raw == value) return;
                    Defense_raw = value;
                    OnPropertyChanged(nameof(Defense));
                }
            }

            protected sbyte Affinity_raw;
            public const string Affinity_displayName = "Affinity";
            public const int Affinity_sortIndex = 900;
            [SortOrder(Affinity_sortIndex)]
            [DisplayName(Affinity_displayName)]
            public virtual sbyte Affinity {
                get => Affinity_raw;
                set {
                    if (Affinity_raw == value.Clamp((sbyte) -100, (sbyte) 100)) return;
                    Affinity_raw = value.Clamp((sbyte) -100, (sbyte) 100);
                    OnPropertyChanged(nameof(Affinity));
                }
            }

            protected byte Element_raw;
            public const string Element_displayName = "Element";
            public const int Element_sortIndex = 950;
            [SortOrder(Element_sortIndex)]
            [DisplayName(Element_displayName)]
            public virtual MHW_Template.Weapons.Element Element {
                get => (MHW_Template.Weapons.Element) Element_raw;
                set {
                    if ((MHW_Template.Weapons.Element) Element_raw == value) return;
                    Element_raw = (byte) value;
                    OnPropertyChanged(nameof(Element));
                }
            }

            protected ushort Element_Damage_raw;
            public const string Element_Damage_displayName = "Element Damage";
            public const int Element_Damage_sortIndex = 1000;
            [SortOrder(Element_Damage_sortIndex)]
            [DisplayName(Element_Damage_displayName)]
            public virtual ushort Element_Damage {
                get => Element_Damage_raw;
                set {
                    if (Element_Damage_raw == value) return;
                    Element_Damage_raw = value;
                    OnPropertyChanged(nameof(Element_Damage));
                }
            }

            protected byte Element_Hidden__raw;
            public const string Element_Hidden__displayName = "Element (Hidden)";
            public const int Element_Hidden__sortIndex = 1050;
            [SortOrder(Element_Hidden__sortIndex)]
            [DisplayName(Element_Hidden__displayName)]
            public virtual MHW_Template.Weapons.Element Element_Hidden_ {
                get => (MHW_Template.Weapons.Element) Element_Hidden__raw;
                set {
                    if ((MHW_Template.Weapons.Element) Element_Hidden__raw == value) return;
                    Element_Hidden__raw = (byte) value;
                    OnPropertyChanged(nameof(Element_Hidden_));
                }
            }

            protected ushort Element_Hidden_Damage_raw;
            public const string Element_Hidden_Damage_displayName = "Element (Hidden) Damage";
            public const int Element_Hidden_Damage_sortIndex = 1100;
            [SortOrder(Element_Hidden_Damage_sortIndex)]
            [DisplayName(Element_Hidden_Damage_displayName)]
            public virtual ushort Element_Hidden_Damage {
                get => Element_Hidden_Damage_raw;
                set {
                    if (Element_Hidden_Damage_raw == value) return;
                    Element_Hidden_Damage_raw = value;
                    OnPropertyChanged(nameof(Element_Hidden_Damage));
                }
            }

            protected byte Elderseal_raw;
            public const string Elderseal_displayName = "Elderseal";
            public const int Elderseal_sortIndex = 1150;
            [SortOrder(Elderseal_sortIndex)]
            [DisplayName(Elderseal_displayName)]
            public virtual MHW_Template.Weapons.Elderseal Elderseal {
                get => (MHW_Template.Weapons.Elderseal) Elderseal_raw;
                set {
                    if ((MHW_Template.Weapons.Elderseal) Elderseal_raw == value) return;
                    Elderseal_raw = (byte) value;
                    OnPropertyChanged(nameof(Elderseal));
                }
            }

            protected byte Shell_Type_Id_raw;
            public const string Shell_Type_Id_displayName = "Shell Type Id";
            public const int Shell_Type_Id_sortIndex = 1200;
            [SortOrder(Shell_Type_Id_sortIndex)]
            [DisplayName(Shell_Type_Id_displayName)]
            public virtual byte Shell_Type_Id {
                get => Shell_Type_Id_raw;
                set {
                    if (Shell_Type_Id_raw == value) return;
                    Shell_Type_Id_raw = value;
                    OnPropertyChanged(nameof(Shell_Type_Id));
                }
            }

            protected byte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 1250;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual byte Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected byte Deviation_raw;
            public const string Deviation_displayName = "Deviation";
            public const int Deviation_sortIndex = 1300;
            [SortOrder(Deviation_sortIndex)]
            [DisplayName(Deviation_displayName)]
            public virtual MHW_Template.Weapons.Deviation Deviation {
                get => (MHW_Template.Weapons.Deviation) Deviation_raw;
                set {
                    if ((MHW_Template.Weapons.Deviation) Deviation_raw == value) return;
                    Deviation_raw = (byte) value;
                    OnPropertyChanged(nameof(Deviation));
                }
            }

            protected byte Slot_Count_raw;
            public const string Slot_Count_displayName = "Slot Count";
            public const int Slot_Count_sortIndex = 1350;
            [SortOrder(Slot_Count_sortIndex)]
            [DisplayName(Slot_Count_displayName)]
            public virtual byte Slot_Count {
                get => Slot_Count_raw;
                set {
                    if (Slot_Count_raw == value) return;
                    Slot_Count_raw = value;
                    OnPropertyChanged(nameof(Slot_Count));
                }
            }

            protected byte Slot_1_Size_raw;
            public const string Slot_1_Size_displayName = "Slot 1 Size";
            public const int Slot_1_Size_sortIndex = 1400;
            [SortOrder(Slot_1_Size_sortIndex)]
            [DisplayName(Slot_1_Size_displayName)]
            public virtual byte Slot_1_Size {
                get => Slot_1_Size_raw;
                set {
                    if (Slot_1_Size_raw == value) return;
                    Slot_1_Size_raw = value;
                    OnPropertyChanged(nameof(Slot_1_Size));
                }
            }

            protected byte Slot_2_Size_raw;
            public const string Slot_2_Size_displayName = "Slot 2 Size";
            public const int Slot_2_Size_sortIndex = 1450;
            [SortOrder(Slot_2_Size_sortIndex)]
            [DisplayName(Slot_2_Size_displayName)]
            public virtual byte Slot_2_Size {
                get => Slot_2_Size_raw;
                set {
                    if (Slot_2_Size_raw == value) return;
                    Slot_2_Size_raw = value;
                    OnPropertyChanged(nameof(Slot_2_Size));
                }
            }

            protected byte Slot_3_Size_raw;
            public const string Slot_3_Size_displayName = "Slot 3 Size";
            public const int Slot_3_Size_sortIndex = 1500;
            [SortOrder(Slot_3_Size_sortIndex)]
            [DisplayName(Slot_3_Size_displayName)]
            public virtual byte Slot_3_Size {
                get => Slot_3_Size_raw;
                set {
                    if (Slot_3_Size_raw == value) return;
                    Slot_3_Size_raw = value;
                    OnPropertyChanged(nameof(Slot_3_Size));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 1550;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 1600;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected uint Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 1650;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual uint Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            protected byte Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 1700;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual byte Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            protected byte Special_Ammo_Type_raw;
            public const string Special_Ammo_Type_displayName = "Special Ammo Type";
            public const int Special_Ammo_Type_sortIndex = 1750;
            [SortOrder(Special_Ammo_Type_sortIndex)]
            [DisplayName(Special_Ammo_Type_displayName)]
            public virtual byte Special_Ammo_Type {
                get => Special_Ammo_Type_raw;
                set {
                    if (Special_Ammo_Type_raw == value) return;
                    Special_Ammo_Type_raw = value;
                    OnPropertyChanged(nameof(Special_Ammo_Type));
                }
            }

            protected byte Tree_Position_raw;
            public const string Tree_Position_displayName = "Tree Position";
            public const int Tree_Position_sortIndex = 1800;
            [SortOrder(Tree_Position_sortIndex)]
            [DisplayName(Tree_Position_displayName)]
            public virtual byte Tree_Position {
                get => Tree_Position_raw;
                set {
                    if (Tree_Position_raw == value) return;
                    Tree_Position_raw = value;
                    OnPropertyChanged(nameof(Tree_Position));
                }
            }

            protected ushort Id_raw;
            public const string Id_displayName = "Id";
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual ushort Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected ushort GMD_Name_Index_raw;
            public const string GMD_Name_Index_displayName = "GMD Name Index";
            public const int GMD_Name_Index_sortIndex = 1900;
            [SortOrder(GMD_Name_Index_sortIndex)]
            [DisplayName(GMD_Name_Index_displayName)]
            [IsReadOnly]
            public virtual ushort GMD_Name_Index {
                get => GMD_Name_Index_raw;
                set {
                    if (GMD_Name_Index_raw == value) return;
                    GMD_Name_Index_raw = value;
                    OnPropertyChanged(nameof(GMD_Name_Index));
                }
            }

            protected ushort GMD_Description_Index_raw;
            public const string GMD_Description_Index_displayName = "GMD Description Index";
            public const int GMD_Description_Index_sortIndex = 1950;
            [SortOrder(GMD_Description_Index_sortIndex)]
            [DisplayName(GMD_Description_Index_displayName)]
            [IsReadOnly]
            public virtual ushort GMD_Description_Index {
                get => GMD_Description_Index_raw;
                set {
                    if (GMD_Description_Index_raw == value) return;
                    GMD_Description_Index_raw = value;
                    OnPropertyChanged(nameof(GMD_Description_Index));
                }
            }

            protected ushort Skill_raw;
            public const string Skill_displayName = "Skill";
            public const int Skill_sortIndex = 2000;
            [SortOrder(Skill_sortIndex)]
            [DisplayName(Skill_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual ushort Skill {
                get => Skill_raw;
                set {
                    if (Skill_raw == value) return;
                    Skill_raw = value;
                    OnPropertyChanged(nameof(Skill));
                    OnPropertyChanged(nameof(Skill_button));
                }
            }

            [SortOrder(Skill_sortIndex)]
            [DisplayName(Skill_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Skill_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill).ToStringWithId(Skill);

            protected ushort Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 2050;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual ushort Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            public const int lastSortIndex = 2100;

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
                data.Index_raw = reader.ReadUInt32();
                data.Unk_1_raw = reader.ReadInt16();
                data.Base_Model_Id_raw = reader.ReadInt16();
                data.Part_1_Id_raw = reader.ReadInt16();
                data.Part_2_Id_raw = reader.ReadInt16();
                data.Unk_2_raw = reader.ReadByte();
                data.Color_raw = reader.ReadByte();
                data.Tree_Id_raw = reader.ReadByte();
                data.Is_Fixed_Upgrade_raw = reader.ReadByte();
                data.Muzzle_Type_raw = reader.ReadByte();
                data.Barrel_Type_raw = reader.ReadByte();
                data.Magazine_Type_raw = reader.ReadByte();
                data.Scope_Type_raw = reader.ReadByte();
                data.Cost_raw = reader.ReadUInt32();
                data.Rarity_raw = reader.ReadByte();
                data.Damage_raw = reader.ReadUInt16();
                data.Defense_raw = reader.ReadUInt16();
                data.Affinity_raw = reader.ReadSByte();
                data.Element_raw = reader.ReadByte();
                data.Element_Damage_raw = reader.ReadUInt16();
                data.Element_Hidden__raw = reader.ReadByte();
                data.Element_Hidden_Damage_raw = reader.ReadUInt16();
                data.Elderseal_raw = reader.ReadByte();
                data.Shell_Type_Id_raw = reader.ReadByte();
                data.Unk_3_raw = reader.ReadByte();
                data.Deviation_raw = reader.ReadByte();
                data.Slot_Count_raw = reader.ReadByte();
                data.Slot_1_Size_raw = reader.ReadByte();
                data.Slot_2_Size_raw = reader.ReadByte();
                data.Slot_3_Size_raw = reader.ReadByte();
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_7_raw = reader.ReadUInt32();
                data.Unk_8_raw = reader.ReadByte();
                data.Special_Ammo_Type_raw = reader.ReadByte();
                data.Tree_Position_raw = reader.ReadByte();
                data.Id_raw = reader.ReadUInt16();
                data.GMD_Name_Index_raw = reader.ReadUInt16();
                data.GMD_Description_Index_raw = reader.ReadUInt16();
                data.Skill_raw = reader.ReadUInt16();
                data.Unk_6_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Base_Model_Id_raw);
                writer.Write(Part_1_Id_raw);
                writer.Write(Part_2_Id_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Color_raw);
                writer.Write(Tree_Id_raw);
                writer.Write(Is_Fixed_Upgrade_raw);
                writer.Write(Muzzle_Type_raw);
                writer.Write(Barrel_Type_raw);
                writer.Write(Magazine_Type_raw);
                writer.Write(Scope_Type_raw);
                writer.Write(Cost_raw);
                writer.Write(Rarity_raw);
                writer.Write(Damage_raw);
                writer.Write(Defense_raw);
                writer.Write(Affinity_raw);
                writer.Write(Element_raw);
                writer.Write(Element_Damage_raw);
                writer.Write(Element_Hidden__raw);
                writer.Write(Element_Hidden_Damage_raw);
                writer.Write(Elderseal_raw);
                writer.Write(Shell_Type_Id_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Deviation_raw);
                writer.Write(Slot_Count_raw);
                writer.Write(Slot_1_Size_raw);
                writer.Write(Slot_2_Size_raw);
                writer.Write(Slot_3_Size_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Special_Ammo_Type_raw);
                writer.Write(Tree_Position_raw);
                writer.Write(Id_raw);
                writer.Write(GMD_Name_Index_raw);
                writer.Write(GMD_Description_Index_raw);
                writer.Write(Skill_raw);
                writer.Write(Unk_6_raw);
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