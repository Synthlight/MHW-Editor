using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp07Param : MhwMultiStructItem<Wp07Param> {
        public partial class Shell_Ammo_Params {
            public string Name {
                get {
                    return Index switch {
                        0 => "Normal Shell",
                        1 => "Long Shell",
                        2 => "Wide Shell",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Shelling_Sharpness_Usage {
            public string Name {
                get {
                    return Index switch {
                        0 => "Normal Shell",
                        1 => "Long Shell",
                        2 => "Wide Shell",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class W07p_Params_10_Wyrmstake_Blast_Duration_per_Pod {
            public string Name {
                get {
                    return Index switch {
                        0 => "Thorn Pod",
                        1 => "Bomb/Pierce Pod",
                        2 => "Scatternut/Crystalburst/Torch Pod/Brightmoss",
                        3 => "Puddle/Dragon Pod",
                        4 => "Unk 1",
                        5 => "Redpit",
                        6 => "Stone",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}