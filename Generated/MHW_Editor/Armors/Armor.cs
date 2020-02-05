
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Armors {
    public partial class Armor {
        public const uint StructSize = 60;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
        }
        protected const string Order_displayName = "Order";
        protected const int Order_sortIndex = 100;
        [SortOrder(Order_sortIndex)]
        [DisplayName(Order_displayName)]
        public ushort Order {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value);
                OnPropertyChanged(nameof(Order));
            }
        }
        protected const string Variant_displayName = "Variant";
        protected const int Variant_sortIndex = 150;
        [SortOrder(Variant_sortIndex)]
        [DisplayName(Variant_displayName)]
        public MHW_Template.Armors.Variant Variant {
            get => (MHW_Template.Armors.Variant) GetData<byte>(6);
            set {
                if ((MHW_Template.Armors.Variant) GetData<byte>(6) == value) return;
                SetData(6, (byte) value);
                OnPropertyChanged(nameof(Variant));
            }
        }
        protected const string Set_Layered_Id_displayName = "Set (Layered) Id";
        protected const int Set_Layered_Id_sortIndex = 200;
        [SortOrder(Set_Layered_Id_sortIndex)]
        [DisplayName(Set_Layered_Id_displayName)]
        public ushort Set_Layered_Id {
            get => GetData<ushort>(7);
            set {
                if (GetData<ushort>(7) == value) return;
                SetData(7, value);
                OnPropertyChanged(nameof(Set_Layered_Id));
            }
        }
        protected const string Type_displayName = "Type";
        protected const int Type_sortIndex = 250;
        [SortOrder(Type_sortIndex)]
        [DisplayName(Type_displayName)]
        public MHW_Template.Armors.ArmorType Type {
            get => (MHW_Template.Armors.ArmorType) GetData<byte>(9);
            set {
                if ((MHW_Template.Armors.ArmorType) GetData<byte>(9) == value) return;
                SetData(9, (byte) value);
                OnPropertyChanged(nameof(Type));
            }
        }
        protected const string Equip_Slot_displayName = "Equip Slot";
        protected const int Equip_Slot_sortIndex = 300;
        [SortOrder(Equip_Slot_sortIndex)]
        [DisplayName(Equip_Slot_displayName)]
        public MHW_Template.Armors.EquipSlot Equip_Slot {
            get => (MHW_Template.Armors.EquipSlot) GetData<byte>(10);
            set {
                if ((MHW_Template.Armors.EquipSlot) GetData<byte>(10) == value) return;
                SetData(10, (byte) value);
                OnPropertyChanged(nameof(Equip_Slot));
            }
        }
        protected const string Defense_displayName = "Defense";
        protected const int Defense_sortIndex = 350;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public ushort Defense {
            get => GetData<ushort>(11);
            set {
                if (GetData<ushort>(11) == value) return;
                SetData(11, value);
                OnPropertyChanged(nameof(Defense));
            }
        }
        protected const string Rarity_displayName = "Rarity";
        protected const int Rarity_sortIndex = 400;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public byte Rarity {
            get => GetData<byte>(20);
            set {
                if (GetData<byte>(20) == value) return;
                SetData(20, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }
        protected const string Cost_displayName = "Cost";
        protected const int Cost_sortIndex = 450;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public uint Cost {
            get => GetData<uint>(21);
            set {
                if (GetData<uint>(21) == value) return;
                SetData(21, value);
                OnPropertyChanged(nameof(Cost));
            }
        }
        protected const string Fire_Res_displayName = "Fire Res";
        protected const int Fire_Res_sortIndex = 500;
        [SortOrder(Fire_Res_sortIndex)]
        [DisplayName(Fire_Res_displayName)]
        public sbyte Fire_Res {
            get => GetData<sbyte>(25);
            set {
                if (GetData<sbyte>(25) == value) return;
                SetData(25, value);
                OnPropertyChanged(nameof(Fire_Res));
            }
        }
        protected const string Water_Res_displayName = "Water Res";
        protected const int Water_Res_sortIndex = 550;
        [SortOrder(Water_Res_sortIndex)]
        [DisplayName(Water_Res_displayName)]
        public sbyte Water_Res {
            get => GetData<sbyte>(26);
            set {
                if (GetData<sbyte>(26) == value) return;
                SetData(26, value);
                OnPropertyChanged(nameof(Water_Res));
            }
        }
        protected const string Ice_Res_displayName = "Ice Res";
        protected const int Ice_Res_sortIndex = 600;
        [SortOrder(Ice_Res_sortIndex)]
        [DisplayName(Ice_Res_displayName)]
        public sbyte Ice_Res {
            get => GetData<sbyte>(27);
            set {
                if (GetData<sbyte>(27) == value) return;
                SetData(27, value);
                OnPropertyChanged(nameof(Ice_Res));
            }
        }
        protected const string Thunder_Res_displayName = "Thunder Res";
        protected const int Thunder_Res_sortIndex = 650;
        [SortOrder(Thunder_Res_sortIndex)]
        [DisplayName(Thunder_Res_displayName)]
        public sbyte Thunder_Res {
            get => GetData<sbyte>(28);
            set {
                if (GetData<sbyte>(28) == value) return;
                SetData(28, value);
                OnPropertyChanged(nameof(Thunder_Res));
            }
        }
        protected const string Dragon_Res_displayName = "Dragon Res";
        protected const int Dragon_Res_sortIndex = 700;
        [SortOrder(Dragon_Res_sortIndex)]
        [DisplayName(Dragon_Res_displayName)]
        public sbyte Dragon_Res {
            get => GetData<sbyte>(29);
            set {
                if (GetData<sbyte>(29) == value) return;
                SetData(29, value);
                OnPropertyChanged(nameof(Dragon_Res));
            }
        }
        protected const string Slot_Count_displayName = "Slot Count";
        protected const int Slot_Count_sortIndex = 750;
        [SortOrder(Slot_Count_sortIndex)]
        [DisplayName(Slot_Count_displayName)]
        public byte Slot_Count {
            get => GetData<byte>(30);
            set {
                if (GetData<byte>(30) == value) return;
                SetData(30, value);
                OnPropertyChanged(nameof(Slot_Count));
            }
        }
        protected const string Slot_1_Size_displayName = "Slot 1 Size";
        protected const int Slot_1_Size_sortIndex = 800;
        [SortOrder(Slot_1_Size_sortIndex)]
        [DisplayName(Slot_1_Size_displayName)]
        public byte Slot_1_Size {
            get => GetData<byte>(31);
            set {
                if (GetData<byte>(31) == value) return;
                SetData(31, value);
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }
        protected const string Slot_2_Size_displayName = "Slot 2 Size";
        protected const int Slot_2_Size_sortIndex = 850;
        [SortOrder(Slot_2_Size_sortIndex)]
        [DisplayName(Slot_2_Size_displayName)]
        public byte Slot_2_Size {
            get => GetData<byte>(32);
            set {
                if (GetData<byte>(32) == value) return;
                SetData(32, value);
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }
        protected const string Slot_3_Size_displayName = "Slot 3 Size";
        protected const int Slot_3_Size_sortIndex = 900;
        [SortOrder(Slot_3_Size_sortIndex)]
        [DisplayName(Slot_3_Size_displayName)]
        public byte Slot_3_Size {
            get => GetData<byte>(33);
            set {
                if (GetData<byte>(33) == value) return;
                SetData(33, value);
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }
        protected const string Set_Skill_1_displayName = "Set Skill 1";
        protected const int Set_Skill_1_sortIndex = 950;
        [SortOrder(Set_Skill_1_sortIndex)]
        [DisplayName(Set_Skill_1_displayName)]
        [DataSource(DataSourceType.Skills)]
        public ushort Set_Skill_1 {
            get => GetData<ushort>(34);
            set {
                if (GetData<ushort>(34) == value) return;
                SetData(34, value);
                OnPropertyChanged(nameof(Set_Skill_1));
            }
        }
        protected const string Set_Skill_1_Level_displayName = "Set Skill 1 Level";
        protected const int Set_Skill_1_Level_sortIndex = 1000;
        [SortOrder(Set_Skill_1_Level_sortIndex)]
        [DisplayName(Set_Skill_1_Level_displayName)]
        public byte Set_Skill_1_Level {
            get => GetData<byte>(36);
            set {
                if (GetData<byte>(36) == value) return;
                SetData(36, value);
                OnPropertyChanged(nameof(Set_Skill_1_Level));
            }
        }
        protected const string Set_Skill_2_displayName = "Set Skill 2";
        protected const int Set_Skill_2_sortIndex = 1050;
        [SortOrder(Set_Skill_2_sortIndex)]
        [DisplayName(Set_Skill_2_displayName)]
        [DataSource(DataSourceType.Skills)]
        public ushort Set_Skill_2 {
            get => GetData<ushort>(37);
            set {
                if (GetData<ushort>(37) == value) return;
                SetData(37, value);
                OnPropertyChanged(nameof(Set_Skill_2));
            }
        }
        protected const string Set_Skill_2_Level_displayName = "Set Skill 2 Level";
        protected const int Set_Skill_2_Level_sortIndex = 1100;
        [SortOrder(Set_Skill_2_Level_sortIndex)]
        [DisplayName(Set_Skill_2_Level_displayName)]
        public byte Set_Skill_2_Level {
            get => GetData<byte>(39);
            set {
                if (GetData<byte>(39) == value) return;
                SetData(39, value);
                OnPropertyChanged(nameof(Set_Skill_2_Level));
            }
        }
        protected const string Skill_1_displayName = "Skill 1";
        protected const int Skill_1_sortIndex = 1150;
        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [DataSource(DataSourceType.Skills)]
        public ushort Skill_1 {
            get => GetData<ushort>(40);
            set {
                if (GetData<ushort>(40) == value) return;
                SetData(40, value);
                OnPropertyChanged(nameof(Skill_1));
            }
        }
        protected const string Skill_1_Level_displayName = "Skill 1 Level";
        protected const int Skill_1_Level_sortIndex = 1200;
        [SortOrder(Skill_1_Level_sortIndex)]
        [DisplayName(Skill_1_Level_displayName)]
        public byte Skill_1_Level {
            get => GetData<byte>(42);
            set {
                if (GetData<byte>(42) == value) return;
                SetData(42, value);
                OnPropertyChanged(nameof(Skill_1_Level));
            }
        }
        protected const string Skill_2_displayName = "Skill 2";
        protected const int Skill_2_sortIndex = 1250;
        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [DataSource(DataSourceType.Skills)]
        public ushort Skill_2 {
            get => GetData<ushort>(43);
            set {
                if (GetData<ushort>(43) == value) return;
                SetData(43, value);
                OnPropertyChanged(nameof(Skill_2));
            }
        }
        protected const string Skill_2_Level_displayName = "Skill 2 Level";
        protected const int Skill_2_Level_sortIndex = 1300;
        [SortOrder(Skill_2_Level_sortIndex)]
        [DisplayName(Skill_2_Level_displayName)]
        public byte Skill_2_Level {
            get => GetData<byte>(45);
            set {
                if (GetData<byte>(45) == value) return;
                SetData(45, value);
                OnPropertyChanged(nameof(Skill_2_Level));
            }
        }
        protected const string Skill_3_displayName = "Skill 3";
        protected const int Skill_3_sortIndex = 1350;
        [SortOrder(Skill_3_sortIndex)]
        [DisplayName(Skill_3_displayName)]
        [DataSource(DataSourceType.Skills)]
        public ushort Skill_3 {
            get => GetData<ushort>(46);
            set {
                if (GetData<ushort>(46) == value) return;
                SetData(46, value);
                OnPropertyChanged(nameof(Skill_3));
            }
        }
        protected const string Skill_3_Level_displayName = "Skill 3 Level";
        protected const int Skill_3_Level_sortIndex = 1400;
        [SortOrder(Skill_3_Level_sortIndex)]
        [DisplayName(Skill_3_Level_displayName)]
        public byte Skill_3_Level {
            get => GetData<byte>(48);
            set {
                if (GetData<byte>(48) == value) return;
                SetData(48, value);
                OnPropertyChanged(nameof(Skill_3_Level));
            }
        }
        protected const string Gender_displayName = "Gender";
        protected const int Gender_sortIndex = 1450;
        [SortOrder(Gender_sortIndex)]
        [DisplayName(Gender_displayName)]
        public MHW_Template.Armors.Gender Gender {
            get => (MHW_Template.Armors.Gender) GetData<byte>(49);
            set {
                if ((MHW_Template.Armors.Gender) GetData<byte>(49) == value) return;
                SetData(49, (byte) value);
                OnPropertyChanged(nameof(Gender));
            }
        }
        protected const string Set_Group_displayName = "Set Group";
        protected const int Set_Group_sortIndex = 1500;
        [SortOrder(Set_Group_sortIndex)]
        [DisplayName(Set_Group_displayName)]
        public ushort Set_Group {
            get => GetData<ushort>(53);
            set {
                if (GetData<ushort>(53) == value) return;
                SetData(53, value);
                OnPropertyChanged(nameof(Set_Group));
            }
        }
        protected const string Is_Permanent_Raw_displayName = "Is Permanent Raw";
        protected const int Is_Permanent_Raw_sortIndex = 1550;
        [SortOrder(Is_Permanent_Raw_sortIndex)]
        [DisplayName(Is_Permanent_Raw_displayName)]
        protected byte Is_Permanent_Raw {
            get => GetData<byte>(59);
            set {
                if (GetData<byte>(59) == value) return;
                SetData(59, value);
                OnPropertyChanged(nameof(Is_Permanent_Raw));
            }
        }
        protected const string GMD_Name_Index_displayName = "GMD Name Index";
        protected const int GMD_Name_Index_sortIndex = 1600;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(55);
            set {
                if (GetData<ushort>(55) == value) return;
                SetData(55, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }
    }
}