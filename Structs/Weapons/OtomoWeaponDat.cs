using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class OtomoWeaponDat : MhwSingleStructFile<OtomoWeaponDat, OtomoWeaponDat.Entries> {
        public partial class Entries {
            public const int Id_sortIndex = Set_Id_sortIndex - 1;

            public string Name => DataHelper.otomoWeaponData[MainWindow.locale].TryGet(GMD_Name_Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.otomoWeaponData[MainWindow.locale].TryGet(GMD_Description_Index).Replace("\r\n", " ");
        }
    }
}