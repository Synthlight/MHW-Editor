using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwMultiStructItem<Gem>, IShowAsSingleStruct<Gem.Entries> {
        public partial class Entries {
            public const int Index_sortIndex = Id_sortIndex - 1;

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.itemDescriptions[MainWindow.locale].TryGet(Id);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}