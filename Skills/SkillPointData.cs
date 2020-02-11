using System;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Skills {
    public partial class SkillPointData : MhwItem {
        public SkillPointData(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string UniqueId => $"{Index}";

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;

        [SortOrder(Is_Set_Bonus_Raw_sortIndex)]
        [DisplayName("Is Set Bonus")]
        public bool Is_Set_Bonus {
            get => Convert.ToBoolean(Is_Set_Bonus_Raw);
            set {
                Is_Set_Bonus_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Is_Set_Bonus));
            }
        }
    }
}