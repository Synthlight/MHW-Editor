using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp10Param : MhwMultiStructItem<Wp10Param> {
        public partial class Kinsect_Stats {
            public string Name {
                get {
                    return Index switch
                    {
                        0 => "Attack Power",
                        1 => "Speed",
                        2 => "Healing",
                        3 => "Stamina Regeneration/s",
                        4 => "Heal Dust",
                        5 => "Blast Dust",
                        6 => "Paralysis Dust",
                        7 => "Poison Dust",
                        8 => "Element",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}