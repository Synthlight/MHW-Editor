using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class ItemMake : MhwItem {
        public ItemMake(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Mat_1_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Mat_1_Id, IdNamePair.Unknown((ushort) Mat_1_Id)).ToString();

        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Mat_2_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Mat_2_Id, IdNamePair.Unknown((ushort) Mat_2_Id)).ToString();

        [SortOrder(Result_Id_sortIndex)]
        [DisplayName(Result_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Result_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Result_Id, IdNamePair.Unknown((ushort) Result_Id)).ToString();

        [SortOrder(Can_Auto_Craft_Raw_sortIndex)]
        [DisplayName("Can Auto-Craft")]
        public bool Can_Auto_Craft {
            get => Convert.ToBoolean(Can_Auto_Craft_Raw);
            set {
                Can_Auto_Craft_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Can_Auto_Craft));
            }
        }
    }
}