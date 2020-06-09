using MHW_Editor.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Structs.Weapons {
    public partial class ArenaEquipment : MhwMultiStructFile<ArenaEquipment> {
        public partial class Entries : IHasWeaponType {
            public WeaponType GetWeaponType() {
                return Weapon_Type;
            }
        }
    }
}