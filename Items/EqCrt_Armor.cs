using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Armors;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public class EqCrt_Armor : EqCrt_Base, IHasArmorType {
        public EqCrt_Armor(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(Equipment_Category_Raw_sortIndex)]
        [DisplayName("Equipment Category")]
        [IsReadOnly]
        public ArmorType Equipment_Category {
            get => (ArmorType) Equipment_Category_Raw;
            set => Equipment_Category_Raw = (byte) value;
        }

        [SortOrder(Equipment_Index_Raw_sortIndex)]
        [DisplayName("Equipment Index")]
        [DataSource(DataSourceType.ArmorByIndex)]
        [IsReadOnly]
        public ushort Equipment_Index {
            get => Equipment_Index_Raw;
            set => Equipment_Index_Raw = value;
        }

        [SortOrder(Equipment_Index_Raw_sortIndex)]
        [DisplayName("Equipment Index")]
        [CustomSorter(typeof(ButtonSorter))]
        public string Equipment_Index_button => DataHelper.armorIndexNameLookup[Equipment_Category][MainWindow.locale].TryGet(Equipment_Index).ToStringWithId(Equipment_Index);

        public ArmorType GetArmorType() {
            return Equipment_Category;
        }
    }
}