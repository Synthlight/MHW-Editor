using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class Bounty : MhwItem {
        public Bounty(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.bountyNames[MainWindow.locale].TryGet(Id);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.bountyDescriptions[MainWindow.locale].TryGet(Id);
    }
}