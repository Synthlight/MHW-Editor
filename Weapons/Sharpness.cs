using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Sharpness : MhwItem {
        public Sharpness(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string UniqueId => $"{Id}";

        public override string Name => "None";
    }
}