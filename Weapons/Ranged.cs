using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Ranged : MhwItem, IWeapon, ISlots {
        private readonly string weaponFilename;

        public Ranged(byte[] bytes, ulong offset, string weaponFilename) : base(bytes, offset) {
            this.weaponFilename = weaponFilename;
        }

        public override string Name => DataHelper.weaponData[MainWindow.locale][weaponFilename][GMD_Name_Index];

        [SortOrder(Is_Fixed_Upgrade_Raw_sortIndex)]
        [DisplayName("Is Fixed Upgrade")]
        public bool Is_Fixed_Upgrade {
            get => Convert.ToBoolean(Is_Fixed_Upgrade_Raw);
            set => Is_Fixed_Upgrade_Raw = Convert.ToByte(value);
        }

        [SortOrder(Skill_sortIndex)]
        [DisplayName(Skill_displayName)]
        public string Skill_button => DataHelper.skillData[MainWindow.locale][Skill].ToString();
    }
}