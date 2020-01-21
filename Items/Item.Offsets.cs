namespace MHW_Editor.Items {
    public partial class Item {
        public override string Name => DataHelper.rawItems.TryGet(Id, "Unknown");
    }
}