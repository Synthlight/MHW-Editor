using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class SwapEnemyRate : MhwItem {
        public SwapEnemyRate(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}