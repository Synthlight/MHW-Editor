using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Skills {
    public partial class CatSkill : MhwSingleStructFile<CatSkill, CatSkill.Entries> {
        public partial class Entries {
            public string Name => DataHelper.catSkillNames[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.catSkillDescriptions[MainWindow.locale].TryGet((uint) Index);
        }
    }
}