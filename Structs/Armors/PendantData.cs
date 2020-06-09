using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Armors {
    public partial class PendantData : MhwSingleStructFile<PendantData, PendantData.Entries> {
        public partial class Entries {
            public string Name => DataHelper.pendantNames[MainWindow.locale].TryGet(Id);
        }
    }
}