using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class MusicSkill : MhwMultiStructItem<MusicSkill>, IShowAsSingleStruct<MusicSkill.Entries> {
        public partial class Entries {
            [SortOrder(Song_Id_Raw_sortIndex)]
            [DisplayName("Song/Id")]
            [CustomSorter(typeof(MusicSkillSorter))]
            public string Song_And_Id => Name.ToStringWithId(Song_Id_Raw);

            [DisplayName("")]
            public string Name => DataHelper.songNames.TryGet(Song_Id_Raw);
        }

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }

    public class MusicSkillSorter : ICustomSorterWithPropertyName {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;
        public string            PropertyName  { get; set; }

        public int Compare(object x, object y) {
            if (x is MusicSkill.Entries x1 && y is MusicSkill.Entries x2) {
                if (MainWindow.showIdBeforeName) {
                    return x1.Song_Id_Raw.CompareTo(x2.Song_Id_Raw) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                } else {
                    var nameCompare = string.Compare(x1.Name, x2.Name, StringComparison.Ordinal) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                    var idCompare   = x1.Song_Id_Raw.CompareTo(x2.Song_Id_Raw) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);

                    return nameCompare == 0 ? idCompare : nameCompare;
                }
            }

            return 0;
        }
    }
}