using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Items {
    public partial class Bounty : MhwSingleStructFile<Bounty, Bounty.Entries> {
        public partial class Entries {
            public string Name => DataHelper.bountyNames[MainWindow.locale].TryGet(Id);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.bountyDescriptions[MainWindow.locale].TryGet(Id);
        }
    }
}