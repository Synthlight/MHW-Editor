
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class WeaponGunLance {
        public const uint StructSize = 8;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Id")]
        public uint Id {
            get => GetData<uint>(0);
        }
        [DisplayName("Shell Type")]
        public MHW_Template.Weapons.ShellType Shell_Type {
            get => (MHW_Template.Weapons.ShellType) GetData<ushort>(4);
            set {
                SetData(4, (ushort) value);
                OnPropertyChanged(nameof(Shell_Type));
            }
        }
        [DisplayName("Shell Level")]
        public ushort Shell_Level {
            get => GetData<ushort>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Shell_Level));
            }
        }
    }
}