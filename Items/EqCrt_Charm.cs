using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Armors;

namespace MHW_Editor.Items {
    public class EqCrt_Charm : EqCrt_Base {
        public EqCrt_Charm(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(Equipment_Category_Raw_sortIndex)]
        [DisplayName("Equipment Category")]
        [IsReadOnly]
        public CharmType Equipment_Category {
            get => (CharmType) Equipment_Category_Raw;
            set => Equipment_Category_Raw = (byte) value;
        }

        [SortOrder(Equipment_Index_Raw_sortIndex)]
        [DisplayName("Equipment Id")]
        [IsReadOnly]
        public ushort Equipment_Id {
            get => Equipment_Index_Raw;
            set => Equipment_Index_Raw = value;
        }

        [DisplayName("Name")]
        public override string Name => DataHelper.pendantNames[MainWindow.locale].TryGet(Equipment_Index_Raw);
    }
}