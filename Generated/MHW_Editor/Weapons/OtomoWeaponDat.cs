using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class OtomoWeaponDat {
        public const uint StructSize = 38;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = "FZoS8QLyOyeFmkdrz73P9Fh2N4NcTwy3QQPjc1YRII5KWovK6yFuU8SL";
        public override string UniqueId => $"{Id}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
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
        public virtual ushort Id {
            get => GetData<ushort>(32);
            set {
                if (GetData<ushort>(32) == value) return;
                SetData(32, value, nameof(Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Id));
            }
        }

        public const string Set_Id_displayName = "Set Id";
        public const int Set_Id_sortIndex = 150;
        [SortOrder(Set_Id_sortIndex)]
        [DisplayName(Set_Id_displayName)]
        public virtual ushort Set_Id {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value, nameof(Set_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_Id));
            }
        }

        public const string Element_displayName = "Element";
        public const int Element_sortIndex = 200;
        [SortOrder(Element_sortIndex)]
        [DisplayName(Element_displayName)]
        public virtual MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(6);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(6) == value) return;
                SetData(6, (byte) value, nameof(Element));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element));
            }
        }

        public const string Attack_Type_displayName = "Attack Type";
        public const int Attack_Type_sortIndex = 250;
        [SortOrder(Attack_Type_sortIndex)]
        [DisplayName(Attack_Type_displayName)]
        public virtual MHW_Template.Weapons.AttackType Attack_Type {
            get => (MHW_Template.Weapons.AttackType) GetData<ushort>(7);
            set {
                if ((MHW_Template.Weapons.AttackType) GetData<ushort>(7) == value) return;
                SetData(7, (ushort) value, nameof(Attack_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Attack_Type));
            }
        }

        public const string Melee_Damage_displayName = "Melee Damage";
        public const int Melee_Damage_sortIndex = 300;
        [SortOrder(Melee_Damage_sortIndex)]
        [DisplayName(Melee_Damage_displayName)]
        public virtual ushort Melee_Damage {
            get => GetData<ushort>(9);
            set {
                if (GetData<ushort>(9) == value) return;
                SetData(9, value, nameof(Melee_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Melee_Damage));
            }
        }

        public const string Ranged_Damage_displayName = "Ranged Damage";
        public const int Ranged_Damage_sortIndex = 350;
        [SortOrder(Ranged_Damage_sortIndex)]
        [DisplayName(Ranged_Damage_displayName)]
        public virtual ushort Ranged_Damage {
            get => GetData<ushort>(11);
            set {
                if (GetData<ushort>(11) == value) return;
                SetData(11, value, nameof(Ranged_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ranged_Damage));
            }
        }

        public const string Elemental_Damage_displayName = "Elemental Damage";
        public const int Elemental_Damage_sortIndex = 400;
        [SortOrder(Elemental_Damage_sortIndex)]
        [DisplayName(Elemental_Damage_displayName)]
        public virtual ushort Elemental_Damage {
            get => GetData<ushort>(13);
            set {
                if (GetData<ushort>(13) == value) return;
                SetData(13, value, nameof(Elemental_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Damage));
            }
        }

        public const string Affinity_displayName = "Affinity";
        public const int Affinity_sortIndex = 450;
        [SortOrder(Affinity_sortIndex)]
        [DisplayName(Affinity_displayName)]
        public virtual short Affinity {
            get => GetData<short>(15);
            set {
                if (GetData<short>(15) == value) return;
                SetData(15, value, nameof(Affinity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity));
            }
        }

        public const string Defense_displayName = "Defense";
        public const int Defense_sortIndex = 500;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public virtual ushort Defense {
            get => GetData<ushort>(17);
            set {
                if (GetData<ushort>(17) == value) return;
                SetData(17, value, nameof(Defense));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Defense));
            }
        }

        public const string Elderseal_displayName = "Elderseal";
        public const int Elderseal_sortIndex = 550;
        [SortOrder(Elderseal_sortIndex)]
        [DisplayName(Elderseal_displayName)]
        public virtual byte Elderseal {
            get => GetData<byte>(19);
            set {
                if (GetData<byte>(19) == value) return;
                SetData(19, value, nameof(Elderseal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elderseal));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 600;
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

        public const string Order_displayName = "Order";
        public const int Order_sortIndex = 650;
        [SortOrder(Order_sortIndex)]
        [DisplayName(Order_displayName)]
        public virtual ushort Order {
            get => GetData<ushort>(21);
            set {
                if (GetData<ushort>(21) == value) return;
                SetData(21, value, nameof(Order));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Order));
            }
        }

        public const string Unk_displayName = "Unk";
        public const int Unk_sortIndex = 700;
        [SortOrder(Unk_sortIndex)]
        [DisplayName(Unk_displayName)]
        public virtual uint Unk {
            get => GetData<uint>(23);
            set {
                if (GetData<uint>(23) == value) return;
                SetData(23, value, nameof(Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk));
            }
        }

        public const string Cost_displayName = "Cost";
        public const int Cost_sortIndex = 750;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public virtual uint Cost {
            get => GetData<uint>(27);
            set {
                if (GetData<uint>(27) == value) return;
                SetData(27, value, nameof(Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public const string Unknown_byte_1_displayName = "Unknown (byte) 1";
        public const int Unknown_byte_1_sortIndex = 800;
        [SortOrder(Unknown_byte_1_sortIndex)]
        [DisplayName(Unknown_byte_1_displayName)]
        public virtual byte Unknown_byte_1 {
            get => GetData<byte>(31);
            set {
                if (GetData<byte>(31) == value) return;
                SetData(31, value, nameof(Unknown_byte_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_byte_1));
            }
        }

        public const string GMD_Name_Index_displayName = "GMD Name Index";
        public const int GMD_Name_Index_sortIndex = 850;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        public virtual ushort GMD_Name_Index {
            get => GetData<ushort>(34);
        }

        public const string GMD_Description_Index_displayName = "GMD Description Index";
        public const int GMD_Description_Index_sortIndex = 900;
        [SortOrder(GMD_Description_Index_sortIndex)]
        [DisplayName(GMD_Description_Index_displayName)]
        public virtual ushort GMD_Description_Index {
            get => GetData<ushort>(36);
        }

        public const int lastSortIndex = 950;
    }
}