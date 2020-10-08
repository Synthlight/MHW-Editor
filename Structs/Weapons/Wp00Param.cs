using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp00Param : MhwMultiStructFile<Wp00Param> {
        public partial class Charge_Times {
            public string Name {
                get {
                    return Index switch
                    {
                        0 => "Charge Slash",
                        1 => "Strong Charged Slash",
                        2 => "True Charge Slash",
                        3 => "Rising Charged Slash",
                        4 => "Midair Charge Slash",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}