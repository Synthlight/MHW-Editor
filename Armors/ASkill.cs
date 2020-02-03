using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Skills {
    public partial class ASkill : MhwItem {
        public ASkill(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(Mantle_Item_Id_sortIndex)]
        [DisplayName(Mantle_Item_Id_displayName)]
        public string Mantle_Item_Id_button => DataHelper.itemData[MainWindow.locale][(ushort) Mantle_Item_Id].ToString();
    }
}