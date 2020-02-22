
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
        public virtual uint Id {
            get => GetData<uint>(0);
        }

        public const string Unknown_1_uint8__displayName = "Unknown 1 (uint8)";
        public const int Unknown_1_uint8__sortIndex = 100;
        [SortOrder(Unknown_1_uint8__sortIndex)]
        [DisplayName(Unknown_1_uint8__displayName)]
        public virtual byte Unknown_1_uint8_ {
            get => GetData<byte>(4);
            set {
                if (GetData<byte>(4) == value) return;
                SetData(4, value, nameof(Unknown_1_uint8_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_1_uint8_));
            }
        }

        public const string Unknown_2_uint16__displayName = "Unknown 2 (uint16)";
        public const int Unknown_2_uint16__sortIndex = 150;
        [SortOrder(Unknown_2_uint16__sortIndex)]
        [DisplayName(Unknown_2_uint16__displayName)]
        public virtual ushort Unknown_2_uint16_ {
            get => GetData<ushort>(5);
            set {
                if (GetData<ushort>(5) == value) return;
                SetData(5, value, nameof(Unknown_2_uint16_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_2_uint16_));
            }
        }

        public const int lastSortIndex = 200;
    }
}