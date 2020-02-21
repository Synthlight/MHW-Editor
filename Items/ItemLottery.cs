using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class ItemLottery : MhwItem {
        public ItemLottery(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;

        [SortOrder(Item_1_Id_sortIndex)]
        [DisplayName(Item_1_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_1_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_1_Id, IdNamePair.Unknown(Item_1_Id)).ToString();

        [SortOrder(Item_2_Id_sortIndex)]
        [DisplayName(Item_2_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_2_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_2_Id, IdNamePair.Unknown(Item_2_Id)).ToString();

        [SortOrder(Item_3_Id_sortIndex)]
        [DisplayName(Item_3_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_3_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_3_Id, IdNamePair.Unknown(Item_3_Id)).ToString();

        [SortOrder(Item_4_Id_sortIndex)]
        [DisplayName(Item_4_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_4_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_4_Id, IdNamePair.Unknown(Item_4_Id)).ToString();

        [SortOrder(Item_5_Id_sortIndex)]
        [DisplayName(Item_5_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_5_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_5_Id, IdNamePair.Unknown(Item_5_Id)).ToString();

        [SortOrder(Item_6_Id_sortIndex)]
        [DisplayName(Item_6_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_6_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_6_Id, IdNamePair.Unknown(Item_6_Id)).ToString();

        [SortOrder(Item_7_Id_sortIndex)]
        [DisplayName(Item_7_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_7_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_7_Id, IdNamePair.Unknown(Item_7_Id)).ToString();

        [SortOrder(Item_8_Id_sortIndex)]
        [DisplayName(Item_8_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_8_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_8_Id, IdNamePair.Unknown(Item_8_Id)).ToString();

        [SortOrder(Item_9_Id_sortIndex)]
        [DisplayName(Item_9_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_9_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_9_Id, IdNamePair.Unknown(Item_9_Id)).ToString();

        [SortOrder(Item_10_Id_sortIndex)]
        [DisplayName(Item_10_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_10_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_10_Id, IdNamePair.Unknown(Item_10_Id)).ToString();
    }
}