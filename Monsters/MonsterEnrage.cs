using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterEnrage : MhwMultiStructItem<MonsterEnrage> {
        public partial class Rage_Stats {
            public string Name {
                get {
                    return Index switch {
                        0 => "LR/HR",
                        1 => "MR",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}