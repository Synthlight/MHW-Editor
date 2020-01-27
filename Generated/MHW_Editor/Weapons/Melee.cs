using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class Melee {
        public const uint StructSize = 66;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        private uint Index {
            get => GetData<uint>(0);
        }
        public ushort Id {
            get => GetData<ushort>(56);
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
            get => GetData<byte>(14);
            set {
                SetData(14, value);
                OnPropertyChanged(nameof(Is_Fixed_Upgrade_Raw));
            }
        }
        public uint Cost {
            get => GetData<uint>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Cost));
            }
        }
        public byte Rarity {
            get => GetData<byte>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }
        public byte Sharpness_Quality {
            get => GetData<byte>(21);
            set {
                SetData(21, value);
                OnPropertyChanged(nameof(Sharpness_Quality));
            }
        }
        public byte Sharpness_Amount {
            get => GetData<byte>(22);
            set {
                SetData(22, value);
                OnPropertyChanged(nameof(Sharpness_Amount));
            }
        }
        public ushort Damage {
            get => GetData<ushort>(23);
            set {
                SetData(23, value);
                OnPropertyChanged(nameof(Damage));
            }
        }
        public ushort Defense {
            get => GetData<ushort>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Defense));
            }
        }
        public sbyte Affinity {
            get => GetData<sbyte>(27);
            set {
                SetData(27, value.Clamp((sbyte) -100, (sbyte) 100));
                OnPropertyChanged(nameof(Affinity));
            }
        }
        public MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(28);
            set {
                SetData(28, (byte) value);
                OnPropertyChanged(nameof(Element));
            }
        }
        public ushort Element_Damage {
            get => GetData<ushort>(29);
            set {
                SetData(29, value);
                OnPropertyChanged(nameof(Element_Damage));
            }
        }
        public MHW_Template.Weapons.Element Hidden_Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(31);
            set {
                SetData(31, (byte) value);
                OnPropertyChanged(nameof(Hidden_Element));
            }
        }
        public ushort Hidden_Element_Damage {
            get => GetData<ushort>(32);
            set {
                SetData(32, value);
                OnPropertyChanged(nameof(Hidden_Element_Damage));
            }
        }
        public MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(34);
            set {
                SetData(34, (byte) value);
                OnPropertyChanged(nameof(Elderseal));
            }
        }
        public byte Slot_Count {
            get => GetData<byte>(35);
            set {
                SetData(35, value);
                OnPropertyChanged(nameof(Slot_Count));
            }
        }
        public byte Slot_1_Size {
            get => GetData<byte>(36);
            set {
                SetData(36, value);
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }
        public byte Slot_2_Size {
            get => GetData<byte>(37);
            set {
                SetData(37, value);
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }
        public byte Slot_3_Size {
            get => GetData<byte>(38);
            set {
                SetData(38, value);
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }
        public ushort Skill {
            get => GetData<ushort>(62);
            set {
                SetData(62, value);
                OnPropertyChanged(nameof(Skill));
            }
        }
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(58);
            set {
                SetData(58, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }
    }
}