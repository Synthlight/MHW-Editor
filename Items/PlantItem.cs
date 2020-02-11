using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class PlantItem : MhwItem {
        public PlantItem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string UniqueId => $"{Item}";

        public override string Name => "None";

        [SortOrder(Item_sortIndex)]
        [DisplayName(Item_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Item_button => DataHelper.itemData[MainWindow.locale].TryGet(Item, IdNamePair.Unknown(Item)).ToString();

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