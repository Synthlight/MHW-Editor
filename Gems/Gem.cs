using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwItem {
        public Gem(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData.TryGet((uint) (Id * 2), "Unknown");
    }
}