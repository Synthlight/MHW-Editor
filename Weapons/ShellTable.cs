using System;
using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable : MhwItem {
        public static readonly Dictionary<byte, IdNamePair<byte>> recoilLookup = new Dictionary<byte, IdNamePair<byte>>();
        public static readonly Dictionary<byte, IdNamePair<byte>> reloadLookup = new Dictionary<byte, IdNamePair<byte>>();

        static ShellTable() {
            // Recoil
            recoilLookup.Add((byte) 0, "Normal (Recoil +1)");

            recoilLookup.Add((byte) 1, "Normal (Recoil +2) M1");
            recoilLookup.Add((byte) 2, "Normal (Recoil +2) M2");
            recoilLookup.Add((byte) 3, "Normal (Recoil +2) M3");
            recoilLookup.Add((byte) 36, "Normal (Recoil +2) M4");

            recoilLookup.Add((byte) 24, "Normal (Recoil +3) M1.2");
            recoilLookup.Add((byte) 11, "Normal (Recoil +3) M1.3");
            recoilLookup.Add((byte) 7, "Normal (Recoil +3) M1.4");
            recoilLookup.Add((byte) 20, "Normal (Recoil +3) M2.3");
            recoilLookup.Add((byte) 5, "Normal (Recoil +3) M2.4");
            recoilLookup.Add((byte) 4, "Normal (Recoil +3) M3");
            recoilLookup.Add((byte) 32, "Normal (Recoil +3) M4");

            recoilLookup.Add((byte) 25, "Normal (Recoil +4) M1.2.3");
            recoilLookup.Add((byte) 19, "Normal (Recoil +4) M1.2.4");
            recoilLookup.Add((byte) 8, "Normal (Recoil +4) M1.3");
            recoilLookup.Add((byte) 12, "Normal (Recoil +4) M1.4");
            recoilLookup.Add((byte) 13, "Normal (Recoil +4) M2.3");
            recoilLookup.Add((byte) 6, "Normal (Recoil +4) M2.4");
            recoilLookup.Add((byte) 9, "Normal (Recoil +4) M3");
            recoilLookup.Add((byte) 21, "Normal (Recoil +4)");

            recoilLookup.Add((byte) 18, "Cluster (Recoil +1)");

            recoilLookup.Add((byte) 27, "Cluster (Recoil +2) M2");
            recoilLookup.Add((byte) 14, "Cluster (Recoil +2) M3");

            recoilLookup.Add((byte) 26, "Cluster (Recoil +3) M1.4");
            recoilLookup.Add((byte) 22, "Cluster (Recoil +3) M2.3");
            recoilLookup.Add((byte) 15, "Cluster (Recoil +3) M2.4");
            recoilLookup.Add((byte) 23, "Cluster (Recoil +3) M3");
            recoilLookup.Add((byte) 16, "Cluster (Recoil +3) M4");

            recoilLookup.Add((byte) 29, "Rapid Fire (Recoil +2) M1");
            recoilLookup.Add((byte) 28, "Rapid Fire (Recoil +2) M2");
            recoilLookup.Add((byte) 30, "Rapid Fire (Recoil +2) M3");
            recoilLookup.Add((byte) 34, "Rapid Fire (Recoil +2) M4");

            recoilLookup.Add((byte) 33, "Rapid Fire (Recoil +3) M2.3");
            recoilLookup.Add((byte) 31, "Rapid Fire (Recoil +3) M3");

            recoilLookup.Add((byte) 35, "Rapid Fire (Sticky)");

            recoilLookup.Add((byte) 10, "Auto-Reload");
            recoilLookup.Add((byte) 17, "Wyvern");

            // Reload
            reloadLookup.Add((byte) 17, "Fast Reload");

            reloadLookup.Add((byte) 14, "Normal Reload M1");
            reloadLookup.Add((byte) 0, "Normal Reload M2");
            reloadLookup.Add((byte) 1, "Normal Reload M3");
            reloadLookup.Add((byte) 18, "Normal Reload M4");

            reloadLookup.Add((byte) 15, "Slow Reload M1.2");
            reloadLookup.Add((byte) 3, "Slow Reload M1.3");
            reloadLookup.Add((byte) 2, "Slow Reload M1.4");
            reloadLookup.Add((byte) 16, "Slow Reload M2.3");
            reloadLookup.Add((byte) 4, "Slow Reload M2.4");
            reloadLookup.Add((byte) 5, "Slow Reload M3");
            reloadLookup.Add((byte) 11, "Slow Reload M4");

            reloadLookup.Add((byte) 19, "Very Slow Reload M1.2.3");
            reloadLookup.Add((byte) 13, "Very Slow Reload M1.2.4");
            reloadLookup.Add((byte) 8, "Very Slow Reload M1.3");
            reloadLookup.Add((byte) 12, "Very Slow Reload M1.4");
            reloadLookup.Add((byte) 20, "Very Slow Reload M1");
            reloadLookup.Add((byte) 9, "Very Slow Reload M2.3");
            reloadLookup.Add((byte) 6, "Very Slow Reload M2.4");
            reloadLookup.Add((byte) 7, "Very Slow Reload M3");
            reloadLookup.Add((byte) 10, "Very Slow Reload");
        }

        public ShellTable(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }

    public static class ShellTableExtensions {
        public static void Add<T>(this Dictionary<T, IdNamePair<T>> dict, T key, string name) where T : struct {
            // Shouldn't happen unless I accidentally duplicated some of the above numbers.
            if (dict.ContainsKey(key)) throw new Exception("Duplicate key.");
            dict[key] = new IdNamePair<T>(key, name);
        }
    }
}