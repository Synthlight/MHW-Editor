using MHW_Editor.Models;
using MHW_Template.Items;

namespace MHW_Editor.Structs.Items {
    public partial class ShopSed : MhwSingleStructFile<ShopSed, ShopSed.Entries> {
        public partial class Entries : IHasEquipmentType {
            public EquipmentType GetEquipmentType() {
                return Equip_Type;
            }
        }
    }
}