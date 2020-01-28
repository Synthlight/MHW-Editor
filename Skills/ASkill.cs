using MHW_Editor.Models;

namespace MHW_Editor.Skills {
    public partial class ASkill : MhwItem {
        public ASkill(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}