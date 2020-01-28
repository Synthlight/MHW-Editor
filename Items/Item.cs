using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class Item : MhwItem {
        public Item(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData[MainWindow.locale].TryGet(Id * 2, "Unknown");
    }
}