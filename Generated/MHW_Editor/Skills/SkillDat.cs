
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class SkillDat {
        public const uint StructSize = 19;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
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
                SetData(15, value);
                OnPropertyChanged(nameof(Param_7));
            }
        }
        protected const string Param_8_displayName = "Param 8";
        protected const int Param_8_sortIndex = 500;
        [SortOrder(Param_8_sortIndex)]
        [DisplayName(Param_8_displayName)]
        public ushort Param_8 {
            get => GetData<ushort>(17);
            set {
                SetData(17, value);
                OnPropertyChanged(nameof(Param_8));
            }
        }
    }
}