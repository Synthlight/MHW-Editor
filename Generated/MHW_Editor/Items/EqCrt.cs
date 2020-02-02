
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class EqCrt {
        public const uint StructSize = 37;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Item_Category_displayName = "Item Category";
        protected const int Item_Category_sortIndex = 50;
        [SortOrder(Item_Category_sortIndex)]
        [DisplayName(Item_Category_displayName)]
        public byte Item_Category {
            get => GetData<byte>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Item_Category));
            }
        }
        protected const string Item_Id_displayName = "Item Id";
        protected const int Item_Id_sortIndex = 100;
        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        public ushort Item_Id {
            get => GetData<ushort>(1);
            set {
                SetData(1, value);
                OnPropertyChanged(nameof(Item_Id));
            }
        }
        protected const string Item_Class_displayName = "Item Class";
        protected const int Item_Class_sortIndex = 150;
        [SortOrder(Item_Class_sortIndex)]
        [DisplayName(Item_Class_displayName)]
        public ushort Item_Class {
            get => GetData<ushort>(3);
            set {
                SetData(3, value);
                OnPropertyChanged(nameof(Item_Class));
            }
        }
        protected const string Unknown_int32__displayName = "Unknown (int32)";
        protected const int Unknown_int32__sortIndex = 200;
        [SortOrder(Unknown_int32__sortIndex)]
        [DisplayName(Unknown_int32__displayName)]
        public int Unknown_int32_ {
            get => GetData<int>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Unknown_int32_));
            }
        }
        protected const string Unlock_Flag_displayName = "Unlock Flag";
        protected const int Unlock_Flag_sortIndex = 250;
        [SortOrder(Unlock_Flag_sortIndex)]
        [DisplayName(Unlock_Flag_displayName)]
        public uint Unlock_Flag {
            get => GetData<uint>(9);
            set {
                SetData(9, value);
                OnPropertyChanged(nameof(Unlock_Flag));
            }
        }
        protected const string Unknown_uint32__displayName = "Unknown (uint32)";
        protected const int Unknown_uint32__sortIndex = 300;
        [SortOrder(Unknown_uint32__sortIndex)]
        [DisplayName(Unknown_uint32__displayName)]
        public uint Unknown_uint32_ {
            get => GetData<uint>(13);
            set {
                SetData(13, value);
                OnPropertyChanged(nameof(Unknown_uint32_));
            }
        }
        protected const string Item_Rank_displayName = "Item Rank";
        protected const int Item_Rank_sortIndex = 350;
        [SortOrder(Item_Rank_sortIndex)]
        [DisplayName(Item_Rank_displayName)]
        public uint Item_Rank {
            get => GetData<uint>(17);
            set {
                SetData(17, value);
                OnPropertyChanged(nameof(Item_Rank));
            }
        }
        protected const string Mat_1_Id_displayName = "Mat 1 Id";
        protected const int Mat_1_Id_sortIndex = 400;
        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        public ushort Mat_1_Id {
            get => GetData<ushort>(21);
            set {
                SetData(21, value);
                OnPropertyChanged(nameof(Mat_1_Id));
            }
        }
        protected const string Mat_1_Count_displayName = "Mat 1 Count";
        protected const int Mat_1_Count_sortIndex = 450;
        [SortOrder(Mat_1_Count_sortIndex)]
        [DisplayName(Mat_1_Count_displayName)]
        public byte Mat_1_Count {
            get => GetData<byte>(23);
            set {
                SetData(23, value);
                OnPropertyChanged(nameof(Mat_1_Count));
            }
        }
        protected const string Mat_2_Id_displayName = "Mat 2 Id";
        protected const int Mat_2_Id_sortIndex = 500;
        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        public ushort Mat_2_Id {
            get => GetData<ushort>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Mat_2_Id));
            }
        }
        protected const string Mat_2_Count_displayName = "Mat 2 Count";
        protected const int Mat_2_Count_sortIndex = 550;
        [SortOrder(Mat_2_Count_sortIndex)]
        [DisplayName(Mat_2_Count_displayName)]
        public byte Mat_2_Count {
            get => GetData<byte>(26);
            set {
                SetData(26, value);
                OnPropertyChanged(nameof(Mat_2_Count));
            }
        }
        protected const string Mat_3_Id_displayName = "Mat 3 Id";
        protected const int Mat_3_Id_sortIndex = 600;
        [SortOrder(Mat_3_Id_sortIndex)]
        [DisplayName(Mat_3_Id_displayName)]
        public ushort Mat_3_Id {
            get => GetData<ushort>(27);
            set {
                SetData(27, value);
                OnPropertyChanged(nameof(Mat_3_Id));
            }
        }
        protected const string Mat_3_Count_displayName = "Mat 3 Count";
        protected const int Mat_3_Count_sortIndex = 650;
        [SortOrder(Mat_3_Count_sortIndex)]
        [DisplayName(Mat_3_Count_displayName)]
        public byte Mat_3_Count {
            get => GetData<byte>(29);
            set {
                SetData(29, value);
                OnPropertyChanged(nameof(Mat_3_Count));
            }
        }
        protected const string Mat_4_Id_displayName = "Mat 4 Id";
        protected const int Mat_4_Id_sortIndex = 700;
        [SortOrder(Mat_4_Id_sortIndex)]
        [DisplayName(Mat_4_Id_displayName)]
        public ushort Mat_4_Id {
            get => GetData<ushort>(30);
            set {
                SetData(30, value);
                OnPropertyChanged(nameof(Mat_4_Id));
            }
        }
        protected const string Mat_4_Count_displayName = "Mat 4 Count";
        protected const int Mat_4_Count_sortIndex = 750;
        [SortOrder(Mat_4_Count_sortIndex)]
        [DisplayName(Mat_4_Count_displayName)]
        public byte Mat_4_Count {
            get => GetData<byte>(32);
            set {
                SetData(32, value);
                OnPropertyChanged(nameof(Mat_4_Count));
            }
        }
        protected const string Unknown_uint8_1_displayName = "Unknown (uint8) 1";
        protected const int Unknown_uint8_1_sortIndex = 800;
        [SortOrder(Unknown_uint8_1_sortIndex)]
        [DisplayName(Unknown_uint8_1_displayName)]
        public byte Unknown_uint8_1 {
            get => GetData<byte>(33);
            set {
                SetData(33, value);
                OnPropertyChanged(nameof(Unknown_uint8_1));
            }
        }
        protected const string Unknown_uint8_2_displayName = "Unknown (uint8) 2";
        protected const int Unknown_uint8_2_sortIndex = 850;
        [SortOrder(Unknown_uint8_2_sortIndex)]
        [DisplayName(Unknown_uint8_2_displayName)]
        public byte Unknown_uint8_2 {
            get => GetData<byte>(34);
            set {
                SetData(34, value);
                OnPropertyChanged(nameof(Unknown_uint8_2));
            }
        }
        protected const string Unknown_uint8_3_displayName = "Unknown (uint8) 3";
        protected const int Unknown_uint8_3_sortIndex = 900;
        [SortOrder(Unknown_uint8_3_sortIndex)]
        [DisplayName(Unknown_uint8_3_displayName)]
        public byte Unknown_uint8_3 {
            get => GetData<byte>(35);
            set {
                SetData(35, value);
                OnPropertyChanged(nameof(Unknown_uint8_3));
            }
        }
        protected const string Unknown_uint8_4_displayName = "Unknown (uint8) 4";
        protected const int Unknown_uint8_4_sortIndex = 950;
        [SortOrder(Unknown_uint8_4_sortIndex)]
        [DisplayName(Unknown_uint8_4_displayName)]
        public byte Unknown_uint8_4 {
            get => GetData<byte>(36);
            set {
                SetData(36, value);
                OnPropertyChanged(nameof(Unknown_uint8_4));
            }
        }
    }
}