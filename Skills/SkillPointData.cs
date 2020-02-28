using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class SkillPointData : MhwItem {
        public SkillPointData(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(0)]
        [DisplayName("Name/Id")]
        [CustomSorter(typeof(SkillPointDataNameIdSorter))]
        public string Name_And_Id => Name.ToStringWithId(Id);

        [DisplayName("")]
        public override string Name => DataHelper.skillNames[MainWindow.locale].TryGet((uint) Id);

        [SortOrder(0)]
        [DisplayName("")]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }

    public class SkillPointDataNameIdSorter : ICustomSorter {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is SkillPointData x1 && y is SkillPointData x2) {
                if (MainWindow.showIdBeforeName) {
                    return x1.Id.CompareTo(x2.Id) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                } else {
                    return string.Compare(x1.Name, x2.Name, StringComparison.Ordinal) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                }
            }

            return 0;
        }
    }
}