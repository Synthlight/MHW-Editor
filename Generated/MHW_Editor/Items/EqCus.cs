using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class EqCus {
        public const uint StructSize = 41;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Item_Category_displayName = "Item Category";
        public const int Item_Category_sortIndex = 50;
        [SortOrder(Item_Category_sortIndex)]
        [DisplayName(Item_Category_displayName)]
        public virtual byte Item_Category {
            get => GetData<byte>(0);
            set {
                if (GetData<byte>(0) == value) return;
                SetData(0, value);
                OnPropertyChanged(nameof(Item_Category));
            }
        }

        public const string External_Item_Index_displayName = "External Item Index";
        public const int External_Item_Index_sortIndex = 100;
        [SortOrder(External_Item_Index_sortIndex)]
        [DisplayName(External_Item_Index_displayName)]
        public virtual ushort External_Item_Index {
            get => GetData<ushort>(1);
            set {
                if (GetData<ushort>(1) == value) return;
                SetData(1, value);
                OnPropertyChanged(nameof(External_Item_Index));
            }
        }

        public const string Unknown_uint16_1_displayName = "Unknown (uint16) 1";
        public const int Unknown_uint16_1_sortIndex = 150;
        [SortOrder(Unknown_uint16_1_sortIndex)]
        [DisplayName(Unknown_uint16_1_displayName)]
        public virtual ushort Unknown_uint16_1 {
            get => GetData<ushort>(3);
            set {
                if (GetData<ushort>(3) == value) return;
                SetData(3, value);
                OnPropertyChanged(nameof(Unknown_uint16_1));
            }
        }

        public const string Unknown_int32_2_displayName = "Unknown (int32) 2";
        public const int Unknown_int32_2_sortIndex = 200;
        [SortOrder(Unknown_int32_2_sortIndex)]
        [DisplayName(Unknown_int32_2_displayName)]
        public virtual int Unknown_int32_2 {
            get => GetData<int>(5);
            set {
                if (GetData<int>(5) == value) return;
                SetData(5, value);
                OnPropertyChanged(nameof(Unknown_int32_2));
            }
        }

        public const string Story_Unlock_displayName = "Story Unlock";
        public const int Story_Unlock_sortIndex = 250;
        [SortOrder(Story_Unlock_sortIndex)]
        [DisplayName(Story_Unlock_displayName)]
        public virtual uint Story_Unlock {
            get => GetData<uint>(9);
            set {
                if (GetData<uint>(9) == value) return;
                SetData(9, value);
                OnPropertyChanged(nameof(Story_Unlock));
            }
        }

        public const string Item_Rank_displayName = "Item Rank";
        public const int Item_Rank_sortIndex = 300;
        [SortOrder(Item_Rank_sortIndex)]
        [DisplayName(Item_Rank_displayName)]
        public virtual uint Item_Rank {
            get => GetData<uint>(13);
            set {
                if (GetData<uint>(13) == value) return;
                SetData(13, value);
                OnPropertyChanged(nameof(Item_Rank));
            }
        }

        public const string Mat_1_Id_displayName = "Mat 1 Id";
        public const int Mat_1_Id_sortIndex = 350;
        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Mat_1_Id {
            get => GetData<ushort>(17);
            set {
                if (GetData<ushort>(17) == value) return;
                SetData(17, value);
                OnPropertyChanged(nameof(Mat_1_Id));
                OnPropertyChanged("Mat_1_Id_button");
            }
        }

        public const string Mat_1_Count_displayName = "Mat 1 Count";
        public const int Mat_1_Count_sortIndex = 400;
        [SortOrder(Mat_1_Count_sortIndex)]
        [DisplayName(Mat_1_Count_displayName)]
        public virtual byte Mat_1_Count {
            get => GetData<byte>(19);
            set {
                if (GetData<byte>(19) == value) return;
                SetData(19, value);
                OnPropertyChanged(nameof(Mat_1_Count));
            }
        }

        public const string Mat_2_Id_displayName = "Mat 2 Id";
        public const int Mat_2_Id_sortIndex = 450;
        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Mat_2_Id {
            get => GetData<ushort>(20);
            set {
                if (GetData<ushort>(20) == value) return;
                SetData(20, value);
                OnPropertyChanged(nameof(Mat_2_Id));
                OnPropertyChanged("Mat_2_Id_button");
            }
        }

        public const string Mat_2_Count_displayName = "Mat 2 Count";
        public const int Mat_2_Count_sortIndex = 500;
        [SortOrder(Mat_2_Count_sortIndex)]
        [DisplayName(Mat_2_Count_displayName)]
        public virtual byte Mat_2_Count {
            get => GetData<byte>(22);
            set {
                if (GetData<byte>(22) == value) return;
                SetData(22, value);
                OnPropertyChanged(nameof(Mat_2_Count));
            }
        }

        public const string Mat_3_Id_displayName = "Mat 3 Id";
        public const int Mat_3_Id_sortIndex = 550;
        [SortOrder(Mat_3_Id_sortIndex)]
        [DisplayName(Mat_3_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Mat_3_Id {
            get => GetData<ushort>(23);
            set {
                if (GetData<ushort>(23) == value) return;
                SetData(23, value);
                OnPropertyChanged(nameof(Mat_3_Id));
                OnPropertyChanged("Mat_3_Id_button");
            }
        }

        public const string Mat_3_Count_displayName = "Mat 3 Count";
        public const int Mat_3_Count_sortIndex = 600;
        [SortOrder(Mat_3_Count_sortIndex)]
        [DisplayName(Mat_3_Count_displayName)]
        public virtual byte Mat_3_Count {
            get => GetData<byte>(25);
            set {
                if (GetData<byte>(25) == value) return;
                SetData(25, value);
                OnPropertyChanged(nameof(Mat_3_Count));
            }
        }

        public const string Mat_4_Id_displayName = "Mat 4 Id";
        public const int Mat_4_Id_sortIndex = 650;
        [SortOrder(Mat_4_Id_sortIndex)]
        [DisplayName(Mat_4_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Mat_4_Id {
            get => GetData<ushort>(26);
            set {
                if (GetData<ushort>(26) == value) return;
                SetData(26, value);
                OnPropertyChanged(nameof(Mat_4_Id));
                OnPropertyChanged("Mat_4_Id_button");
            }
        }

        public const string Mat_4_Count_displayName = "Mat 4 Count";
        public const int Mat_4_Count_sortIndex = 700;
        [SortOrder(Mat_4_Count_sortIndex)]
        [DisplayName(Mat_4_Count_displayName)]
        public virtual byte Mat_4_Count {
            get => GetData<byte>(28);
            set {
                if (GetData<byte>(28) == value) return;
                SetData(28, value);
                OnPropertyChanged(nameof(Mat_4_Count));
            }
        }

        public const string Child_index_1_displayName = "Child index 1";
        public const int Child_index_1_sortIndex = 750;
        [SortOrder(Child_index_1_sortIndex)]
        [DisplayName(Child_index_1_displayName)]
        public virtual ushort Child_index_1 {
            get => GetData<ushort>(29);
            set {
                if (GetData<ushort>(29) == value) return;
                SetData(29, value);
                OnPropertyChanged(nameof(Child_index_1));
            }
        }

        public const string Child_index_2_displayName = "Child index 2";
        public const int Child_index_2_sortIndex = 800;
        [SortOrder(Child_index_2_sortIndex)]
        [DisplayName(Child_index_2_displayName)]
        public virtual ushort Child_index_2 {
            get => GetData<ushort>(31);
            set {
                if (GetData<ushort>(31) == value) return;
                SetData(31, value);
                OnPropertyChanged(nameof(Child_index_2));
            }
        }

        public const string Child_index_3_displayName = "Child index 3";
        public const int Child_index_3_sortIndex = 850;
        [SortOrder(Child_index_3_sortIndex)]
        [DisplayName(Child_index_3_displayName)]
        public virtual ushort Child_index_3 {
            get => GetData<ushort>(33);
            set {
                if (GetData<ushort>(33) == value) return;
                SetData(33, value);
                OnPropertyChanged(nameof(Child_index_3));
            }
        }

        public const string Child_index_4_displayName = "Child index 4";
        public const int Child_index_4_sortIndex = 900;
        [SortOrder(Child_index_4_sortIndex)]
        [DisplayName(Child_index_4_displayName)]
        public virtual ushort Child_index_4 {
            get => GetData<ushort>(35);
            set {
                if (GetData<ushort>(35) == value) return;
                SetData(35, value);
                OnPropertyChanged(nameof(Child_index_4));
            }
        }

        public const int lastSortIndex = 950;
    }
}