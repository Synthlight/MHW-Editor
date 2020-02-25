using System;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class PlantItem : MhwItem {
        public PlantItem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(Unlocked_from_start_Raw_sortIndex)]
        [DisplayName("Unlocked from start")]
        public bool Unlocked_from_start {
            get => Convert.ToBoolean(Unlocked_from_start_Raw);
            set {
                Unlocked_from_start_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Unlocked_from_start));
            }
        }
    }
}