using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class EqCrt : MhwItem {
        public static readonly Dictionary<string, Dictionary<byte, IdNamePair>> categoryLookup = new Dictionary<string, Dictionary<byte, IdNamePair>>();

        static EqCrt() {
            byte i = 0;
            categoryLookup["armor"] = new Dictionary<byte, IdNamePair> {
                {i, new IdNamePair(i++, "Head")},
                {i, new IdNamePair(i++, "Chest")},
                {i, new IdNamePair(i++, "Waist")},
                {i, new IdNamePair(i++, "Arms")},
                {i, new IdNamePair(i++, "Legs")},
                {i, new IdNamePair(i, "Charm")}
            };
            i = 0;
            categoryLookup["ot"] = new Dictionary<byte, IdNamePair> {
                {i, new IdNamePair(i++, "Weapon")},
                {i, new IdNamePair(i++, "Head")},
                {i, new IdNamePair(i, "Body")}
            };
            i = 0;
            categoryLookup["weapon"] = new Dictionary<byte, IdNamePair> {
                {i, new IdNamePair(i++, "Greatsword")},
                {i, new IdNamePair(i++, "Longsword")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i++, "Unknown")},
                {i, new IdNamePair(i, "Unknown")}
            };
        }

        public EqCrt(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}