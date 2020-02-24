using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class Bounty : MhwItem {
        public Bounty(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.bountyData[MainWindow.locale].TryGet(Id, "Unknown");

        [SortOrder(lastSortIndex + 1)]
        [DisplayName("Description")]
        public string Description => DataHelper.bountyDataDescriptions[MainWindow.locale].TryGet(Id, "Unknown");
    }
}