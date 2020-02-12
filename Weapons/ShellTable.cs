using System;
using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable : MhwItem {
        public static readonly Dictionary<byte, IdNamePair> recoilLookup = new Dictionary<byte, IdNamePair>();
        public static readonly Dictionary<byte, IdNamePair> reloadLookup = new Dictionary<byte, IdNamePair>();

        static ShellTable() {
            // Recoil
            AddToList(recoilLookup, 0, "Normal (Recoil +1)");
            AddToList(recoilLookup, 1, "Normal (Recoil +2) M1");
            AddToList(recoilLookup, 2, "Normal (Recoil +2) M2");
            AddToList(recoilLookup, 3, "Normal (Recoil +2) M3");
            AddToList(recoilLookup, 34, "Normal (Recoil +2) M4");
            AddToList(recoilLookup, 4, "Normal (Recoil +3) M1.4");
            AddToList(recoilLookup, 5, "Normal (Recoil +3) M1.4");
            AddToList(recoilLookup, 7, "Normal (Recoil +3) M1.4");
            AddToList(recoilLookup, 11, "Normal (Recoil +3) M1.3");
            AddToList(recoilLookup, 20, "Normal (Recoil +3) M2.3");
            AddToList(recoilLookup, 21, "Normal (Recoil +3)");
            AddToList(recoilLookup, 24, "Normal (Recoil +3) M1.2");
            AddToList(recoilLookup, 32, "Normal (Recoil +3) M4");
            AddToList(recoilLookup, 6, "Normal (Recoil +4) M2.4");
            AddToList(recoilLookup, 8, "Normal (Recoil +4) M1.3");
            AddToList(recoilLookup, 9, "Normal (Recoil +4) M3");
            AddToList(recoilLookup, 12, "Normal (Recoil +4) M1.4");
            AddToList(recoilLookup, 13, "Normal (Recoil +4) M2.3");
            AddToList(recoilLookup, 19, "Normal (Recoil +4) M1.2.4");
            AddToList(recoilLookup, 25, "Normal (Recoil +4) M1.2.3");

            AddToList(recoilLookup, 18, "Cluster (Recoil +1)");
            AddToList(recoilLookup, 14, "Cluster (Recoil +2) M3");
            AddToList(recoilLookup, 27, "Cluster (Recoil +2) M2");
            AddToList(recoilLookup, 15, "Cluster (Recoil +3) M2.4");
            AddToList(recoilLookup, 16, "Cluster (Recoil +3) M4");
            AddToList(recoilLookup, 22, "Cluster (Recoil +3) M2.3");
            AddToList(recoilLookup, 23, "Cluster (Recoil +3) M3");
            AddToList(recoilLookup, 26, "Cluster (Recoil +3) M1.4");

            AddToList(recoilLookup, 28, "Rapid Fire (Recoil +2) M2");
            AddToList(recoilLookup, 29, "Rapid Fire (Recoil +2) M1");
            AddToList(recoilLookup, 30, "Rapid Fire (Recoil +2) M3");
            AddToList(recoilLookup, 36, "Rapid Fire (Recoil +2) M4");
            AddToList(recoilLookup, 31, "Rapid Fire (Recoil +3) M3");
            AddToList(recoilLookup, 33, "Rapid Fire (Recoil +3) M2.3");
            AddToList(recoilLookup, 35, "Rapid Fire (Sticky)");

            AddToList(recoilLookup, 10, "Auto-Reload");
            AddToList(recoilLookup, 17, "Wyvern");

            // Reload
            AddToList(reloadLookup, 17, "Fast Reload");

            AddToList(reloadLookup, 0, "Normal Reload M2");
            AddToList(reloadLookup, 1, "Normal Reload M3");
            AddToList(reloadLookup, 14, "Normal Reload M1");
            AddToList(reloadLookup, 18, "Normal Reload M1.4");

            AddToList(reloadLookup, 2, "Slow Reload M1.4");
            AddToList(reloadLookup, 3, "Slow Reload M1.3");
            AddToList(reloadLookup, 4, "Slow Reload M2.4");
            AddToList(reloadLookup, 5, "Slow Reload M3");
            AddToList(reloadLookup, 11, "Slow Reload M4");
            AddToList(reloadLookup, 15, "Slow Reload M1.2");
            AddToList(reloadLookup, 16, "Slow Reload M2.3");

            AddToList(reloadLookup, 6, "Very Slow Reload M2.4");
            AddToList(reloadLookup, 7, "Very Slow Reload M2.3");
            AddToList(reloadLookup, 8, "Very Slow Reload M1.3");
            AddToList(reloadLookup, 9, "Very Slow Reload M2.3");
            AddToList(reloadLookup, 10, "Very Slow Reload");
            AddToList(reloadLookup, 12, "Very Slow Reload M1.4");
            AddToList(reloadLookup, 13, "Very Slow Reload M1.2.4");
            AddToList(reloadLookup, 19, "Very Slow Reload M1.2.3");
            AddToList(reloadLookup, 20, "Very Slow Reload M1");

            //AddMissing(recoilLookup);
            //AddMissing(reloadLookup);
        }

        public ShellTable(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public static void AddToList(Dictionary<byte, IdNamePair> dict, byte b, string name) {
            // Shouldn't happen unless I accidentally duplicated some of the above numbers.
            if (dict.ContainsKey(b)) throw new Exception("Duplicate key.");
            dict[b] = new IdNamePair(b, name);
        }

        private static void AddMissing(IDictionary<byte, IdNamePair> dict) {
            for (byte i = 0; i < 50; i++) {
                if (dict.ContainsKey(i)) continue;
                dict[i] = new IdNamePair(i, "------------");
            }
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }
}