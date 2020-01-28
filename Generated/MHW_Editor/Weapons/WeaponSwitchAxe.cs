using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class WeaponSwitchAxe {
        public const uint StructSize = 7;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public uint Id {
            get => GetData<uint>(0);
        }
        public byte Unknown_1 {
            get => GetData<byte>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Unknown_1));
            }
        }
        public ushort Unknown_2 {
            get => GetData<ushort>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Unknown_2));
            }
        }
    }
}