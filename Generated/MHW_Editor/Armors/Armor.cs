


namespace MHW_Editor.Armors {
    public partial class Armor {
        public const ushort StructSize = 60;
        public const ushort InitialOffset = 10;
        public uint Index {
            get => GetData<uint>(0);
            set => SetData(0, value);
        }
        public ushort Order {
            get => GetData<ushort>(4);
            set => SetData(4, value);
        }
        public MHW_Template.Armors.Variant Variant {
            get => (MHW_Template.Armors.Variant) GetData<byte>(6);
            set => SetData(6, (byte) value);
        }
        public ushort Set_Id {
            get => GetData<ushort>(7);
            set => SetData(7, value);
        }
        public byte Type {
            get => GetData<byte>(9);
            set => SetData(9, value);
        }
        public MHW_Template.Armors.EquipSlot Equip_Slot {
            get => (MHW_Template.Armors.EquipSlot) GetData<byte>(10);
            set => SetData(10, (byte) value);
        }
        public ushort Defense {
            get => GetData<ushort>(11);
            set => SetData(11, value);
        }
        public byte Rarity {
            get => GetData<byte>(20);
            set => SetData(20, value);
        }
        public ushort Cost {
            get => GetData<ushort>(21);
            set => SetData(21, value);
        }
        public sbyte Fire_Res {
            get => GetData<sbyte>(25);
            set => SetData(25, value);
        }
        public sbyte Water_Res {
            get => GetData<sbyte>(26);
            set => SetData(26, value);
        }
        public sbyte Ice_Res {
            get => GetData<sbyte>(27);
            set => SetData(27, value);
        }
        public sbyte Thunder_Res {
            get => GetData<sbyte>(28);
            set => SetData(28, value);
        }
        public sbyte Dragon_Res {
            get => GetData<sbyte>(29);
            set => SetData(29, value);
        }
        public byte Slot_Count {
            get => GetData<byte>(30);
            set => SetData(30, value);
        }
        public byte Slot_1_Size {
            get => GetData<byte>(31);
            set => SetData(31, value);
        }
        public byte Slot_2_Size {
            get => GetData<byte>(32);
            set => SetData(32, value);
        }
        public byte Slot_3_Size {
            get => GetData<byte>(33);
            set => SetData(33, value);
        }
        public ushort Set_Skill_1_Raw {
            get => GetData<ushort>(34);
            set => SetData(34, value);
        }
        public byte Set_Skill_1_Level {
            get => GetData<byte>(36);
            set => SetData(36, value);
        }
        public ushort Set_Skill_2_Raw {
            get => GetData<ushort>(37);
            set => SetData(37, value);
        }
        public byte Set_Skill_2_Level {
            get => GetData<byte>(39);
            set => SetData(39, value);
        }
        public ushort Skill_1_Raw {
            get => GetData<ushort>(40);
            set => SetData(40, value);
        }
        public byte Skill_1_Level {
            get => GetData<byte>(42);
            set => SetData(42, value);
        }
        public ushort Skill_2_Raw {
            get => GetData<ushort>(43);
            set => SetData(43, value);
        }
        public byte Skill_2_Level {
            get => GetData<byte>(45);
            set => SetData(45, value);
        }
        public ushort Skill_3_Raw {
            get => GetData<ushort>(46);
            set => SetData(46, value);
        }
        public byte Skill_3_Level {
            get => GetData<byte>(48);
            set => SetData(48, value);
        }
        public byte Gender {
            get => GetData<byte>(49);
            set => SetData(49, value);
        }
        public ushort Set_Group {
            get => GetData<ushort>(53);
            set => SetData(53, value);
        }
    }
}