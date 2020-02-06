
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Skills {
    public partial class SkillDat {
        public const uint StructSize = 27;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public ushort Id {
            get => GetData<ushort>(0);
        }

        protected const string Level_displayName = "Level";
        protected const int Level_sortIndex = 100;
        [SortOrder(Level_sortIndex)]
        [DisplayName(Level_displayName)]
        public byte Level {
            get => GetData<byte>(2);
        }

        protected const string Param_1_displayName = "Param 1";
        protected const int Param_1_sortIndex = 150;
        [SortOrder(Param_1_sortIndex)]
        [DisplayName(Param_1_displayName)]
        public ushort Param_1 {
            get => GetData<ushort>(3);
            set {
                if (GetData<ushort>(3) == value) return;
                SetData(3, value);
                OnPropertyChanged(nameof(Param_1));
            }
        }

        protected const string Param_2_displayName = "Param 2";
        protected const int Param_2_sortIndex = 200;
        [SortOrder(Param_2_sortIndex)]
        [DisplayName(Param_2_displayName)]
        public ushort Param_2 {
            get => GetData<ushort>(5);
            set {
                if (GetData<ushort>(5) == value) return;
                SetData(5, value);
                OnPropertyChanged(nameof(Param_2));
            }
        }

        protected const string Param_3_displayName = "Param 3";
        protected const int Param_3_sortIndex = 250;
        [SortOrder(Param_3_sortIndex)]
        [DisplayName(Param_3_displayName)]
        public ushort Param_3 {
            get => GetData<ushort>(7);
            set {
                if (GetData<ushort>(7) == value) return;
                SetData(7, value);
                OnPropertyChanged(nameof(Param_3));
            }
        }

        protected const string Param_4_displayName = "Param 4";
        protected const int Param_4_sortIndex = 300;
        [SortOrder(Param_4_sortIndex)]
        [DisplayName(Param_4_displayName)]
        public ushort Param_4 {
            get => GetData<ushort>(9);
            set {
                if (GetData<ushort>(9) == value) return;
                SetData(9, value);
                OnPropertyChanged(nameof(Param_4));
            }
        }

        protected const string Param_5_displayName = "Param 5";
        protected const int Param_5_sortIndex = 350;
        [SortOrder(Param_5_sortIndex)]
        [DisplayName(Param_5_displayName)]
        public ushort Param_5 {
            get => GetData<ushort>(11);
            set {
                if (GetData<ushort>(11) == value) return;
                SetData(11, value);
                OnPropertyChanged(nameof(Param_5));
            }
        }

        protected const string Param_6_displayName = "Param 6";
        protected const int Param_6_sortIndex = 400;
        [SortOrder(Param_6_sortIndex)]
        [DisplayName(Param_6_displayName)]
        public ushort Param_6 {
            get => GetData<ushort>(13);
            set {
                if (GetData<ushort>(13) == value) return;
                SetData(13, value);
                OnPropertyChanged(nameof(Param_6));
            }
        }

        protected const string Param_7_displayName = "Param 7";
        protected const int Param_7_sortIndex = 450;
        [SortOrder(Param_7_sortIndex)]
        [DisplayName(Param_7_displayName)]
        public ushort Param_7 {
            get => GetData<ushort>(15);
            set {
                if (GetData<ushort>(15) == value) return;
                SetData(15, value);
                OnPropertyChanged(nameof(Param_7));
            }
        }

        protected const string Param_8_displayName = "Param 8";
        protected const int Param_8_sortIndex = 500;
        [SortOrder(Param_8_sortIndex)]
        [DisplayName(Param_8_displayName)]
        public ushort Param_8 {
            get => GetData<ushort>(19);
            set {
                if (GetData<ushort>(19) == value) return;
                SetData(19, value);
                OnPropertyChanged(nameof(Param_8));
            }
        }

        protected const string Param_9_displayName = "Param 9";
        protected const int Param_9_sortIndex = 550;
        [SortOrder(Param_9_sortIndex)]
        [DisplayName(Param_9_displayName)]
        public ushort Param_9 {
            get => GetData<ushort>(21);
            set {
                if (GetData<ushort>(21) == value) return;
                SetData(21, value);
                OnPropertyChanged(nameof(Param_9));
            }
        }

        protected const string Param_10_displayName = "Param 10";
        protected const int Param_10_sortIndex = 600;
        [SortOrder(Param_10_sortIndex)]
        [DisplayName(Param_10_displayName)]
        public ushort Param_10 {
            get => GetData<ushort>(23);
            set {
                if (GetData<ushort>(23) == value) return;
                SetData(23, value);
                OnPropertyChanged(nameof(Param_10));
            }
        }

        protected const string Param_11_displayName = "Param 11";
        protected const int Param_11_sortIndex = 650;
        [SortOrder(Param_11_sortIndex)]
        [DisplayName(Param_11_displayName)]
        public ushort Param_11 {
            get => GetData<ushort>(25);
            set {
                if (GetData<ushort>(25) == value) return;
                SetData(25, value);
                OnPropertyChanged(nameof(Param_11));
            }
        }
    }
}