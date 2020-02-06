using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class OtomoWeaponDat : MhwItem {
        public OtomoWeaponDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.otomoWeaponData[MainWindow.locale].TryGet(GMD_Name_Index, "Unknown");

        [SortOrder(Set_Group_sortIndex + 1)]
        [DisplayName("Description")]
        public string Description => DataHelper.otomoWeaponData[MainWindow.locale].TryGet(GMD_Description_Index, "Unknown").Replace("\r\n", " ");
    }
}