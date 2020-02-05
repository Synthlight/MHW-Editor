
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Ranged {
        public const uint StructSize = 69;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        protected const string Index_displayName = "Index";
        protected const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        private uint Index {
            get => GetData<uint>(0);
        }

        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 100;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public ushort Id {
            get => GetData<ushort>(59);
        }

        protected const string Base_Model_Id_displayName = "Base Model Id";
        protected const int Base_Model_Id_sortIndex = 150;
        [SortOrder(Base_Model_Id_sortIndex)]
        [DisplayName(Base_Model_Id_displayName)]
        public short Base_Model_Id {
            get => GetData<short>(6);
            set {
                if (GetData<short>(6) == value) return;
                SetData(6, value);
                OnPropertyChanged(nameof(Base_Model_Id));
            }
        }

        protected const string Part_1_Id_displayName = "Part 1 Id";
        protected const int Part_1_Id_sortIndex = 200;
        [SortOrder(Part_1_Id_sortIndex)]
        [DisplayName(Part_1_Id_displayName)]
        public short Part_1_Id {
            get => GetData<short>(8);
            set {
                if (GetData<short>(8) == value) return;
                SetData(8, value);
                OnPropertyChanged(nameof(Part_1_Id));
            }
        }

        protected const string Part_2_Id_displayName = "Part 2 Id";
        protected const int Part_2_Id_sortIndex = 250;
        [SortOrder(Part_2_Id_sortIndex)]
        [DisplayName(Part_2_Id_displayName)]
        public short Part_2_Id {
            get => GetData<short>(10);
            set {
                if (GetData<short>(10) == value) return;
                SetData(10, value);
                OnPropertyChanged(nameof(Part_2_Id));
            }
        }

        protected const string Is_Fixed_Upgrade_Raw_displayName = "Is Fixed Upgrade Raw";
        protected const int Is_Fixed_Upgrade_Raw_sortIndex = 300;
        [SortOrder(Is_Fixed_Upgrade_Raw_sortIndex)]
        [DisplayName(Is_Fixed_Upgrade_Raw_displayName)]
        protected byte Is_Fixed_Upgrade_Raw {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value);
                OnPropertyChanged(nameof(Is_Fixed_Upgrade_Raw));
            }
        }

        protected const string Muzzle_Type_displayName = "Muzzle Type";
        protected const int Muzzle_Type_sortIndex = 350;
        [SortOrder(Muzzle_Type_sortIndex)]
        [DisplayName(Muzzle_Type_displayName)]
        public MHW_Template.Weapons.MuzzleType Muzzle_Type {
            get => (MHW_Template.Weapons.MuzzleType) GetData<byte>(16);
            set {
                if ((MHW_Template.Weapons.MuzzleType) GetData<byte>(16) == value) return;
                SetData(16, (byte) value);
                OnPropertyChanged(nameof(Muzzle_Type));
            }
        }

        protected const string Barrel_Type_displayName = "Barrel Type";
        protected const int Barrel_Type_sortIndex = 400;
        [SortOrder(Barrel_Type_sortIndex)]
        [DisplayName(Barrel_Type_displayName)]
        public MHW_Template.Weapons.BarrelType Barrel_Type {
            get => (MHW_Template.Weapons.BarrelType) GetData<byte>(17);
            set {
                if ((MHW_Template.Weapons.BarrelType) GetData<byte>(17) == value) return;
                SetData(17, (byte) value);
                OnPropertyChanged(nameof(Barrel_Type));
            }
        }

        protected const string Magazine_Type_displayName = "Magazine Type";
        protected const int Magazine_Type_sortIndex = 450;
        [SortOrder(Magazine_Type_sortIndex)]
        [DisplayName(Magazine_Type_displayName)]
        public MHW_Template.Weapons.MagazineType Magazine_Type {
            get => (MHW_Template.Weapons.MagazineType) GetData<byte>(18);
            set {
                if ((MHW_Template.Weapons.MagazineType) GetData<byte>(18) == value) return;
                SetData(18, (byte) value);
                OnPropertyChanged(nameof(Magazine_Type));
            }
        }

        protected const string Scope_Type_displayName = "Scope Type";
        protected const int Scope_Type_sortIndex = 500;
        [SortOrder(Scope_Type_sortIndex)]
        [DisplayName(Scope_Type_displayName)]
        public MHW_Template.Weapons.ScopeType Scope_Type {
            get => (MHW_Template.Weapons.ScopeType) GetData<byte>(19);
            set {
                if ((MHW_Template.Weapons.ScopeType) GetData<byte>(19) == value) return;
                SetData(19, (byte) value);
                OnPropertyChanged(nameof(Scope_Type));
            }
        }

        protected const string Cost_displayName = "Cost";
        protected const int Cost_sortIndex = 550;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public uint Cost {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value);
                OnPropertyChanged(nameof(Cost));
            }
        }

        protected const string Rarity_displayName = "Rarity";
        protected const int Rarity_sortIndex = 600;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public byte Rarity {
            get => GetData<byte>(24);
            set {
                if (GetData<byte>(24) == value) return;
                SetData(24, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }

        protected const string Damage_displayName = "Damage";
        protected const int Damage_sortIndex = 650;
        [SortOrder(Damage_sortIndex)]
        [DisplayName(Damage_displayName)]
        public ushort Damage {
            get => GetData<ushort>(25);
            set {
                if (GetData<ushort>(25) == value) return;
                SetData(25, value);
                OnPropertyChanged(nameof(Damage));
            }
        }

        protected const string Defense_displayName = "Defense";
        protected const int Defense_sortIndex = 700;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public ushort Defense {
            get => GetData<ushort>(27);
            set {
                if (GetData<ushort>(27) == value) return;
                SetData(27, value);
                OnPropertyChanged(nameof(Defense));
            }
        }

        protected const string Affinity_displayName = "Affinity";
        protected const int Affinity_sortIndex = 750;
        [SortOrder(Affinity_sortIndex)]
        [DisplayName(Affinity_displayName)]
        public sbyte Affinity {
            get => GetData<sbyte>(29);
            set {
                if (GetData<sbyte>(29) == value.Clamp((sbyte) -100, (sbyte) 100)) return;
                SetData(29, value.Clamp((sbyte) -100, (sbyte) 100));
                OnPropertyChanged(nameof(Affinity));
            }
        }

        protected const string Element_displayName = "Element";
        protected const int Element_sortIndex = 800;
        [SortOrder(Element_sortIndex)]
        [DisplayName(Element_displayName)]
        public MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(30);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(30) == value) return;
                SetData(30, (byte) value);
                OnPropertyChanged(nameof(Element));
            }
        }

        protected const string Element_Damage_displayName = "Element Damage";
        protected const int Element_Damage_sortIndex = 850;
        [SortOrder(Element_Damage_sortIndex)]
        [DisplayName(Element_Damage_displayName)]
        public ushort Element_Damage {
            get => GetData<ushort>(31);
            set {
                if (GetData<ushort>(31) == value) return;
                SetData(31, value);
                OnPropertyChanged(nameof(Element_Damage));
            }
        }

        protected const string Element_Hidden__displayName = "Element (Hidden)";
        protected const int Element_Hidden__sortIndex = 900;
        [SortOrder(Element_Hidden__sortIndex)]
        [DisplayName(Element_Hidden__displayName)]
        public MHW_Template.Weapons.Element Element_Hidden_ {
            get => (MHW_Template.Weapons.Element) GetData<byte>(33);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(33) == value) return;
                SetData(33, (byte) value);
                OnPropertyChanged(nameof(Element_Hidden_));
            }
        }

        protected const string Element_Hidden_Damage_displayName = "Element (Hidden) Damage";
        protected const int Element_Hidden_Damage_sortIndex = 950;
        [SortOrder(Element_Hidden_Damage_sortIndex)]
        [DisplayName(Element_Hidden_Damage_displayName)]
        public ushort Element_Hidden_Damage {
            get => GetData<ushort>(34);
            set {
                if (GetData<ushort>(34) == value) return;
                SetData(34, value);
                OnPropertyChanged(nameof(Element_Hidden_Damage));
            }
        }

        protected const string Elderseal_displayName = "Elderseal";
        protected const int Elderseal_sortIndex = 1000;
        [SortOrder(Elderseal_sortIndex)]
        [DisplayName(Elderseal_displayName)]
        public MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(36);
            set {
                if ((MHW_Template.Weapons.Elderseal) GetData<byte>(36) == value) return;
                SetData(36, (byte) value);
                OnPropertyChanged(nameof(Elderseal));
            }
        }

        protected const string Shell_Type_Id_displayName = "Shell Type Id";
        protected const int Shell_Type_Id_sortIndex = 1050;
        [SortOrder(Shell_Type_Id_sortIndex)]
        [DisplayName(Shell_Type_Id_displayName)]
        public byte Shell_Type_Id {
            get => GetData<byte>(37);
            set {
                if (GetData<byte>(37) == value) return;
                SetData(37, value);
                OnPropertyChanged(nameof(Shell_Type_Id));
            }
        }

        protected const string Deviation_displayName = "Deviation";
        protected const int Deviation_sortIndex = 1100;
        [SortOrder(Deviation_sortIndex)]
        [DisplayName(Deviation_displayName)]
        public MHW_Template.Weapons.Deviation Deviation {
            get => (MHW_Template.Weapons.Deviation) GetData<byte>(39);
            set {
                if ((MHW_Template.Weapons.Deviation) GetData<byte>(39) == value) return;
                SetData(39, (byte) value);
                OnPropertyChanged(nameof(Deviation));
            }
        }

        protected const string Slot_Count_displayName = "Slot Count";
        protected const int Slot_Count_sortIndex = 1150;
        [SortOrder(Slot_Count_sortIndex)]
        [DisplayName(Slot_Count_displayName)]
        public byte Slot_Count {
            get => GetData<byte>(40);
            set {
                if (GetData<byte>(40) == value) return;
                SetData(40, value);
                OnPropertyChanged(nameof(Slot_Count));
            }
        }

        protected const string Slot_1_Size_displayName = "Slot 1 Size";
        protected const int Slot_1_Size_sortIndex = 1200;
        [SortOrder(Slot_1_Size_sortIndex)]
        [DisplayName(Slot_1_Size_displayName)]
        public byte Slot_1_Size {
            get => GetData<byte>(41);
            set {
                if (GetData<byte>(41) == value) return;
                SetData(41, value);
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }

        protected const string Slot_2_Size_displayName = "Slot 2 Size";
        protected const int Slot_2_Size_sortIndex = 1250;
        [SortOrder(Slot_2_Size_sortIndex)]
        [DisplayName(Slot_2_Size_displayName)]
        public byte Slot_2_Size {
            get => GetData<byte>(42);
            set {
                if (GetData<byte>(42) == value) return;
                SetData(42, value);
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }

        protected const string Slot_3_Size_displayName = "Slot 3 Size";
        protected const int Slot_3_Size_sortIndex = 1300;
        [SortOrder(Slot_3_Size_sortIndex)]
        [DisplayName(Slot_3_Size_displayName)]
        public byte Slot_3_Size {
            get => GetData<byte>(43);
            set {
                if (GetData<byte>(43) == value) return;
                SetData(43, value);
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }

        protected const string Special_Ammo_Type_displayName = "Special Ammo Type";
        protected const int Special_Ammo_Type_sortIndex = 1350;
        [SortOrder(Special_Ammo_Type_sortIndex)]
        [DisplayName(Special_Ammo_Type_displayName)]
        public byte Special_Ammo_Type {
            get => GetData<byte>(57);
            set {
                if (GetData<byte>(57) == value) return;
                SetData(57, value);
                OnPropertyChanged(nameof(Special_Ammo_Type));
            }
        }

        protected const string Skill_displayName = "Skill";
        protected const int Skill_sortIndex = 1400;
        [SortOrder(Skill_sortIndex)]
        [DisplayName(Skill_displayName)]
        [DataSource(DataSourceType.Skills)]
        public ushort Skill {
            get => GetData<ushort>(65);
            set {
                if (GetData<ushort>(65) == value) return;
                SetData(65, value);
                OnPropertyChanged(nameof(Skill));
            }
        }

        protected const string GMD_Name_Index_displayName = "GMD Name Index";
        protected const int GMD_Name_Index_sortIndex = 1450;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(61);
            set {
                if (GetData<ushort>(61) == value) return;
                SetData(61, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }
    }
}