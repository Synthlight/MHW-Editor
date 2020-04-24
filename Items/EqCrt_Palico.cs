using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template.Armors;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public class EqCrt_Palico : EqCrt_Base {
        public EqCrt_Palico(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(Equipment_Category_Raw_sortIndex)]
        [DisplayName("Equipment Category")]
        [IsReadOnly]
        public PalicoEquipType Equipment_Category {
            get => (PalicoEquipType) Equipment_Category_Raw;
            set => Equipment_Category_Raw = (byte) value;
        }

        [SortOrder(Equipment_Index_Raw_sortIndex)]
        [DisplayName("Equipment Id")]
        [IsReadOnly]
        public ushort Equipment_Id {
            get => Equipment_Index_Raw;
            set => Equipment_Index_Raw = value;
        }
    }
}