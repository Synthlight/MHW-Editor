using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Structs.Items.TimeGate.Models {
    public class Weapon : MhwStructItem {
        [SortOrder(25)]
        [DisplayName("Unlock Day")]
        [IsReadOnly]
        public DateTime unlockTime { get; set; }

        [SortOrder(50)]
        [DisplayName("Weapon Category")]
        [IsReadOnly]
        public WeaponType weaponCategory { get; set; }

        [SortOrder(100)]
        [DisplayName("Weapon Id")]
        [DataSource(DataSourceType.WeaponsById)]
        [IsReadOnly]
        public uint weaponId { get; set; }

        [SortOrder(150)]
        [DisplayName("Weapon Id")]
        [CustomSorter(typeof(ButtonSorter))]
        public string weaponId_button => DataHelper.weaponIdNameLookup[weaponCategory][MainWindow.locale].TryGet(weaponId).ToStringWithId(weaponId);
    }
}