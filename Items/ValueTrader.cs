using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class ValueTrader : MhwItem {
        public ValueTrader(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;

        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id, IdNamePair.Unknown((ushort) Item_Id)).ToString();
    }
}