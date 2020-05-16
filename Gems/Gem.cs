using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwItem {
        public Gem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.itemDescriptions[MainWindow.locale].TryGet(Id);
    }
}