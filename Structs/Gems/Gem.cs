using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Gems {
    public partial class Gem : MhwSingleStructFile<Gem, Gem.Entries> {
        public partial class Entries {
            public const int Index_sortIndex = Id_sortIndex - 1;

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.itemDescriptions[MainWindow.locale].TryGet(Id);
        }
    }
}