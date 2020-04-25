using System;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp12Param : MhwMultiStructItem<Wp12Param> {
        protected override ulong GetEntryCount(Type type) {
            if (type == typeof(Shield_Mods)) {
                return GetFirstEntry<Number_of_Shield_Mods_Struct>().Number_of_Shield_Mods;
            }

            return base.GetEntryCount(type);
        }

        protected override void PrepSave() {
            GetFirstEntry<Number_of_Shield_Mods_Struct>().Number_of_Shield_Mods = (uint) GetDataContainer<Shield_Mods>().list.Count;
        }
    }
}