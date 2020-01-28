using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class NewLimitBreak {
        public const uint StructSize = 38;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public ushort Id_1 {
            get => GetData<ushort>(0);
        }
        public ushort Id_2 {
            get => GetData<ushort>(2);
        }
        public ushort Needed_Item_Id_to_Unlock {
            get => GetData<ushort>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Needed_Item_Id_to_Unlock));
            }
        }
        protected sbyte Activated_1 {
            get => GetData<sbyte>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Activated_1));
            }
        }
        protected sbyte Activated_2 {
            get => GetData<sbyte>(7);
            set {
                SetData(7, value);
                OnPropertyChanged(nameof(Activated_2));
            }
        }
        protected sbyte Activated_3 {
            get => GetData<sbyte>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Activated_3));
            }
        }
        protected sbyte Activated_4 {
            get => GetData<sbyte>(9);
            set {
                SetData(9, value);
                OnPropertyChanged(nameof(Activated_4));
            }
        }
        public ushort Mat_1 {
            get => GetData<ushort>(14);
            set {
                SetData(14, value);
                OnPropertyChanged(nameof(Mat_1));
            }
        }
        public byte Mat_1_Quantity {
            get => GetData<byte>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Mat_1_Quantity));
            }
        }
        public ushort Mat_2 {
            get => GetData<ushort>(17);
            set {
                SetData(17, value);
                OnPropertyChanged(nameof(Mat_2));
            }
        }
        public byte Mat_2_Quantity {
            get => GetData<byte>(19);
            set {
                SetData(19, value);
                OnPropertyChanged(nameof(Mat_2_Quantity));
            }
        }
        public ushort Mat_3 {
            get => GetData<ushort>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Mat_3));
            }
        }
        public byte Mat_3_Quantity {
            get => GetData<byte>(22);
            set {
                SetData(22, value);
                OnPropertyChanged(nameof(Mat_3_Quantity));
            }
        }
        public ushort Mat_4 {
            get => GetData<ushort>(23);
            set {
                SetData(23, value);
                OnPropertyChanged(nameof(Mat_4));
            }
        }
        public byte Mat_4_Quantity {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Mat_4_Quantity));
            }
        }
        public byte Id_3 {
            get => GetData<byte>(37);
        }
    }
}