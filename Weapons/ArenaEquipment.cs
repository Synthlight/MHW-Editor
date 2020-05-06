using MHW_Editor.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Weapons {
    public partial class ArenaEquipment : MhwMultiStructItem<ArenaEquipment> {
        public partial class Entries : IHasWeaponType {
            public WeaponType GetWeaponType() {
                return Weapon_Type;
            }
        }
    }
}