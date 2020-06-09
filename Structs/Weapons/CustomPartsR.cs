using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class CustomPartsR : MhwSingleStructFile<CustomPartsR, CustomPartsR.Entries> {
        public partial class Entries {
            public const int Id_sortIndex = Weapon_Type_sortIndex - 1;

            public string Name => DataHelper.customPartsRecipeNames[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.customPartsRecipeDescriptions[MainWindow.locale].TryGet((uint) Index);
        }
    }
}