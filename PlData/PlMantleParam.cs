using MHW_Editor.Models;

namespace MHW_Editor.PlData {
    public partial class PlMantleParam : MhwItem, IHasCustomView<PlDataItemCustomView> {
        public PlMantleParam(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}