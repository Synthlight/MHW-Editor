using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class ArmUp : MhwItem, IMhwItem {
        public ArmUp(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}