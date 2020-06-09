using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class PendantData : MhwMultiStructItem<PendantData>, IShowAsSingleStruct<PendantData.Entries> {
        public partial class Entries {
            public string Name => DataHelper.pendantNames[MainWindow.locale].TryGet(Id);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}