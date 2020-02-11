using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class NewLimitBreakR {
        public const uint StructSize = 38;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id_1}|{Id_2}";

        public const string Id_1_displayName = "Id 1";
        public const int Id_1_sortIndex = 50;
        [SortOrder(Id_1_sortIndex)]
        [DisplayName(Id_1_displayName)]
        public virtual ushort Id_1 {
            get => GetData<ushort>(0);
        }

        public const string Id_2_displayName = "Id 2";
        public const int Id_2_sortIndex = 100;
        [SortOrder(Id_2_sortIndex)]
        [DisplayName(Id_2_displayName)]
        public virtual ushort Id_2 {
            get => GetData<ushort>(2);
        }

        public const string Needed_Item_Id_to_Unlock_displayName = "Needed Item Id to Unlock";
        public const int Needed_Item_Id_to_Unlock_sortIndex = 150;
        [SortOrder(Needed_Item_Id_to_Unlock_sortIndex)]
        [DisplayName(Needed_Item_Id_to_Unlock_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Needed_Item_Id_to_Unlock {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value, nameof(Needed_Item_Id_to_Unlock));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Needed_Item_Id_to_Unlock));
                OnPropertyChanged(nameof(Needed_Item_Id_to_Unlock_button));
            }
        }

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 200;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual int Unk1 {
            get => GetData<int>(6);
            set {
                if (GetData<int>(6) == value) return;
                SetData(6, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Mat_1_Id_displayName = "Mat 1 Id";
        public const int Mat_1_Id_sortIndex = 250;
        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Mat_1_Id {
            get => GetData<ushort>(14);
            set {
                if (GetData<ushort>(14) == value) return;
                SetData(14, value, nameof(Mat_1_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_1_Id));
                OnPropertyChanged(nameof(Mat_1_Id_button));
            }
        }

        public const string Mat_1_Count_displayName = "Mat 1 Count";
        public const int Mat_1_Count_sortIndex = 300;
        [SortOrder(Mat_1_Count_sortIndex)]
        [DisplayName(Mat_1_Count_displayName)]
        public virtual byte Mat_1_Count {
            get => GetData<byte>(16);
            set {
                if (GetData<byte>(16) == value) return;
                SetData(16, value, nameof(Mat_1_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_1_Count));
            }
        }

        public const string Mat_2_Id_displayName = "Mat 2 Id";
        public const int Mat_2_Id_sortIndex = 350;
        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Mat_2_Id {
            get => GetData<ushort>(17);
            set {
                if (GetData<ushort>(17) == value) return;
                SetData(17, value, nameof(Mat_2_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_2_Id));
                OnPropertyChanged(nameof(Mat_2_Id_button));
            }
        }

        public const string Mat_2_Count_displayName = "Mat 2 Count";
        public const int Mat_2_Count_sortIndex = 400;
        [SortOrder(Mat_2_Count_sortIndex)]
        [DisplayName(Mat_2_Count_displayName)]
        public virtual byte Mat_2_Count {
            get => GetData<byte>(19);
            set {
                if (GetData<byte>(19) == value) return;
                SetData(19, value, nameof(Mat_2_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_2_Count));
            }
        }

        public const string Mat_3_Id_displayName = "Mat 3 Id";
        public const int Mat_3_Id_sortIndex = 450;
        [SortOrder(Mat_3_Id_sortIndex)]
        [DisplayName(Mat_3_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Mat_3_Id {
            get => GetData<ushort>(20);
            set {
                if (GetData<ushort>(20) == value) return;
                SetData(20, value, nameof(Mat_3_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_3_Id));
                OnPropertyChanged(nameof(Mat_3_Id_button));
            }
        }

        public const string Mat_3_Count_displayName = "Mat 3 Count";
        public const int Mat_3_Count_sortIndex = 500;
        [SortOrder(Mat_3_Count_sortIndex)]
        [DisplayName(Mat_3_Count_displayName)]
        public virtual byte Mat_3_Count {
            get => GetData<byte>(22);
            set {
                if (GetData<byte>(22) == value) return;
                SetData(22, value, nameof(Mat_3_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_3_Count));
            }
        }

        public const string Mat_4_Id_displayName = "Mat 4 Id";
        public const int Mat_4_Id_sortIndex = 550;
        [SortOrder(Mat_4_Id_sortIndex)]
        [DisplayName(Mat_4_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Mat_4_Id {
            get => GetData<ushort>(23);
            set {
                if (GetData<ushort>(23) == value) return;
                SetData(23, value, nameof(Mat_4_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_4_Id));
                OnPropertyChanged(nameof(Mat_4_Id_button));
            }
        }

        public const string Mat_4_Count_displayName = "Mat 4 Count";
        public const int Mat_4_Count_sortIndex = 600;
        [SortOrder(Mat_4_Count_sortIndex)]
        [DisplayName(Mat_4_Count_displayName)]
        public virtual byte Mat_4_Count {
            get => GetData<byte>(25);
            set {
                if (GetData<byte>(25) == value) return;
                SetData(25, value, nameof(Mat_4_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_4_Count));
            }
        }

        public const string Id_3_displayName = "Id 3";
        public const int Id_3_sortIndex = 650;
        [SortOrder(Id_3_sortIndex)]
        [DisplayName(Id_3_displayName)]
        public virtual byte Id_3 {
            get => GetData<byte>(37);
        }

        public const int lastSortIndex = 700;
    }
}