using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterParts : MhwMultiStructItem<MonsterParts> {
        public partial class Flinches {
            [SortOrder(Parts1_sortIndex)]
            [DisplayName("Parts")]
            [IsList]
            public dynamic Parts {
                get {
                    return Parts_Type switch {
                        1 => Parts1_raw,
                        2 => Parts2_raw,
                        3 => Parts3_raw,
                        _ => null // Should never happen.
                    };
                }
            }
        }
    }
}