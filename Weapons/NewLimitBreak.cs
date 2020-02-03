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

        [SortOrder(Mat_1_sortIndex)]
        [DisplayName(Mat_1_displayName)]
        public string Mat_1_button => DataHelper.itemData[MainWindow.locale][Mat_1].ToString();

        [SortOrder(Mat_2_sortIndex)]
        [DisplayName(Mat_2_displayName)]
        public string Mat_2_button => DataHelper.itemData[MainWindow.locale][Mat_2].ToString();

        [SortOrder(Mat_3_sortIndex)]
        [DisplayName(Mat_3_displayName)]
        public string Mat_3_button => DataHelper.itemData[MainWindow.locale][Mat_3].ToString();

        [SortOrder(Mat_4_sortIndex)]
        [DisplayName(Mat_4_displayName)]
        public string Mat_4_button => DataHelper.itemData[MainWindow.locale][Mat_4].ToString();
    }
}