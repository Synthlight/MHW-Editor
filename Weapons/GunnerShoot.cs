using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class GunnerShoot : MhwItem {
        public static readonly Dictionary<byte, string> recoilLookup = new Dictionary<byte, string>();

        static GunnerShoot() {
            recoilLookup[0]  = "Normal +1";
            recoilLookup[1]  = "Normal +2";
            recoilLookup[2]  = "Auto-Reload";
            recoilLookup[3]  = "Rapid +1";
            recoilLookup[4]  = "Rapid +2";
            recoilLookup[6]  = "Normal +3";
            recoilLookup[7]  = "Normal +4";
            recoilLookup[8]  = "Rapid +3";
            recoilLookup[9]  = "Wyvern";
            recoilLookup[10] = "Cluster +1";
            recoilLookup[11] = "Cluster +2";
            recoilLookup[12] = "Cluster +3";
            recoilLookup[13] = "Rapid Sticky";
        }

        public GunnerShoot(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }
}