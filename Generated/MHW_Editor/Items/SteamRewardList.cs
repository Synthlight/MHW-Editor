using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class SteamRewardList {
        public const uint StructSize = 24;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Type_displayName = "Type";
        public const int Type_sortIndex = 50;
        [SortOrder(Type_sortIndex)]
        [DisplayName(Type_displayName)]
        public virtual int Type {
            get => GetData<int>(0);
            set {
                if (GetData<int>(0) == value) return;
                SetData(0, value, nameof(Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Type));
            }
        }

        public const string Item_Id_displayName = "Item Id";
        public const int Item_Id_sortIndex = 100;
        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_Id {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id));
                OnPropertyChanged(nameof(Item_Id_button));
            }
        }

        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

        public const string Quantity_displayName = "Quantity";
        public const int Quantity_sortIndex = 150;
        [SortOrder(Quantity_sortIndex)]
        [DisplayName(Quantity_displayName)]
        public virtual uint Quantity {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Quantity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public const string Chance__displayName = "Chance %";
        public const int Chance__sortIndex = 200;
        [SortOrder(Chance__sortIndex)]
        [DisplayName(Chance__displayName)]
        public virtual ulong Chance_ {
            get => GetData<ulong>(12);
            set {
                if (GetData<ulong>(12) == value) return;
                SetData(12, value, nameof(Chance_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Chance_));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 250;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual MHW_Template.Items.SteamRarity Rarity {
            get => (MHW_Template.Items.SteamRarity) GetData<uint>(20);
            set {
                if ((MHW_Template.Items.SteamRarity) GetData<uint>(20) == value) return;
                SetData(20, (uint) value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const int lastSortIndex = 300;
    }
}