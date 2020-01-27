using MHW_Template.Weapons;

namespace MHW_Editor.Weapons {
    public class BowGun : Ranged {
        public BowGun(byte[] bytes, ulong offset, string weaponFilename) : base(bytes, offset, weaponFilename) {
        }

        public new SpecialAmmo Special_Ammo_Type {
            get => (SpecialAmmo) base.Special_Ammo_Type;
            set => base.Special_Ammo_Type = (byte) value;
        }
    }
}