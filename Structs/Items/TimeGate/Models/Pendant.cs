using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Items.TimeGate.Models {
    public class Pendant : MhwStructItem {
        [SortOrder(25)]
        [DisplayName("Unlock Day")]
        [IsReadOnly]
        public DateTime unlockTime { get; set; }

        [SortOrder(100)]
        [DisplayName("Pendant Id")]
        [DataSource(DataSourceType.Pendants)]
        [IsReadOnly]
        public uint pendantId { get; set; }

        [SortOrder(150)]
        [DisplayName("Pendant Id")]
        [CustomSorter(typeof(ButtonSorter))]
        public string pendantId_button => DataHelper.pendantNames[MainWindow.locale].TryGet(pendantId).ToStringWithId(pendantId);
    }
}