using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class MelderItem : MhwItem {
        public MelderItem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(Result_Item_Id_sortIndex)]
        [DisplayName(Result_Item_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Result_Item_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Result_Item_Id, IdNamePair.Unknown((ushort) Result_Item_Id)).ToString();
    }
}