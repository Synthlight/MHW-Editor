using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using MHW_Editor.Models;

namespace MHW_Editor.Structs.PlData {
    public partial class PlPlayerParam : MhwMultiStructItem<PlPlayerParam> {
        public partial class Player_Params_5_Dodge_IFrames {
            public string Name {
                get {
                    return Index switch {
                        0 => "Normal",
                        1 => "Step",
                        2 => "Sword & Shield Back Step",
                        3 => "Dual Blades Demon Mode Step",
                        4 => "Long Sword Counter",
                        5 => "Bow Charge Step",
                        6 => "HBG Roll Dodge",
                        7 => "LBG Side Dodge",
                        8 => "Dual Blades Demon Mode Slinger Evade",
                        9 => "Dual Blades Slinger Evade",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Player_Params_6_Evade_Distance {
            public string Name {
                get {
                    return Index switch {
                        0 => "Normal",
                        1 => "Step",
                        2 => "Sword & Shield Back Step",
                        3 => "Dual Blades Demon Mode Step",
                        4 => "Long Sword Counter",
                        5 => "Bow Charge Step",
                        6 => "HBG Roll Dodge",
                        7 => "LBG Side Dodge",
                        8 => "Dual Blades Demon Mode Slinger Evade",
                        9 => "Dual Blades Slinger Evade",
                        10 => "Insect Glaive Air Dodge",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Skipping_Ahead_1_ {
            [SortOrder(Raw_Bytes_sortIndex - 1)]
            [DisplayName("Bytes Skipped")]
            public uint BytesSkipped => (uint) Raw_Bytes_raw.Count;
        }

        public partial class Skipping_Ahead_2_ {
            [SortOrder(Raw_Bytes_sortIndex - 1)]
            [DisplayName("Bytes Skipped")]
            public uint BytesSkipped => (uint) Raw_Bytes_raw.Count;
        }

        public partial class The_Rest {
            [SortOrder(The_rest_of_the_file_as_bytes__sortIndex - 1)]
            [DisplayName("Bytes Skipped")]
            public uint BytesSkipped => (uint) The_rest_of_the_file_as_bytes__raw.Count;

            public partial class End_Junk {
                public static ObservableCollection<End_Junk> LoadData(BinaryReader reader, The_Rest parent) {
                    var list  = new ObservableCollection<End_Junk>();
                    var bytes = reader.ReadRemainderAsByteArray();
                    for (var i = 0; i < bytes.Count; i++) {
                        list.Add(new End_Junk {
                            Index   = (ulong) i,
                            Unk_raw = bytes[i]
                        });
                    }
                    return list;
                }
            }
        }
    }
}