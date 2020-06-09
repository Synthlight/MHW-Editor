using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Models;
using MHW_Template.Items;

namespace MHW_Editor.Structs.Items {
    public partial class ShopSed : MhwMultiStructItem<ShopSed>, IShowAsSingleStruct<ShopSed.Entries> {
        public partial class Entries : IHasEquipmentType {
            public EquipmentType GetEquipmentType() {
                return Equip_Type;
            }
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}