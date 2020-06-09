using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class AwakenedExp : MhwMultiStructItem<AwakenedExp>, IShowAsSingleStruct<AwakenedExp.Entries> {
        public partial class Entries {
            [SortOrder(20)]
            public ulong Level => Index;
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}