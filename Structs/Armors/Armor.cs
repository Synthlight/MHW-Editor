using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Armors {
    public partial class Armor : MhwMultiStructItem<Armor>, IShowAsSingleStruct<Armor.Entries> {
        public partial class Entries : ISlots {
            public string Name => DataHelper.armorData[MainWindow.locale].TryGet(GMD_Name_Index);

            [SortOrder(lastSortIndex + 1)]
            public string Description => DataHelper.armorData[MainWindow.locale].TryGet(GMD_Description_Index).Replace("\r\n", " ");
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}