using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class ItemMake {
        public const uint StructSize = 31;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        [IsReadOnly]
        public virtual uint Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Id));
            }
        }

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 100;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual ushort Unk1 {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Mat_1_Id_displayName = "Mat 1 Id";
        public const int Mat_1_Id_sortIndex = 150;
        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Mat_1_Id {
            get => GetData<uint>(6);
            set {
                if (GetData<uint>(6) == value) return;
                SetData(6, value, nameof(Mat_1_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_1_Id));
                OnPropertyChanged(nameof(Mat_1_Id_button));
            }
        }

        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Mat_1_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_1_Id).ToStringWithId(Mat_1_Id);

        public const string Mat_2_Id_displayName = "Mat 2 Id";
        public const int Mat_2_Id_sortIndex = 200;
        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Mat_2_Id {
            get => GetData<uint>(10);
            set {
                if (GetData<uint>(10) == value) return;
                SetData(10, value, nameof(Mat_2_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mat_2_Id));
                OnPropertyChanged(nameof(Mat_2_Id_button));
            }
        }

        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Mat_2_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_2_Id).ToStringWithId(Mat_2_Id);

        public const string Result_Id_displayName = "Result Id";
        public const int Result_Id_sortIndex = 250;
        [SortOrder(Result_Id_sortIndex)]
        [DisplayName(Result_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Result_Id {
            get => GetData<uint>(14);
            set {
                if (GetData<uint>(14) == value) return;
                SetData(14, value, nameof(Result_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Result_Id));
                OnPropertyChanged(nameof(Result_Id_button));
            }
        }

        [SortOrder(Result_Id_sortIndex)]
        [DisplayName(Result_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Result_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Result_Id).ToStringWithId(Result_Id);

        public const string Quantity_displayName = "Quantity";
        public const int Quantity_sortIndex = 300;
        [SortOrder(Quantity_sortIndex)]
        [DisplayName(Quantity_displayName)]
        public virtual uint Quantity {
            get => GetData<uint>(18);
            set {
                if (GetData<uint>(18) == value) return;
                SetData(18, value, nameof(Quantity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 350;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual uint Unk2 {
            get => GetData<uint>(22);
            set {
                if (GetData<uint>(22) == value) return;
                SetData(22, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Category_displayName = "Category";
        public const int Category_sortIndex = 400;
        [SortOrder(Category_sortIndex)]
        [DisplayName(Category_displayName)]
        public virtual MHW_Template.Items.ItemCategory Category {
            get => (MHW_Template.Items.ItemCategory) GetData<uint>(26);
            set {
                if ((MHW_Template.Items.ItemCategory) GetData<uint>(26) == value) return;
                SetData(26, (uint) value, nameof(Category));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Category));
            }
        }

        public const string Can_Auto_Craft_displayName = "Can Auto-Craft";
        public const int Can_Auto_Craft_sortIndex = 450;
        [SortOrder(Can_Auto_Craft_sortIndex)]
        [DisplayName(Can_Auto_Craft_displayName)]
        public virtual bool Can_Auto_Craft {
            get => (bool) Convert.ToBoolean(GetData<byte>(30));
            set {
                if (Convert.ToBoolean(GetData<byte>(30)) == value) return;
                SetData(30, Convert.ToByte(value), nameof(Can_Auto_Craft));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Can_Auto_Craft));
            }
        }

        public const int lastSortIndex = 500;
    }
}