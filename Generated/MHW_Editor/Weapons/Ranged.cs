using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Ranged {
        public const uint StructSize = 69;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        [IsReadOnly]
        public virtual uint Index {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Index));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Index));
            }
        }

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 100;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        [IsReadOnly]
        public virtual ushort Id {
            get => GetData<ushort>(59);
            set {
                if (GetData<ushort>(59) == value) return;
                SetData(59, value, nameof(Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Id));
            }
        }

        public const string Base_Model_Id_displayName = "Base Model Id";
        public const int Base_Model_Id_sortIndex = 150;
        [SortOrder(Base_Model_Id_sortIndex)]
        [DisplayName(Base_Model_Id_displayName)]
        public virtual short Base_Model_Id {
            get => GetData<short>(6);
            set {
                if (GetData<short>(6) == value) return;
                SetData(6, value, nameof(Base_Model_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Base_Model_Id));
            }
        }

        public const string Part_1_Id_displayName = "Part 1 Id";
        public const int Part_1_Id_sortIndex = 200;
        [SortOrder(Part_1_Id_sortIndex)]
        [DisplayName(Part_1_Id_displayName)]
        public virtual short Part_1_Id {
            get => GetData<short>(8);
            set {
                if (GetData<short>(8) == value) return;
                SetData(8, value, nameof(Part_1_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Part_1_Id));
            }
        }

        public const string Part_2_Id_displayName = "Part 2 Id";
        public const int Part_2_Id_sortIndex = 250;
        [SortOrder(Part_2_Id_sortIndex)]
        [DisplayName(Part_2_Id_displayName)]
        public virtual short Part_2_Id {
            get => GetData<short>(10);
            set {
                if (GetData<short>(10) == value) return;
                SetData(10, value, nameof(Part_2_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Part_2_Id));
            }
        }

        public const string Color_displayName = "Color";
        public const int Color_sortIndex = 300;
        [SortOrder(Color_sortIndex)]
        [DisplayName(Color_displayName)]
        public virtual byte Color {
            get => GetData<byte>(13);
            set {
                if (GetData<byte>(13) == value) return;
                SetData(13, value, nameof(Color));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Color));
            }
        }

        public const string Is_Fixed_Upgrade_displayName = "Is Fixed Upgrade";
        public const int Is_Fixed_Upgrade_sortIndex = 350;
        [SortOrder(Is_Fixed_Upgrade_sortIndex)]
        [DisplayName(Is_Fixed_Upgrade_displayName)]
        public virtual bool Is_Fixed_Upgrade {
            get => (bool) Convert.ToBoolean(GetData<byte>(15));
            set {
                if (Convert.ToBoolean(GetData<byte>(15)) == value) return;
                SetData(15, Convert.ToByte(value), nameof(Is_Fixed_Upgrade));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Is_Fixed_Upgrade));
            }
        }

        public const string Muzzle_Type_displayName = "Muzzle Type";
        public const int Muzzle_Type_sortIndex = 400;
        [SortOrder(Muzzle_Type_sortIndex)]
        [DisplayName(Muzzle_Type_displayName)]
        public virtual MHW_Template.Weapons.MuzzleType Muzzle_Type {
            get => (MHW_Template.Weapons.MuzzleType) GetData<byte>(16);
            set {
                if ((MHW_Template.Weapons.MuzzleType) GetData<byte>(16) == value) return;
                SetData(16, (byte) value, nameof(Muzzle_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Muzzle_Type));
            }
        }

        public const string Barrel_Type_displayName = "Barrel Type";
        public const int Barrel_Type_sortIndex = 450;
        [SortOrder(Barrel_Type_sortIndex)]
        [DisplayName(Barrel_Type_displayName)]
        public virtual MHW_Template.Weapons.BarrelType Barrel_Type {
            get => (MHW_Template.Weapons.BarrelType) GetData<byte>(17);
            set {
                if ((MHW_Template.Weapons.BarrelType) GetData<byte>(17) == value) return;
                SetData(17, (byte) value, nameof(Barrel_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Barrel_Type));
            }
        }

        public const string Magazine_Type_displayName = "Magazine Type";
        public const int Magazine_Type_sortIndex = 500;
        [SortOrder(Magazine_Type_sortIndex)]
        [DisplayName(Magazine_Type_displayName)]
        public virtual MHW_Template.Weapons.MagazineType Magazine_Type {
            get => (MHW_Template.Weapons.MagazineType) GetData<byte>(18);
            set {
                if ((MHW_Template.Weapons.MagazineType) GetData<byte>(18) == value) return;
                SetData(18, (byte) value, nameof(Magazine_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Magazine_Type));
            }
        }

        public const string Scope_Type_displayName = "Scope Type";
        public const int Scope_Type_sortIndex = 550;
        [SortOrder(Scope_Type_sortIndex)]
        [DisplayName(Scope_Type_displayName)]
        public virtual MHW_Template.Weapons.ScopeType Scope_Type {
            get => (MHW_Template.Weapons.ScopeType) GetData<byte>(19);
            set {
                if ((MHW_Template.Weapons.ScopeType) GetData<byte>(19) == value) return;
                SetData(19, (byte) value, nameof(Scope_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Scope_Type));
            }
        }

        public const string Cost_displayName = "Cost";
        public const int Cost_sortIndex = 600;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public virtual uint Cost {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 650;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual byte Rarity {
            get => GetData<byte>(24);
            set {
                if (GetData<byte>(24) == value) return;
                SetData(24, value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Damage_displayName = "Damage";
        public const int Damage_sortIndex = 700;
        [SortOrder(Damage_sortIndex)]
        [DisplayName(Damage_displayName)]
        public virtual ushort Damage {
            get => GetData<ushort>(25);
            set {
                if (GetData<ushort>(25) == value) return;
                SetData(25, value, nameof(Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Damage));
            }
        }

        public const string Defense_displayName = "Defense";
        public const int Defense_sortIndex = 750;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public virtual ushort Defense {
            get => GetData<ushort>(27);
            set {
                if (GetData<ushort>(27) == value) return;
                SetData(27, value, nameof(Defense));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Defense));
            }
        }

        public const string Affinity_displayName = "Affinity";
        public const int Affinity_sortIndex = 800;
        [SortOrder(Affinity_sortIndex)]
        [DisplayName(Affinity_displayName)]
        public virtual sbyte Affinity {
            get => GetData<sbyte>(29);
            set {
                if (GetData<sbyte>(29) == value.Clamp((sbyte) -100, (sbyte) 100)) return;
                SetData(29, value.Clamp((sbyte) -100, (sbyte) 100), nameof(Affinity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity));
            }
        }

        public const string Element_displayName = "Element";
        public const int Element_sortIndex = 850;
        [SortOrder(Element_sortIndex)]
        [DisplayName(Element_displayName)]
        public virtual MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(30);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(30) == value) return;
                SetData(30, (byte) value, nameof(Element));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element));
            }
        }

        public const string Element_Damage_displayName = "Element Damage";
        public const int Element_Damage_sortIndex = 900;
        [SortOrder(Element_Damage_sortIndex)]
        [DisplayName(Element_Damage_displayName)]
        public virtual ushort Element_Damage {
            get => GetData<ushort>(31);
            set {
                if (GetData<ushort>(31) == value) return;
                SetData(31, value, nameof(Element_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_Damage));
            }
        }

        public const string Element_Hidden__displayName = "Element (Hidden)";
        public const int Element_Hidden__sortIndex = 950;
        [SortOrder(Element_Hidden__sortIndex)]
        [DisplayName(Element_Hidden__displayName)]
        public virtual MHW_Template.Weapons.Element Element_Hidden_ {
            get => (MHW_Template.Weapons.Element) GetData<byte>(33);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(33) == value) return;
                SetData(33, (byte) value, nameof(Element_Hidden_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_Hidden_));
            }
        }

        public const string Element_Hidden_Damage_displayName = "Element (Hidden) Damage";
        public const int Element_Hidden_Damage_sortIndex = 1000;
        [SortOrder(Element_Hidden_Damage_sortIndex)]
        [DisplayName(Element_Hidden_Damage_displayName)]
        public virtual ushort Element_Hidden_Damage {
            get => GetData<ushort>(34);
            set {
                if (GetData<ushort>(34) == value) return;
                SetData(34, value, nameof(Element_Hidden_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_Hidden_Damage));
            }
        }

        public const string Elderseal_displayName = "Elderseal";
        public const int Elderseal_sortIndex = 1050;
        [SortOrder(Elderseal_sortIndex)]
        [DisplayName(Elderseal_displayName)]
        public virtual MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(36);
            set {
                if ((MHW_Template.Weapons.Elderseal) GetData<byte>(36) == value) return;
                SetData(36, (byte) value, nameof(Elderseal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elderseal));
            }
        }

        public const string Shell_Type_Id_displayName = "Shell Type Id";
        public const int Shell_Type_Id_sortIndex = 1100;
        [SortOrder(Shell_Type_Id_sortIndex)]
        [DisplayName(Shell_Type_Id_displayName)]
        public virtual byte Shell_Type_Id {
            get => GetData<byte>(37);
            set {
                if (GetData<byte>(37) == value) return;
                SetData(37, value, nameof(Shell_Type_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shell_Type_Id));
            }
        }

        public const string Deviation_displayName = "Deviation";
        public const int Deviation_sortIndex = 1150;
        [SortOrder(Deviation_sortIndex)]
        [DisplayName(Deviation_displayName)]
        public virtual MHW_Template.Weapons.Deviation Deviation {
            get => (MHW_Template.Weapons.Deviation) GetData<byte>(39);
            set {
                if ((MHW_Template.Weapons.Deviation) GetData<byte>(39) == value) return;
                SetData(39, (byte) value, nameof(Deviation));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Deviation));
            }
        }

        public const string Slot_Count_displayName = "Slot Count";
        public const int Slot_Count_sortIndex = 1200;
        [SortOrder(Slot_Count_sortIndex)]
        [DisplayName(Slot_Count_displayName)]
        public virtual byte Slot_Count {
            get => GetData<byte>(40);
            set {
                if (GetData<byte>(40) == value) return;
                SetData(40, value, nameof(Slot_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_Count));
            }
        }

        public const string Slot_1_Size_displayName = "Slot 1 Size";
        public const int Slot_1_Size_sortIndex = 1250;
        [SortOrder(Slot_1_Size_sortIndex)]
        [DisplayName(Slot_1_Size_displayName)]
        public virtual byte Slot_1_Size {
            get => GetData<byte>(41);
            set {
                if (GetData<byte>(41) == value) return;
                SetData(41, value, nameof(Slot_1_Size));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }

        public const string Slot_2_Size_displayName = "Slot 2 Size";
        public const int Slot_2_Size_sortIndex = 1300;
        [SortOrder(Slot_2_Size_sortIndex)]
        [DisplayName(Slot_2_Size_displayName)]
        public virtual byte Slot_2_Size {
            get => GetData<byte>(42);
            set {
                if (GetData<byte>(42) == value) return;
                SetData(42, value, nameof(Slot_2_Size));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }

        public const string Slot_3_Size_displayName = "Slot 3 Size";
        public const int Slot_3_Size_sortIndex = 1350;
        [SortOrder(Slot_3_Size_sortIndex)]
        [DisplayName(Slot_3_Size_displayName)]
        public virtual byte Slot_3_Size {
            get => GetData<byte>(43);
            set {
                if (GetData<byte>(43) == value) return;
                SetData(43, value, nameof(Slot_3_Size));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }

        public const string Special_Ammo_Type_displayName = "Special Ammo Type";
        public const int Special_Ammo_Type_sortIndex = 1400;
        [SortOrder(Special_Ammo_Type_sortIndex)]
        [DisplayName(Special_Ammo_Type_displayName)]
        public virtual byte Special_Ammo_Type {
            get => GetData<byte>(57);
            set {
                if (GetData<byte>(57) == value) return;
                SetData(57, value, nameof(Special_Ammo_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Special_Ammo_Type));
            }
        }

        public const string Tree_Id_displayName = "Tree Id";
        public const int Tree_Id_sortIndex = 1450;
        [SortOrder(Tree_Id_sortIndex)]
        [DisplayName(Tree_Id_displayName)]
        public virtual byte Tree_Id {
            get => GetData<byte>(14);
            set {
                if (GetData<byte>(14) == value) return;
                SetData(14, value, nameof(Tree_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Tree_Id));
            }
        }

        public const string Tree_Position_displayName = "Tree Position";
        public const int Tree_Position_sortIndex = 1500;
        [SortOrder(Tree_Position_sortIndex)]
        [DisplayName(Tree_Position_displayName)]
        public virtual byte Tree_Position {
            get => GetData<byte>(58);
            set {
                if (GetData<byte>(58) == value) return;
                SetData(58, value, nameof(Tree_Position));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Tree_Position));
            }
        }

        public const string Skill_displayName = "Skill";
        public const int Skill_sortIndex = 1550;
        [SortOrder(Skill_sortIndex)]
        [DisplayName(Skill_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Skill {
            get => GetData<ushort>(65);
            set {
                if (GetData<ushort>(65) == value) return;
                SetData(65, value, nameof(Skill));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill));
                OnPropertyChanged(nameof(Skill_button));
            }
        }

        [SortOrder(Skill_sortIndex)]
        [DisplayName(Skill_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Skill_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill).ToStringWithId(Skill);

        public const string GMD_Name_Index_displayName = "GMD Name Index";
        public const int GMD_Name_Index_sortIndex = 1600;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        [IsReadOnly]
        public virtual ushort GMD_Name_Index {
            get => GetData<ushort>(61);
            set {
                if (GetData<ushort>(61) == value) return;
                SetData(61, value, nameof(GMD_Name_Index));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }

        public const string GMD_Description_Index_displayName = "GMD Description Index";
        public const int GMD_Description_Index_sortIndex = 1650;
        [SortOrder(GMD_Description_Index_sortIndex)]
        [DisplayName(GMD_Description_Index_displayName)]
        [IsReadOnly]
        public virtual ushort GMD_Description_Index {
            get => GetData<ushort>(63);
            set {
                if (GetData<ushort>(63) == value) return;
                SetData(63, value, nameof(GMD_Description_Index));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(GMD_Description_Index));
            }
        }

        public const int lastSortIndex = 1700;
    }
}