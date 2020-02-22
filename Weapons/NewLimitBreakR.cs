using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class NewLimitBreakR : MhwItem {
        public NewLimitBreakR(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}