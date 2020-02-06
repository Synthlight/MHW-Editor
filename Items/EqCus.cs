using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class EqCus : MhwItem {
        public EqCus(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Mat_1_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Mat_1_Id, IdNamePair.Unknown(Mat_1_Id)).ToString();

        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Mat_2_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Mat_2_Id, IdNamePair.Unknown(Mat_2_Id)).ToString();

        [SortOrder(Mat_3_Id_sortIndex)]
        [DisplayName(Mat_3_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Mat_3_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Mat_3_Id, IdNamePair.Unknown(Mat_3_Id)).ToString();

        [SortOrder(Mat_4_Id_sortIndex)]
        [DisplayName(Mat_4_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Mat_4_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Mat_4_Id, IdNamePair.Unknown(Mat_4_Id)).ToString();
    }
}