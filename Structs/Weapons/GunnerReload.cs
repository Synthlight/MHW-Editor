using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class GunnerReload : MhwMultiStructItem<GunnerReload>, IShowAsSingleStruct<GunnerReload.Entries> {
        public static readonly Dictionary<byte, string> reloadLookup = new Dictionary<byte, string> {
            {0, "Fast"},
            {1, "Normal"},
            {2, "Slow"},
            {3, "Very Slow"}
        };

        public partial class Entries {
            [SortOrder(20)]
            public ulong Id => Index;
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}