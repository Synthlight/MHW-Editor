using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class RodInsect : MhwSingleStructFile<RodInsect, RodInsect.Entries> {
        public partial class Entries {
            public const int Tree_Position_Id_sortIndex = Tree_Position_sortIndex - 2;
            public const int Tree_Id_sortIndex          = Tree_Position_sortIndex - 1;

            public string Name => DataHelper.kinsectNames[MainWindow.locale].TryGet((byte) Index);
        }
    }
}