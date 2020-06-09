using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class CustomPartsR : MhwMultiStructItem<CustomPartsR>, IShowAsSingleStruct<CustomPartsR.Entries> {
        public partial class Entries {
            public const int Id_sortIndex = Weapon_Type_sortIndex - 1;

            public string Name => DataHelper.customPartsRecipeNames[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.customPartsRecipeDescriptions[MainWindow.locale].TryGet((uint) Index);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}