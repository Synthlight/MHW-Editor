using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class Item : MhwItem, IMhwItem {
        public Item(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.rawItems.TryGet(Id, "Unknown");
    }
}