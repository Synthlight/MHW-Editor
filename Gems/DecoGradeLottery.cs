using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Models;

namespace MHW_Editor.Gems {
    public partial class DecoGradeLottery : MhwMultiStructItem<DecoGradeLottery>, IShowAsSingleStruct<DecoGradeLottery.Entries> {
        public partial class Entries {
            public const int Stream_R6__sortIndex = Grade_9_sortIndex + 10;
            public const int Stream_R8__sortIndex = Stream_R6__sortIndex + 10;
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}