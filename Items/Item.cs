namespace MHW_Editor.Items {
    public partial class Item : MhwItem, IMhwItem {
        public Item(byte[] bytes, int offset) : base(bytes, offset) {
        }
    }
}