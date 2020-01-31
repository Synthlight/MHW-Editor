
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class Melee {
        public const uint StructSize = 66;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
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
            get => GetData<ushort>(56);
        }
        protected const string Base_Model_Id_displayName = "Base Model Id";
        protected const int Base_Model_Id_sortIndex = 150;
        [SortOrder(Base_Model_Id_sortIndex)]
        [DisplayName(Base_Model_Id_displayName)]
        public short Base_Model_Id {
            get => GetData<short>(6);
            set {
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
                SetData(15, value);
                OnPropertyChanged(nameof(Is_Fixed_Upgrade_Raw));
            }
        }
        protected const string Cost_displayName = "Cost";
        protected const int Cost_sortIndex = 350;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public uint Cost {
            get => GetData<uint>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Cost));
            }
        }
        protected const string Rarity_displayName = "Rarity";
        protected const int Rarity_sortIndex = 400;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public byte Rarity {
            get => GetData<byte>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }
        protected const string Sharpness_Quality_displayName = "Sharpness Quality";
        protected const int Sharpness_Quality_sortIndex = 450;
        [SortOrder(Sharpness_Quality_sortIndex)]
        [DisplayName(Sharpness_Quality_displayName)]
        public byte Sharpness_Quality {
            get => GetData<byte>(21);
            set {
                SetData(21, value);
                OnPropertyChanged(nameof(Sharpness_Quality));
            }
        }
        protected const string Sharpness_Amount_displayName = "Sharpness Amount";
        protected const int Sharpness_Amount_sortIndex = 500;
        [SortOrder(Sharpness_Amount_sortIndex)]
        [DisplayName(Sharpness_Amount_displayName)]
        public byte Sharpness_Amount {
            get => GetData<byte>(22);
            set {
                SetData(22, value);
                OnPropertyChanged(nameof(Sharpness_Amount));
            }
        }
        protected const string Damage_displayName = "Damage";
        protected const int Damage_sortIndex = 550;
        [SortOrder(Damage_sortIndex)]
        [DisplayName(Damage_displayName)]
        public ushort Damage {
            get => GetData<ushort>(23);
            set {
                SetData(23, value);
                OnPropertyChanged(nameof(Damage));
            }
        }
        protected const string Defense_displayName = "Defense";
        protected const int Defense_sortIndex = 600;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public ushort Defense {
            get => GetData<ushort>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Defense));
            }
        }
        protected const string Affinity_displayName = "Affinity";
        protected const int Affinity_sortIndex = 650;
        [SortOrder(Affinity_sortIndex)]
        [DisplayName(Affinity_displayName)]
        public sbyte Affinity {
            get => GetData<sbyte>(27);
            set {
                SetData(27, value.Clamp((sbyte) -100, (sbyte) 100));
                OnPropertyChanged(nameof(Affinity));
            }
        }
        protected const string Element_displayName = "Element";
        protected const int Element_sortIndex = 700;
        [SortOrder(Element_sortIndex)]
        [DisplayName(Element_displayName)]
        public MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(28);
            set {
                SetData(28, (byte) value);
                OnPropertyChanged(nameof(Element));
            }
        }
        protected const string Element_Damage_displayName = "Element Damage";
        protected const int Element_Damage_sortIndex = 750;
        [SortOrder(Element_Damage_sortIndex)]
        [DisplayName(Element_Damage_displayName)]
        public ushort Element_Damage {
            get => GetData<ushort>(29);
            set {
                SetData(29, value);
                OnPropertyChanged(nameof(Element_Damage));
            }
        }
        protected const string Element_Hidden__displayName = "Element (Hidden)";
        protected const int Element_Hidden__sortIndex = 800;
        [SortOrder(Element_Hidden__sortIndex)]
        [DisplayName(Element_Hidden__displayName)]
        public MHW_Template.Weapons.Element Element_Hidden_ {
            get => (MHW_Template.Weapons.Element) GetData<byte>(31);
            set {
                SetData(31, (byte) value);
                OnPropertyChanged(nameof(Element_Hidden_));
            }
        }
        protected const string Element_Hidden_Damage_displayName = "Element (Hidden) Damage";
        protected const int Element_Hidden_Damage_sortIndex = 850;
        [SortOrder(Element_Hidden_Damage_sortIndex)]
        [DisplayName(Element_Hidden_Damage_displayName)]
        public ushort Element_Hidden_Damage {
            get => GetData<ushort>(32);
            set {
                SetData(32, value);
                OnPropertyChanged(nameof(Element_Hidden_Damage));
            }
        }
        protected const string Elderseal_displayName = "Elderseal";
        protected const int Elderseal_sortIndex = 900;
        [SortOrder(Elderseal_sortIndex)]
        [DisplayName(Elderseal_displayName)]
        public MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(34);
            set {
                SetData(34, (byte) value);
                OnPropertyChanged(nameof(Elderseal));
            }
        }
        protected const string Slot_Count_displayName = "Slot Count";
        protected const int Slot_Count_sortIndex = 950;
        [SortOrder(Slot_Count_sortIndex)]
        [DisplayName(Slot_Count_displayName)]
        public byte Slot_Count {
            get => GetData<byte>(35);
            set {
                SetData(35, value);
                OnPropertyChanged(nameof(Slot_Count));
            }
        }
        protected const string Slot_1_Size_displayName = "Slot 1 Size";
        protected const int Slot_1_Size_sortIndex = 1000;
        [SortOrder(Slot_1_Size_sortIndex)]
        [DisplayName(Slot_1_Size_displayName)]
        public byte Slot_1_Size {
            get => GetData<byte>(36);
            set {
                SetData(36, value);
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }
        protected const string Slot_2_Size_displayName = "Slot 2 Size";
        protected const int Slot_2_Size_sortIndex = 1050;
        [SortOrder(Slot_2_Size_sortIndex)]
        [DisplayName(Slot_2_Size_displayName)]
        public byte Slot_2_Size {
            get => GetData<byte>(37);
            set {
                SetData(37, value);
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }
        protected const string Slot_3_Size_displayName = "Slot 3 Size";
        protected const int Slot_3_Size_sortIndex = 1100;
        [SortOrder(Slot_3_Size_sortIndex)]
        [DisplayName(Slot_3_Size_displayName)]
        public byte Slot_3_Size {
            get => GetData<byte>(38);
            set {
                SetData(38, value);
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }
        protected const string Special_Ability_1_ID_displayName = "Special Ability 1 ID";
        protected const int Special_Ability_1_ID_sortIndex = 1150;
        [SortOrder(Special_Ability_1_ID_sortIndex)]
        [DisplayName(Special_Ability_1_ID_displayName)]
        public ushort Special_Ability_1_ID {
            get => GetData<ushort>(39);
            set {
                SetData(39, value);
                OnPropertyChanged(nameof(Special_Ability_1_ID));
            }
        }
        protected const string Special_Ability_2_ID_displayName = "Special Ability 2 ID";
        protected const int Special_Ability_2_ID_sortIndex = 1200;
        [SortOrder(Special_Ability_2_ID_sortIndex)]
        [DisplayName(Special_Ability_2_ID_displayName)]
        public ushort Special_Ability_2_ID {
            get => GetData<ushort>(41);
            set {
                SetData(41, value);
                OnPropertyChanged(nameof(Special_Ability_2_ID));
            }
        }
        protected const string Skill_displayName = "Skill";
        protected const int Skill_sortIndex = 1250;
        [SortOrder(Skill_sortIndex)]
        [DisplayName(Skill_displayName)]
        public ushort Skill {
            get => GetData<ushort>(62);
            set {
                SetData(62, value);
                OnPropertyChanged(nameof(Skill));
            }
        }
        protected const string GMD_Name_Index_displayName = "GMD Name Index";
        protected const int GMD_Name_Index_sortIndex = 1300;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(58);
            set {
                SetData(58, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }
    }
}