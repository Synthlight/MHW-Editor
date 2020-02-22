using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class ItemList : MhwItem {
        public ItemList(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}