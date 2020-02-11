using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class MelderExchange : MhwItem {
        public MelderExchange(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string UniqueId => $"{Source_Item_Id}";

        public override string Name => "None";

        [SortOrder(Source_Item_Id_sortIndex)]
        [DisplayName(Source_Item_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Source_Item_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Source_Item_Id, IdNamePair.Unknown((ushort) Source_Item_Id)).ToString();
    }
}