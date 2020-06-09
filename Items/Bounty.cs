using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class Bounty : MhwMultiStructItem<Bounty>, IShowAsSingleStruct<Bounty.Entries> {
        public partial class Entries {
            public string Name => DataHelper.bountyNames[MainWindow.locale].TryGet(Id);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.bountyDescriptions[MainWindow.locale].TryGet(Id);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}