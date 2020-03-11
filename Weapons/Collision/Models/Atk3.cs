using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class Atk3 : IAtk { // 199
        [IsReadOnly]
        [DisplayName("Move Id")]
        [SortOrder(10)]
        public uint moveId { get; set; } // 0

        [DisplayName("Damage Type 1")]
        [SortOrder(20)]
        public uint damageType1 { get; set; } // 4

        [DisplayName("Damage Type 2")]
        [SortOrder(30)]
        public uint damageType2 { get; set; } // 8

        [DisplayName("Damage Motion Value")]
        [SortOrder(40)]
        public float damageMotionValue { get; set; } // 12

        [DisplayName("Fixed Damage")]
        [SortOrder(50)]
        public float Fixed_Damage { get; set; } // 16

        [DisplayName("Modifier PartDamage")]
        [SortOrder(60)]
        public float Modifier_partDamage { get; set; } // 20

        [DisplayName("Element Type")]
        [SortOrder(70)]
        public uint Element_Type { get; set; } // 24

        [DisplayName("Fixed Elemental Damage")]
        [SortOrder(80)]
        public float Fixed_Elemental_Damage { get; set; } // 28

        [DisplayName("Modifier Element")]
        [SortOrder(90)]
        public float Modifier_element { get; set; } // 32

        [DisplayName("Modifier Status")]
        [SortOrder(100)]
        public float Modifier_status { get; set; } // 36

        [DisplayName("Fixed Status Value: Poison")]
        [SortOrder(110)]
        public float Fixed_statusValue_Poison { get; set; } // 40

        [DisplayName("Fixed Status Value: Paralysis")]
        [SortOrder(120)]
        public float Fixed_statusValue_Paralysis { get; set; } // 44

        [DisplayName("Fixed Status Value: Sleep")]
        [SortOrder(130)]
        public float Fixed_statusValue_Sleep { get; set; } // 48

        [DisplayName("Fixed Status Value: Blast")]
        [SortOrder(140)]
        public float Fixed_statusValue_Blast { get; set; } // 52

        [DisplayName("Extra Stun")]
        [SortOrder(150)]
        public float extraStun { get; set; } // 56

        [DisplayName("Extra Exhaust")]
        [SortOrder(160)]
        public float extraExhaust { get; set; } // 60

        [DisplayName("Fixed Status Value: Traq")]
        [SortOrder(170)]
        public float Fixed_statusValue_Traq { get; set; } // 64

        [SortOrder(180)]
        public float unk1 { get; set; } // 68

        [SortOrder(190)]
        public float unk2 { get; set; } // 72

        [DisplayName("Soften Value")]
        [SortOrder(200)]
        public float Soften_Value { get; set; } // 76

        [SortOrder(210)]
        public float unk3 { get; set; } // 80

        [SortOrder(220)]
        public float unk4 { get; set; } // 84

        [SortOrder(230)]
        public float unk5 { get; set; } // 88

        [SortOrder(240)]
        public float unk6 { get; set; } // 92

        [SortOrder(250)]
        public float unk7 { get; set; } // 96

        [SortOrder(260)]
        public float unk8 { get; set; } // 100

        [SortOrder(270)]
        public uint unk9 { get; set; } // 104

        [SortOrder(280)]
        public uint unk10 { get; set; } // 108

        [SortOrder(290)]
        public uint unk11 { get; set; } // 112

        [SortOrder(300)]
        public uint unk12 { get; set; } // 116

        [SortOrder(310)]
        public uint unk13 { get; set; } // 120

        [SortOrder(320)]
        public uint unk14 { get; set; } // 124

        [SortOrder(330)]
        public sbyte unk15 { get; set; } // 128

        [SortOrder(340)]
        public byte unk16 { get; set; } // 129

        [SortOrder(350)]
        public byte unk17 { get; set; } // 130

        [SortOrder(360)]
        public uint unk18 { get; set; } // 131

        [SortOrder(370)]
        public uint unk19 { get; set; } // 135

        [SortOrder(380)]
        public float unk20 { get; set; } // 139

        [SortOrder(390)]
        public uint unk21 { get; set; } // 143

        [DisplayName("Piercing Attack")]
        [SortOrder(400)]
        public byte piercingAttack { get; set; } // 147

        [DisplayName("Delay Between Attack Frames")]
        [SortOrder(410)]
        public float delayBetweenAttackFrames { get; set; } // 148

        [SortOrder(420)]
        public byte unk24 { get; set; } // 152

        [SortOrder(430)]
        public uint unk25 { get; set; } // 153

        [SortOrder(440)]
        public uint unk26 { get; set; } // 157

        [SortOrder(450)]
        public uint unk27 { get; set; } // 161

        [SortOrder(460)]
        public uint unk28 { get; set; } // 165

        [SortOrder(470)]
        public uint unk29 { get; set; } // 169

        [SortOrder(480)]
        public uint unk30 { get; set; } // 173

        [SortOrder(490)]
        public uint unk31 { get; set; } // 177

        [SortOrder(500)]
        public uint unk32 { get; set; } // 181

        [SortOrder(510)]
        public uint unk33 { get; set; } // 185

        [SortOrder(520)]
        public uint unk34 { get; set; } // 189

        [SortOrder(530)]
        public uint unk35 { get; set; } // 193

        [SortOrder(540)]
        public ushort unk36 { get; set; } // 197
    }
}