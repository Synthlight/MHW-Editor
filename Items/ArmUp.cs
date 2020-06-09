using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class ArmUp : MhwMultiStructItem<ArmUp>, IShowAsSingleStruct<ArmUp.Entries> {
        public partial class Entries {
            [SortOrder(20)]
            public ulong Rarity => Index;
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}