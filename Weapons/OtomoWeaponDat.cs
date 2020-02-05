using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class OtomoWeaponDat : MhwItem {
        public OtomoWeaponDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.otomoWeaponData[MainWindow.locale][GMD_Name_Index];

        [SortOrder(Set_Group_sortIndex + 1)]
        [DisplayName("Description")]
        public string Description => DataHelper.otomoWeaponData[MainWindow.locale][GMD_Description_Index].Replace("\r\n", " ");
    }
}