using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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

        public partial class Remainder {
            public partial class End_Junk {
                public static ObservableCollection<End_Junk> LoadData(BinaryReader reader, Remainder parent) {
                    var list = new ObservableCollection<End_Junk>();
                    var i = -1;
                    while (reader.BaseStream.Position < reader.BaseStream.Length) {
                        list.Add(new End_Junk {
                            Index   = (ulong) ++i,
                            Unk_raw = reader.ReadByte()
                        });
                    }
                    return list;
                }
            }
        }
    }
}