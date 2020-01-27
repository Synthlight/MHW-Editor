using System;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class Armor : MhwItem, ISlots {
        public Armor(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.armorData.TryGet(GMD_Name_Index, "Unknown");

        public bool Is_Permanent {
            get => Convert.ToBoolean(Is_Permanent_Raw);
            set => Is_Permanent_Raw = Convert.ToByte(value);
        }
    }
}