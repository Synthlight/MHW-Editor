using System;
using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable : MhwItem {
        public static readonly Dictionary<byte, IdNamePair> recoilLookup = new Dictionary<byte, IdNamePair>();
        public static readonly Dictionary<byte, IdNamePair> reloadLookup = new Dictionary<byte, IdNamePair>();

        // Recoil
        public static readonly byte[] normalRec1 = {0x00};
        public static readonly byte[] normalRec2 = {0x01, 0x02, 0x03};
        public static readonly byte[] normalRec3 = {0x04, 0x05, 0x07, 0x0b, 0x14, 0x15, 0x18, 0x20};
        public static readonly byte[] normalRec4 = {0x06, 0x08, 0x09, 0x0c, 0x0d, 0x13, 0x19};
        public static readonly byte[] rapidFireRec2 = {0x1c, 0x1d, 0x1e};
        public static readonly byte[] rapidFireRec3 = {0x1f, 0x21};
        public static readonly byte[] followUpRec1 = {0x12};
        public static readonly byte[] followUpRec2 = {0x0e, 0x1b};
        public static readonly byte[] followUpRec3 = {0x0f, 0x10, 0x16, 0x17, 0x1a};
        public static readonly byte[] autoReload = {0x0a};
        public static readonly byte[] wyvern = {0x11};
        // Reload
        public static readonly byte[] fast = {0x11};
        public static readonly byte[] normal = {0x00, 0x01, 0x0e, 0x12};
        public static readonly byte[] slow = {0x02, 0x03, 0x04, 0x05, 0x0b, 0x0f, 0x10};
        public static readonly byte[] varySlow = {0x06, 0x07, 0x08, 0x09, 0x0a, 0x0c, 0x0d};

        static ShellTable() {
            // Recoil
            AddToList(recoilLookup, normalRec1, "Normal (Recoil +1)");
            AddToList(recoilLookup, normalRec2, "Normal (Recoil +2)");
            AddToList(recoilLookup, normalRec3, "Normal (Recoil +3)");
            AddToList(recoilLookup, normalRec4, "Normal (Recoil +4)");
            AddToList(recoilLookup, rapidFireRec2, "Rapid Fire (Recoil +2)");
            AddToList(recoilLookup, rapidFireRec3, "Rapid Fire (Recoil +3)");
            AddToList(recoilLookup, followUpRec1, "Follow-Up (Recoil +1)");
            AddToList(recoilLookup, followUpRec2, "Follow-Up (Recoil +2)");
            AddToList(recoilLookup, followUpRec3, "Follow-Up (Recoil +3)");
            AddToList(recoilLookup, autoReload, "Auto-Reload");
            AddToList(recoilLookup, wyvern, "Wyvern");
            // Reload
            AddToList(reloadLookup, fast, "Fast");
            AddToList(reloadLookup, normal, "Normal");
            AddToList(reloadLookup, slow, "Slow");
            AddToList(reloadLookup, varySlow, "Very Slow");
        }

        public ShellTable(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public static void AddToList(Dictionary<byte, IdNamePair> dict, IEnumerable<byte> values, string name) {
            foreach (var b in values) {
                // Shouldn't happen unless I accidentally duplicated some of the above numbers.
                if (dict.ContainsKey(b)) throw new Exception("Duplicate key.");
                dict[b] = new IdNamePair(b, name); //$"{name} 0x{b:X2}"
            }
        }

        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}