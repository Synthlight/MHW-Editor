using MHW_Editor.Models;

namespace MHW_Editor.PlData {
    public partial class PlMantleParam : MhwMultiStructItem<PlMantleParam> {
        public partial class Mantle_Params_2_ {
            public string Name {
                get {
                    return Index switch {
                        0 => "Fireproof Mantle",
                        1 => "Waterproof Mantle",
                        2 => "Iceproof Mantle",
                        3 => "Thunderproof Mantle",
                        4 => "Dragonproof Mantle",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}