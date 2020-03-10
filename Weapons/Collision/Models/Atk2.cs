using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct Atk2 : IAtk { // 171
        [IsReadOnly]
        [DisplayName("Move Id")]
        [SortOrder(10)]
        public uint Index { get; set; } // 0

        [SortOrder(20)]
        public uint unk1 { get; set; } // 4

        [SortOrder(30)]
        public uint unk2 { get; set; } // 8

        [SortOrder(40)]
        public uint unk3 { get; set; } // 12

        [SortOrder(50)]
        public float unk4 { get; set; } // 16

        [SortOrder(60)]
        public uint unk5 { get; set; } // 20

        [SortOrder(70)]
        public uint unk6 { get; set; } // 24

        [SortOrder(80)]
        public float unk7 { get; set; } // 28

        [SortOrder(90)]
        public uint unk8 { get; set; } // 32

        [SortOrder(100)]
        public uint unk9 { get; set; } // 36

        [SortOrder(110)]
        public uint unk10 { get; set; } // 40

        [SortOrder(120)]
        public uint unk11 { get; set; } // 44

        [SortOrder(130)]
        public uint unk12 { get; set; } // 48

        [SortOrder(140)]
        public uint unk13 { get; set; } // 52

        [SortOrder(150)]
        public uint unk14 { get; set; } // 56

        [SortOrder(160)]
        public uint unk15 { get; set; } // 60

        [SortOrder(170)]
        public uint unk16 { get; set; } // 64

        [SortOrder(180)]
        public uint unk17 { get; set; } // 68

        [SortOrder(190)]
        public float unk18 { get; set; } // 72

        [SortOrder(200)]
        public uint unk19 { get; set; } // 76

        [SortOrder(210)]
        public uint unk20 { get; set; } // 80

        [SortOrder(220)]
        public uint unk21 { get; set; } // 84

        [SortOrder(230)]
        public uint unk22 { get; set; } // 88

        [SortOrder(240)]
        public uint unk23 { get; set; } // 92

        [SortOrder(250)]
        public uint unk24 { get; set; } // 96

        [SortOrder(260)]
        public float unk25 { get; set; } // 100

        [SortOrder(270)]
        public float unk26 { get; set; } // 104

        [SortOrder(280)]
        public float unk27 { get; set; } // 108

        [SortOrder(290)]
        public uint unk28 { get; set; } // 112

        [SortOrder(300)]
        public uint unk29 { get; set; } // 116

        [SortOrder(310)]
        public uint unk30 { get; set; } // 120

        [SortOrder(320)]
        public uint unk31 { get; set; } // 124

        [SortOrder(330)]
        public uint unk32 { get; set; } // 128

        [SortOrder(340)]
        public uint unk33 { get; set; } // 132

        [SortOrder(350)]
        public uint unk34 { get; set; } // 136

        [SortOrder(360)]
        public uint unk35 { get; set; } // 140

        [SortOrder(370)]
        public uint unk36 { get; set; } // 144

        [SortOrder(380)]
        public uint unk37 { get; set; } // 148

        [SortOrder(390)]
        public uint unk38 { get; set; } // 152

        [SortOrder(400)]
        public byte unk39 { get; set; } // 156

        [SortOrder(410)]
        public uint unk40 { get; set; } // 157

        [SortOrder(420)]
        public uint unk41 { get; set; } // 161

        [SortOrder(430)]
        public uint unk42 { get; set; } // 165

        [SortOrder(440)]
        public ushort unk43 { get; set; } // 169
    }
}