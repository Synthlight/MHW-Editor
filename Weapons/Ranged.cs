using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public abstract partial class Ranged : MhwItem, IWeapon, ISlots {
        private readonly string weaponFilename;

        protected Ranged(byte[] bytes, ulong offset, string weaponFilename) : base(bytes, offset) {
            this.weaponFilename = weaponFilename;
        }

        public override string Name => DataHelper.weaponData[MainWindow.locale][weaponFilename].TryGet(GMD_Name_Index);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.weaponData[MainWindow.locale][weaponFilename].TryGet(GMD_Description_Index).Replace("\r\n", " ");

        [SortOrder(Is_Fixed_Upgrade_Raw_sortIndex)]
        [DisplayName("Is Fixed Upgrade")]
        public bool Is_Fixed_Upgrade {
            get => Convert.ToBoolean(Is_Fixed_Upgrade_Raw);
            set {
                Is_Fixed_Upgrade_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Is_Fixed_Upgrade));
            }
        }
    }
}