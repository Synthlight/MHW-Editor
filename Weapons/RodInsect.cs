using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class RodInsect : MhwItem {
        public RodInsect(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}