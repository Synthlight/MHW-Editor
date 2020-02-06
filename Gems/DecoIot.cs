using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Skills;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class DecoIot : MhwItem {
        public DecoIot(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(0)]
        [DisplayName("Name/Id")]
        [CustomSorter(typeof(DecoIotNameIdSorter))]
        public IdNamePair Name_And_Id => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id, IdNamePair.Unknown((ushort) Item_Id));

        public override string Name => "None";
    }

    public class DecoIotNameIdSorter : ICustomSorter {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is DecoIot x1 && y is DecoIot x2) {
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