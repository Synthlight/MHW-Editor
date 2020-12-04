using System.IO;
using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp09Param : MhwMultiStructFile<Wp09Param> {
        public partial class Elemental_SAED_Spawn_Interval_Coords {
            public string Name {
                get {
                    return Index switch {
                        0 => "1 Phial",
                        1 => "2 Phials",
                        2 => "3 Phials",
                        3 => "4 Phials",
                        4 => "5 Phials",
                        5 => "6 Phials",
                        _ => "Unknown"
                    };
                }
            }

            public partial class Spawn_Intervals {
                private static ulong GetLoadCount(BinaryReader reader, Elemental_SAED_Spawn_Interval_Coords parent) {
                    return parent.Index + 1;
                }

                public string Name {
                    get {
                        return Index switch {
                            0 => "Phial 1",
                            1 => "Phial 2",
                            2 => "Phial 3",
                            3 => "Phial 4",
                            4 => "Phial 5",
                            5 => "Phial 6",
                            _ => "Unknown"
                        };
                    }
                }
            }

            public partial class Coordinates {
                private static ulong GetLoadCount(BinaryReader reader, Elemental_SAED_Spawn_Interval_Coords parent) {
                    return parent.Index + 1;
                }

                public string Name {
                    get {
                        return Index switch {
                            0 => "Phial 1",
                            1 => "Phial 2",
                            2 => "Phial 3",
                            3 => "Phial 4",
                            4 => "Phial 5",
                            5 => "Phial 6",
                            _ => "Unknown"
                        };
                    }
                }
            }
        }
    }
}