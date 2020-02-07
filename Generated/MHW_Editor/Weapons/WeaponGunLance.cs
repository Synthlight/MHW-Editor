using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class WeaponGunLance {
        public const uint StructSize = 8;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
        }

        public const string Shell_Type_displayName = "Shell Type";
        public const int Shell_Type_sortIndex = 100;
        [SortOrder(Shell_Type_sortIndex)]
        [DisplayName(Shell_Type_displayName)]
        public MHW_Template.Weapons.ShellType Shell_Type {
            get => (MHW_Template.Weapons.ShellType) GetData<ushort>(4);
            set {
                if ((MHW_Template.Weapons.ShellType) GetData<ushort>(4) == value) return;
                SetData(4, (ushort) value);
                OnPropertyChanged(nameof(Shell_Type));
            }
        }

        public const string Shell_Level_displayName = "Shell Level";
        public const int Shell_Level_sortIndex = 150;
        [SortOrder(Shell_Level_sortIndex)]
        [DisplayName(Shell_Level_displayName)]
        public ushort Shell_Level {
            get => GetData<ushort>(6);
            set {
                if (GetData<ushort>(6) == value) return;
                SetData(6, value);
                OnPropertyChanged(nameof(Shell_Level));
            }
        }
    }
}