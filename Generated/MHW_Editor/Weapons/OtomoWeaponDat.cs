
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class OtomoWeaponDat {
        public const uint StructSize = 38;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = "FZoS8QLyOyeFmkdrz73P9Fh2N4NcTwy3QQPjc1YRII5KWovK6yFuU8SL";

        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value);
                OnPropertyChanged(nameof(Id));
            }
        }

        protected const string Set_Id_displayName = "Set Id";
        protected const int Set_Id_sortIndex = 100;
        [SortOrder(Set_Id_sortIndex)]
        [DisplayName(Set_Id_displayName)]
        public ushort Set_Id {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value);
                OnPropertyChanged(nameof(Set_Id));
            }
        }

        protected const string Element_displayName = "Element";
        protected const int Element_sortIndex = 150;
        [SortOrder(Element_sortIndex)]
        [DisplayName(Element_displayName)]
        public MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(6);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(6) == value) return;
                SetData(6, (byte) value);
                OnPropertyChanged(nameof(Element));
            }
        }

        protected const string Attack_Type_displayName = "Attack Type";
        protected const int Attack_Type_sortIndex = 200;
        [SortOrder(Attack_Type_sortIndex)]
        [DisplayName(Attack_Type_displayName)]
        public MHW_Template.Weapons.OtomoAttackType Attack_Type {
            get => (MHW_Template.Weapons.OtomoAttackType) GetData<byte>(7);
            set {
                if ((MHW_Template.Weapons.OtomoAttackType) GetData<byte>(7) == value) return;
                SetData(7, (byte) value);
                OnPropertyChanged(nameof(Attack_Type));
            }
        }

        protected const string Melee_Damage_displayName = "Melee Damage";
        protected const int Melee_Damage_sortIndex = 250;
        [SortOrder(Melee_Damage_sortIndex)]
        [DisplayName(Melee_Damage_displayName)]
        public ushort Melee_Damage {
            get => GetData<ushort>(9);
            set {
                if (GetData<ushort>(9) == value) return;
                SetData(9, value);
                OnPropertyChanged(nameof(Melee_Damage));
            }
        }

        protected const string Ranged_Damage_displayName = "Ranged Damage";
        protected const int Ranged_Damage_sortIndex = 300;
        [SortOrder(Ranged_Damage_sortIndex)]
        [DisplayName(Ranged_Damage_displayName)]
        public ushort Ranged_Damage {
            get => GetData<ushort>(11);
            set {
                if (GetData<ushort>(11) == value) return;
                SetData(11, value);
                OnPropertyChanged(nameof(Ranged_Damage));
            }
        }

        protected const string Elemental_Damage_displayName = "Elemental Damage";
        protected const int Elemental_Damage_sortIndex = 350;
        [SortOrder(Elemental_Damage_sortIndex)]
        [DisplayName(Elemental_Damage_displayName)]
        public ushort Elemental_Damage {
            get => GetData<ushort>(13);
            set {
                if (GetData<ushort>(13) == value) return;
                SetData(13, value);
                OnPropertyChanged(nameof(Elemental_Damage));
            }
        }

        protected const string Affinity_displayName = "Affinity";
        protected const int Affinity_sortIndex = 400;
        [SortOrder(Affinity_sortIndex)]
        [DisplayName(Affinity_displayName)]
        public short Affinity {
            get => GetData<short>(15);
            set {
                if (GetData<short>(15) == value) return;
                SetData(15, value);
                OnPropertyChanged(nameof(Affinity));
            }
        }

        protected const string Defense_displayName = "Defense";
        protected const int Defense_sortIndex = 450;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public ushort Defense {
            get => GetData<ushort>(17);
            set {
                if (GetData<ushort>(17) == value) return;
                SetData(17, value);
                OnPropertyChanged(nameof(Defense));
            }
        }

        protected const string Elderseal_displayName = "Elderseal";
        protected const int Elderseal_sortIndex = 500;
        [SortOrder(Elderseal_sortIndex)]
        [DisplayName(Elderseal_displayName)]
        public byte Elderseal {
            get => GetData<byte>(19);
            set {
                if (GetData<byte>(19) == value) return;
                SetData(19, value);
                OnPropertyChanged(nameof(Elderseal));
            }
        }

        protected const string Rarity_displayName = "Rarity";
        protected const int Rarity_sortIndex = 550;
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

        protected const string Order_displayName = "Order";
        protected const int Order_sortIndex = 600;
        [SortOrder(Order_sortIndex)]
        [DisplayName(Order_displayName)]
        public ushort Order {
            get => GetData<ushort>(21);
            set {
                if (GetData<ushort>(21) == value) return;
                SetData(21, value);
                OnPropertyChanged(nameof(Order));
            }
        }

        protected const string Cost_displayName = "Cost";
        protected const int Cost_sortIndex = 650;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public uint Cost {
            get => GetData<uint>(27);
            set {
                if (GetData<uint>(27) == value) return;
                SetData(27, value);
                OnPropertyChanged(nameof(Cost));
            }
        }

        protected const string Unknown_byte_1_displayName = "Unknown (byte) 1";
        protected const int Unknown_byte_1_sortIndex = 700;
        [SortOrder(Unknown_byte_1_sortIndex)]
        [DisplayName(Unknown_byte_1_displayName)]
        public byte Unknown_byte_1 {
            get => GetData<byte>(31);
            set {
                if (GetData<byte>(31) == value) return;
                SetData(31, value);
                OnPropertyChanged(nameof(Unknown_byte_1));
            }
        }

        protected const string Set_Group_displayName = "Set Group";
        protected const int Set_Group_sortIndex = 750;
        [SortOrder(Set_Group_sortIndex)]
        [DisplayName(Set_Group_displayName)]
        public ushort Set_Group {
            get => GetData<ushort>(32);
            set {
                if (GetData<ushort>(32) == value) return;
                SetData(32, value);
                OnPropertyChanged(nameof(Set_Group));
            }
        }

        protected const string GMD_Name_Index_displayName = "GMD Name Index";
        protected const int GMD_Name_Index_sortIndex = 800;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(34);
            set {
                if (GetData<ushort>(34) == value) return;
                SetData(34, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }

        protected const string GMD_Description_Index_displayName = "GMD Description Index";
        protected const int GMD_Description_Index_sortIndex = 850;
        [SortOrder(GMD_Description_Index_sortIndex)]
        [DisplayName(GMD_Description_Index_displayName)]
        protected ushort GMD_Description_Index {
            get => GetData<ushort>(36);
            set {
                if (GetData<ushort>(36) == value) return;
                SetData(36, value);
                OnPropertyChanged(nameof(GMD_Description_Index));
            }
        }
    }
}