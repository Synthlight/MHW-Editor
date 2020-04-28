using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class GunnerReload : MhwItem {
        public static readonly Dictionary<byte, string> reloadLookup = new Dictionary<byte, string>();

        static GunnerReload() {
            reloadLookup[0] = "Fast";
            reloadLookup[1] = "Normal";
            reloadLookup[2] = "Slow";
            reloadLookup[3] = "Very Slow";
        }

        public GunnerReload(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }
}