using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public abstract partial class EqCus_Base : MhwItem {
        protected EqCus_Base(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}