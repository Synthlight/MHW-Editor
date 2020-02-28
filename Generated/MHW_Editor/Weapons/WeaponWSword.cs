using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class WeaponWSword {
        public const uint StructSize = 10;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual uint Id {
            get => GetData<uint>(0);
        }

        public const string Element_1_Type_displayName = "Element 1 Type";
        public const int Element_1_Type_sortIndex = 100;
        [SortOrder(Element_1_Type_sortIndex)]
        [DisplayName(Element_1_Type_displayName)]
        public virtual MHW_Template.Weapons.Element Element_1_Type {
            get => (MHW_Template.Weapons.Element) GetData<byte>(4);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(4) == value) return;
                SetData(4, (byte) value, nameof(Element_1_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_1_Type));
            }
        }

        public const string Element_1_Dmg_displayName = "Element 1 Dmg";
        public const int Element_1_Dmg_sortIndex = 150;
        [SortOrder(Element_1_Dmg_sortIndex)]
        [DisplayName(Element_1_Dmg_displayName)]
        public virtual short Element_1_Dmg {
            get => GetData<short>(5);
            set {
                if (GetData<short>(5) == value) return;
                SetData(5, value, nameof(Element_1_Dmg));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_1_Dmg));
            }
        }

        public const string Element_2_Type_displayName = "Element 2 Type";
        public const int Element_2_Type_sortIndex = 200;
        [SortOrder(Element_2_Type_sortIndex)]
        [DisplayName(Element_2_Type_displayName)]
        public virtual MHW_Template.Weapons.Element Element_2_Type {
            get => (MHW_Template.Weapons.Element) GetData<byte>(7);
            set {
                if ((MHW_Template.Weapons.Element) GetData<byte>(7) == value) return;
                SetData(7, (byte) value, nameof(Element_2_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_2_Type));
            }
        }

        public const string Element_2_Dmg_displayName = "Element 2 Dmg";
        public const int Element_2_Dmg_sortIndex = 250;
        [SortOrder(Element_2_Dmg_sortIndex)]
        [DisplayName(Element_2_Dmg_displayName)]
        public virtual short Element_2_Dmg {
            get => GetData<short>(8);
            set {
                if (GetData<short>(8) == value) return;
                SetData(8, value, nameof(Element_2_Dmg));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element_2_Dmg));
            }
        }

        public const int lastSortIndex = 300;
    }
}