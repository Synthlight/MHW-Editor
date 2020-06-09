using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using MHW_Editor.Models;

namespace MHW_Editor.Structs.PlData {
    public partial class PlItemParam : MhwMultiStructItem<PlItemParam> {
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