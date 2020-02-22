using System;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class ItemMake : MhwItem {
        public ItemMake(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(Can_Auto_Craft_Raw_sortIndex)]
        [DisplayName("Can Auto-Craft")]
        public bool Can_Auto_Craft {
            get => Convert.ToBoolean(Can_Auto_Craft_Raw);
            set {
                Can_Auto_Craft_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Can_Auto_Craft));
            }
        }
    }
}