using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class ArmUp : MhwItem {
        public ArmUp(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Rarity => (Offset - InitialOffset) / StructSize;
    }
}