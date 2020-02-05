using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Armors {
    public partial class OtomoArmorDat : MhwItem {
        public OtomoArmorDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.otomoArmorData[MainWindow.locale][GMD_Name_Index];

        [SortOrder(Set_Group_sortIndex + 1)]
        [DisplayName("Description")]
        public string Description => DataHelper.otomoArmorData[MainWindow.locale][GMD_Description_Index].Replace("\r\n", " ");

        [SortOrder(Is_Full_Set_Raw_sortIndex)]
        [DisplayName("Is Full Set")]
        public bool Is_Full_Set {
            get => Convert.ToBoolean(Is_Full_Set_Raw);
            set => Is_Full_Set_Raw = Convert.ToByte(value);
        }
    }
}