using System;
using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable : MhwItem {
        public static readonly Dictionary<byte, IdNamePair> recoilLookup = new Dictionary<byte, IdNamePair>();
        public static readonly Dictionary<byte, IdNamePair> reloadLookup = new Dictionary<byte, IdNamePair>();

        static ShellTable() {
            // Recoil
            recoilLookup.Add(0, "Normal (Recoil +1)");

            recoilLookup.Add(1, "Normal (Recoil +2) M1");
            recoilLookup.Add(2, "Normal (Recoil +2) M2");
            recoilLookup.Add(3, "Normal (Recoil +2) M3");
            recoilLookup.Add(34, "Normal (Recoil +2) M4");

            recoilLookup.Add(24, "Normal (Recoil +3) M1.2");
            recoilLookup.Add(11, "Normal (Recoil +3) M1.3");
            recoilLookup.Add(7, "Normal (Recoil +3) M1.4");
            recoilLookup.Add(20, "Normal (Recoil +3) M2.3");
            recoilLookup.Add(5, "Normal (Recoil +3) M2.4");
            recoilLookup.Add(4, "Normal (Recoil +3) M3");
            recoilLookup.Add(32, "Normal (Recoil +3) M4");

            recoilLookup.Add(25, "Normal (Recoil +4) M1.2.3");
            recoilLookup.Add(19, "Normal (Recoil +4) M1.2.4");
            recoilLookup.Add(8, "Normal (Recoil +4) M1.3");
            recoilLookup.Add(12, "Normal (Recoil +4) M1.4");
            recoilLookup.Add(13, "Normal (Recoil +4) M2.3");
            recoilLookup.Add(6, "Normal (Recoil +4) M2.4");
            recoilLookup.Add(9, "Normal (Recoil +4) M3");
            recoilLookup.Add(21, "Normal (Recoil +4)");

            recoilLookup.Add(18, "Cluster (Recoil +1)");

            recoilLookup.Add(27, "Cluster (Recoil +2) M2");
            recoilLookup.Add(14, "Cluster (Recoil +2) M3");

            recoilLookup.Add(26, "Cluster (Recoil +3) M1.4");
            recoilLookup.Add(22, "Cluster (Recoil +3) M2.3");
            recoilLookup.Add(15, "Cluster (Recoil +3) M2.4");
            recoilLookup.Add(23, "Cluster (Recoil +3) M3");
            recoilLookup.Add(16, "Cluster (Recoil +3) M4");

            recoilLookup.Add(29, "Rapid Fire (Recoil +2) M1");
            recoilLookup.Add(28, "Rapid Fire (Recoil +2) M2");
            recoilLookup.Add(30, "Rapid Fire (Recoil +2) M3");
            recoilLookup.Add(36, "Rapid Fire (Recoil +2) M4");

            recoilLookup.Add(33, "Rapid Fire (Recoil +3) M2.3");
            recoilLookup.Add(31, "Rapid Fire (Recoil +3) M3");

            recoilLookup.Add(35, "Rapid Fire (Sticky)");

            recoilLookup.Add(10, "Auto-Reload");
            recoilLookup.Add(17, "Wyvern");

            // Reload
            reloadLookup.Add(17, "Fast Reload");

            reloadLookup.Add(14, "Normal Reload M1");
            reloadLookup.Add(0, "Normal Reload M2");
            reloadLookup.Add(1, "Normal Reload M3");
            reloadLookup.Add(18, "Normal Reload M4");

            reloadLookup.Add(15, "Slow Reload M1.2");
            reloadLookup.Add(3, "Slow Reload M1.3");
            reloadLookup.Add(2, "Slow Reload M1.4");
            reloadLookup.Add(16, "Slow Reload M2.3");
            reloadLookup.Add(4, "Slow Reload M2.4");
            reloadLookup.Add(5, "Slow Reload M3");
            reloadLookup.Add(11, "Slow Reload M4");

            reloadLookup.Add(19, "Very Slow Reload M1.2.3");
            reloadLookup.Add(13, "Very Slow Reload M1.2.4");
            reloadLookup.Add(8, "Very Slow Reload M1.3");
            reloadLookup.Add(12, "Very Slow Reload M1.4");
            reloadLookup.Add(20, "Very Slow Reload M1");
            reloadLookup.Add(9, "Very Slow Reload M2.3");
            reloadLookup.Add(6, "Very Slow Reload M2.4");
            reloadLookup.Add(7, "Very Slow Reload M3");
            reloadLookup.Add(10, "Very Slow Reload");
        }

        public ShellTable(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }

    public static class ShellTableExtensions {
        public static void Add(this Dictionary<byte, IdNamePair> dict, byte key, string name) {
            // Shouldn't happen unless I accidentally duplicated some of the above numbers.
            if (dict.ContainsKey(key)) throw new Exception("Duplicate key.");
            dict[key] = new IdNamePair(key, name);
        }
    }
}