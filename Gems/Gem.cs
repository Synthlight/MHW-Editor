using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwItem {
        public Gem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData[MainWindow.locale].TryGet(Id, IdNamePair.Unknown(Id)).name;
    }
}