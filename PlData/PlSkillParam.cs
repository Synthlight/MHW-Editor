using MHW_Editor.Models;

namespace MHW_Editor.PlData {
    public partial class PlSkillParam : MhwItem, IHasCustomView<PlDataItemCustomView> {
        public PlSkillParam(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}