namespace MHW_Weapon_Editor.Weapons {
    public partial class Melee : MhwItem, IWeapon {
        public const int WEAPON_SIZE = 20;
        public const int WEAPON_OFFSET_INITIAL = 25;
        public const int WEAPON_OFFSET_BETWEEN = 65;

        public byte Rarity {
            get => GetData(Offsets.RARITY);
            set => SetData(Offsets.RARITY, value);
        }
        public byte SharpnessQuality {
            get => GetData(Offsets.SHARPNESS_QUALITY);
            set => SetData(Offsets.SHARPNESS_QUALITY, value);
        }
        public byte SharpnessAmount {
            get => GetData(Offsets.SHARPNESS_AMOUNT);
            set => SetData(Offsets.SHARPNESS_AMOUNT, value);
        }
        public byte Damage1 {
            get => GetData(Offsets.DAMAGE1);
            set => SetData(Offsets.DAMAGE1, value);
        }
        public byte Damage2 {
            get => GetData(Offsets.DAMAGE2);
            set => SetData(Offsets.DAMAGE2, value);
        }
        public byte Defense1 {
            get => GetData(Offsets.DEFENSE1);
            set => SetData(Offsets.DEFENSE1, value);
        }
        public byte Defense2 {
            get => GetData(Offsets.DEFENSE2);
            set => SetData(Offsets.DEFENSE2, value);
        }
        public sbyte Affinity {
            get => GetSData(Offsets.AFFINITY);
            set => SetData(Offsets.AFFINITY, value);
        }
        public Element ElemType {
            get => (Element) GetData(Offsets.ELEM_TYPE);
            set => SetData(Offsets.ELEM_TYPE, (byte) value);
        }
        public byte ElemDmg1 {
            get => GetData(Offsets.ELEM_DMG1);
            set => SetData(Offsets.ELEM_DMG1, value);
        }
        public byte ElemDmg2 {
            get => GetData(Offsets.ELEM_DMG2);
            set => SetData(Offsets.ELEM_DMG2, value);
        }
        public Element HiddenElemType {
            get => (Element) GetData(Offsets.HIDDEN_ELEM_TYPE);
            set => SetData(Offsets.HIDDEN_ELEM_TYPE, (byte) value);
        }
        public byte HiddenElemDmg1 {
            get => GetData(Offsets.HIDDEN_ELEM_DMG1);
            set => SetData(Offsets.HIDDEN_ELEM_DMG1, value);
        }
        public byte HiddenElemDmg2 {
            get => GetData(Offsets.HIDDEN_ELEM_DMG2);
            set => SetData(Offsets.HIDDEN_ELEM_DMG2, value);
        }
        public byte ElderSeal {
            get => GetData(Offsets.ELDER_SEAL);
            set => SetData(Offsets.ELDER_SEAL, value);
        }
        public byte Slots {
            get => GetData(Offsets.SLOTS);
            set => SetData(Offsets.SLOTS, value);
        }
        public byte Slot1Size {
            get => GetData(Offsets.SLOT1_SIZE);
            set => SetData(Offsets.SLOT1_SIZE, value);
        }
        public byte Slot2Size {
            get => GetData(Offsets.SLOT2_SIZE);
            set => SetData(Offsets.SLOT2_SIZE, value);
        }
        public byte Slot3Size {
            get => GetData(Offsets.SLOT3_SIZE);
            set => SetData(Offsets.SLOT3_SIZE, value);
        }
        public byte Ability {
            get => GetData(Offsets.ABILITY);
            set => SetData(Offsets.ABILITY, value);
        }

        public Melee(byte[] bytes, int offset) : base(bytes, offset) {
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
    }
}