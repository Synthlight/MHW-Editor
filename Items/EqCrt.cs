using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class EqCrt : MhwItem {
        public EqCrt(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}