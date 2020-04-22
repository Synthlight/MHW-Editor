using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class SafiItemGradeLottery : MhwItem {
        public SafiItemGradeLottery(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(0)]
        [DisplayName("Name/Id")]
        [CustomSorter(typeof(SafiItemGradeLotteryNameIdSorter))]
        public string Name_And_Id => Name.ToStringWithId(Item_Id);

        [DisplayName("")]
        public override string Name => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id);
    }

    public class SafiItemGradeLotteryNameIdSorter : ICustomSorter {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is SafiItemGradeLottery x1 && y is SafiItemGradeLottery x2) {
                if (MainWindow.showIdBeforeName) {
                    return x1.Item_Id.CompareTo(x2.Item_Id) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                } else {
                    return string.Compare(x1.Name, x2.Name, StringComparison.Ordinal) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
                }
            }

            return 0;
        }
    }
}