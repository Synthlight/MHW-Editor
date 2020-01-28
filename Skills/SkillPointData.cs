using MHW_Editor.Models;

namespace MHW_Editor.Skills {
    public partial class SkillPointData : MhwItem {
        public SkillPointData(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}