using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class GunnerShoot : MhwSingleStructFile<GunnerShoot, GunnerShoot.Entries> {
        public static readonly Dictionary<byte, string> recoilLookup = new Dictionary<byte, string> {
            {0, "Normal +1"},
            {1, "Normal +2"},
            {6, "Normal +3"},
            {7, "Normal +4"},
            {3, "Rapid +1"},
            {4, "Rapid +2"},
            {8, "Rapid +3"},
            {2, "Auto-Reload"},
            {9, "Wyvern"},
            {10, "Cluster +1"},
            {11, "Cluster +2"},
            {12, "Cluster +3"},
            {13, "Rapid Sticky"}
        };

        public partial class Entries {
            [SortOrder(20)]
            public ulong Id => Index;
        }
    }
}