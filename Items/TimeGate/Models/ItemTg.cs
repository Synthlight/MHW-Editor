using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items.TimeGate.Models {
    public class ItemTg : MhwStructItem {
        [SortOrder(25)]
        [DisplayName("Unlock Day")]
        [IsReadOnly]
        public DateTime unlockTime { get; set; }

        [SortOrder(100)]
        [DisplayName("Item Id")]
        [DataSource(DataSourceType.Items)]
        [IsReadOnly]
        public uint itemId { get; set; }

        [SortOrder(150)]
        [DisplayName("Item Id")]
        [CustomSorter(typeof(ButtonSorter))]
        public string itemId_button => DataHelper.itemNames[MainWindow.locale].TryGet(itemId).ToStringWithId(itemId);
    }
}