


using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class Armor {
        public const ushort StructSize = 60;
        public const ushort InitialOffset = 10;
        public uint Id {
            get => GetData<uint>(0);
        }
        public ushort Order {
            get => GetData<ushort>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Order));
            }
        }
        public MHW_Template.Armors.Variant Variant {
            get => (MHW_Template.Armors.Variant) GetData<byte>(6);
            set {
                SetData(6, (byte) value);
                OnPropertyChanged(nameof(Variant));
            }
        }
        public ushort Set_Id {
            get => GetData<ushort>(7);
            set {
                SetData(7, value);
                OnPropertyChanged(nameof(Set_Id));
            }
        }
        public MHW_Template.Armors.ArmorType Type {
            get => (MHW_Template.Armors.ArmorType) GetData<byte>(9);
            set {
                SetData(9, (byte) value);
                OnPropertyChanged(nameof(Type));
            }
        }
        public MHW_Template.Armors.EquipSlot Equip_Slot {
            get => (MHW_Template.Armors.EquipSlot) GetData<byte>(10);
            set {
                SetData(10, (byte) value);
                OnPropertyChanged(nameof(Equip_Slot));
            }
        }
        public ushort Defense {
            get => GetData<ushort>(11);
            set {
                SetData(11, value);
                OnPropertyChanged(nameof(Defense));
            }
        }
        public byte Rarity {
            get => GetData<byte>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }
        public uint Cost {
            get => GetData<uint>(21);
            set {
                SetData(21, value);
                OnPropertyChanged(nameof(Cost));
            }
        }
        public sbyte Fire_Res {
            get => GetData<sbyte>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Fire_Res));
            }
        }
        public sbyte Water_Res {
            get => GetData<sbyte>(26);
            set {
                SetData(26, value);
                OnPropertyChanged(nameof(Water_Res));
            }
        }
        public sbyte Ice_Res {
            get => GetData<sbyte>(27);
            set {
                SetData(27, value);
                OnPropertyChanged(nameof(Ice_Res));
            }
        }
        public sbyte Thunder_Res {
            get => GetData<sbyte>(28);
            set {
                SetData(28, value);
                OnPropertyChanged(nameof(Thunder_Res));
            }
        }
        public sbyte Dragon_Res {
            get => GetData<sbyte>(29);
            set {
                SetData(29, value);
                OnPropertyChanged(nameof(Dragon_Res));
            }
        }
        public byte Slot_Count {
            get => GetData<byte>(30);
            set {
                SetData(30, value);
                OnPropertyChanged(nameof(Slot_Count));
            }
        }
        public byte Slot_1_Size {
            get => GetData<byte>(31);
            set {
                SetData(31, value);
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }
        public byte Slot_2_Size {
            get => GetData<byte>(32);
            set {
                SetData(32, value);
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }
        public byte Slot_3_Size {
            get => GetData<byte>(33);
            set {
                SetData(33, value);
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }
        protected ushort Set_Skill_1_Raw {
            get => GetData<ushort>(34);
            set {
                SetData(34, value);
                OnPropertyChanged(nameof(Set_Skill_1_Raw));
            }
        }
        public byte Set_Skill_1_Level {
            get => GetData<byte>(36);
            set {
                SetData(36, value);
                OnPropertyChanged(nameof(Set_Skill_1_Level));
            }
        }
        protected ushort Set_Skill_2_Raw {
            get => GetData<ushort>(37);
            set {
                SetData(37, value);
                OnPropertyChanged(nameof(Set_Skill_2_Raw));
            }
        }
        public byte Set_Skill_2_Level {
            get => GetData<byte>(39);
            set {
                SetData(39, value);
                OnPropertyChanged(nameof(Set_Skill_2_Level));
            }
        }
        protected ushort Skill_1_Raw {
            get => GetData<ushort>(40);
            set {
                SetData(40, value);
                OnPropertyChanged(nameof(Skill_1_Raw));
            }
        }
        public byte Skill_1_Level {
            get => GetData<byte>(42);
            set {
                SetData(42, value);
                OnPropertyChanged(nameof(Skill_1_Level));
            }
        }
        protected ushort Skill_2_Raw {
            get => GetData<ushort>(43);
            set {
                SetData(43, value);
                OnPropertyChanged(nameof(Skill_2_Raw));
            }
        }
        public byte Skill_2_Level {
            get => GetData<byte>(45);
            set {
                SetData(45, value);
                OnPropertyChanged(nameof(Skill_2_Level));
            }
        }
        protected ushort Skill_3_Raw {
            get => GetData<ushort>(46);
            set {
                SetData(46, value);
                OnPropertyChanged(nameof(Skill_3_Raw));
            }
        }
        public byte Skill_3_Level {
            get => GetData<byte>(48);
            set {
                SetData(48, value);
                OnPropertyChanged(nameof(Skill_3_Level));
            }
        }
        public MHW_Template.Armors.Gender Gender {
            get => (MHW_Template.Armors.Gender) GetData<byte>(49);
            set {
                SetData(49, (byte) value);
                OnPropertyChanged(nameof(Gender));
            }
        }
        public ushort Set_Group {
            get => GetData<ushort>(53);
            set {
                SetData(53, value);
                OnPropertyChanged(nameof(Set_Group));
            }
        }
        protected byte Is_Permanent_Raw {
            get => GetData<byte>(59);
            set {
                SetData(59, value);
                OnPropertyChanged(nameof(Is_Permanent_Raw));
            }
        }
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(55);
            set {
                SetData(55, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }
    }
}