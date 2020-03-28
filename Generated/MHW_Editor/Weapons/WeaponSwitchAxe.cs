using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class WeaponSwitchAxe {
        public const uint StructSize = 7;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        [IsReadOnly]
        public virtual uint Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Id));
            }
        }

        public const string Phial_Type_displayName = "Phial Type";
        public const int Phial_Type_sortIndex = 100;
        [SortOrder(Phial_Type_sortIndex)]
        [DisplayName(Phial_Type_displayName)]
        public virtual MHW_Template.Weapons.PhialType Phial_Type {
            get => (MHW_Template.Weapons.PhialType) GetData<byte>(4);
            set {
                if ((MHW_Template.Weapons.PhialType) GetData<byte>(4) == value) return;
                SetData(4, (byte) value, nameof(Phial_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Phial_Type));
            }
        }

        public const string Phial_Amount_displayName = "Phial Amount";
        public const int Phial_Amount_sortIndex = 150;
        [SortOrder(Phial_Amount_sortIndex)]
        [DisplayName(Phial_Amount_displayName)]
        public virtual ushort Phial_Amount {
            get => GetData<ushort>(5);
            set {
                if (GetData<ushort>(5) == value) return;
                SetData(5, value, nameof(Phial_Amount));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Phial_Amount));
            }
        }

        public const int lastSortIndex = 200;
    }
}