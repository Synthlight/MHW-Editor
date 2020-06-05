using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp07Param : MhwMultiStructItem<Wp07Param> {
        public partial class Shell_Ammo_Params {
            public string Name {
                get {
                    return Index switch
                    {
                        0 => "Normal",
                        1 => "Long Shell",
                        2 => "Wide Shell",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}