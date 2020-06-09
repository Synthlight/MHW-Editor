using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Items {
    public partial class MelderExchange : MhwMultiStructFile<MelderExchange> {
        public partial class Item_Box {
            public partial class Items {
                [DisplayName("")] public override ulong Index { get; set; }

                public const string Item_Id_displayName = "Item Id";
                public const int    Item_Id_sortIndex   = 25;

                [SortOrder(Item_Id_sortIndex)]
                [DisplayName(Item_Id_displayName)]
                [DataSource(DataSourceType.Items)]
                [IsReadOnly]
                public ushort Item_Id => (ushort) Index;

                [SortOrder(Item_Id_sortIndex)]
                [DisplayName(Item_Id_displayName)]
                [CustomSorter(typeof(ButtonSorter))]
                public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);
            }
        }
    }
}