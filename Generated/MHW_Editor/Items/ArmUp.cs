
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class ArmUp {
        public const uint StructSize = 22;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Rarity}";

        public const string Quest_Progress_1_displayName = "Quest Progress 1";
        public const int Quest_Progress_1_sortIndex = 50;
        [SortOrder(Quest_Progress_1_sortIndex)]
        [DisplayName(Quest_Progress_1_displayName)]
        public virtual short Quest_Progress_1 {
            get => GetData<short>(0);
            set {
                if (GetData<short>(0) == value) return;
                SetData(0, value, nameof(Quest_Progress_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_1));
            }
        }

        public const string Quest_Progress_2_displayName = "Quest Progress 2";
        public const int Quest_Progress_2_sortIndex = 100;
        [SortOrder(Quest_Progress_2_sortIndex)]
        [DisplayName(Quest_Progress_2_displayName)]
        public virtual short Quest_Progress_2 {
            get => GetData<short>(2);
            set {
                if (GetData<short>(2) == value) return;
                SetData(2, value, nameof(Quest_Progress_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_2));
            }
        }

        public const string Quest_Progress_3_displayName = "Quest Progress 3";
        public const int Quest_Progress_3_sortIndex = 150;
        [SortOrder(Quest_Progress_3_sortIndex)]
        [DisplayName(Quest_Progress_3_displayName)]
        public virtual short Quest_Progress_3 {
            get => GetData<short>(4);
            set {
                if (GetData<short>(4) == value) return;
                SetData(4, value, nameof(Quest_Progress_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_3));
            }
        }

        public const string Quest_Progress_4_displayName = "Quest Progress 4";
        public const int Quest_Progress_4_sortIndex = 200;
        [SortOrder(Quest_Progress_4_sortIndex)]
        [DisplayName(Quest_Progress_4_displayName)]
        public virtual short Quest_Progress_4 {
            get => GetData<short>(6);
            set {
                if (GetData<short>(6) == value) return;
                SetData(6, value, nameof(Quest_Progress_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_4));
            }
        }

        public const string Quest_Progress_5_displayName = "Quest Progress 5";
        public const int Quest_Progress_5_sortIndex = 250;
        [SortOrder(Quest_Progress_5_sortIndex)]
        [DisplayName(Quest_Progress_5_displayName)]
        public virtual short Quest_Progress_5 {
            get => GetData<short>(8);
            set {
                if (GetData<short>(8) == value) return;
                SetData(8, value, nameof(Quest_Progress_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_5));
            }
        }

        public const string Quest_Progress_6_displayName = "Quest Progress 6";
        public const int Quest_Progress_6_sortIndex = 300;
        [SortOrder(Quest_Progress_6_sortIndex)]
        [DisplayName(Quest_Progress_6_displayName)]
        public virtual short Quest_Progress_6 {
            get => GetData<short>(10);
            set {
                if (GetData<short>(10) == value) return;
                SetData(10, value, nameof(Quest_Progress_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_6));
            }
        }

        public const string Quest_Progress_7_displayName = "Quest Progress 7";
        public const int Quest_Progress_7_sortIndex = 350;
        [SortOrder(Quest_Progress_7_sortIndex)]
        [DisplayName(Quest_Progress_7_displayName)]
        public virtual short Quest_Progress_7 {
            get => GetData<short>(12);
            set {
                if (GetData<short>(12) == value) return;
                SetData(12, value, nameof(Quest_Progress_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_7));
            }
        }

        public const string Quest_Progress_8_displayName = "Quest Progress 8";
        public const int Quest_Progress_8_sortIndex = 400;
        [SortOrder(Quest_Progress_8_sortIndex)]
        [DisplayName(Quest_Progress_8_displayName)]
        public virtual short Quest_Progress_8 {
            get => GetData<short>(14);
            set {
                if (GetData<short>(14) == value) return;
                SetData(14, value, nameof(Quest_Progress_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_8));
            }
        }

        public const string Quest_Progress_9_displayName = "Quest Progress 9";
        public const int Quest_Progress_9_sortIndex = 450;
        [SortOrder(Quest_Progress_9_sortIndex)]
        [DisplayName(Quest_Progress_9_displayName)]
        public virtual short Quest_Progress_9 {
            get => GetData<short>(16);
            set {
                if (GetData<short>(16) == value) return;
                SetData(16, value, nameof(Quest_Progress_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_9));
            }
        }

        public const string Quest_Progress_10_displayName = "Quest Progress 10";
        public const int Quest_Progress_10_sortIndex = 500;
        [SortOrder(Quest_Progress_10_sortIndex)]
        [DisplayName(Quest_Progress_10_displayName)]
        public virtual short Quest_Progress_10 {
            get => GetData<short>(18);
            set {
                if (GetData<short>(18) == value) return;
                SetData(18, value, nameof(Quest_Progress_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_10));
            }
        }

        public const string Quest_Progress_11_displayName = "Quest Progress 11";
        public const int Quest_Progress_11_sortIndex = 550;
        [SortOrder(Quest_Progress_11_sortIndex)]
        [DisplayName(Quest_Progress_11_displayName)]
        public virtual short Quest_Progress_11 {
            get => GetData<short>(20);
            set {
                if (GetData<short>(20) == value) return;
                SetData(20, value, nameof(Quest_Progress_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Progress_11));
            }
        }

        public const int lastSortIndex = 600;
    }
}