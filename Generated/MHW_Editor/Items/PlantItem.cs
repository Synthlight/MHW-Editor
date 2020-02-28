using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class PlantItem {
        public const uint StructSize = 37;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Item}";

        public const string Cultivation_category_displayName = "Cultivation category";
        public const int Cultivation_category_sortIndex = 50;
        [SortOrder(Cultivation_category_sortIndex)]
        [DisplayName(Cultivation_category_displayName)]
        public virtual MHW_Template.Items.CultivationCategory Cultivation_category {
            get => (MHW_Template.Items.CultivationCategory) GetData<uint>(0);
            set {
                if ((MHW_Template.Items.CultivationCategory) GetData<uint>(0) == value) return;
                SetData(0, (uint) value, nameof(Cultivation_category));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cultivation_category));
            }
        }

        public const string Unlocked_from_start_displayName = "Unlocked from start";
        public const int Unlocked_from_start_sortIndex = 100;
        [SortOrder(Unlocked_from_start_sortIndex)]
        [DisplayName(Unlocked_from_start_displayName)]
        public virtual bool Unlocked_from_start {
            get => (bool) Convert.ToBoolean(GetData<byte>(8));
            set {
                if (Convert.ToBoolean(GetData<byte>(8)) == value) return;
                SetData(8, Convert.ToByte(value), nameof(Unlocked_from_start));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlocked_from_start));
            }
        }

        public const string Item_displayName = "Item";
        public const int Item_sortIndex = 150;
        [SortOrder(Item_sortIndex)]
        [DisplayName(Item_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item {
            get => GetData<ushort>(9);
            set {
                if (GetData<ushort>(9) == value) return;
                SetData(9, value, nameof(Item));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item));
                OnPropertyChanged(nameof(Item_button));
            }
        }

        [SortOrder(Item_sortIndex)]
        [DisplayName(Item_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Item_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item).ToStringWithId(Item);

        public const string Required_time_displayName = "Required time";
        public const int Required_time_sortIndex = 200;
        [SortOrder(Required_time_sortIndex)]
        [DisplayName(Required_time_displayName)]
        public virtual uint Required_time {
            get => GetData<uint>(13);
            set {
                if (GetData<uint>(13) == value) return;
                SetData(13, value, nameof(Required_time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Required_time));
            }
        }

        public const string Catalyst_time_bonus_displayName = "Catalyst time bonus";
        public const int Catalyst_time_bonus_sortIndex = 250;
        [SortOrder(Catalyst_time_bonus_sortIndex)]
        [DisplayName(Catalyst_time_bonus_displayName)]
        public virtual uint Catalyst_time_bonus {
            get => GetData<uint>(17);
            set {
                if (GetData<uint>(17) == value) return;
                SetData(17, value, nameof(Catalyst_time_bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Catalyst_time_bonus));
            }
        }

        public const string Amount_Base__displayName = "Amount (Base)";
        public const int Amount_Base__sortIndex = 300;
        [SortOrder(Amount_Base__sortIndex)]
        [DisplayName(Amount_Base__displayName)]
        public virtual uint Amount_Base_ {
            get => GetData<uint>(25);
            set {
                if (GetData<uint>(25) == value) return;
                SetData(25, value, nameof(Amount_Base_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Amount_Base_));
            }
        }

        public const string Amount_1__displayName = "Amount (+1)";
        public const int Amount_1__sortIndex = 350;
        [SortOrder(Amount_1__sortIndex)]
        [DisplayName(Amount_1__displayName)]
        public virtual uint Amount_1_ {
            get => GetData<uint>(29);
            set {
                if (GetData<uint>(29) == value) return;
                SetData(29, value, nameof(Amount_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Amount_1_));
            }
        }

        public const string Amount_2__displayName = "Amount (+2)";
        public const int Amount_2__sortIndex = 400;
        [SortOrder(Amount_2__sortIndex)]
        [DisplayName(Amount_2__displayName)]
        public virtual uint Amount_2_ {
            get => GetData<uint>(33);
            set {
                if (GetData<uint>(33) == value) return;
                SetData(33, value, nameof(Amount_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Amount_2_));
            }
        }

        public const string Unknown_int32_1_displayName = "Unknown (int32) 1";
        public const int Unknown_int32_1_sortIndex = 450;
        [SortOrder(Unknown_int32_1_sortIndex)]
        [DisplayName(Unknown_int32_1_displayName)]
        public virtual uint Unknown_int32_1 {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Unknown_int32_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_int32_1));
            }
        }

        public const int lastSortIndex = 500;
    }
}