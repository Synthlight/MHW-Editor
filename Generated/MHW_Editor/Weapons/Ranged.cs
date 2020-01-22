


namespace MHW_Editor.Weapons {
    public partial class Ranged {
        public const ushort StructSize = 69;
        public const ushort InitialOffset = 10;
        public uint Index___ {
            get => GetData<uint>(0);
        }
        public ushort Id {
            get => GetData<ushort>(59);
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
        public byte Is_Fixed_Upgrade_Raw {
            get => GetData<byte>(14);
            set => SetData(14, value);
        }
        public MHW_Template.Weapons.MuzzleType Muzzle_Type {
            get => (MHW_Template.Weapons.MuzzleType) GetData<byte>(16);
            set => SetData(16, (byte) value);
        }
        public MHW_Template.Weapons.BarrelType Barrel_Type {
            get => (MHW_Template.Weapons.BarrelType) GetData<byte>(17);
            set => SetData(17, (byte) value);
        }
        public MHW_Template.Weapons.MagazineType Magazine_Type {
            get => (MHW_Template.Weapons.MagazineType) GetData<byte>(18);
            set => SetData(18, (byte) value);
        }
        public MHW_Template.Weapons.ScopeType Scope_Type {
            get => (MHW_Template.Weapons.ScopeType) GetData<byte>(19);
            set => SetData(19, (byte) value);
        }
        public uint Cost {
            get => GetData<uint>(20);
            set => SetData(20, value);
        }
        public byte Rarity {
            get => GetData<byte>(24);
            set => SetData(24, value);
        }
        public ushort Damage {
            get => GetData<ushort>(25);
            set => SetData(25, value);
        }
        public ushort Defense {
            get => GetData<ushort>(27);
            set => SetData(27, value);
        }
        public sbyte Affinity {
            get => GetData<sbyte>(29);
            set => SetData(29, value.Clamp((sbyte) -100, (sbyte) 100));
        }
        public MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(30);
            set => SetData(30, (byte) value);
        }
        public ushort Element_Damage {
            get => GetData<ushort>(31);
            set => SetData(31, value);
        }
        public MHW_Template.Weapons.Element Hidden_Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(33);
            set => SetData(33, (byte) value);
        }
        public ushort Hidden_Element_Damage {
            get => GetData<ushort>(34);
            set => SetData(34, value);
        }
        public MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(36);
            set => SetData(36, (byte) value);
        }
        public byte Shell_Type_Id {
            get => GetData<byte>(37);
            set => SetData(37, value);
        }
        public MHW_Template.Weapons.Deviation Deviation {
            get => (MHW_Template.Weapons.Deviation) GetData<byte>(39);
            set => SetData(39, (byte) value);
        }
        public byte Slot_Count {
            get => GetData<byte>(40);
            set => SetData(40, value);
        }
        public byte Slot_1_Size {
            get => GetData<byte>(41);
            set => SetData(41, value);
        }
        public byte Slot_2_Size {
            get => GetData<byte>(42);
            set => SetData(42, value);
        }
        public byte Slot_3_Size {
            get => GetData<byte>(43);
            set => SetData(43, value);
        }
        public byte Special_Ammo_Type {
            get => GetData<byte>(57);
            set => SetData(57, value);
        }
        public ushort Skill_Raw {
            get => GetData<ushort>(65);
            set => SetData(65, value);
        }
    }
}