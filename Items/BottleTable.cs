using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class BottleTable : MhwItem, IMhwItem {
        public BottleTable(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        public int Id => (Offset - InitialOffset) / 6;
    }
}