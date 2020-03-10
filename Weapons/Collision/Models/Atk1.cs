using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct Atk1 : IAtk { // 218
        [DisplayName("Move Id")]
        [SortOrder(10)]
        public uint index { get; set; } // 0

        [DisplayName("Attack Type")]
        [SortOrder(20)]
        public uint attack_type { get; set; } // 4

        [DisplayName("Motion Value")]
        [SortOrder(30)]
        public float motion_value { get; set; } // 8

        [DisplayName("Fixed Damage")]
        [SortOrder(40)]
        public float fixed_damage { get; set; } // 12

        [DisplayName("Part Modifier")]
        [SortOrder(50)]
        public float part_modifier { get; set; } // 16

        [DisplayName("Elemental Modifier")]
        [SortOrder(60)]
        public float elemental_modifier { get; set; } // 20

        [DisplayName("Status Modifier")]
        [SortOrder(70)]
        public float status_modifier { get; set; } // 24

        [DisplayName("Stun")]
        [SortOrder(80)]
        public float stun { get; set; } // 28

        [DisplayName("Exhaust")]
        [SortOrder(90)]
        public float exhaust { get; set; } // 32

        [DisplayName("Mount")]
        [SortOrder(100)]
        public float mount { get; set; } // 36

        [SortOrder(110)]
        public float unk12 { get; set; } // 40

        [SortOrder(120)]
        public float unk13 { get; set; } // 44

        [SortOrder(130)]
        public byte unk14 { get; set; } // 48

        [DisplayName("Soften Value")]
        [SortOrder(140)]
        public float soften_value { get; set; } // 49

        [SortOrder(150)]
        public float unk16 { get; set; } // 53

        [SortOrder(160)]
        public float unk17 { get; set; } // 57

        [SortOrder(170)]
        public float unk18 { get; set; } // 61

        [SortOrder(180)]
        public float unk19 { get; set; } // 65

        [SortOrder(190)]
        public float unk20 { get; set; } // 69

        [SortOrder(200)]
        public float unk21 { get; set; } // 73

        [SortOrder(210)]
        public float unk22 { get; set; } // 77

        [SortOrder(220)]
        public float unk23 { get; set; } // 81

        [DisplayName("Flinch Value")]
        [SortOrder(230)]
        public uint flinch_value { get; set; } // 85

        [SortOrder(240)]
        public uint unk25 { get; set; } // 89

        [DisplayName("Mind's Eye")]
        [SortOrder(250)]
        public byte minds_eye { get; set; } // 93

        [SortOrder(260)]
        public float unk27 { get; set; } // 94

        [SortOrder(270)]
        public float unk28 { get; set; } // 98

        [SortOrder(280)]
        public byte unk29 { get; set; } // 102

        [SortOrder(290)]
        public float unk30 { get; set; } // 103

        [SortOrder(300)]
        public float unk31 { get; set; } // 107

        [DisplayName("Hit Lag (a)")]
        [SortOrder(310)]
        public float hit_lag_a { get; set; } // 111

        [SortOrder(320)]
        public float unk33 { get; set; } // 115

        [SortOrder(330)]
        public float unk34 { get; set; } // 119

        [SortOrder(340)]
        public float unk35 { get; set; } // 123

        [SortOrder(350)]
        public float unk36 { get; set; } // 127

        [DisplayName("Hit Lag (b)")]
        [SortOrder(360)]
        public float hit_lag_b { get; set; } // 131

        [SortOrder(370)]
        public float unk38 { get; set; } // 135

        [SortOrder(380)]
        public float unk39 { get; set; } // 139

        [SortOrder(390)]
        public uint unk40 { get; set; } // 143

        [SortOrder(400)]
        public sbyte unk41 { get; set; } // 147

        [SortOrder(410)]
        public byte unk42 { get; set; } // 148

        [SortOrder(420)]
        public uint unk43 { get; set; } // 149

        [SortOrder(430)]
        public float unk44 { get; set; } // 153

        [SortOrder(440)]
        public float unk45 { get; set; } // 157

        [SortOrder(450)]
        public float unk46 { get; set; } // 161

        [SortOrder(460)]
        public byte unk47 { get; set; } // 165

        [SortOrder(470)]
        public float unk48 { get; set; } // 166

        [SortOrder(480)]
        public uint unk49 { get; set; } // 170

        [SortOrder(490)]
        public ushort unk50 { get; set; } // 174

        [DisplayName("Sprite Gen")]
        [SortOrder(500)]
        public float sprite_gen { get; set; } // 176

        [DisplayName("Motion Value (From Spending Enough Sprite)")]
        [SortOrder(510)]
        public float motion_value_from_spending_enough_sprite { get; set; } // 180

        [SortOrder(520)]
        public float unk53 { get; set; } // 184

        [SortOrder(530)]
        public uint unk54 { get; set; } // 188

        [SortOrder(540)]
        public uint unk55 { get; set; } // 192

        [SortOrder(550)]
        public uint unk56 { get; set; } // 196

        [SortOrder(560)]
        public uint unk57 { get; set; } // 200

        [SortOrder(570)]
        public uint unk58 { get; set; } // 204

        [SortOrder(580)]
        public uint unk59 { get; set; } // 208

        [SortOrder(590)]
        public uint unk60 { get; set; } // 212

        [SortOrder(600)]
        public ushort unk61 { get; set; } // 216
    }
}