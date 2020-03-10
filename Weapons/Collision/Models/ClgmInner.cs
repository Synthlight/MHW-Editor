using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct ClgmInner { // 72
        [SortOrder(10)]
        public byte unk1 { get; set; }

        [SortOrder(20)]
        public byte unk2 { get; set; }

        [SortOrder(30)]
        public float unk3 { get; set; }

        [SortOrder(40)]
        public float unk4 { get; set; }

        [SortOrder(50)]
        public float unk5 { get; set; }

        [SortOrder(60)]
        public float unk6 { get; set; }

        [SortOrder(70)]
        public int unk7 { get; set; }

        [SortOrder(80)]
        public float unk8 { get; set; }

        [SortOrder(90)]
        public float unk9 { get; set; }

        [SortOrder(100)]
        public float unk10 { get; set; }

        [SortOrder(110)]
        public float unk11 { get; set; }

        [SortOrder(120)]
        public float unk12 { get; set; }

        [SortOrder(130)]
        public float unk13 { get; set; }

        [SortOrder(140)]
        public ushort unk14 { get; set; }

        [SortOrder(150)]
        public uint unk15 { get; set; }

        [SortOrder(160)]
        public short unk16 { get; set; }

        [SortOrder(170)]
        public float unk17 { get; set; }

        [SortOrder(180)]
        public float unk18 { get; set; }

        [SortOrder(190)]
        public float unk19 { get; set; }

        [SortOrder(200)]
        public float unk20 { get; set; }

        [SortOrder(210)]
        public ushort unk21 { get; set; }
    }
}