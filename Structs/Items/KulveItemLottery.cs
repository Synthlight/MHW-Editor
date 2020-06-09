using MHW_Editor.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Structs.Items {
    public partial class KulveItemLottery : MhwSingleStructFile<KulveItemLottery, KulveItemLottery.Entries> {
        public partial class Entries : IHasWeaponType {
            public WeaponType GetWeaponType() {
                return Weapon_Type;
            }
        }
    }
}