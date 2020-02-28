using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class OtomoArmorDat : MhwItem {
        public OtomoArmorDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.otomoArmorData[MainWindow.locale].TryGet(GMD_Name_Index);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.otomoArmorData[MainWindow.locale].TryGet(GMD_Description_Index).Replace("\r\n", " ");
    }
}