using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class Atk0 : IAtk { // 179
        [IsReadOnly]
        [DisplayName("Move Id")]
        [SortOrder(10)]
        public uint moveId { get; set; } // 0

        [SortOrder(20)]
        public uint unk10 { get; set; } // 4

        [SortOrder(30)]
        public uint unk20 { get; set; } // 8

        [SortOrder(40)]
        public float unk30 { get; set; } // 12

        [SortOrder(50)]
        public float unk40 { get; set; } // 16

        [SortOrder(60)]
        public float unk50 { get; set; } // 20

        [SortOrder(70)]
        public uint unk60 { get; set; } // 24

        [SortOrder(80)]
        public uint unk70 { get; set; } // 28

        [SortOrder(90)]
        public uint unk80 { get; set; } // 32

        [SortOrder(100)]
        public uint unk90 { get; set; } // 36

        [SortOrder(110)]
        public uint unk100 { get; set; } // 40

        [SortOrder(120)]
        public uint unk110 { get; set; } // 44

        [SortOrder(130)]
        public uint unk120 { get; set; } // 48

        [SortOrder(140)]
        public uint unk130 { get; set; } // 52

        [SortOrder(150)]
        public uint unk140 { get; set; } // 56

        [SortOrder(160)]
        public uint unk150 { get; set; } // 60

        [SortOrder(170)]
        public uint unk160 { get; set; } // 64

        [SortOrder(180)]
        public uint unk170 { get; set; } // 68

        [SortOrder(190)]
        public uint unk180 { get; set; } // 72

        [SortOrder(200)]
        public uint unk190 { get; set; } // 76

        [SortOrder(210)]
        public uint unk200 { get; set; } // 80

        [SortOrder(220)]
        public uint unk210 { get; set; } // 84

        [SortOrder(230)]
        public uint unk220 { get; set; } // 88

        [SortOrder(240)]
        public float unk230 { get; set; } // 92

        [SortOrder(250)]
        public float unk240 { get; set; } // 96

        [SortOrder(260)]
        public float unk250 { get; set; } // 100

        [SortOrder(270)]
        public uint unk260 { get; set; } // 104

        [SortOrder(280)]
        public uint unk270 { get; set; } // 108

        [SortOrder(290)]
        public uint unk280 { get; set; } // 112

        [SortOrder(300)]
        public uint unk290 { get; set; } // 116

        [SortOrder(310)]
        public float unk300 { get; set; } // 120

        [SortOrder(320)]
        public uint unk310 { get; set; } // 124

        [SortOrder(330)]
        public uint unk320 { get; set; } // 128

        [SortOrder(340)]
        public byte unk330 { get; set; } // 132

        [SortOrder(350)]
        public uint unk340 { get; set; } // 133

        [SortOrder(360)]
        public float unk350 { get; set; } // 137

        [SortOrder(370)]
        public float unk360 { get; set; } // 141

        [SortOrder(380)]
        public uint unk370 { get; set; } // 145

        [SortOrder(390)]
        public uint unk380 { get; set; } // 149

        [SortOrder(400)]
        public uint unk390 { get; set; } // 153

        [SortOrder(410)]
        public uint unk400 { get; set; } // 157

        [SortOrder(420)]
        public uint unk410 { get; set; } // 161

        public uint unk420 { get; set; } // 165

        [SortOrder(440)]
        public uint unk430 { get; set; } // 169

        [SortOrder(450)]
        public uint unk440 { get; set; } // 173

        [SortOrder(460)]
        public ushort unk450 { get; set; } // 177
    }
}