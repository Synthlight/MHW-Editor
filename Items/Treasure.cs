using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class Treasure : MhwItem {
        public Treasure(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}