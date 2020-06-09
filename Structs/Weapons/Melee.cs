using System.Diagnostics.CodeAnalysis;
using System.IO;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class Melee : MhwSingleStructFile<Melee, Melee.Entries> {
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
        }
    }
}