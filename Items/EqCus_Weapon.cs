using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Items {
    public class EqCus_Weapon : EqCus_Base, IHasWeaponType {
        public EqCus_Weapon(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(Equipment_Category_Raw_sortIndex)]
        [DisplayName("Equipment Category")]
        [IsReadOnly]
        public WeaponType Equipment_Category {
            get => (WeaponType) Equipment_Category_Raw;
            set => Equipment_Category_Raw = (byte) value;
        }

        [SortOrder(Equipment_Index_Raw_sortIndex)]
        [DisplayName("Equipment Index")]
        [DataSource(DataSourceType.WeaponsByIndex)]
        [IsReadOnly]
        public ushort Equipment_Index {
            get => Equipment_Index_Raw;
            set => Equipment_Index_Raw = value;
        }

        [SortOrder(Equipment_Index_Raw_sortIndex)]
        [DisplayName("Equipment Index")]
        [CustomSorter(typeof(ButtonSorter))]
        public string Equipment_Index_button => DataHelper.weaponIndexNameLookup[Equipment_Category][MainWindow.locale].TryGet(Equipment_Index).ToStringWithId(Equipment_Index);

        public WeaponType GetWeaponType() {
            return Equipment_Category;
        }
    }
}