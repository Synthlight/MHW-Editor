using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class CustomParts : MhwSingleStructFile<CustomParts, CustomParts.Entries> {
        public partial class Entries {
            public string Name => DataHelper.customPartsNames[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.customPartsDescriptions[MainWindow.locale].TryGet((uint) Index);
        }
    }
}