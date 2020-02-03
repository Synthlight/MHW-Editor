using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwItem {
        public Gem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData[MainWindow.locale][Id].name;
    }
}