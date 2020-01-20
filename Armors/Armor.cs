using MHW_Editor.Gems;

namespace MHW_Editor.Armors {
    public partial class Armor : MhwItem, IMhwItem, ISlots {
        public const int ARMOR_SIZE = 60;
        public const int ARMOR_OFFSET_INITIAL = 10;
        public const int ARMOR_OFFSET_BETWEEN = ARMOR_SIZE;

        public ushort Index {
            get => GetData<ushort>(Offsets.INDEX);
            set => SetData(Offsets.INDEX, value);
        }
        public Variant Variant {
            get => (Variant) GetData<byte>(Offsets.VARIANT);
            set => SetData(Offsets.VARIANT, (byte) value);
        }
        public byte SetId {
            get => GetData<byte>(Offsets.SET_ID);
            set => SetData(Offsets.SET_ID, value);
        }
        public EquipSlot EquipSlot {
            get => (EquipSlot) GetData<byte>(Offsets.EQUIP_SLOT);
            set => SetData(Offsets.EQUIP_SLOT, (byte) value);
        }
        public ushort Defense {
            get => GetData<ushort>(Offsets.DEFENSE);
            set => SetData(Offsets.DEFENSE, value);
        }
        public ushort PrimaryId {
            get => GetData<ushort>(Offsets.PRIMARY_ID);
            set => SetData(Offsets.PRIMARY_ID, value);
        }
        public ushort SecondaryId {
            get => GetData<ushort>(Offsets.SECONDARY_ID);
            set => SetData(Offsets.SECONDARY_ID, value);
        }
        public byte Rarity {
            get => GetData<byte>(Offsets.RARITY);
            set => SetData(Offsets.RARITY, value);
        }
        public ushort Cost {
            get => GetData<ushort>(Offsets.COST);
            set => SetData(Offsets.COST, value);
        }
        public sbyte FireRes {
            get => GetData<sbyte>(Offsets.FIRE_RES);
            set => SetData(Offsets.FIRE_RES, value);
        }
        public sbyte WaterRes {
            get => GetData<sbyte>(Offsets.WATER_RES);
            set => SetData(Offsets.WATER_RES, value);
        }
        public sbyte IceRes {
            get => GetData<sbyte>(Offsets.ICE_RES);
            set => SetData(Offsets.ICE_RES, value);
        }
        public sbyte ThunderRes {
            get => GetData<sbyte>(Offsets.THUNDER_RES);
            set => SetData(Offsets.THUNDER_RES, value);
        }
        public sbyte DragonRes {
            get => GetData<sbyte>(Offsets.DRAGON_RES);
            set => SetData(Offsets.DRAGON_RES, value);
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
        public string SetSkill1 {
            get => Skills.GetName(GetData<ushort>(Offsets.SET_SKILL1));
            set => SetData(Offsets.SET_SKILL1, Skills.ToUShort(value));
        }
        public byte SetSkill1Lvl {
            get => GetData<byte>(Offsets.SET_SKILL1_LVL);
            set => SetData(Offsets.SET_SKILL1_LVL, value);
        }
        public string SetSkill2 {
            get => Skills.GetName(GetData<ushort>(Offsets.SET_SKILL2));
            set => SetData(Offsets.SET_SKILL2, Skills.ToUShort(value));
        }
        public byte SetSkill2Lvl {
            get => GetData<byte>(Offsets.SET_SKILL2_LVL);
            set => SetData(Offsets.SET_SKILL2_LVL, value);
        }
        public string Skill1 {
            get => Skills.GetName(GetData<ushort>(Offsets.SKILL1));
            set => SetData(Offsets.SKILL1, Skills.ToUShort(value));
        }
        public ushort Skill1Id => GetData<ushort>(Offsets.SKILL1);
        public byte Skill1Lvl {
            get => GetData<byte>(Offsets.SKILL1_LVL);
            set => SetData(Offsets.SKILL1_LVL, value);
        }
        public string Skill2 {
            get => Skills.GetName(GetData<ushort>(Offsets.SKILL2));
            set => SetData(Offsets.SKILL2, Skills.ToUShort(value));
        }
        public ushort Skill2Id => GetData<ushort>(Offsets.SKILL2);
        public byte Skill2Lvl {
            get => GetData<byte>(Offsets.SKILL2_LVL);
            set => SetData(Offsets.SKILL2_LVL, value);
        }
        public string Skill3 {
            get => Skills.GetName(GetData<ushort>(Offsets.SKILL3));
            set => SetData(Offsets.SKILL3, Skills.ToUShort(value));
        }
        public ushort Skill3Id => GetData<ushort>(Offsets.SKILL3);
        public byte Skill3Lvl {
            get => GetData<byte>(Offsets.SKILL3_LVL);
            set => SetData(Offsets.SKILL3_LVL, value);
        }

        public Armor(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public static class Offsets {
            public const int INDEX = 0; // u2
            public const int VARIANT = 6;
            public const int SET_ID = 7;
            public const int EQUIP_SLOT = 10;
            public const int DEFENSE = 11; // u2
            public const int PRIMARY_ID = 13; // u2
            public const int SECONDARY_ID = 15; // u2
            public const int RARITY = 20;
            public const int COST = 21; // u2
            public const int FIRE_RES = 25; // s1
            public const int WATER_RES = 26; // s1
            public const int ICE_RES = 27; // s1
            public const int THUNDER_RES = 28; // s1
            public const int DRAGON_RES = 29; // s1
            public const int SLOTS = 30;
            public const int SLOT1_SIZE = 31;
            public const int SLOT2_SIZE = 32;
            public const int SLOT3_SIZE = 33;
            public const int SET_SKILL1 = 34; // s2
            public const int SET_SKILL1_LVL = 36;
            public const int SET_SKILL2 = 37; // s2
            public const int SET_SKILL2_LVL = 39;
            public const int SKILL1 = 40; // s2
            public const int SKILL1_LVL = 42;
            public const int SKILL2 = 43; // s2
            public const int SKILL2_LVL = 45;
            public const int SKILL3 = 46; // s2
            public const int SKILL3_LVL = 48;
        }
    }
}