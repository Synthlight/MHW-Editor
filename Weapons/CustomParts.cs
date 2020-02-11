using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class CustomParts : MhwItem {
        public CustomParts(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}