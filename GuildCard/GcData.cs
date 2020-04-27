using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.GuildCard {
    public partial class GcData : MhwItem {
        public GcData(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}