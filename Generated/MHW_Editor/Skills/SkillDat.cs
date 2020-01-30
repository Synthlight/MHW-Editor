
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class SkillDat {
        public const uint StructSize = 19;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Id")]
        public ushort Id {
            get => GetData<ushort>(0);
        }
        [DisplayName("Level")]
        public byte Level {
            get => GetData<byte>(2);
        }
        [DisplayName("Param 1")]
        public ushort Param_1 {
            get => GetData<ushort>(3);
            set {
                SetData(3, value);
                OnPropertyChanged(nameof(Param_1));
            }
        }
        [DisplayName("Param 2")]
        public ushort Param_2 {
            get => GetData<ushort>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Param_2));
            }
        }
        [DisplayName("Param 3")]
        public ushort Param_3 {
            get => GetData<ushort>(7);
            set {
                SetData(7, value);
                OnPropertyChanged(nameof(Param_3));
            }
        }
        [DisplayName("Param 4")]
        public ushort Param_4 {
            get => GetData<ushort>(9);
            set {
                SetData(9, value);
                OnPropertyChanged(nameof(Param_4));
            }
        }
        [DisplayName("Param 5")]
        public ushort Param_5 {
            get => GetData<ushort>(11);
            set {
                SetData(11, value);
                OnPropertyChanged(nameof(Param_5));
            }
        }
        [DisplayName("Param 6")]
        public ushort Param_6 {
            get => GetData<ushort>(13);
            set {
                SetData(13, value);
                OnPropertyChanged(nameof(Param_6));
            }
        }
        [DisplayName("Param 7")]
        public ushort Param_7 {
            get => GetData<ushort>(15);
            set {
                SetData(15, value);
                OnPropertyChanged(nameof(Param_7));
            }
        }
        [DisplayName("Param 8")]
        public ushort Param_8 {
            get => GetData<ushort>(17);
            set {
                SetData(17, value);
                OnPropertyChanged(nameof(Param_8));
            }
        }
    }
}