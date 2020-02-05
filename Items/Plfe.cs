using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class Plfe : MhwItem {
        public Plfe(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}