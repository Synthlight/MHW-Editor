using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class MelderItem : MhwItem {
        public MelderItem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}