using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class BottleTable : MhwItem {
        public BottleTable(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}