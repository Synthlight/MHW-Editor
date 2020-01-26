using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Sharpness : MhwItem {
        public Sharpness(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}