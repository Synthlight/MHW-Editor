using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class CustomParts {
        public const uint StructSize = 25;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = "PCEBFfRCbwIdy6AZIoNA5lXV6FEki0yBEyW4FPXZUyWgeauqY8PYeZkM";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        public virtual uint Index {
            get => GetData<uint>(0);
        }

        public const string Weapon_Type_displayName = "Weapon Type";
        public const int Weapon_Type_sortIndex = 100;
        [SortOrder(Weapon_Type_sortIndex)]
        [DisplayName(Weapon_Type_displayName)]
        public virtual MHW_Template.Weapons.WeaponType Weapon_Type {
            get => (MHW_Template.Weapons.WeaponType) GetData<uint>(4);
            set {
                if ((MHW_Template.Weapons.WeaponType) GetData<uint>(4) == value) return;
                SetData(4, (uint) value, nameof(Weapon_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Weapon_Type));
            }
        }

        public const string Augment_Id_displayName = "Augment Id";
        public const int Augment_Id_sortIndex = 150;
        [SortOrder(Augment_Id_sortIndex)]
        [DisplayName(Augment_Id_displayName)]
        public virtual uint Augment_Id {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Augment_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Augment_Id));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 200;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual byte Unk3 {
            get => GetData<byte>(12);
            set {
                if (GetData<byte>(12) == value) return;
                SetData(12, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Craft_Cost_displayName = "Craft Cost";
        public const int Craft_Cost_sortIndex = 250;
        [SortOrder(Craft_Cost_sortIndex)]
        [DisplayName(Craft_Cost_displayName)]
        public virtual uint Craft_Cost {
            get => GetData<uint>(13);
            set {
                if (GetData<uint>(13) == value) return;
                SetData(13, value, nameof(Craft_Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Craft_Cost));
            }
        }

        public const string Attack_displayName = "Attack";
        public const int Attack_sortIndex = 300;
        [SortOrder(Attack_sortIndex)]
        [DisplayName(Attack_displayName)]
        public virtual ushort Attack {
            get => GetData<ushort>(17);
            set {
                if (GetData<ushort>(17) == value) return;
                SetData(17, value, nameof(Attack));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Attack));
            }
        }

        public const string Defense_displayName = "Defense";
        public const int Defense_sortIndex = 350;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public virtual ushort Defense {
            get => GetData<ushort>(19);
            set {
                if (GetData<ushort>(19) == value) return;
                SetData(19, value, nameof(Defense));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Defense));
            }
        }

        public const string Affinity_displayName = "Affinity";
        public const int Affinity_sortIndex = 400;
        [SortOrder(Affinity_sortIndex)]
        [DisplayName(Affinity_displayName)]
        public virtual byte Affinity {
            get => GetData<byte>(21);
            set {
                if (GetData<byte>(21) == value) return;
                SetData(21, value, nameof(Affinity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity));
            }
        }

        public const string Element_displayName = "Element";
        public const int Element_sortIndex = 450;
        [SortOrder(Element_sortIndex)]
        [DisplayName(Element_displayName)]
        public virtual byte Element {
            get => GetData<byte>(22);
            set {
                if (GetData<byte>(22) == value) return;
                SetData(22, value, nameof(Element));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element));
            }
        }

        public const int lastSortIndex = 500;
    }
}