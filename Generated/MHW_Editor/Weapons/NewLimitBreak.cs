
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class NewLimitBreak {
        public const uint StructSize = 38;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Id_1_displayName = "Id 1";
        protected const int Id_1_sortIndex = 50;
        [SortOrder(Id_1_sortIndex)]
        [DisplayName(Id_1_displayName)]
        public ushort Id_1 {
            get => GetData<ushort>(0);
        }
        protected const string Id_2_displayName = "Id 2";
        protected const int Id_2_sortIndex = 100;
        [SortOrder(Id_2_sortIndex)]
        [DisplayName(Id_2_displayName)]
        public ushort Id_2 {
            get => GetData<ushort>(2);
        }
        protected const string Needed_Item_Id_to_Unlock_displayName = "Needed Item Id to Unlock";
        protected const int Needed_Item_Id_to_Unlock_sortIndex = 150;
        [SortOrder(Needed_Item_Id_to_Unlock_sortIndex)]
        [DisplayName(Needed_Item_Id_to_Unlock_displayName)]
        [DataSource(DataSourceType.Items)]
        public ushort Needed_Item_Id_to_Unlock {
            get => GetData<ushort>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Needed_Item_Id_to_Unlock));
            }
        }
        protected const string Activated_1_displayName = "Activated 1";
        protected const int Activated_1_sortIndex = 200;
        [SortOrder(Activated_1_sortIndex)]
        [DisplayName(Activated_1_displayName)]
        protected sbyte Activated_1 {
            get => GetData<sbyte>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Activated_1));
            }
        }
        protected const string Activated_2_displayName = "Activated 2";
        protected const int Activated_2_sortIndex = 250;
        [SortOrder(Activated_2_sortIndex)]
        [DisplayName(Activated_2_displayName)]
        protected sbyte Activated_2 {
            get => GetData<sbyte>(7);
            set {
                SetData(7, value);
                OnPropertyChanged(nameof(Activated_2));
            }
        }
        protected const string Activated_3_displayName = "Activated 3";
        protected const int Activated_3_sortIndex = 300;
        [SortOrder(Activated_3_sortIndex)]
        [DisplayName(Activated_3_displayName)]
        protected sbyte Activated_3 {
            get => GetData<sbyte>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Activated_3));
            }
        }
        protected const string Activated_4_displayName = "Activated 4";
        protected const int Activated_4_sortIndex = 350;
        [SortOrder(Activated_4_sortIndex)]
        [DisplayName(Activated_4_displayName)]
        protected sbyte Activated_4 {
            get => GetData<sbyte>(9);
            set {
                SetData(9, value);
                OnPropertyChanged(nameof(Activated_4));
            }
        }
        protected const string Mat_1_Id_displayName = "Mat 1 Id";
        protected const int Mat_1_Id_sortIndex = 400;
        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public ushort Mat_1_Id {
            get => GetData<ushort>(14);
            set {
                SetData(14, value);
                OnPropertyChanged(nameof(Mat_1_Id));
            }
        }
        protected const string Mat_1_Count_displayName = "Mat 1 Count";
        protected const int Mat_1_Count_sortIndex = 450;
        [SortOrder(Mat_1_Count_sortIndex)]
        [DisplayName(Mat_1_Count_displayName)]
        public byte Mat_1_Count {
            get => GetData<byte>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Mat_1_Count));
            }
        }
        protected const string Mat_2_Id_displayName = "Mat 2 Id";
        protected const int Mat_2_Id_sortIndex = 500;
        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public ushort Mat_2_Id {
            get => GetData<ushort>(17);
            set {
                SetData(17, value);
                OnPropertyChanged(nameof(Mat_2_Id));
            }
        }
        protected const string Mat_2_Count_displayName = "Mat 2 Count";
        protected const int Mat_2_Count_sortIndex = 550;
        [SortOrder(Mat_2_Count_sortIndex)]
        [DisplayName(Mat_2_Count_displayName)]
        public byte Mat_2_Count {
            get => GetData<byte>(19);
            set {
                SetData(19, value);
                OnPropertyChanged(nameof(Mat_2_Count));
            }
        }
        protected const string Mat_3_Id_displayName = "Mat 3 Id";
        protected const int Mat_3_Id_sortIndex = 600;
        [SortOrder(Mat_3_Id_sortIndex)]
        [DisplayName(Mat_3_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public ushort Mat_3_Id {
            get => GetData<ushort>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Mat_3_Id));
            }
        }
        protected const string Mat_3_Count_displayName = "Mat 3 Count";
        protected const int Mat_3_Count_sortIndex = 650;
        [SortOrder(Mat_3_Count_sortIndex)]
        [DisplayName(Mat_3_Count_displayName)]
        public byte Mat_3_Count {
            get => GetData<byte>(22);
            set {
                SetData(22, value);
                OnPropertyChanged(nameof(Mat_3_Count));
            }
        }
        protected const string Mat_4_Id_displayName = "Mat 4 Id";
        protected const int Mat_4_Id_sortIndex = 700;
        [SortOrder(Mat_4_Id_sortIndex)]
        [DisplayName(Mat_4_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public ushort Mat_4_Id {
            get => GetData<ushort>(23);
            set {
                SetData(23, value);
                OnPropertyChanged(nameof(Mat_4_Id));
            }
        }
        protected const string Mat_4_Count_displayName = "Mat 4 Count";
        protected const int Mat_4_Count_sortIndex = 750;
        [SortOrder(Mat_4_Count_sortIndex)]
        [DisplayName(Mat_4_Count_displayName)]
        public byte Mat_4_Count {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Mat_4_Count));
            }
        }
        protected const string Id_3_displayName = "Id 3";
        protected const int Id_3_sortIndex = 800;
        [SortOrder(Id_3_sortIndex)]
        [DisplayName(Id_3_displayName)]
        public byte Id_3 {
            get => GetData<byte>(37);
        }
    }
}