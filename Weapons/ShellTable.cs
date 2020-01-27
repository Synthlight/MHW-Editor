using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable : MhwItem {
        public ShellTable(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}