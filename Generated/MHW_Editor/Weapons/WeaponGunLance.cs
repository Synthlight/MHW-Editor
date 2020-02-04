
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class WeaponGunLance {
        public const uint StructSize = 8;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
        }
        protected const string Shell_Type_displayName = "Shell Type";
        protected const int Shell_Type_sortIndex = 100;
        [SortOrder(Shell_Type_sortIndex)]
        [DisplayName(Shell_Type_displayName)]
        public MHW_Template.Weapons.ShellType Shell_Type {
            get => (MHW_Template.Weapons.ShellType) GetData<ushort>(4);
            set {
                SetData(4, (ushort) value);
                OnPropertyChanged(nameof(Shell_Type));
            }
        }
        protected const string Shell_Level_displayName = "Shell Level";
        protected const int Shell_Level_sortIndex = 150;
        [SortOrder(Shell_Level_sortIndex)]
        [DisplayName(Shell_Level_displayName)]
        public ushort Shell_Level {
            get => GetData<ushort>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Shell_Level));
            }
        }
    }
}