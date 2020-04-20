using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterEnrage : ICustomSaveLoad {
        public partial class Rage_Stats {
            public string Name {
                get {
                    return index switch
                    {
                        0 => "LR/HR",
                        1 => "MR",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}