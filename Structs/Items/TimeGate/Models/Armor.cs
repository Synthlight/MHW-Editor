using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Armors;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Items.TimeGate.Models {
    public class Armor : MhwStructItem {
        [SortOrder(25)]
        [DisplayName("Unlock Day")]
        [IsReadOnly]
        public DateTime unlockTime { get; set; }

        [SortOrder(50)]
        [DisplayName("Equip Slot")]
        [IsReadOnly]
        public ArmorType armorType { get; set; }

        [SortOrder(100)]
        [DisplayName("Armor (Set) Id")]
        [DataSource(DataSourceType.ArmorById)]
        [IsReadOnly]
        public uint armorId { get; set; }

        [SortOrder(150)]
        [DisplayName("Armor (Set) Id")]
        [CustomSorter(typeof(ButtonSorter))]
        public string armorId_button => DataHelper.armorIdNameLookup[armorType][MainWindow.locale].TryGet(armorId).ToStringWithId(armorId);
    }
}