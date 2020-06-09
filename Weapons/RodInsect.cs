using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class RodInsect : MhwMultiStructItem<RodInsect>, IShowAsSingleStruct<RodInsect.Entries> {
        public partial class Entries {
            public const int Tree_Position_Id_sortIndex = Tree_Position_sortIndex - 2;
            public const int Tree_Id_sortIndex          = Tree_Position_sortIndex - 1;

            public string Name => DataHelper.kinsectNames[MainWindow.locale].TryGet((byte) Index);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}