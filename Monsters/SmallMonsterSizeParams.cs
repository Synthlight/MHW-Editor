using System;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class SmallMonsterSizeParams : MhwMultiStructItem<SmallMonsterSizeParams> {
        protected override ulong GetEntryCount(Type type) {
            if (type == typeof(Size_Settings)) {
                return GetFirstEntry<Small_Monster_Size_Params>().Number_of_Size_Settings;
            }

            return base.GetEntryCount(type);
        }

        protected override void PrepSave() {
            GetFirstEntry<Small_Monster_Size_Params>().Number_of_Size_Settings = (uint) GetDataContainer<Size_Settings>().list.Count;
        }
    }
}