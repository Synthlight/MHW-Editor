using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class CustomParts : MhwMultiStructItem<CustomParts>, IShowAsSingleStruct<CustomParts.Entries> {
        public partial class Entries {
            public string Name => DataHelper.customPartsNames[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.customPartsDescriptions[MainWindow.locale].TryGet((uint) Index);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}