using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class LimitBreakMaterialBase {
        public const uint StructSize = 14;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 50;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual byte Rarity {
            get => GetData<byte>(0);
            set {
                if (GetData<byte>(0) == value) return;
                SetData(0, value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Equip_Type_displayName = "Equip Type";
        public const int Equip_Type_sortIndex = 100;
        [SortOrder(Equip_Type_sortIndex)]
        [DisplayName(Equip_Type_displayName)]
        public virtual byte Equip_Type {
            get => GetData<byte>(1);
            set {
                if (GetData<byte>(1) == value) return;
                SetData(1, value, nameof(Equip_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Equip_Type));
            }
        }

        public const string Cost_displayName = "Cost";
        public const int Cost_sortIndex = 150;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public virtual uint Cost {
            get => GetData<uint>(2);
            set {
                if (GetData<uint>(2) == value) return;
                SetData(2, value, nameof(Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public const string Item_1_Id_displayName = "Item 1 Id";
        public const int Item_1_Id_sortIndex = 200;
        [SortOrder(Item_1_Id_sortIndex)]
        [DisplayName(Item_1_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_1_Id {
            get => GetData<ushort>(6);
            set {
                if (GetData<ushort>(6) == value) return;
                SetData(6, value, nameof(Item_1_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Id));
                OnPropertyChanged(nameof(Item_1_Id_button));
            }
        }

        [SortOrder(Item_1_Id_sortIndex)]
        [DisplayName(Item_1_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Item_1_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_1_Id, IdNamePair.Unknown((ushort) Item_1_Id)).ToString();

        public const string Item_1_Cnt_displayName = "Item 1 Cnt";
        public const int Item_1_Cnt_sortIndex = 250;
        [SortOrder(Item_1_Cnt_sortIndex)]
        [DisplayName(Item_1_Cnt_displayName)]
        public virtual ushort Item_1_Cnt {
            get => GetData<ushort>(8);
            set {
                if (GetData<ushort>(8) == value) return;
                SetData(8, value, nameof(Item_1_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Cnt));
            }
        }

        public const string Item_2_Id_displayName = "Item 2 Id";
        public const int Item_2_Id_sortIndex = 300;
        [SortOrder(Item_2_Id_sortIndex)]
        [DisplayName(Item_2_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_2_Id {
            get => GetData<ushort>(10);
            set {
                if (GetData<ushort>(10) == value) return;
                SetData(10, value, nameof(Item_2_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Id));
                OnPropertyChanged(nameof(Item_2_Id_button));
            }
        }

        [SortOrder(Item_2_Id_sortIndex)]
        [DisplayName(Item_2_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Item_2_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_2_Id, IdNamePair.Unknown((ushort) Item_2_Id)).ToString();

        public const string Item_2_Cnt_displayName = "Item 2 Cnt";
        public const int Item_2_Cnt_sortIndex = 350;
        [SortOrder(Item_2_Cnt_sortIndex)]
        [DisplayName(Item_2_Cnt_displayName)]
        public virtual ushort Item_2_Cnt {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value, nameof(Item_2_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Cnt));
            }
        }

        public const int lastSortIndex = 400;
    }
}