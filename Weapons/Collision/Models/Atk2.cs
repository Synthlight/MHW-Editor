using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class Atk2 : IAtk { // 171
        [IsReadOnly]
        [DisplayName("Move Id")]
        [SortOrder(10)]
        public uint moveId { get; set; } // 0

        [DisplayName("Knock-back Type")]
        [SortOrder(20)]
        public uint knockBackType { get; set; } // 4

        [DisplayName("Knock-back Lvl")]
        [SortOrder(30)]
        public uint knockBackLvl { get; set; } // 8

        [SortOrder(40)]
        public uint unk3 { get; set; } // 12

        [DisplayName("Motion Value")]
        [SortOrder(50)]
        public float motionValue { get; set; } // 16

        [SortOrder(60)]
        public uint unk5 { get; set; } // 20

        [SortOrder(70)]
        public uint unk6 { get; set; } // 24

        [DisplayName("Guard Stamina Cost")]
        [SortOrder(80)]
        public float guardStaminaCost { get; set; } // 28

        [DisplayName("Guard Req")]
        [SortOrder(90)]
        public uint guardReq { get; set; } // 32

        [DisplayName("Element Id")]
        [SortOrder(100)]
        public uint elementId { get; set; } // 36

        [SortOrder(110)]
        public uint unk10 { get; set; } // 40

        [DisplayName("Element Dmg")]
        [SortOrder(120)]
        public float elementDmg { get; set; } // 44

        [SortOrder(130)]
        public float unk12 { get; set; } // 48

        [DisplayName("Deadly Poison")]
        [SortOrder(140)]
        public float deadlyPoison { get; set; } // 52

        [DisplayName("Paralysis")]
        [SortOrder(150)]
        public float paralysis { get; set; } // 56

        [DisplayName("Sleep")]
        [SortOrder(160)]
        public float sleep { get; set; } // 60

        [DisplayName("Blast")]
        [SortOrder(170)]
        public float blast { get; set; } // 64

        [DisplayName("Blast Scourge")]
        [SortOrder(180)]
        public float blastScourge { get; set; } // 68

        [DisplayName("Stun")]
        [SortOrder(190)]
        public float stun { get; set; } // 72

        [DisplayName("Bleed")]
        [SortOrder(200)]
        public float bleed { get; set; } // 76

        [DisplayName("Miasma")]
        [SortOrder(210)]
        public float miasma { get; set; } // 80

        [DisplayName("Ele Res Down Double")]
        [SortOrder(220)]
        public byte eleResDownDouble { get; set; } // 84

        [DisplayName("Ele Res Down")]
        [SortOrder(221)]
        public byte eleResDown { get; set; } // 85

        [DisplayName("Def Down Double")]
        [SortOrder(222)]
        public byte defDownDouble { get; set; } // 86

        [DisplayName("Def Down")]
        [SortOrder(223)]
        public byte defDown { get; set; } // 87

        [SortOrder(230)]
        public uint unk22 { get; set; } // 88

        [SortOrder(240)]
        public uint unk23 { get; set; } // 92

        [SortOrder(250)]
        public float unk24 { get; set; } // 96

        [SortOrder(260)]
        public float unk25 { get; set; } // 100

        [SortOrder(270)]
        public float unk26 { get; set; } // 104

        [SortOrder(280)]
        public float unk27 { get; set; } // 108

        [SortOrder(290)]
        public float unk28 { get; set; } // 112

        [SortOrder(300)]
        public uint unk29 { get; set; } // 116

        [SortOrder(310)]
        public uint unk30 { get; set; } // 120

        [SortOrder(320)]
        public uint unk31 { get; set; } // 124

        [SortOrder(330)]
        public byte unk32 { get; set; } // 125

        [SortOrder(340)]
        public float unk33 { get; set; } // 129

        [SortOrder(350)]
        public uint unk34 { get; set; } // 133

        [SortOrder(360)]
        public uint unk35 { get; set; } // 137

        [SortOrder(370)]
        public uint unk36 { get; set; } // 141

        [SortOrder(380)]
        public uint unk37 { get; set; } // 145

        [SortOrder(390)]
        public uint unk38 { get; set; } // 149

        [SortOrder(400)]
        public uint unk39 { get; set; } // 153

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