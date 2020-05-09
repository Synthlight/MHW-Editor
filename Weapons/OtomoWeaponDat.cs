using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class OtomoWeaponDat : MhwItem {
        public OtomoWeaponDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.otomoWeaponData[MainWindow.locale].TryGet(GMD_Name_Index);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.otomoWeaponData[MainWindow.locale].TryGet(GMD_Description_Index).Replace("\r\n", " ");
    }
}