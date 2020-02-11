using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class Ranged : MhwItem, IWeapon, ISlots {
        private readonly string weaponFilename;

        public Ranged(byte[] bytes, ulong offset, string weaponFilename) : base(bytes, offset) {
            this.weaponFilename = weaponFilename;
        }

        public override string UniqueId => $"{Id}";

        public override string Name => DataHelper.weaponData[MainWindow.locale][weaponFilename].TryGet(GMD_Name_Index, "Unknown");

        [SortOrder(lastSortIndex + 1)]
        [DisplayName("Description")]
        public string Description => DataHelper.weaponData[MainWindow.locale][weaponFilename].TryGet(GMD_Description_Index, "Unknown").Replace("\r\n", " ");

        [SortOrder(Is_Fixed_Upgrade_Raw_sortIndex)]
        [DisplayName("Is Fixed Upgrade")]
        public bool Is_Fixed_Upgrade {
            get => Convert.ToBoolean(Is_Fixed_Upgrade_Raw);
            set {
                Is_Fixed_Upgrade_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Is_Fixed_Upgrade));
            }
        }

        [SortOrder(Skill_sortIndex)]
        [DisplayName(Skill_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_button => DataHelper.skillData[MainWindow.locale].TryGet(Skill, IdNamePair.Unknown(Skill)).ToString();
    }
}