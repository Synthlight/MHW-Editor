using System;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterClawGrab : MhwMultiStructItem<MonsterClawGrab> {
        protected override ulong GetEntryCount(Type type) {
            if (type == typeof(Clagger_Params)) {
                return GetFirstEntry<Monster_Claw_Grab>().Number_of_Claggers;
            }

            return base.GetEntryCount(type);
        }

        protected override void PrepSave() {
            GetFirstEntry<Monster_Claw_Grab>().Number_of_Claggers = (uint) GetDataContainer<Clagger_Params>().list.Count;
        }
    }
}