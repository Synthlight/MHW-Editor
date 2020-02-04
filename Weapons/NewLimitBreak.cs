using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class NewLimitBreak : MhwItem {
        public NewLimitBreak(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(Needed_Item_Id_to_Unlock_sortIndex)]
        [DisplayName(Needed_Item_Id_to_Unlock_displayName)]
        public string Needed_Item_Id_to_Unlock_button => DataHelper.itemData[MainWindow.locale][Needed_Item_Id_to_Unlock].ToString();

        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        public string Mat_1_Id_button => DataHelper.itemData[MainWindow.locale][Mat_1_Id].ToString();

        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        public string Mat_2_Id_button => DataHelper.itemData[MainWindow.locale][Mat_2_Id].ToString();

        [SortOrder(Mat_3_Id_sortIndex)]
        [DisplayName(Mat_3_Id_displayName)]
        public string Mat_3_Id_button => DataHelper.itemData[MainWindow.locale][Mat_3_Id].ToString();

        [SortOrder(Mat_4_Id_sortIndex)]
        [DisplayName(Mat_4_Id_displayName)]
        public string Mat_4_Id_button => DataHelper.itemData[MainWindow.locale][Mat_4_Id].ToString();
    }
}