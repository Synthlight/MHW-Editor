using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.GuildCard {
    public class GcData_Title1 : GcData {
        public GcData_Title1(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("Name")]
        public override string Name => DataHelper.gcTitles1Gmd[MainWindow.locale].TryGet((uint) Index * 2);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.gcTitles1Gmd[MainWindow.locale].TryGet((uint) Index * 2 + 1).Replace("\r\n", " ");
    }
}