using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Armors {
    public partial class ASkill : MhwMultiStructItem<ASkill>, IShowAsSingleStruct<ASkill.Entries> {
        public partial class Entries {
            public const int Mantle_Id_sortIndex = Icon_Id_sortIndex - 1;

            public string Name => DataHelper.mantleNames[MainWindow.locale].TryGet((ushort) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.mantleDescriptions[MainWindow.locale].TryGet((ushort) Index);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}