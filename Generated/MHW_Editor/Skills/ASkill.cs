
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class ASkill {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Mantle Id")]
        public uint Mantle_Id {
            get => GetData<uint>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Mantle_Id));
            }
        }
        [DisplayName("Unknown (uint32)")]
        public uint Unknown_uint32_ {
            get => GetData<uint>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Unknown_uint32_));
            }
        }
        [DisplayName("Color")]
        public uint Color {
            get => GetData<uint>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Color));
            }
        }
        [DisplayName("Sort Order")]
        public uint Sort_Order {
            get => GetData<uint>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Sort_Order));
            }
        }
        [DisplayName("Mantle Item Id")]
        public uint Mantle_Item_Id {
            get => GetData<uint>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Mantle_Item_Id));
            }
        }
        [DisplayName("Unlock Flag or Item Id?")]
        public uint Unlock_Flag_or_Item_Id_ {
            get => GetData<uint>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Unlock_Flag_or_Item_Id_));
            }
        }
        [DisplayName("Deco Count")]
        public byte Deco_Count {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Deco_Count));
            }
        }
        [DisplayName("Deco Lvl 1")]
        public byte Deco_Lvl_1 {
            get => GetData<byte>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Deco_Lvl_1));
            }
        }
        [DisplayName("Deco Lvl 2")]
        public byte Deco_Lvl_2 {
            get => GetData<byte>(26);
            set {
                SetData(26, value);
                OnPropertyChanged(nameof(Deco_Lvl_2));
            }
        }
        [DisplayName("Deco Lvl 3")]
        public byte Deco_Lvl_3 {
            get => GetData<byte>(27);
            set {
                SetData(27, value);
                OnPropertyChanged(nameof(Deco_Lvl_3));
            }
        }
    }
}