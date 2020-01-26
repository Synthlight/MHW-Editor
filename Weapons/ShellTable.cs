using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable : MhwItem {
        public ShellTable(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        public int Index => (Offset - InitialOffset) / StructSize;
    }
}