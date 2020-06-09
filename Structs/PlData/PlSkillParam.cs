using MHW_Editor.Models;

namespace MHW_Editor.Structs.PlData {
    public partial class PlSkillParam : MhwMultiStructItem<PlSkillParam> {
        public partial class Wide_Range {
            public string Name {
                get {
                    return Index switch {
                        0 => "Efficiency",
                        1 => "Range",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Focus {
            public string Name {
                get {
                    return Index switch {
                        0 => "Gunlance, Charge Shot",
                        1 => "Charge Blade, Slash 2",
                        2 => "Charge Blade, Phial Charge Slash",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Punishing_Draw {
            public string Name {
                get {
                    return Index switch {
                        0 => "Great Sword",
                        1 => "Sword & Shield",
                        2 => "Dual Blades",
                        3 => "Long Sword",
                        4 => "Hammer",
                        5 => "Hunting Horn",
                        6 => "Lance",
                        7 => "Gunlance",
                        8 => "Switch Axe",
                        9 => "Charge Blade",
                        10 => "Insect Glaive",
                        11 => "Bow",
                        12 => "HBG",
                        13 => "LBG",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Razor_Sharp {
            public string Name {
                get {
                    return Index switch {
                        0 => "Razor Sharp",
                        1 => "True Razor Sharp",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Minds_Eye_Ballistics {
            public string Name {
                get {
                    return Index switch {
                        0 => "Gun",
                        1 => "Bow",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Critical_Element_Multipliers {
            public string Name {
                get {
                    return Index switch {
                        0 => "Critical Element",
                        1 => "True Critical Element",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Critical_Condition_Multipliers {
            public string Name {
                get {
                    return Index switch {
                        0 => "Critical Condition",
                        1 => "True Condition Element",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Artillery {
            public string Name {
                get {
                    return Index switch {
                        0 => "Gunlance Shell Attack Rate",
                        1 => "Gunlance WyvernFire Attack Rate",
                        2 => "Gunlance Wyrmstake Cannon Attack Rate",
                        3 => "Gunlance WyvernFire Cooldown Time Rate",
                        4 => "Charge Blade Impact Phial Attack Rate",
                        5 => "Bowgun Sticky Ammo Attack Rate",
                        6 => "Bowgun Kakusan? Attack Rate (Appears Unused?)",
                        7 => "Bowgun Wyvern Ammo Attack Rate",
                        8 => "LBG Wyvernblast Attack Rate (Appears Unused?)",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Ammo_Up {
            public string Name {
                get {
                    return Index switch {
                        0 => "Level 1",
                        1 => "Level 2",
                        2 => "Level 3",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Power_Prolonger {
            public string Name {
                get {
                    return Index switch {
                        0 => "Dual Blades",
                        1 => "Long Sword",
                        2 => "Switch Axe",
                        3 => "Charge Blade",
                        4 => "Insect Glaive",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Slinger_Up {
            public string Name {
                get {
                    return Index switch {
                        0 => "Stone",
                        1 => "Redpit",
                        2 => "Brightmoss",
                        3 => "Scatternut",
                        4 => "Unk 1",
                        5 => "Unk 2",
                        6 => "Unk 3",
                        7 => "Unk 4",
                        8 => "Unk 5",
                        9 => "Torch Pod",
                        10 => "Unk 6",
                        11 => "Unk 7",
                        12 => "Unk 8",
                        13 => "Unk 9",
                        14 => "Bomb Pod",
                        15 => "Piercing Pod",
                        16 => "Slinger Thorn",
                        17 => "Dragon Pod",
                        18 => "Unk 10",
                        19 => "Unk 11",
                        20 => "Unk 12",
                        21 => "Unk 13",
                        22 => "Unk 14",
                        23 => "Unk 15",
                        24 => "Unk 16",
                        25 => "Unk 17",
                        26 => "Crystalburst",
                        27 => "Puddle Pod",
                        28 => "Unk 18",
                        29 => "Unk 19",
                        30 => "Unk 20",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Frostcraft_1_ {
            public string Name {
                get {
                    return Index switch {
                        0 => "Great Sword",
                        1 => "Sword & Shield",
                        2 => "Dual Blades",
                        3 => "Long Sword",
                        4 => "Hammer",
                        5 => "Hunting Horn",
                        6 => "Lance",
                        7 => "Gunlance",
                        8 => "Switch Axe",
                        9 => "Charge Blade",
                        10 => "Insect Glaive",
                        11 => "Bow",
                        12 => "HBG",
                        13 => "LBG",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}