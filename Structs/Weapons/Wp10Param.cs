using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp10Param : MhwMultiStructFile<Wp10Param> {
        public partial class Kinsect_Stats {
            public string Name {
                get {
                    return Index switch {
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

        public partial class Action_Param_Relate_Jumping_Attacks_ {
            public string Name {
                get {
                    return Index switch {
                        0 => "Jumping Advancing Slash",
                        1 => "Jumping Advancing Slash (White Extract)",
                        2 => "Strong Jumping Advancing Slash (Helicopter Motion)",
                        3 => "Strong Jumping Advancing Slash (Helicopter Motion, White Extract)",
                        4 => "Strong Jumping Advancing Slash (Finish)",
                        5 => "Strong Jumping Advancing Slash (Finish, White Extract)",
                        6 => "Sliding Jumping Advancing Slash And Strong Jumping Advancing Slash (Not White or White)",
                        7 => "Sliding Jumping Advancing Slash And Strong Jumping Advancing Slash (Not White or White)",
                        8 => "Sliding Jumping Advancing Slash And Strong Jumping Advancing Slash (Not White or White)",
                        9 => "Sliding Jumping Advancing Slash And Strong Jumping Advancing Slash (Not White or White)",
                        10 => "Jumping Slash",
                        11 => "Jumping Slash (White)",
                        12 => "Strong Jumping Slash",
                        13 => "Strong Jumping Slash (White)",
                        14 => "Midair Clutch (Prepare Motion)",
                        15 => "Midair Clutch (Prepare Motion, White)",
                        16 => "Midair Clutch",
                        17 => "Midair Clutch (White)",
                        18 => "Descending Thrust (Fore)",
                        19 => "Descending Thrust (Fore, White)",
                        20 => "Descending Thrust (Later)",
                        21 => "Descending Thrust (Later, White)",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}