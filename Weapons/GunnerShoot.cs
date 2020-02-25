using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class GunnerShoot : MhwItem {
        public static readonly Dictionary<byte, IdNamePair<byte>> recoilLookup = new Dictionary<byte, IdNamePair<byte>>();

        static GunnerShoot() {
            recoilLookup.Add((byte) 0, "Normal +1");
            recoilLookup.Add((byte) 1, "Normal +2");
            recoilLookup.Add((byte) 2, "Auto-Reload");
            recoilLookup.Add((byte) 3, "Rapid +1");
            recoilLookup.Add((byte) 4, "Rapid +2");
            recoilLookup.Add((byte) 6, "Normal +3");
            recoilLookup.Add((byte) 7, "Normal +4");
            recoilLookup.Add((byte) 8, "Rapid +3");
            recoilLookup.Add((byte) 9, "Wyvern");
            recoilLookup.Add((byte) 10, "Cluster +1");
            recoilLookup.Add((byte) 11, "Cluster +2");
            recoilLookup.Add((byte) 12, "Cluster +3");
            recoilLookup.Add((byte) 13, "Rapid Sticky");
        }

        public GunnerShoot(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }
}