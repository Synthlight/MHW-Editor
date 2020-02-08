using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Armors {
    public partial class Armor {
        public const uint StructSize = 60;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual uint Id {
            get => GetData<uint>(0);
        }

        public const string Order_displayName = "Order";
        public const int Order_sortIndex = 100;
        [SortOrder(Order_sortIndex)]
        [DisplayName(Order_displayName)]
        public virtual ushort Order {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Order));
            }
        }

        public const string Variant_displayName = "Variant";
        public const int Variant_sortIndex = 150;
        [SortOrder(Variant_sortIndex)]
        [DisplayName(Variant_displayName)]
        public virtual MHW_Template.Armors.Variant Variant {
            get => (MHW_Template.Armors.Variant) GetData<byte>(6);
            set {
                if ((MHW_Template.Armors.Variant) GetData<byte>(6) == value) return;
                SetData(6, (byte) value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Variant));
            }
        }

        public const string Set_Layered_Id_displayName = "Set (Layered) Id";
        public const int Set_Layered_Id_sortIndex = 200;
        [SortOrder(Set_Layered_Id_sortIndex)]
        [DisplayName(Set_Layered_Id_displayName)]
        public virtual ushort Set_Layered_Id {
            get => GetData<ushort>(7);
            set {
                if (GetData<ushort>(7) == value) return;
                SetData(7, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_Layered_Id));
            }
        }

        public const string Type_displayName = "Type";
        public const int Type_sortIndex = 250;
        [SortOrder(Type_sortIndex)]
        [DisplayName(Type_displayName)]
        public virtual MHW_Template.Armors.ArmorType Type {
            get => (MHW_Template.Armors.ArmorType) GetData<byte>(9);
            set {
                if ((MHW_Template.Armors.ArmorType) GetData<byte>(9) == value) return;
                SetData(9, (byte) value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Type));
            }
        }

        public const string Equip_Slot_displayName = "Equip Slot";
        public const int Equip_Slot_sortIndex = 300;
        [SortOrder(Equip_Slot_sortIndex)]
        [DisplayName(Equip_Slot_displayName)]
        public virtual MHW_Template.Armors.EquipSlot Equip_Slot {
            get => (MHW_Template.Armors.EquipSlot) GetData<byte>(10);
            set {
                if ((MHW_Template.Armors.EquipSlot) GetData<byte>(10) == value) return;
                SetData(10, (byte) value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Equip_Slot));
            }
        }

        public const string Defense_displayName = "Defense";
        public const int Defense_sortIndex = 350;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public virtual ushort Defense {
            get => GetData<ushort>(11);
            set {
                if (GetData<ushort>(11) == value) return;
                SetData(11, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Defense));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 400;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual byte Rarity {
            get => GetData<byte>(20);
            set {
                if (GetData<byte>(20) == value) return;
                SetData(20, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Cost_displayName = "Cost";
        public const int Cost_sortIndex = 450;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public virtual uint Cost {
            get => GetData<uint>(21);
            set {
                if (GetData<uint>(21) == value) return;
                SetData(21, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public const string Fire_Res_displayName = "Fire Res";
        public const int Fire_Res_sortIndex = 500;
        [SortOrder(Fire_Res_sortIndex)]
        [DisplayName(Fire_Res_displayName)]
        public virtual sbyte Fire_Res {
            get => GetData<sbyte>(25);
            set {
                if (GetData<sbyte>(25) == value) return;
                SetData(25, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Fire_Res));
            }
        }

        public const string Water_Res_displayName = "Water Res";
        public const int Water_Res_sortIndex = 550;
        [SortOrder(Water_Res_sortIndex)]
        [DisplayName(Water_Res_displayName)]
        public virtual sbyte Water_Res {
            get => GetData<sbyte>(26);
            set {
                if (GetData<sbyte>(26) == value) return;
                SetData(26, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Water_Res));
            }
        }

        public const string Ice_Res_displayName = "Ice Res";
        public const int Ice_Res_sortIndex = 600;
        [SortOrder(Ice_Res_sortIndex)]
        [DisplayName(Ice_Res_displayName)]
        public virtual sbyte Ice_Res {
            get => GetData<sbyte>(27);
            set {
                if (GetData<sbyte>(27) == value) return;
                SetData(27, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ice_Res));
            }
        }

        public const string Thunder_Res_displayName = "Thunder Res";
        public const int Thunder_Res_sortIndex = 650;
        [SortOrder(Thunder_Res_sortIndex)]
        [DisplayName(Thunder_Res_displayName)]
        public virtual sbyte Thunder_Res {
            get => GetData<sbyte>(28);
            set {
                if (GetData<sbyte>(28) == value) return;
                SetData(28, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thunder_Res));
            }
        }

        public const string Dragon_Res_displayName = "Dragon Res";
        public const int Dragon_Res_sortIndex = 700;
        [SortOrder(Dragon_Res_sortIndex)]
        [DisplayName(Dragon_Res_displayName)]
        public virtual sbyte Dragon_Res {
            get => GetData<sbyte>(29);
            set {
                if (GetData<sbyte>(29) == value) return;
                SetData(29, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragon_Res));
            }
        }

        public const string Slot_Count_displayName = "Slot Count";
        public const int Slot_Count_sortIndex = 750;
        [SortOrder(Slot_Count_sortIndex)]
        [DisplayName(Slot_Count_displayName)]
        public virtual byte Slot_Count {
            get => GetData<byte>(30);
            set {
                if (GetData<byte>(30) == value) return;
                SetData(30, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_Count));
            }
        }

        public const string Slot_1_Size_displayName = "Slot 1 Size";
        public const int Slot_1_Size_sortIndex = 800;
        [SortOrder(Slot_1_Size_sortIndex)]
        [DisplayName(Slot_1_Size_displayName)]
        public virtual byte Slot_1_Size {
            get => GetData<byte>(31);
            set {
                if (GetData<byte>(31) == value) return;
                SetData(31, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }

        public const string Slot_2_Size_displayName = "Slot 2 Size";
        public const int Slot_2_Size_sortIndex = 850;
        [SortOrder(Slot_2_Size_sortIndex)]
        [DisplayName(Slot_2_Size_displayName)]
        public virtual byte Slot_2_Size {
            get => GetData<byte>(32);
            set {
                if (GetData<byte>(32) == value) return;
                SetData(32, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }

        public const string Slot_3_Size_displayName = "Slot 3 Size";
        public const int Slot_3_Size_sortIndex = 900;
        [SortOrder(Slot_3_Size_sortIndex)]
        [DisplayName(Slot_3_Size_displayName)]
        public virtual byte Slot_3_Size {
            get => GetData<byte>(33);
            set {
                if (GetData<byte>(33) == value) return;
                SetData(33, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }

        public const string Set_Skill_1_displayName = "Set Skill 1";
        public const int Set_Skill_1_sortIndex = 950;
        [SortOrder(Set_Skill_1_sortIndex)]
        [DisplayName(Set_Skill_1_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Set_Skill_1 {
            get => GetData<ushort>(34);
            set {
                if (GetData<ushort>(34) == value) return;
                SetData(34, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_Skill_1));
                OnPropertyChanged("Set_Skill_1_button");
            }
        }

        public const string Set_Skill_1_Level_displayName = "Set Skill 1 Level";
        public const int Set_Skill_1_Level_sortIndex = 1000;
        [SortOrder(Set_Skill_1_Level_sortIndex)]
        [DisplayName(Set_Skill_1_Level_displayName)]
        public virtual byte Set_Skill_1_Level {
            get => GetData<byte>(36);
            set {
                if (GetData<byte>(36) == value) return;
                SetData(36, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_Skill_1_Level));
            }
        }

        public const string Set_Skill_2_displayName = "Set Skill 2";
        public const int Set_Skill_2_sortIndex = 1050;
        [SortOrder(Set_Skill_2_sortIndex)]
        [DisplayName(Set_Skill_2_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Set_Skill_2 {
            get => GetData<ushort>(37);
            set {
                if (GetData<ushort>(37) == value) return;
                SetData(37, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_Skill_2));
                OnPropertyChanged("Set_Skill_2_button");
            }
        }

        public const string Set_Skill_2_Level_displayName = "Set Skill 2 Level";
        public const int Set_Skill_2_Level_sortIndex = 1100;
        [SortOrder(Set_Skill_2_Level_sortIndex)]
        [DisplayName(Set_Skill_2_Level_displayName)]
        public virtual byte Set_Skill_2_Level {
            get => GetData<byte>(39);
            set {
                if (GetData<byte>(39) == value) return;
                SetData(39, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_Skill_2_Level));
            }
        }

        public const string Skill_1_displayName = "Skill 1";
        public const int Skill_1_sortIndex = 1150;
        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Skill_1 {
            get => GetData<ushort>(40);
            set {
                if (GetData<ushort>(40) == value) return;
                SetData(40, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_1));
                OnPropertyChanged("Skill_1_button");
            }
        }

        public const string Skill_1_Level_displayName = "Skill 1 Level";
        public const int Skill_1_Level_sortIndex = 1200;
        [SortOrder(Skill_1_Level_sortIndex)]
        [DisplayName(Skill_1_Level_displayName)]
        public virtual byte Skill_1_Level {
            get => GetData<byte>(42);
            set {
                if (GetData<byte>(42) == value) return;
                SetData(42, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_1_Level));
            }
        }

        public const string Skill_2_displayName = "Skill 2";
        public const int Skill_2_sortIndex = 1250;
        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Skill_2 {
            get => GetData<ushort>(43);
            set {
                if (GetData<ushort>(43) == value) return;
                SetData(43, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_2));
                OnPropertyChanged("Skill_2_button");
            }
        }

        public const string Skill_2_Level_displayName = "Skill 2 Level";
        public const int Skill_2_Level_sortIndex = 1300;
        [SortOrder(Skill_2_Level_sortIndex)]
        [DisplayName(Skill_2_Level_displayName)]
        public virtual byte Skill_2_Level {
            get => GetData<byte>(45);
            set {
                if (GetData<byte>(45) == value) return;
                SetData(45, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_2_Level));
            }
        }

        public const string Skill_3_displayName = "Skill 3";
        public const int Skill_3_sortIndex = 1350;
        [SortOrder(Skill_3_sortIndex)]
        [DisplayName(Skill_3_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Skill_3 {
            get => GetData<ushort>(46);
            set {
                if (GetData<ushort>(46) == value) return;
                SetData(46, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_3));
                OnPropertyChanged("Skill_3_button");
            }
        }

        public const string Skill_3_Level_displayName = "Skill 3 Level";
        public const int Skill_3_Level_sortIndex = 1400;
        [SortOrder(Skill_3_Level_sortIndex)]
        [DisplayName(Skill_3_Level_displayName)]
        public virtual byte Skill_3_Level {
            get => GetData<byte>(48);
            set {
                if (GetData<byte>(48) == value) return;
                SetData(48, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_3_Level));
            }
        }

        public const string Gender_displayName = "Gender";
        public const int Gender_sortIndex = 1450;
        [SortOrder(Gender_sortIndex)]
        [DisplayName(Gender_displayName)]
        public virtual MHW_Template.Armors.Gender Gender {
            get => (MHW_Template.Armors.Gender) GetData<byte>(49);
            set {
                if ((MHW_Template.Armors.Gender) GetData<byte>(49) == value) return;
                SetData(49, (byte) value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gender));
            }
        }

        public const string Set_Group_displayName = "Set Group";
        public const int Set_Group_sortIndex = 1500;
        [SortOrder(Set_Group_sortIndex)]
        [DisplayName(Set_Group_displayName)]
        public virtual ushort Set_Group {
            get => GetData<ushort>(53);
            set {
                if (GetData<ushort>(53) == value) return;
                SetData(53, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_Group));
            }
        }

        public const string Is_Permanent_Raw_displayName = "Is Permanent Raw";
        public const int Is_Permanent_Raw_sortIndex = 1550;
        [SortOrder(Is_Permanent_Raw_sortIndex)]
        [DisplayName(Is_Permanent_Raw_displayName)]
        private byte Is_Permanent_Raw {
            get => GetData<byte>(59);
            set {
                if (GetData<byte>(59) == value) return;
                SetData(59, value);
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Is_Permanent_Raw));
            }
        }

        public const string GMD_Name_Index_displayName = "GMD Name Index";
        public const int GMD_Name_Index_sortIndex = 1600;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        public virtual ushort GMD_Name_Index {
            get => GetData<ushort>(55);
        }

        public const string GMD_Description_Index_displayName = "GMD Description Index";
        public const int GMD_Description_Index_sortIndex = 1650;
        [SortOrder(GMD_Description_Index_sortIndex)]
        [DisplayName(GMD_Description_Index_displayName)]
        public virtual ushort GMD_Description_Index {
            get => GetData<ushort>(57);
        }

        public const int lastSortIndex = 1700;
    }
}