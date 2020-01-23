


using MHW_Template;

namespace MHW_Editor.Items {
    public partial class ArmUp {
        public const ushort StructSize = 22;
        public const ushort InitialOffset = 10;
        public short Unk1 {
            get => GetData<short>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Unk1));
            }
        }
        public short Unk2 {
            get => GetData<short>(2);
            set {
                SetData(2, value);
                OnPropertyChanged(nameof(Unk2));
            }
        }
        public short Unk3 {
            get => GetData<short>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Unk3));
            }
        }
        public short Unk4 {
            get => GetData<short>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Unk4));
            }
        }
        public short Unk5 {
            get => GetData<short>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Unk5));
            }
        }
        public short Unk6 {
            get => GetData<short>(10);
            set {
                SetData(10, value);
                OnPropertyChanged(nameof(Unk6));
            }
        }
        public short Unk7 {
            get => GetData<short>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Unk7));
            }
        }
        public short Unk8 {
            get => GetData<short>(14);
            set {
                SetData(14, value);
                OnPropertyChanged(nameof(Unk8));
            }
        }
        public short Unk9 {
            get => GetData<short>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Unk9));
            }
        }
        public short Unk10 {
            get => GetData<short>(18);
            set {
                SetData(18, value);
                OnPropertyChanged(nameof(Unk10));
            }
        }
        public short Unk11 {
            get => GetData<short>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Unk11));
            }
        }
    }
}