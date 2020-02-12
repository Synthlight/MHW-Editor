using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class GunnerReload : MhwItem {
        public static readonly Dictionary<byte, IdNamePair> reloadLookup = new Dictionary<byte, IdNamePair>();

        static GunnerReload() {
            reloadLookup.Add(0, "Fast");
            reloadLookup.Add(1, "Normal");
            reloadLookup.Add(2, "Slow");
            reloadLookup.Add(3, "Very Slow");
        }

        public GunnerReload(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }
}