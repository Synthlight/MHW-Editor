using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class Armor : MhwItem, ISlots {
        public Armor(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.armorData[MainWindow.locale].TryGet(GMD_Name_Index);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.armorData[MainWindow.locale].TryGet(GMD_Description_Index).Replace("\r\n", " ");
    }
}