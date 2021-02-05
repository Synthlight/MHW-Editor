using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Skills {
    public partial class SkillDat : MhwSingleStructFile<SkillDat, SkillDat.Entries> {
        public partial class Entries {
            [SortOrder(Param_8_sortIndex + 1)]
            public string Description => DataHelper.skillDescriptions[MainWindow.locale].TryGet(Id);
        }
    }
}