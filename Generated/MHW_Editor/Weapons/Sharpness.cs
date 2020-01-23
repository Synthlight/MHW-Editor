using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class Sharpness {
        public const ushort StructSize = 18;
        public const ushort InitialOffset = 10;
        public uint Id {
            get => GetData<uint>(0);
        }
        public ushort Red {
            get => GetData<ushort>(4);
            set {
                SetData(4, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Red));
            }
        }
        public ushort Orange {
            get => GetData<ushort>(6);
            set {
                SetData(6, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Orange));
            }
        }
        public ushort Yellow {
            get => GetData<ushort>(8);
            set {
                SetData(8, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Yellow));
            }
        }
        public ushort Green {
            get => GetData<ushort>(10);
            set {
                SetData(10, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Green));
            }
        }
        public ushort Blue {
            get => GetData<ushort>(12);
            set {
                SetData(12, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Blue));
            }
        }
        public ushort White {
            get => GetData<ushort>(14);
            set {
                SetData(14, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(White));
            }
        }
        public ushort Purple {
            get => GetData<ushort>(16);
            set {
                SetData(16, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Purple));
            }
        }
    }
}