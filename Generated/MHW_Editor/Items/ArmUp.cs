
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class ArmUp {
        public const uint StructSize = 22;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Unknown_int16_1_displayName = "Unknown (int16) 1";
        protected const int Unknown_int16_1_sortIndex = 50;
        [SortOrder(Unknown_int16_1_sortIndex)]
        [DisplayName(Unknown_int16_1_displayName)]
        public short Unknown_int16_1 {
            get => GetData<short>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Unknown_int16_1));
            }
        }
        protected const string Unknown_int16_2_displayName = "Unknown (int16) 2";
        protected const int Unknown_int16_2_sortIndex = 100;
        [SortOrder(Unknown_int16_2_sortIndex)]
        [DisplayName(Unknown_int16_2_displayName)]
        public short Unknown_int16_2 {
            get => GetData<short>(2);
            set {
                SetData(2, value);
                OnPropertyChanged(nameof(Unknown_int16_2));
            }
        }
        protected const string Unknown_int16_3_displayName = "Unknown (int16) 3";
        protected const int Unknown_int16_3_sortIndex = 150;
        [SortOrder(Unknown_int16_3_sortIndex)]
        [DisplayName(Unknown_int16_3_displayName)]
        public short Unknown_int16_3 {
            get => GetData<short>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Unknown_int16_3));
            }
        }
        protected const string Unknown_int16_4_displayName = "Unknown (int16) 4";
        protected const int Unknown_int16_4_sortIndex = 200;
        [SortOrder(Unknown_int16_4_sortIndex)]
        [DisplayName(Unknown_int16_4_displayName)]
        public short Unknown_int16_4 {
            get => GetData<short>(6);
            set {
                SetData(6, value);
                OnPropertyChanged(nameof(Unknown_int16_4));
            }
        }
        protected const string Unknown_int16_5_displayName = "Unknown (int16) 5";
        protected const int Unknown_int16_5_sortIndex = 250;
        [SortOrder(Unknown_int16_5_sortIndex)]
        [DisplayName(Unknown_int16_5_displayName)]
        public short Unknown_int16_5 {
            get => GetData<short>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Unknown_int16_5));
            }
        }
        protected const string Unknown_int16_6_displayName = "Unknown (int16) 6";
        protected const int Unknown_int16_6_sortIndex = 300;
        [SortOrder(Unknown_int16_6_sortIndex)]
        [DisplayName(Unknown_int16_6_displayName)]
        public short Unknown_int16_6 {
            get => GetData<short>(10);
            set {
                SetData(10, value);
                OnPropertyChanged(nameof(Unknown_int16_6));
            }
        }
        protected const string Unknown_int16_7_displayName = "Unknown (int16) 7";
        protected const int Unknown_int16_7_sortIndex = 350;
        [SortOrder(Unknown_int16_7_sortIndex)]
        [DisplayName(Unknown_int16_7_displayName)]
        public short Unknown_int16_7 {
            get => GetData<short>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Unknown_int16_7));
            }
        }
        protected const string Unknown_int16_8_displayName = "Unknown (int16) 8";
        protected const int Unknown_int16_8_sortIndex = 400;
        [SortOrder(Unknown_int16_8_sortIndex)]
        [DisplayName(Unknown_int16_8_displayName)]
        public short Unknown_int16_8 {
            get => GetData<short>(14);
            set {
                SetData(14, value);
                OnPropertyChanged(nameof(Unknown_int16_8));
            }
        }
        protected const string Unknown_int16_9_displayName = "Unknown (int16) 9";
        protected const int Unknown_int16_9_sortIndex = 450;
        [SortOrder(Unknown_int16_9_sortIndex)]
        [DisplayName(Unknown_int16_9_displayName)]
        public short Unknown_int16_9 {
            get => GetData<short>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Unknown_int16_9));
            }
        }
        protected const string Unknown_int16_10_displayName = "Unknown (int16) 10";
        protected const int Unknown_int16_10_sortIndex = 500;
        [SortOrder(Unknown_int16_10_sortIndex)]
        [DisplayName(Unknown_int16_10_displayName)]
        public short Unknown_int16_10 {
            get => GetData<short>(18);
            set {
                SetData(18, value);
                OnPropertyChanged(nameof(Unknown_int16_10));
            }
        }
        protected const string Unknown_int16_11_displayName = "Unknown (int16) 11";
        protected const int Unknown_int16_11_sortIndex = 550;
        [SortOrder(Unknown_int16_11_sortIndex)]
        [DisplayName(Unknown_int16_11_displayName)]
        public short Unknown_int16_11 {
            get => GetData<short>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Unknown_int16_11));
            }
        }
    }
}