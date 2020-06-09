using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class OtomoArmorDat : MhwMultiStructItem<OtomoArmorDat>, IShowAsSingleStruct<OtomoArmorDat.Entries> {
        public partial class Entries {
            public string Name => DataHelper.otomoArmorData[MainWindow.locale].TryGet(GMD_Name_Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.otomoArmorData[MainWindow.locale].TryGet(GMD_Description_Index).Replace("\r\n", " ");
        }


        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}