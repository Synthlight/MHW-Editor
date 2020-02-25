using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class MelderItem {
        public const uint StructSize = 21;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Result_Item_Id_displayName = "Result Item Id";
        public const int Result_Item_Id_sortIndex = 50;
        [SortOrder(Result_Item_Id_sortIndex)]
        [DisplayName(Result_Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Result_Item_Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Result_Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Result_Item_Id));
                OnPropertyChanged(nameof(Result_Item_Id_button));
            }
        }

        [SortOrder(Result_Item_Id_sortIndex)]
        [DisplayName(Result_Item_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Result_Item_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Result_Item_Id).ToStringWithId(Result_Item_Id);

        public const string Research_Points_displayName = "Research Points";
        public const int Research_Points_sortIndex = 100;
        [SortOrder(Research_Points_sortIndex)]
        [DisplayName(Research_Points_displayName)]
        public virtual uint Research_Points {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Research_Points));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Research_Points));
            }
        }

        public const string Melding_Points_displayName = "Melding Points";
        public const int Melding_Points_sortIndex = 150;
        [SortOrder(Melding_Points_sortIndex)]
        [DisplayName(Melding_Points_displayName)]
        public virtual uint Melding_Points {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Melding_Points));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Melding_Points));
            }
        }

        public const string Category_displayName = "Category";
        public const int Category_sortIndex = 200;
        [SortOrder(Category_sortIndex)]
        [DisplayName(Category_displayName)]
        public virtual MHW_Template.Items.ItemCategory Category {
            get => (MHW_Template.Items.ItemCategory) GetData<uint>(12);
            set {
                if ((MHW_Template.Items.ItemCategory) GetData<uint>(12) == value) return;
                SetData(12, (uint) value, nameof(Category));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Category));
            }
        }

        public const string Unlock_Flag_displayName = "Unlock Flag";
        public const int Unlock_Flag_sortIndex = 250;
        [SortOrder(Unlock_Flag_sortIndex)]
        [DisplayName(Unlock_Flag_displayName)]
        public virtual uint Unlock_Flag {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Unlock_Flag));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlock_Flag));
            }
        }

        public const string Unknown_uint8__displayName = "Unknown (uint8)";
        public const int Unknown_uint8__sortIndex = 300;
        [SortOrder(Unknown_uint8__sortIndex)]
        [DisplayName(Unknown_uint8__displayName)]
        public virtual byte Unknown_uint8_ {
            get => GetData<byte>(20);
            set {
                if (GetData<byte>(20) == value) return;
                SetData(20, value, nameof(Unknown_uint8_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_uint8_));
            }
        }

        public const int lastSortIndex = 350;
    }
}