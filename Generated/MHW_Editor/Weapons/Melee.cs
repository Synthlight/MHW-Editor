
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class Melee {
        public const uint StructSize = 66;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Index")]
        private uint Index {
            get => GetData<uint>(0);
        }
        [DisplayName("Id")]
        public ushort Id {
            get => GetData<ushort>(56);
        }
        [DisplayName("Base Model Id")]
        public short Base_Model_Id {
            get => GetData<short>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Base_Model_Id));
            }
        }
        [DisplayName("Part 1 Id")]
        public short Part_1_Id {
            get => GetData<short>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Part_1_Id));
            }
        }
        [DisplayName("Part 2 Id")]
        public short Part_2_Id {
            get => GetData<short>(10);
            set {
                SetData(10, value);
                OnPropertyChanged(nameof(Part_2_Id));
            }
        }
        [DisplayName("Is Fixed Upgrade Raw")]
        protected byte Is_Fixed_Upgrade_Raw {
            get => GetData<byte>(15);
            set {
                SetData(15, value);
                OnPropertyChanged(nameof(Is_Fixed_Upgrade_Raw));
            }
        }
        [DisplayName("Cost")]
        public uint Cost {
            get => GetData<uint>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Cost));
            }
        }
        [DisplayName("Rarity")]
        public byte Rarity {
            get => GetData<byte>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }
        [DisplayName("Sharpness Quality")]
        public byte Sharpness_Quality {
            get => GetData<byte>(21);
            set {
                SetData(21, value);
                OnPropertyChanged(nameof(Sharpness_Quality));
            }
        }
        [DisplayName("Sharpness Amount")]
        public byte Sharpness_Amount {
            get => GetData<byte>(22);
            set {
                SetData(22, value);
                OnPropertyChanged(nameof(Sharpness_Amount));
            }
        }
        [DisplayName("Damage")]
        public ushort Damage {
            get => GetData<ushort>(23);
            set {
                SetData(23, value);
                OnPropertyChanged(nameof(Damage));
            }
        }
        [DisplayName("Defense")]
        public ushort Defense {
            get => GetData<ushort>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Defense));
            }
        }
        [DisplayName("Affinity")]
        public sbyte Affinity {
            get => GetData<sbyte>(27);
            set {
                SetData(27, value.Clamp((sbyte) -100, (sbyte) 100));
                OnPropertyChanged(nameof(Affinity));
            }
        }
        [DisplayName("Element")]
        public MHW_Template.Weapons.Element Element {
            get => (MHW_Template.Weapons.Element) GetData<byte>(28);
            set {
                SetData(28, (byte) value);
                OnPropertyChanged(nameof(Element));
            }
        }
        [DisplayName("Element Damage")]
        public ushort Element_Damage {
            get => GetData<ushort>(29);
            set {
                SetData(29, value);
                OnPropertyChanged(nameof(Element_Damage));
            }
        }
        [DisplayName("Element (Hidden)")]
        public MHW_Template.Weapons.Element Element_Hidden_ {
            get => (MHW_Template.Weapons.Element) GetData<byte>(31);
            set {
                SetData(31, (byte) value);
                OnPropertyChanged(nameof(Element_Hidden_));
            }
        }
        [DisplayName("Element (Hidden) Damage")]
        public ushort Element_Hidden_Damage {
            get => GetData<ushort>(32);
            set {
                SetData(32, value);
                OnPropertyChanged(nameof(Element_Hidden_Damage));
            }
        }
        [DisplayName("Elderseal")]
        public MHW_Template.Weapons.Elderseal Elderseal {
            get => (MHW_Template.Weapons.Elderseal) GetData<byte>(34);
            set {
                SetData(34, (byte) value);
                OnPropertyChanged(nameof(Elderseal));
            }
        }
        [DisplayName("Slot Count")]
        public byte Slot_Count {
            get => GetData<byte>(35);
            set {
                SetData(35, value);
                OnPropertyChanged(nameof(Slot_Count));
            }
        }
        [DisplayName("Slot 1 Size")]
        public byte Slot_1_Size {
            get => GetData<byte>(36);
            set {
                SetData(36, value);
                OnPropertyChanged(nameof(Slot_1_Size));
            }
        }
        [DisplayName("Slot 2 Size")]
        public byte Slot_2_Size {
            get => GetData<byte>(37);
            set {
                SetData(37, value);
                OnPropertyChanged(nameof(Slot_2_Size));
            }
        }
        [DisplayName("Slot 3 Size")]
        public byte Slot_3_Size {
            get => GetData<byte>(38);
            set {
                SetData(38, value);
                OnPropertyChanged(nameof(Slot_3_Size));
            }
        }
        [DisplayName("Special Ability 1 ID")]
        public ushort Special_Ability_1_ID {
            get => GetData<ushort>(39);
            set {
                SetData(39, value);
                OnPropertyChanged(nameof(Special_Ability_1_ID));
            }
        }
        [DisplayName("Special Ability 2 ID")]
        public ushort Special_Ability_2_ID {
            get => GetData<ushort>(41);
            set {
                SetData(41, value);
                OnPropertyChanged(nameof(Special_Ability_2_ID));
            }
        }
        [DisplayName("Skill")]
        public ushort Skill {
            get => GetData<ushort>(62);
            set {
                SetData(62, value);
                OnPropertyChanged(nameof(Skill));
            }
        }
        [DisplayName("GMD Name Index")]
        protected ushort GMD_Name_Index {
            get => GetData<ushort>(58);
            set {
                SetData(58, value);
                OnPropertyChanged(nameof(GMD_Name_Index));
            }
        }
    }
}