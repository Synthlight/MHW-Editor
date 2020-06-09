using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class OtomoWeaponDat : MhwMultiStructItem<OtomoWeaponDat>, IShowAsSingleStruct<OtomoWeaponDat.Entries> {
        public partial class Entries {
            public const int Id_sortIndex = Set_Id_sortIndex - 1;

            public string Name => DataHelper.otomoWeaponData[MainWindow.locale].TryGet(GMD_Name_Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.otomoWeaponData[MainWindow.locale].TryGet(GMD_Description_Index).Replace("\r\n", " ");
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}