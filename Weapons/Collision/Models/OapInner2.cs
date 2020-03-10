using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct OapInner2 : IOapInner { // 13
        [SortOrder(10)]
        public uint unk1 { get; set; }

        [SortOrder(20)]
        public uint unk2 { get; set; }

        [SortOrder(30)]
        public uint unk3 { get; set; }

        [SortOrder(40)]
        public byte unk4 { get; set; }
    }
}