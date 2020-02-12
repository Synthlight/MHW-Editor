using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class GunnerShoot : MhwItem {
        public static readonly Dictionary<byte, IdNamePair> recoilLookup = new Dictionary<byte, IdNamePair>();

        static GunnerShoot() {
            recoilLookup.Add(0, "Normal +1");
            recoilLookup.Add(1, "Normal +2");
            recoilLookup.Add(2, "Auto-Reload");
            recoilLookup.Add(3, "Rapid +1");
            recoilLookup.Add(4, "Rapid +2");
            recoilLookup.Add(6, "Normal +3");
            recoilLookup.Add(7, "Normal +4");
            recoilLookup.Add(8, "Rapid +3");
            recoilLookup.Add(9, "Wyvern");
            recoilLookup.Add(10, "Cluster +1");
            recoilLookup.Add(11, "Cluster +2");
            recoilLookup.Add(12, "Cluster +3");
            recoilLookup.Add(13, "Rapid Sticky");
        }

        public GunnerShoot(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }
}