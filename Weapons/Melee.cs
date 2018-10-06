using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace MHW_Weapon_Editor.Weapons {
    public class Melee : IWeapon {
        public const int WEAPON_SIZE = 20;
        public const int WEAPON_OFFSET_INITIAL = 25;
        public const int WEAPON_OFFSET_BETWEEN = 65;

        public byte Rarity { get; set; }
        public byte SharpnessQuality { get; set; }
        public byte SharpnessAmount { get; set; }
        public byte Damage1 { get; set; }
        public byte Damage2 { get; set; }
        public byte Defense1 { get; set; }
        public byte Defense2 { get; set; }
        public byte Affinity { get; set; }
        public Element ElemType { get; set; }
        public byte ElemDmg1 { get; set; }
        public byte ElemDmg2 { get; set; }
        public byte HiddenElemType { get; set; }
        public byte HiddenElemDmg1 { get; set; }
        public byte HiddenElemDmg2 { get; set; }
        public byte ElderSeal { get; set; }
        public byte Slots { get; set; }
        public byte Slot1Size { get; set; }
        public byte Slot2Size { get; set; }
        public byte Slot3Size { get; set; }
        public byte Ability { get; set; }

        public int Offset { get; set; }

        public static Melee FromByteArray(byte[] buff) {
            if (buff.Length < WEAPON_SIZE) return null;

            return new Melee {
                Rarity = buff[Offsets.RARITY],
                SharpnessQuality = buff[Offsets.SHARPNESS_QUALITY],
                SharpnessAmount = buff[Offsets.SHARPNESS_AMOUNT],
                Damage1 = buff[Offsets.DAMAGE1],
                Damage2 = buff[Offsets.DAMAGE2],
                Defense1 = buff[Offsets.DEFENSE1],
                Defense2 = buff[Offsets.DEFENSE2],
                Affinity = buff[Offsets.AFFINITY],
                ElemType = (Element) buff[Offsets.ELEM_TYPE],
                ElemDmg1 = buff[Offsets.ELEM_DMG1],
                ElemDmg2 = buff[Offsets.ELEM_DMG2],
                HiddenElemType = buff[Offsets.HIDDEN_ELEM_TYPE],
                HiddenElemDmg1 = buff[Offsets.HIDDEN_ELEM_DMG1],
                HiddenElemDmg2 = buff[Offsets.HIDDEN_ELEM_DMG2],
                ElderSeal = buff[Offsets.ELDER_SEAL],
                Slots = buff[Offsets.SLOTS],
                Slot1Size = buff[Offsets.SLOT1_SIZE],
                Slot2Size = buff[Offsets.SLOT2_SIZE],
                Slot3Size = buff[Offsets.SLOT3_SIZE],
                Ability = buff[Offsets.ABILITY]
            };
        }

        public byte[] ToByteArray() {
            var buff = new byte[WEAPON_SIZE];
            buff[Offsets.RARITY] = Rarity;
            buff[Offsets.SHARPNESS_QUALITY] = SharpnessQuality;
            buff[Offsets.SHARPNESS_AMOUNT] = SharpnessAmount;
            buff[Offsets.DAMAGE1] = Damage1;
            buff[Offsets.DAMAGE2] = Damage2;
            buff[Offsets.DEFENSE1] = Defense1;
            buff[Offsets.DEFENSE2] = Defense2;
            buff[Offsets.AFFINITY] = Affinity;
            buff[Offsets.ELEM_TYPE] = (byte) ElemType;
            buff[Offsets.ELEM_DMG1] = ElemDmg1;
            buff[Offsets.ELEM_DMG2] = ElemDmg2;
            buff[Offsets.HIDDEN_ELEM_TYPE] = HiddenElemType;
            buff[Offsets.HIDDEN_ELEM_DMG1] = HiddenElemDmg1;
            buff[Offsets.HIDDEN_ELEM_DMG2] = HiddenElemDmg2;
            buff[Offsets.ELDER_SEAL] = ElderSeal;
            buff[Offsets.SLOTS] = Slots;
            buff[Offsets.SLOT1_SIZE] = Slot1Size;
            buff[Offsets.SLOT2_SIZE] = Slot2Size;
            buff[Offsets.SLOT3_SIZE] = Slot3Size;
            buff[Offsets.ABILITY] = Ability;
            return buff;
        }

        public static class Offsets {
            public const int RARITY = 0;
            public const int SHARPNESS_QUALITY = 1;
            public const int SHARPNESS_AMOUNT = 2;
            public const int DAMAGE1 = 3;
            public const int DAMAGE2 = 4;
            public const int DEFENSE1 = 5;
            public const int DEFENSE2 = 6;
            public const int AFFINITY = 7;
            public const int ELEM_TYPE = 8;
            public const int ELEM_DMG1 = 9;
            public const int ELEM_DMG2 = 10;
            public const int HIDDEN_ELEM_TYPE = 11;
            public const int HIDDEN_ELEM_DMG1 = 12;
            public const int HIDDEN_ELEM_DMG2 = 13;
            public const int ELDER_SEAL = 14;
            public const int SLOTS = 15;
            public const int SLOT1_SIZE = 16;
            public const int SLOT2_SIZE = 17;
            public const int SLOT3_SIZE = 18;
            public const int ABILITY = 19;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}