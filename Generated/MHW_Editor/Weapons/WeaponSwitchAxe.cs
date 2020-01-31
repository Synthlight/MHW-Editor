
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class WeaponSwitchAxe {
        public const uint StructSize = 7;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
        }
        protected const string Unknown_1_uint8__displayName = "Unknown 1 (uint8)";
        protected const int Unknown_1_uint8__sortIndex = 100;
        [SortOrder(Unknown_1_uint8__sortIndex)]
        [DisplayName(Unknown_1_uint8__displayName)]
        public byte Unknown_1_uint8_ {
            get => GetData<byte>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Unknown_1_uint8_));
            }
        }
        protected const string Unknown_2_uint16__displayName = "Unknown 2 (uint16)";
        protected const int Unknown_2_uint16__sortIndex = 150;
        [SortOrder(Unknown_2_uint16__sortIndex)]
        [DisplayName(Unknown_2_uint16__displayName)]
        public ushort Unknown_2_uint16_ {
            get => GetData<ushort>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Unknown_2_uint16_));
            }
        }
    }
}