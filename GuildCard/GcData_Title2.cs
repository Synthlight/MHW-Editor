using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.GuildCard {
    public class GcData_Title2 : GcData {
        public GcData_Title2(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("Name")]
        public override string Name => DataHelper.gcTitles2Gmd[MainWindow.locale].TryGet((uint) Index * 2);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.gcTitles2Gmd[MainWindow.locale].TryGet((uint) Index * 2 + 1).Replace("\r\n", " ");
    }
}