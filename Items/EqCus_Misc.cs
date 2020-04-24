using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public class EqCus_Misc : EqCus_Base {
        public EqCus_Misc(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [SortOrder(Equipment_Category_Raw_sortIndex)]
        [DisplayName("Equipment Category")]
        [IsReadOnly]
        public byte Equipment_Category {
            get => Equipment_Category_Raw;
            set => Equipment_Category_Raw = value;
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