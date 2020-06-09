using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Skills {
    public partial class SkillPointData : MhwSingleStructFile<SkillPointData, SkillPointData.Entries> {
        public partial class Entries {
            [SortOrder(0)]
            [DisplayName("Name/Id")]
            [CustomSorter(typeof(SkillPointDataNameIdSorter))]
            public string Name_And_Id => Name.ToStringWithId(Id);

            [DisplayName("")]
            public string Name => DataHelper.skillNames[MainWindow.locale].TryGet((uint) Id);

            [SortOrder(0)]
            [DisplayName("")]
            public ulong Id => Index;
        }
    }

    public class SkillPointDataNameIdSorter : ICustomSorter {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is SkillPointData.Entries x1 && y is SkillPointData.Entries x2) {
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