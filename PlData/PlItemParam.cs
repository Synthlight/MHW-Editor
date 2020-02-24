using MHW_Editor.Models;

namespace MHW_Editor.PlData {
    public partial class PlItemParam : MhwItem, IHasCustomView<PlItemCustomView> {
        public PlItemParam(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}