using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp11Param : MhwMultiStructItem<Wp11Param> {
        public partial class Bow_Charge {
            public string Name {
                get {
                    return Index switch
                    {
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
                    return Index switch
                    {
                        0 => "Normal Shot",
                        1 => "Power Shot",
                        2 => "Quick Shot",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}