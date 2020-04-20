using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterStamina : ICustomSaveLoad {
        public partial class Stamina_LR_ {
            public static ulong GetEntryCount(List<List<object>> data) {
                return data.GetEntry<Stamina_Count_LR_>(typeof(Stamina_Count_LR_))?.Number_of_Stamina_Entries ?? 0;
            }
        }

        public partial class Stamina_HR_ {
            public static ulong GetEntryCount(List<List<object>> data) {
                return data.GetEntry<Stamina_Count_HR_>(typeof(Stamina_Count_HR_))?.Number_of_Stamina_Entries ?? 0;
            }
        }

        public partial class Stamina_MR_ {
            public static ulong GetEntryCount(List<List<object>> data) {
                return data.GetEntry<Stamina_Count_MR_>(typeof(Stamina_Count_MR_))?.Number_of_Stamina_Entries ?? 0;
            }
        }
    }
}