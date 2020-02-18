using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class Odr : MhwItem {
        public Odr(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}