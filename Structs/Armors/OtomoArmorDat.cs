using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Armors {
    public partial class OtomoArmorDat : MhwSingleStructFile<OtomoArmorDat, OtomoArmorDat.Entries> {
        public partial class Entries {
            public string Name => DataHelper.otomoArmorData[MainWindow.locale].TryGet(GMD_Name_Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.otomoArmorData[MainWindow.locale].TryGet(GMD_Description_Index).Replace("\r\n", " ");
        }
    }
}