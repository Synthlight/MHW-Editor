
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class ArmUp {
        public const uint StructSize = 22;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Unknown (uint16) 1")]
        public short Unknown_uint16_1 {
            get => GetData<short>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Unknown_uint16_1));
            }
        }
        [DisplayName("Unknown (uint16) 2")]
        public short Unknown_uint16_2 {
            get => GetData<short>(2);
            set {
                SetData(2, value);
                OnPropertyChanged(nameof(Unknown_uint16_2));
            }
        }
        [DisplayName("Unknown (uint16) 3")]
        public short Unknown_uint16_3 {
            get => GetData<short>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Unknown_uint16_3));
            }
        }
        [DisplayName("Unknown (uint16) 4")]
        public short Unknown_uint16_4 {
            get => GetData<short>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Unknown_uint16_4));
            }
        }
        [DisplayName("Unknown (uint16) 5")]
        public short Unknown_uint16_5 {
            get => GetData<short>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Unknown_uint16_5));
            }
        }
        [DisplayName("Unknown (uint16) 6")]
        public short Unknown_uint16_6 {
            get => GetData<short>(10);
            set {
                SetData(10, value);
                OnPropertyChanged(nameof(Unknown_uint16_6));
            }
        }
        [DisplayName("Unknown (uint16) 7")]
        public short Unknown_uint16_7 {
            get => GetData<short>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Unknown_uint16_7));
            }
        }
        [DisplayName("Unknown (uint16) 8")]
        public short Unknown_uint16_8 {
            get => GetData<short>(14);
            set {
                SetData(14, value);
                OnPropertyChanged(nameof(Unknown_uint16_8));
            }
        }
        [DisplayName("Unknown (uint16) 9")]
        public short Unknown_uint16_9 {
            get => GetData<short>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Unknown_uint16_9));
            }
        }
        [DisplayName("Unknown (uint16) 10")]
        public short Unknown_uint16_10 {
            get => GetData<short>(18);
            set {
                SetData(18, value);
                OnPropertyChanged(nameof(Unknown_uint16_10));
            }
        }
        [DisplayName("Unknown (uint16) 11")]
        public short Unknown_uint16_11 {
            get => GetData<short>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Unknown_uint16_11));
            }
        }
    }
}