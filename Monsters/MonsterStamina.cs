using System;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterStamina : MhwMultiStructItem<MonsterStamina> {
        protected override ulong GetEntryCount(Type type) {
            if (type == typeof(Stamina_LR_)) {
                return GetFirstEntry<Stamina_Count_LR_>().Number_of_Stamina_Entries;
            }

            if (type == typeof(Stamina_HR_)) {
                return GetFirstEntry<Stamina_Count_HR_>().Number_of_Stamina_Entries;
            }

            if (type == typeof(Stamina_MR_)) {
                return GetFirstEntry<Stamina_Count_MR_>().Number_of_Stamina_Entries;
            }

            return base.GetEntryCount(type);
        }

        protected override void PrepSave() {
            GetFirstEntry<Stamina_Count_LR_>().Number_of_Stamina_Entries = (uint) GetDataContainer<Stamina_LR_>().list.Count;
            GetFirstEntry<Stamina_Count_HR_>().Number_of_Stamina_Entries = (uint) GetDataContainer<Stamina_HR_>().list.Count;
            GetFirstEntry<Stamina_Count_MR_>().Number_of_Stamina_Entries = (uint) GetDataContainer<Stamina_MR_>().list.Count;
        }
    }
}