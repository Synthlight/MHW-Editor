using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class ArmUp {
        public const uint StructSize = 22;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Unknown_int16_1_displayName = "Unknown (int16) 1";
        public const int Unknown_int16_1_sortIndex = 50;
        [SortOrder(Unknown_int16_1_sortIndex)]
        [DisplayName(Unknown_int16_1_displayName)]
        public virtual short Unknown_int16_1 {
            get => GetData<short>(0);
            set {
                if (GetData<short>(0) == value) return;
                SetData(0, value);
                OnPropertyChanged(nameof(Unknown_int16_1));
            }
        }

        public const string Unknown_int16_2_displayName = "Unknown (int16) 2";
        public const int Unknown_int16_2_sortIndex = 100;
        [SortOrder(Unknown_int16_2_sortIndex)]
        [DisplayName(Unknown_int16_2_displayName)]
        public virtual short Unknown_int16_2 {
            get => GetData<short>(2);
            set {
                if (GetData<short>(2) == value) return;
                SetData(2, value);
                OnPropertyChanged(nameof(Unknown_int16_2));
            }
        }

        public const string Unknown_int16_3_displayName = "Unknown (int16) 3";
        public const int Unknown_int16_3_sortIndex = 150;
        [SortOrder(Unknown_int16_3_sortIndex)]
        [DisplayName(Unknown_int16_3_displayName)]
        public virtual short Unknown_int16_3 {
            get => GetData<short>(4);
            set {
                if (GetData<short>(4) == value) return;
                SetData(4, value);
                OnPropertyChanged(nameof(Unknown_int16_3));
            }
        }

        public const string Unknown_int16_4_displayName = "Unknown (int16) 4";
        public const int Unknown_int16_4_sortIndex = 200;
        [SortOrder(Unknown_int16_4_sortIndex)]
        [DisplayName(Unknown_int16_4_displayName)]
        public virtual short Unknown_int16_4 {
            get => GetData<short>(6);
            set {
                if (GetData<short>(6) == value) return;
                SetData(6, value);
                OnPropertyChanged(nameof(Unknown_int16_4));
            }
        }

        public const string Unknown_int16_5_displayName = "Unknown (int16) 5";
        public const int Unknown_int16_5_sortIndex = 250;
        [SortOrder(Unknown_int16_5_sortIndex)]
        [DisplayName(Unknown_int16_5_displayName)]
        public virtual short Unknown_int16_5 {
            get => GetData<short>(8);
            set {
                if (GetData<short>(8) == value) return;
                SetData(8, value);
                OnPropertyChanged(nameof(Unknown_int16_5));
            }
        }

        public const string Unknown_int16_6_displayName = "Unknown (int16) 6";
        public const int Unknown_int16_6_sortIndex = 300;
        [SortOrder(Unknown_int16_6_sortIndex)]
        [DisplayName(Unknown_int16_6_displayName)]
        public virtual short Unknown_int16_6 {
            get => GetData<short>(10);
            set {
                if (GetData<short>(10) == value) return;
                SetData(10, value);
                OnPropertyChanged(nameof(Unknown_int16_6));
            }
        }

        public const string Unknown_int16_7_displayName = "Unknown (int16) 7";
        public const int Unknown_int16_7_sortIndex = 350;
        [SortOrder(Unknown_int16_7_sortIndex)]
        [DisplayName(Unknown_int16_7_displayName)]
        public virtual short Unknown_int16_7 {
            get => GetData<short>(12);
            set {
                if (GetData<short>(12) == value) return;
                SetData(12, value);
                OnPropertyChanged(nameof(Unknown_int16_7));
            }
        }

        public const string Unknown_int16_8_displayName = "Unknown (int16) 8";
        public const int Unknown_int16_8_sortIndex = 400;
        [SortOrder(Unknown_int16_8_sortIndex)]
        [DisplayName(Unknown_int16_8_displayName)]
        public virtual short Unknown_int16_8 {
            get => GetData<short>(14);
            set {
                if (GetData<short>(14) == value) return;
                SetData(14, value);
                OnPropertyChanged(nameof(Unknown_int16_8));
            }
        }

        public const string Unknown_int16_9_displayName = "Unknown (int16) 9";
        public const int Unknown_int16_9_sortIndex = 450;
        [SortOrder(Unknown_int16_9_sortIndex)]
        [DisplayName(Unknown_int16_9_displayName)]
        public virtual short Unknown_int16_9 {
            get => GetData<short>(16);
            set {
                if (GetData<short>(16) == value) return;
                SetData(16, value);
                OnPropertyChanged(nameof(Unknown_int16_9));
            }
        }

        public const string Unknown_int16_10_displayName = "Unknown (int16) 10";
        public const int Unknown_int16_10_sortIndex = 500;
        [SortOrder(Unknown_int16_10_sortIndex)]
        [DisplayName(Unknown_int16_10_displayName)]
        public virtual short Unknown_int16_10 {
            get => GetData<short>(18);
            set {
                if (GetData<short>(18) == value) return;
                SetData(18, value);
                OnPropertyChanged(nameof(Unknown_int16_10));
            }
        }

        public const string Unknown_int16_11_displayName = "Unknown (int16) 11";
        public const int Unknown_int16_11_sortIndex = 550;
        [SortOrder(Unknown_int16_11_sortIndex)]
        [DisplayName(Unknown_int16_11_displayName)]
        public virtual short Unknown_int16_11 {
            get => GetData<short>(20);
            set {
                if (GetData<short>(20) == value) return;
                SetData(20, value);
                OnPropertyChanged(nameof(Unknown_int16_11));
            }
        }

        public const int lastSortIndex = 600;
    }
}