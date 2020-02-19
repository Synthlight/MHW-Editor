using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class Bounty : MhwItem {
        public Bounty(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.bountyData[MainWindow.locale].TryGet(Id, "Unknown");

        [SortOrder(lastSortIndex + 1)]
        [DisplayName("Description")]
        public string Description => DataHelper.bountyDataDescriptions[MainWindow.locale].TryGet(Id, "Unknown").Replace("\r\n", " ");

        [SortOrder(Item_Id_1_sortIndex)]
        [DisplayName(Item_Id_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_Id_1_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id_1, IdNamePair.Unknown((ushort) Item_Id_1)).ToString();

        [SortOrder(Item_Id_2_sortIndex)]
        [DisplayName(Item_Id_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_Id_2_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id_2, IdNamePair.Unknown((ushort) Item_Id_2)).ToString();

        [SortOrder(Item_Id_3_sortIndex)]
        [DisplayName(Item_Id_3_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_Id_3_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id_3, IdNamePair.Unknown((ushort) Item_Id_3)).ToString();
    }
}