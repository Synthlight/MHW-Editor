using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Misc {
    public partial class Food : MhwSingleStructFile<Food, Food.Entries> {
        public partial class Entries {
            public string Name => DataHelper.foodNames[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.foodDescriptions[MainWindow.locale].TryGet((uint) Index);
        }
    }
}