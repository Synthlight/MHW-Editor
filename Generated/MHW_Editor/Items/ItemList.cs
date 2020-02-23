using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class ItemList {
        public const uint StructSize = 8;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Item_Id_displayName = "Item Id";
        public const int Item_Id_sortIndex = 50;
        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id));
                OnPropertyChanged(nameof(Item_Id_button));
            }
        }

        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Item_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id, IdNamePair.Unknown((ushort) Item_Id)).ToString();

        public const string Quantity_displayName = "Quantity";
        public const int Quantity_sortIndex = 100;
        [SortOrder(Quantity_sortIndex)]
        [DisplayName(Quantity_displayName)]
        public virtual uint Quantity {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Quantity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public const int lastSortIndex = 150;
    }
}