using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class AwakenedLimitBreakR : MhwSingleStructFile<AwakenedLimitBreakR, AwakenedLimitBreakR.Entries> {
        public partial class Entries {
            public string Name => DataHelper.awakeningNames[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.awakeningDescriptions[MainWindow.locale].TryGet((uint) Index);
        }
    }
}