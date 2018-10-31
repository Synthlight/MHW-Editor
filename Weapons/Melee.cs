namespace MHW_Weapon_Editor.Weapons {
    public partial class Melee : MhwItem, ISlots {
        public const int WEAPON_SIZE = 20;
        public const int WEAPON_OFFSET_INITIAL = 25;
        public const int WEAPON_OFFSET_BETWEEN = 65;

        public byte Rarity {
            get => GetData<byte>(Offsets.RARITY);
            set => SetData(Offsets.RARITY, value);
        }
        public byte SharpnessQuality {
            get => GetData<byte>(Offsets.SHARPNESS_QUALITY);
            set => SetData(Offsets.SHARPNESS_QUALITY, value.Clamp((byte) 1, (byte) 118));
        }
        public byte SharpnessAmount {
            get => GetData<byte>(Offsets.SHARPNESS_AMOUNT);
            set => SetData(Offsets.SHARPNESS_AMOUNT, value.Clamp((byte) 1, (byte) 8));
        }
        public ushort Damage {
            get => GetData<ushort>(Offsets.DAMAGE);
            set => SetData(Offsets.DAMAGE, value);
        }
        public ushort Defense {
            get => GetData<ushort>(Offsets.DEFENSE);
            set => SetData(Offsets.DEFENSE, value);
        }
        public sbyte Affinity {
            get => GetData<sbyte>(Offsets.AFFINITY);
            set => SetData(Offsets.AFFINITY, value.Clamp((sbyte) -100, (sbyte) 100));
        }
        public Element ElemType {
            get => (Element) GetData<byte>(Offsets.ELEM_TYPE);
            set => SetData(Offsets.ELEM_TYPE, (byte) value);
        }
        public ushort ElemDmg {
            get => GetData<ushort>(Offsets.ELEM_DMG);
            set => SetData(Offsets.ELEM_DMG, value);
        }
        public Element HiddenElemType {
            get => (Element) GetData<byte>(Offsets.HIDDEN_ELEM_TYPE);
            set => SetData(Offsets.HIDDEN_ELEM_TYPE, (byte) value);
        }
        public ushort HiddenElemDmg {
            get => GetData<ushort>(Offsets.HIDDEN_ELEM_DMG);
            set => SetData(Offsets.HIDDEN_ELEM_DMG, value);
        }
        public byte ElderSeal {
            get => GetData<byte>(Offsets.ELDER_SEAL);
            set => SetData(Offsets.ELDER_SEAL, value);
        }
        public byte Slots {
            get => GetData<byte>(Offsets.SLOTS);
            set => SetData(Offsets.SLOTS, value);
        }
        public byte Slot1Size {
            get => GetData<byte>(Offsets.SLOT1_SIZE);
            set => SetData(Offsets.SLOT1_SIZE, value);
        }
        public byte Slot2Size {
            get => GetData<byte>(Offsets.SLOT2_SIZE);
            set => SetData(Offsets.SLOT2_SIZE, value);
        }
        public byte Slot3Size {
            get => GetData<byte>(Offsets.SLOT3_SIZE);
            set => SetData(Offsets.SLOT3_SIZE, value);
        }
        public byte Ability {
            get => GetData<byte>(Offsets.ABILITY);
            set => SetData(Offsets.ABILITY, value);
        }

        public Melee(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public static class Offsets {
            public const int RARITY = 0;
            public const int SHARPNESS_QUALITY = 1;
            public const int SHARPNESS_AMOUNT = 2;
            public const int DAMAGE = 3; // u2
            public const int DEFENSE = 5; // u2
            public const int AFFINITY = 7; // s1
            public const int ELEM_TYPE = 8;
            public const int ELEM_DMG = 9; // u2
            public const int HIDDEN_ELEM_TYPE = 11;
            public const int HIDDEN_ELEM_DMG = 12; // u2
            public const int ELDER_SEAL = 14;
            public const int SLOTS = 15;
            public const int SLOT1_SIZE = 16;
            public const int SLOT2_SIZE = 17;
            public const int SLOT3_SIZE = 18;
            public const int ABILITY = 19;
        }
    }
}