
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class Plit {
        public const uint StructSize = 37;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Cultivation_category_displayName = "Cultivation category";
        protected const int Cultivation_category_sortIndex = 50;
        [SortOrder(Cultivation_category_sortIndex)]
        [DisplayName(Cultivation_category_displayName)]
        public MHW_Template.Items.CultivationCategory Cultivation_category {
            get => (MHW_Template.Items.CultivationCategory) GetData<uint>(0);
            set {
                SetData(0, (uint) value);
                OnPropertyChanged(nameof(Cultivation_category));
            }
        }
        protected const string Unlocked_from_start_Raw_displayName = "Unlocked from start Raw";
        protected const int Unlocked_from_start_Raw_sortIndex = 100;
        [SortOrder(Unlocked_from_start_Raw_sortIndex)]
        [DisplayName(Unlocked_from_start_Raw_displayName)]
        protected byte Unlocked_from_start_Raw {
            get => GetData<byte>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Unlocked_from_start_Raw));
            }
        }
        protected const string Item_displayName = "Item";
        protected const int Item_sortIndex = 150;
        [SortOrder(Item_sortIndex)]
        [DisplayName(Item_displayName)]
        [DataSource(DataSourceType.Items)]
        public ushort Item {
            get => GetData<ushort>(9);
            set {
                SetData(9, value);
                OnPropertyChanged(nameof(Item));
            }
        }
        protected const string Required_time_displayName = "Required time";
        protected const int Required_time_sortIndex = 200;
        [SortOrder(Required_time_sortIndex)]
        [DisplayName(Required_time_displayName)]
        public uint Required_time {
            get => GetData<uint>(13);
            set {
                SetData(13, value);
                OnPropertyChanged(nameof(Required_time));
            }
        }
        protected const string Catalyst_time_bonus_displayName = "Catalyst time bonus";
        protected const int Catalyst_time_bonus_sortIndex = 250;
        [SortOrder(Catalyst_time_bonus_sortIndex)]
        [DisplayName(Catalyst_time_bonus_displayName)]
        public uint Catalyst_time_bonus {
            get => GetData<uint>(17);
            set {
                SetData(17, value);
                OnPropertyChanged(nameof(Catalyst_time_bonus));
            }
        }
        protected const string Amount_Base__displayName = "Amount (Base)";
        protected const int Amount_Base__sortIndex = 300;
        [SortOrder(Amount_Base__sortIndex)]
        [DisplayName(Amount_Base__displayName)]
        public uint Amount_Base_ {
            get => GetData<uint>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Amount_Base_));
            }
        }
        protected const string Amount_1__displayName = "Amount (+1)";
        protected const int Amount_1__sortIndex = 350;
        [SortOrder(Amount_1__sortIndex)]
        [DisplayName(Amount_1__displayName)]
        public uint Amount_1_ {
            get => GetData<uint>(29);
            set {
                SetData(29, value);
                OnPropertyChanged(nameof(Amount_1_));
            }
        }
        protected const string Amount_2__displayName = "Amount (+2)";
        protected const int Amount_2__sortIndex = 400;
        [SortOrder(Amount_2__sortIndex)]
        [DisplayName(Amount_2__displayName)]
        public uint Amount_2_ {
            get => GetData<uint>(33);
            set {
                SetData(33, value);
                OnPropertyChanged(nameof(Amount_2_));
            }
        }
        protected const string Unknown_int32_1_displayName = "Unknown (int32) 1";
        protected const int Unknown_int32_1_sortIndex = 450;
        [SortOrder(Unknown_int32_1_sortIndex)]
        [DisplayName(Unknown_int32_1_displayName)]
        public uint Unknown_int32_1 {
            get => GetData<uint>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Unknown_int32_1));
            }
        }
    }
}