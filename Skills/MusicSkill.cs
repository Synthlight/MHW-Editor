using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class MusicSkill : MhwItem {
        public MusicSkill(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(Song_Id_Raw_sortIndex)]
        [DisplayName("Song/Id")]
        [CustomSorter(typeof(MusicSkillSorter), true)]
        public IdNamePair Song_Id => DataHelper.songData[MainWindow.locale].TryGet((ushort) Song_Id_Raw, IdNamePair.Unknown((ushort) Song_Id_Raw));
    }

    public class MusicSkillSorter : ICustomSorterWithPropertyName {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;
        public string PropertyName { get; set; }

        public int Compare(object x, object y) {
            if (x is MusicSkill x1 && y is MusicSkill x2) {
                if (MainWindow.showIdBeforeName) {
                    return x1.Song_Id.id.CompareTo(x2.Song_Id.id) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                } else {
                    var nameCompare = string.Compare(x1.Song_Id.name, x2.Song_Id.name, StringComparison.Ordinal) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                    var idCompare = x1.Song_Id.id.CompareTo(x2.Song_Id.id) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);

                    return nameCompare == 0 ? idCompare : nameCompare;
                }
            }

            return 0;
        }
    }
}