using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct OapInner3 : IOapInner { // 48
        [SortOrder(10)]
        public uint unk1 { get; set; }

        [SortOrder(20)]
        public ushort unk2 { get; set; }

        [SortOrder(30)]
        public ushort unk3 { get; set; }

        [SortOrder(40)]
        public uint unk4 { get; set; }

        [SortOrder(50)]
        public uint unk5 { get; set; }

        [SortOrder(60)]
        public uint unk6 { get; set; }

        [SortOrder(70)]
        public int unk7 { get; set; }

        [SortOrder(80)]
        public uint unk8 { get; set; }

        [SortOrder(90)]
        public uint unk9 { get; set; }

        [SortOrder(100)]
        public uint unk10 { get; set; }

        [SortOrder(110)]
        public int unk11 { get; set; }

        [SortOrder(120)]
        public uint unk12 { get; set; }

        [SortOrder(130)]
        public uint unk13 { get; set; }
    }
}