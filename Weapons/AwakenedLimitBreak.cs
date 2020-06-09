using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class AwakenedLimitBreak : MhwMultiStructItem<AwakenedLimitBreak>, IShowAsSingleStruct<AwakenedLimitBreak.Entries> {
        public partial class Entries {
            public string Name => DataHelper.awakeningNames[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.awakeningDescriptions[MainWindow.locale].TryGet((uint) Index);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}