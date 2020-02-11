using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Melee {
        public const uint StructSize = 66;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        public virtual uint Index {
            get => GetData<uint>(0);
        }

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 100;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual ushort Id {
            get => GetData<ushort>(56);
        }

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 150;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual short Unk1 {
            get => GetData<short>(4);
            set {
                if (GetData<short>(4) == value) return;
                SetData(4, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Base_Model_Id_displayName = "Base Model Id";
        public const int Base_Model_Id_sortIndex = 200;
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
        public const int Part_1_Id_sortIndex = 250;
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
        public const int Part_2_Id_sortIndex = 300;
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

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 350;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual byte Unk2 {
            get => GetData<byte>(13);
            set {
                if (GetData<byte>(13) == value) return;
                SetData(13, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 400;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual byte Unk3 {
            get => GetData<byte>(14);
            set {
                if (GetData<byte>(14) == value) return;
                SetData(14, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Is_Fixed_Upgrade_Raw_displayName = "Is Fixed Upgrade Raw";
        public const int Is_Fixed_Upgrade_Raw_sortIndex = 450;
        [SortOrder(Is_Fixed_Upgrade_Raw_sortIndex)]
        [DisplayName(Is_Fixed_Upgrade_Raw_displayName)]
        private byte Is_Fixed_Upgrade_Raw {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value) return;
                SetData(15, value, nameof(Is_Fixed_Upgrade_Raw));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Is_Fixed_Upgrade_Raw));
                OnPropertyChanged(nameof(Is_Fixed_Upgrade));
            }
        }

        public const string Cost_displayName = "Cost";
        public const int Cost_sortIndex = 500;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public virtual uint Cost {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 550;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual byte Rarity {
            get => GetData<byte>(20);
            set {
                if (GetData<byte>(20) == value) return;
                SetData(20, value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Sharpness_kire_Id_displayName = "Sharpness (.kire) Id";
        public const int Sharpness_kire_Id_sortIndex = 600;
        [SortOrder(Sharpness_kire_Id_sortIndex)]
        [DisplayName(Sharpness_kire_Id_displayName)]
        public virtual byte Sharpness_kire_Id {
            get => GetData<byte>(21);
            set {
                if (GetData<byte>(21) == value) return;
                SetData(21, value, nameof(Sharpness_kire_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sharpness_kire_Id));
            }
        }

        public const string Sharpness_Amount_displayName = "Sharpness Amount";
        public const int Sharpness_Amount_sortIndex = 650;
        [SortOrder(Sharpness_Amount_sortIndex)]
        [DisplayName(Sharpness_Amount_displayName)]
        public virtual byte Sharpness_Amount {
            get => GetData<byte>(22);
            set {
                if (GetData<byte>(22) == value) return;
                SetData(22, value, nameof(Sharpness_Amount));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sharpness_Amount));
            }
        }

        public const string Damage_displayName = "Damage";
        public const int Damage_sortIndex = 700;
        [SortOrder(Damage_sortIndex)]
        [DisplayName(Damage_displayName)]
        public virtual ushort Damage {
            get => GetData<ushort>(23);
            set {
                if (GetData<ushort>(23) == value) return;
                SetData(23, value, nameof(Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Damage));
            }
        }

        public const string Defense_displayName = "Defense";
        public const int Defense_sortIndex = 750;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public virtual ushort Defense {
            get => GetData<ushort>(25);
            set {
                if (GetData<ushort>(25) == value) return;
                SetData(25, value, nameof(Defense));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Defense));
            }
        }

        public const string Affinity_displayName = "Affinity";
        public const int Affinity_sortIndex = 800;
        [SortOrder(Affinity_sortIndex)]
        [DisplayName(Affinity_displayName)]
        public virtual sbyte Affinity {
            get => GetData<sbyte>(27);
            set {
                if (GetData<sbyte>(27) == value.Clamp((sbyte) -100, (sbyte) 100)) return;
                SetData(27, value.Clamp((sbyte) -100, (sbyte) 100), nameof(Affinity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity));
            }
        }

        public const string Element_displayName = "Element";
        public const int Element_sortIndex = 850;
        [SortOrder(Element_sortIndex)]
        [DisplayName(Element_displayName)]
        public virtual MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(28);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(28) == value) return;
                SetData(28, (byte) value, nameof(Element));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element));
            }
        }

        public const string Element_Damage_displayName = "Element Damage";
        public const int Element_Damage_sortIndex = 900;
        [SortOrder(Element_Damage_sortIndex)]
        [DisplayName(Element_Damage_displayName)]
        public virtual ushort Element_Damage {
            get => GetData<ushort>(29);
            set {
                if (GetData<ushort>(29) == value) return;
                SetData(29, value, nameof(Element_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_Damage));
            }
        }

        public const string Element_Hidden__displayName = "Element (Hidden)";
        public const int Element_Hidden__sortIndex = 950;
        [SortOrder(Element_Hidden__sortIndex)]
        [DisplayName(Element_Hidden__displayName)]
        public virtual MHW_Template.Weapons.Element Element_Hidden_ {
            get => (MHW_Template.Weapons.Element) GetData<byte>(31);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(31) == value) return;
                SetData(31, (byte) value, nameof(Element_Hidden_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_Hidden_));
            }
        }

        public const string Element_Hidden_Damage_displayName = "Element (Hidden) Damage";
        public const int Element_Hidden_Damage_sortIndex = 1000;
        [SortOrder(Element_Hidden_Damage_sortIndex)]
        [DisplayName(Element_Hidden_Damage_displayName)]
        public virtual ushort Element_Hidden_Damage {
            get => GetData<ushort>(32);
            set {
                if (GetData<ushort>(32) == value) return;
                SetData(32, value, nameof(Element_Hidden_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_Hidden_Damage));
            }
        }

        public const string Elderseal_displayName = "Elderseal";
        public const int Elderseal_sortIndex = 1050;
        [SortOrder(Elderseal_sortIndex)]
        [DisplayName(Elderseal_displayName)]
        public virtual MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(34);
            set {
                if ((MHW_Template.Weapons.Elderseal) GetData<byte>(34) == value) return;
                SetData(34, (byte) value, nameof(Elderseal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elderseal));
            }
        }

        public const string Slot_Count_displayName = "Slot Count";
        public const int Slot_Count_sortIndex = 1100;
        [SortOrder(Slot_Count_sortIndex)]
        [DisplayName(Slot_Count_displayName)]
        public virtual byte Slot_Count {
            get => GetData<byte>(35);
            set {
                if (GetData<byte>(35) == value) return;
                SetData(35, value, nameof(Slot_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_Count));
            }
        }

        public const string Slot_1_Size_displayName = "Slot 1 Size";
        public const int Slot_1_Size_sortIndex = 1150;
        [SortOrder(Slot_1_Size_sortIndex)]
        [DisplayName(Slot_1_Size_displayName)]
        public virtual byte Slot_1_Size {
            get => GetData<byte>(36);
            set {
                if (GetData<byte>(36) == value) return;
                SetData(36, value, nameof(Slot_1_Size));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }

        public const string Slot_2_Size_displayName = "Slot 2 Size";
        public const int Slot_2_Size_sortIndex = 1200;
        [SortOrder(Slot_2_Size_sortIndex)]
        [DisplayName(Slot_2_Size_displayName)]
        public virtual byte Slot_2_Size {
            get => GetData<byte>(37);
            set {
                if (GetData<byte>(37) == value) return;
                SetData(37, value, nameof(Slot_2_Size));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }

        public const string Slot_3_Size_displayName = "Slot 3 Size";
        public const int Slot_3_Size_sortIndex = 1250;
        [SortOrder(Slot_3_Size_sortIndex)]
        [DisplayName(Slot_3_Size_displayName)]
        public virtual byte Slot_3_Size {
            get => GetData<byte>(38);
            set {
                if (GetData<byte>(38) == value) return;
                SetData(38, value, nameof(Slot_3_Size));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }

        public const string Special_Ability_1_ID_displayName = "Special Ability 1 ID";
        public const int Special_Ability_1_ID_sortIndex = 1300;
        [SortOrder(Special_Ability_1_ID_sortIndex)]
        [DisplayName(Special_Ability_1_ID_displayName)]
        public virtual ushort Special_Ability_1_ID {
            get => GetData<ushort>(39);
            set {
                if (GetData<ushort>(39) == value) return;
                SetData(39, value, nameof(Special_Ability_1_ID));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Special_Ability_1_ID));
            }
        }

        public const string Special_Ability_2_ID_displayName = "Special Ability 2 ID";
        public const int Special_Ability_2_ID_sortIndex = 1350;
        [SortOrder(Special_Ability_2_ID_sortIndex)]
        [DisplayName(Special_Ability_2_ID_displayName)]
        public virtual ushort Special_Ability_2_ID {
            get => GetData<ushort>(41);
            set {
                if (GetData<ushort>(41) == value) return;
                SetData(41, value, nameof(Special_Ability_2_ID));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Special_Ability_2_ID));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 1400;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual byte Unk4 {
            get => GetData<byte>(55);
            set {
                if (GetData<byte>(55) == value) return;
                SetData(55, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Skill_displayName = "Skill";
        public const int Skill_sortIndex = 1450;
        [SortOrder(Skill_sortIndex)]
        [DisplayName(Skill_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Skill {
            get => GetData<ushort>(62);
            set {
                if (GetData<ushort>(62) == value) return;
                SetData(62, value, nameof(Skill));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill));
                OnPropertyChanged(nameof(Skill_button));
            }
        }

        public const string GMD_Name_Index_displayName = "GMD Name Index";
        public const int GMD_Name_Index_sortIndex = 1500;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        public virtual ushort GMD_Name_Index {
            get => GetData<ushort>(58);
        }

        public const string GMD_Description_Index_displayName = "GMD Description Index";
        public const int GMD_Description_Index_sortIndex = 1550;
        [SortOrder(GMD_Description_Index_sortIndex)]
        [DisplayName(GMD_Description_Index_displayName)]
        public virtual ushort GMD_Description_Index {
            get => GetData<ushort>(60);
        }

        public const int lastSortIndex = 1600;
    }
}