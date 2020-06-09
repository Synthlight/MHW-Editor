using MHW_Editor.Models;

namespace MHW_Editor.Structs.Monsters {
    public partial class MonsterRandomSize : MhwMultiStructFile<MonsterRandomSize> {
        public partial class Crown_Tables {
            public string Name {
                get {
                    return Index switch {
                        0 => "Default Size Only",
                        1 => "A: Uncrowned Only",
                        2 => "A: Silver Crown Low",
                        3 => "A: Silver Crown High",
                        4 => "A: Minimum To Silver",
                        5 => "A: Gold Crown Low",
                        6 => "A: Gold Crown High",
                        7 => "A: Gold Crown Ultra High",
                        8 => "A: Gold Crown Ultra Low",
                        9 => "A: Spare Frame 3",
                        10 => "Spare Frame",
                        11 => "B: Uncrowned Only",
                        12 => "B: Silver Crown Low",
                        13 => "B: Silver Crown High",
                        14 => "B: Minimum To Silver",
                        15 => "B: Gold Crown Low",
                        16 => "B: Gold Crown High",
                        17 => "B: Gold Crown Ultra High",
                        18 => "B: Gold Crown Ultra Low",
                        19 => "B: Spare Frame 3",
                        20 => "Spare Frame",
                        21 => "D: Gold Crown Low",
                        22 => "D: Gold Crown High",
                        23 => "D: Gold Crown Ultra High",
                        24 => "D: Gold Crown Ultra Low",
                        25 => "C: Gold Crown Low",
                        26 => "C: Gold Crown High",
                        27 => "C: Gold Crown Ultra High",
                        28 => "C: Gold Crown Ultra Low",
                        29 => "C: Spare Frame 3",
                        30 => "Spare Frame",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}