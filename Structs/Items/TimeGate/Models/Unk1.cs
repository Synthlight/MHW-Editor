using System;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Structs.Items.TimeGate.Models {
    public class Unk1 : MhwStructItem {
        [SortOrder(25)]
        [DisplayName("Unlock Day")]
        [IsReadOnly]
        public DateTime unlockTime { get; set; }

        [SortOrder(100)]
        [DisplayName("Unk 1")]
        [IsReadOnly]
        public uint unk1 { get; set; }
    }
}