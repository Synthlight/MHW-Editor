using MHW_Editor.Models;

namespace MHW_Editor.Structs.Monsters {
    public partial class MonsterEnrage : MhwMultiStructFile<MonsterEnrage> {
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