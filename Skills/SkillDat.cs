using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class SkillDat : MhwItem {
        public SkillDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(0)]
        [DisplayName("Name/Id")]
        [CustomSorter(typeof(SkillDatNameIdSorter))]
        public string Name_And_Id => Name.ToStringWithId(Id);

        [DisplayName("")]
        public override string Name => DataHelper.skillNames[MainWindow.locale].TryGet(Id);

        [SortOrder(Param_8_sortIndex + 1)]
        public string Description => DataHelper.skillDescriptions[MainWindow.locale].TryGet(Id);

        [SortOrder(0)]
        [DisplayName("")]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }

    public class SkillDatNameIdSorter : ICustomSorter {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is SkillDat x1 && y is SkillDat x2) {
                if (MainWindow.showIdBeforeName) {
                    var idCompare    = x1.Id.CompareTo(x2.Id) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                    var levelCompare = x1.Level.CompareTo(x2.Level) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);

                    return idCompare == 0 ? levelCompare : idCompare;
                } else {
                    var nameCompare  = string.Compare(x1.Name, x2.Name, StringComparison.Ordinal) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                    var levelCompare = x1.Level.CompareTo(x2.Level) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);

                    return nameCompare == 0 ? levelCompare : nameCompare;
                }
            }

            return 0;
        }
    }
}