using MHW_Editor.Models;

namespace MHW_Editor.Armors {
    public partial class CharmDat : MhwItem {
        public CharmDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}