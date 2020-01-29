using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class ASkill {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public uint Mantle_Id {
            get => GetData<uint>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Mantle_Id));
            }
        }
        public uint uint32_1 {
            get => GetData<uint>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(uint32_1));
            }
        }
        public uint uint32_2 {
            get => GetData<uint>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(uint32_2));
            }
        }
        public uint uint32_3 {
            get => GetData<uint>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(uint32_3));
            }
        }
        public uint Mantle_Item_Id {
            get => GetData<uint>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Mantle_Item_Id));
            }
        }
        public uint Unlock_Flag {
            get => GetData<uint>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Unlock_Flag));
            }
        }
        public byte Deco_Count {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Deco_Count));
            }
        }
        public byte Deco_Lvl_1 {
            get => GetData<byte>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Deco_Lvl_1));
            }
        }
        public byte Deco_Lvl_2 {
            get => GetData<byte>(26);
            set {
                SetData(26, value);
                OnPropertyChanged(nameof(Deco_Lvl_2));
            }
        }
        public byte Deco_Lvl_3 {
            get => GetData<byte>(27);
            set {
                SetData(27, value);
                OnPropertyChanged(nameof(Deco_Lvl_3));
            }
        }
    }
}