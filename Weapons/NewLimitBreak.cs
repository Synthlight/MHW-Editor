using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class NewLimitBreak : MhwItem {
        public NewLimitBreak(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string UniqueId => $"{Aug_Category}|{Aug_Level}";

        public override string Name => "None";
    }
}