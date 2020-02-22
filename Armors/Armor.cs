using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class Armor : MhwItem, ISlots {
        public Armor(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.armorData[MainWindow.locale].TryGet(GMD_Name_Index, "Unknown");

        [SortOrder(lastSortIndex + 1)]
        [DisplayName("Description")]
        public string Description => DataHelper.armorData[MainWindow.locale].TryGet(GMD_Description_Index, "Unknown").Replace("\r\n", " ");

        [SortOrder(Set_Group_sortIndex + 1)]
        [DisplayName("Is Permanent")]
        public bool Is_Permanent {
            get => Convert.ToBoolean(Is_Permanent_Raw);
            set {
                Is_Permanent_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Is_Permanent));
            }
        }
    }
}