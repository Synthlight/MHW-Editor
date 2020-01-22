


namespace MHW_Editor.Weapons {
    public partial class Melee {
        public const ushort StructSize = 66;
        public const ushort InitialOffset = 10;
        private uint Index {
            get => GetData<uint>(0);
        }
        public ushort Id {
            get => GetData<ushort>(56);
        }
        public short Base_Model_Id {
            get => GetData<short>(6);
            set => SetData(6, value);
        }
        public short Part_1_Id {
            get => GetData<short>(8);
            set => SetData(8, value);
        }
        public short Part_2_Id {
            get => GetData<short>(10);
            set => SetData(10, value);
        }
        protected byte Is_Fixed_Upgrade_Raw {
            get => GetData<byte>(14);
            set => SetData(14, value);
        }
        public uint Cost {
            get => GetData<uint>(16);
            set => SetData(16, value);
        }
        public byte Rarity {
            get => GetData<byte>(20);
            set => SetData(20, value);
        }
        public byte Sharpness_Quality {
            get => GetData<byte>(21);
            set => SetData(21, value);
        }
        public byte Sharpness_Amount {
            get => GetData<byte>(22);
            set => SetData(22, value);
        }
        public ushort Damage {
            get => GetData<ushort>(23);
            set => SetData(23, value);
        }
        public ushort Defense {
            get => GetData<ushort>(25);
            set => SetData(25, value);
        }
        public sbyte Affinity {
            get => GetData<sbyte>(27);
            set => SetData(27, value.Clamp((sbyte) -100, (sbyte) 100));
        }
        public MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(28);
            set => SetData(28, (byte) value);
        }
        public ushort Element_Damage {
            get => GetData<ushort>(29);
            set => SetData(29, value);
        }
        public MHW_Template.Weapons.Element Hidden_Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(31);
            set => SetData(31, (byte) value);
        }
        public ushort Hidden_Element_Damage {
            get => GetData<ushort>(32);
            set => SetData(32, value);
        }
        public MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(34);
            set => SetData(34, (byte) value);
        }
        public byte Slot_Count {
            get => GetData<byte>(35);
            set => SetData(35, value);
        }
        public byte Slot_1_Size {
            get => GetData<byte>(36);
            set => SetData(36, value);
        }
        public byte Slot_2_Size {
            get => GetData<byte>(37);
            set => SetData(37, value);
        }
        public byte Slot_3_Size {
            get => GetData<byte>(38);
            set => SetData(38, value);
        }
        protected ushort Skill_Raw {
            get => GetData<ushort>(62);
            set => SetData(62, value);
        }
    }
}