
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class WeaponSwitchAxe {
        public const uint StructSize = 7;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Id")]
        public uint Id {
            get => GetData<uint>(0);
        }
        [DisplayName("Unknown 1 (uint8)")]
        public byte Unknown_1_uint8_ {
            get => GetData<byte>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Unknown_1_uint8_));
            }
        }
        [DisplayName("Unknown 2 (uint16)")]
        public ushort Unknown_2_uint16_ {
            get => GetData<ushort>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Unknown_2_uint16_));
            }
        }
    }
}