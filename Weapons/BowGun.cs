using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Weapons {
    public class BowGun : Ranged {
        public BowGun(byte[] bytes, ulong offset, string weaponFilename) : base(bytes, offset, weaponFilename) {
        }

        [SortOrder(Special_Ammo_Type_sortIndex)]
        [DisplayName(Special_Ammo_Type_displayName)]
        public new SpecialAmmo Special_Ammo_Type {
            get => (SpecialAmmo) base.Special_Ammo_Type;
            set {
                base.Special_Ammo_Type = (byte) value;
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Special_Ammo_Type));
            }
        }
    }
}