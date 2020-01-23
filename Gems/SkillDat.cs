using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class SkillDat : MhwItem, IMhwItem {
        public SkillDat(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.skillData.TryGet(Id, Id.ToString());
    }
}