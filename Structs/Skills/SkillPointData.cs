using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Skills {
    public partial class SkillPointData : MhwSingleStructFile<SkillPointData, SkillPointData.Entries> {
        public partial class Entries {
            public string Name => DataHelper.skillNames[MainWindow.locale].TryGet((uint) Id);

            public ulong Id => Index;
        }
    }
}