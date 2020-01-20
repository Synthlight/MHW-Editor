namespace MHW_Editor.Weapons {
    public partial class Ranged : MhwItem, ISlots {
        public const int WEAPON_SIZE = 20;
        public const int WEAPON_OFFSET_INITIAL = 34;
        public const int WEAPON_OFFSET_BETWEEN = 69;

        public byte Rarity {
            get => GetData<byte>(Offsets.RARITY);
            set => SetData(Offsets.RARITY, value);
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
        public byte HiddenElemType {
            get => GetData<byte>(Offsets.HIDDEN_ELEM_TYPE);
            set => SetData(Offsets.HIDDEN_ELEM_TYPE, value);
        }
        public ushort HiddenElemDmg {
            get => GetData<ushort>(Offsets.HIDDEN_ELEM_DMG);
            set => SetData(Offsets.HIDDEN_ELEM_DMG, value);
        }
        public byte ElderSeal {
            get => GetData<byte>(Offsets.ELDER_SEAL);
            set => SetData(Offsets.ELDER_SEAL, value);
        }
        public byte AmmoType {
            get => GetData<byte>(Offsets.AMMO_TYPE);
            set => SetData(Offsets.AMMO_TYPE, value);
        }
        public byte Unknown {
            get => GetData<byte>(Offsets.UNKNOWN);
            set => SetData(Offsets.UNKNOWN, value);
        }
        public byte Deviation {
            get => GetData<byte>(Offsets.DEVIATION);
            set => SetData(Offsets.DEVIATION, value);
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

        public Ranged(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public static class Offsets {
            public const int RARITY = 0;
            public const int DAMAGE = 1; // u2
            public const int DEFENSE = 3; // u2
            public const int AFFINITY = 5; // s1
            public const int ELEM_TYPE = 6;
            public const int ELEM_DMG = 7; // u2
            public const int HIDDEN_ELEM_TYPE = 9;
            public const int HIDDEN_ELEM_DMG = 10; // u2
            public const int ELDER_SEAL = 12;
            public const int AMMO_TYPE = 13;
            public const int UNKNOWN = 14;
            public const int DEVIATION = 15;
            public const int SLOTS = 16;
            public const int SLOT1_SIZE = 17;
            public const int SLOT2_SIZE = 18;
            public const int SLOT3_SIZE = 19;
        }
    }
}