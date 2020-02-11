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
        public IdNamePair Name_And_Id => DataHelper.skillData[MainWindow.locale].TryGet((ushort) Id, IdNamePair.Unknown((ushort) Id));

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;

        [SortOrder(Is_Set_Bonus_Raw_sortIndex)]
        [DisplayName("Is Set Bonus")]
        public bool Is_Set_Bonus {
            get => Convert.ToBoolean(Is_Set_Bonus_Raw);
            set {
                Is_Set_Bonus_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Is_Set_Bonus));
            }
        }
    }

    public class SkillPointDataNameIdSorter : ICustomSorter {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is SkillPointData x1 && y is SkillPointData x2) {
                if (MainWindow.showIdBeforeName) {
                    return x1.Name_And_Id.id.CompareTo(x2.Name_And_Id.id) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                } else {
                    return string.Compare(x1.Name_And_Id.name, x2.Name_And_Id.name, StringComparison.Ordinal) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                }
            }

            return 0;
        }
    }
}