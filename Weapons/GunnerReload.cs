using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class GunnerReload : MhwItem {
        public static readonly Dictionary<byte, IdNamePair<byte>> reloadLookup = new Dictionary<byte, IdNamePair<byte>>();

        static GunnerReload() {
            reloadLookup.Add((byte) 0, "Fast");
            reloadLookup.Add((byte) 1, "Normal");
            reloadLookup.Add((byte) 2, "Slow");
            reloadLookup.Add((byte) 3, "Very Slow");
        }

        public GunnerReload(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }
}