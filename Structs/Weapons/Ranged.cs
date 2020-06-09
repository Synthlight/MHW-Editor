using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Weapons;

namespace MHW_Editor.Structs.Weapons {
    public partial class Ranged : MhwSingleStructFile<Ranged, Ranged.Entries> {
        public void Init(string targetFile) {
            var target = Path.GetFileNameWithoutExtension(targetFile);
            foreach (var entry in GetSingleStructList()) {
                entry.Init(target);
            }
        }

        public partial class Entries : IWeapon, ISlots {
            public const int Id_sortIndex      = Index_sortIndex + 1;
            public const int Tree_Id_sortIndex = Tree_Position_sortIndex - 1;

            private string targetFile;

            [SuppressMessage("ReSharper", "ParameterHidesMember")]
            public void Init(string targetFile) {
                this.targetFile = targetFile;
            }

            public string Name => DataHelper.weaponData[MainWindow.locale][targetFile].TryGet(GMD_Name_Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.weaponData[MainWindow.locale][targetFile].TryGet(GMD_Description_Index).Replace("\r\n", " ");

            [SortOrder(Special_Ammo_Type_sortIndex)]
            [DisplayName(Special_Ammo_Type_displayName)]
            public SpecialAmmo Special_Ammo_Type_BowGun {
                get => (SpecialAmmo) Special_Ammo_Type;
                set {
                    Special_Ammo_Type = (byte) value;
                    OnPropertyChanged(nameof(Special_Ammo_Type_BowGun));
                }
            }
        }

        public static bool ShouldCancel(string propertyName, MainWindow mainWindow) {
            var isBowGun = mainWindow.Title.StartsWith("hbg") || mainWindow.Title.StartsWith("lbg");
            var isBow    = mainWindow.Title.StartsWith("bow");

            switch (propertyName) {
                case nameof(Entries.Special_Ammo_Type):
                    return isBowGun;
                case nameof(Entries.Special_Ammo_Type_BowGun):
                    return !isBowGun;
                case nameof(Entries.Barrel_Type):
                case nameof(Entries.Deviation):
                case nameof(Entries.Magazine_Type):
                case nameof(Entries.Muzzle_Type):
                case nameof(Entries.Scope_Type):
                case nameof(Entries.Shell_Type_Id):
                    return !isBow;
                default: return false;
            }
        }
    }
}