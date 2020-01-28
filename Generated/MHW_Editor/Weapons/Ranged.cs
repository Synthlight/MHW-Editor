using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class Ranged {
        public const uint StructSize = 69;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        private uint Index {
            get => GetData<uint>(0);
        }
        public ushort Id {
            get => GetData<ushort>(59);
        }
        public short Base_Model_Id {
            get => GetData<short>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Base_Model_Id));
            }
        }
        public short Part_1_Id {
            get => GetData<short>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Part_1_Id));
            }
        }
        public short Part_2_Id {
            get => GetData<short>(10);
            set {
                SetData(10, value);
                OnPropertyChanged(nameof(Part_2_Id));
            }
        }
        protected byte Is_Fixed_Upgrade_Raw {
            get => GetData<byte>(15);
            set {
                SetData(15, value);
                OnPropertyChanged(nameof(Is_Fixed_Upgrade_Raw));
            }
        }
        public MHW_Template.Weapons.MuzzleType Muzzle_Type {
            get => (MHW_Template.Weapons.MuzzleType) GetData<byte>(16);
            set {
                SetData(16, (byte) value);
                OnPropertyChanged(nameof(Muzzle_Type));
            }
        }
        public MHW_Template.Weapons.BarrelType Barrel_Type {
            get => (MHW_Template.Weapons.BarrelType) GetData<byte>(17);
            set {
                SetData(17, (byte) value);
                OnPropertyChanged(nameof(Barrel_Type));
            }
        }
        public MHW_Template.Weapons.MagazineType Magazine_Type {
            get => (MHW_Template.Weapons.MagazineType) GetData<byte>(18);
            set {
                SetData(18, (byte) value);
                OnPropertyChanged(nameof(Magazine_Type));
            }
        }
        public MHW_Template.Weapons.ScopeType Scope_Type {
            get => (MHW_Template.Weapons.ScopeType) GetData<byte>(19);
            set {
                SetData(19, (byte) value);
                OnPropertyChanged(nameof(Scope_Type));
            }
        }
        public uint Cost {
            get => GetData<uint>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Cost));
            }
        }
        public byte Rarity {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }
        public ushort Damage {
            get => GetData<ushort>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Damage));
            }
        }
        public ushort Defense {
            get => GetData<ushort>(27);
            set {
                SetData(27, value);
                OnPropertyChanged(nameof(Defense));
            }
        }
        public sbyte Affinity {
            get => GetData<sbyte>(29);
            set {
                SetData(29, value.Clamp((sbyte) -100, (sbyte) 100));
                OnPropertyChanged(nameof(Affinity));
            }
        }
        public MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(30);
            set {
                SetData(30, (byte) value);
                OnPropertyChanged(nameof(Element));
            }
        }
        public ushort Element_Damage {
            get => GetData<ushort>(31);
            set {
                SetData(31, value);
                OnPropertyChanged(nameof(Element_Damage));
            }
        }
        public MHW_Template.Weapons.Element Hidden_Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(33);
            set {
                SetData(33, (byte) value);
                OnPropertyChanged(nameof(Hidden_Element));
            }
        }
        public ushort Hidden_Element_Damage {
            get => GetData<ushort>(34);
            set {
                SetData(34, value);
                OnPropertyChanged(nameof(Hidden_Element_Damage));
            }
        }
        public MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(36);
            set {
                SetData(36, (byte) value);
                OnPropertyChanged(nameof(Elderseal));
            }
        }
        public byte Shell_Type_Id {
            get => GetData<byte>(37);
            set {
                SetData(37, value);
                OnPropertyChanged(nameof(Shell_Type_Id));
            }
        }
        public MHW_Template.Weapons.Deviation Deviation {
            get => (MHW_Template.Weapons.Deviation) GetData<byte>(39);
            set {
                SetData(39, (byte) value);
                OnPropertyChanged(nameof(Deviation));
            }
        }
        public byte Slot_Count {
            get => GetData<byte>(40);
            set {
                SetData(40, value);
                OnPropertyChanged(nameof(Slot_Count));
            }
        }
        public byte Slot_1_Size {
            get => GetData<byte>(41);
            set {
                SetData(41, value);
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }
        public byte Slot_2_Size {
            get => GetData<byte>(42);
            set {
                SetData(42, value);
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }
        public byte Slot_3_Size {
            get => GetData<byte>(43);
            set {
                SetData(43, value);
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }
        public byte Special_Ammo_Type {
            get => GetData<byte>(57);
            set {
                SetData(57, value);
                OnPropertyChanged(nameof(Special_Ammo_Type));
            }
        }
        public ushort Skill {
            get => GetData<ushort>(65);
            set {
                SetData(65, value);
                OnPropertyChanged(nameof(Skill));
            }
        }
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(61);
            set {
                SetData(61, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }
    }
}