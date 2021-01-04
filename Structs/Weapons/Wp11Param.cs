using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp11Param : MhwMultiStructFile<Wp11Param> {
        public partial class Bow_Charge {
            public string Name {
                get {
                    return Index switch {
                        0 => "Charge Time Required",
                        1 => "Status Coating Buildup Multiplier",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Arrows_Shot {
            public string Name {
                get {
                    return Index switch {
                        0 => "Normal Shot",
                        1 => "Power Shot",
                        2 => "Quick Shot",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Arrow_Grid_ {
            public string Name {
                get {
                    return Index switch {
                        0 => "Normal Shot 1",
                        1 => "Normal Shot 2",
                        2 => "Normal Shot 3",
                        3 => "Normal Shot 4",
                        4 => "Power Shot 1",
                        5 => "Power Shot 2",
                        6 => "Power Shot 3",
                        7 => "Power Shot 4",
                        8 => "Quick Shot 1",
                        9 => "Quick Shot 2",
                        10 => "Quick Shot 3",
                        11 => "Quick Shot 4",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}