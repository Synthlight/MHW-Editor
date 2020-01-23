using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class SkillDat {
        public const ushort StructSize = 19;
        public const ushort InitialOffset = 10;
        public ushort Id {
            get => GetData<ushort>(0);
        }
        public byte Level {
            get => GetData<byte>(2);
        }
        public ushort Param_1 {
            get => GetData<ushort>(3);
            set {
                SetData(3, value);
                OnPropertyChanged(nameof(Param_1));
            }
        }
        public ushort Param_2 {
            get => GetData<ushort>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Param_2));
            }
        }
        public ushort Param_3 {
            get => GetData<ushort>(7);
            set {
                SetData(7, value);
                OnPropertyChanged(nameof(Param_3));
            }
        }
        public ushort Param_4 {
            get => GetData<ushort>(9);
            set {
                SetData(9, value);
                OnPropertyChanged(nameof(Param_4));
            }
        }
        public ushort Param_5 {
            get => GetData<ushort>(11);
            set {
                SetData(11, value);
                OnPropertyChanged(nameof(Param_5));
            }
        }
        public ushort Param_6 {
            get => GetData<ushort>(13);
            set {
                SetData(13, value);
                OnPropertyChanged(nameof(Param_6));
            }
        }
        public ushort Param_7 {
            get => GetData<ushort>(15);
            set {
                SetData(15, value);
                OnPropertyChanged(nameof(Param_7));
            }
        }
        public ushort Param_8 {
            get => GetData<ushort>(17);
            set {
                SetData(17, value);
                OnPropertyChanged(nameof(Param_8));
            }
        }
    }
}