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

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public ushort Id {
            get => GetData<ushort>(0);
        }

        public const string Level_displayName = "Level";
        public const int Level_sortIndex = 100;
        [SortOrder(Level_sortIndex)]
        [DisplayName(Level_displayName)]
        public byte Level {
            get => GetData<byte>(2);
        }

        public const string Param_1_displayName = "Param 1";
        public const int Param_1_sortIndex = 150;
        [SortOrder(Param_1_sortIndex)]
        [DisplayName(Param_1_displayName)]
        public uint Param_1 {
            get => GetData<uint>(3);
            set {
                if (GetData<uint>(3) == value) return;
                SetData(3, value);
                OnPropertyChanged(nameof(Param_1));
            }
        }

        public const string Param_2_displayName = "Param 2";
        public const int Param_2_sortIndex = 200;
        [SortOrder(Param_2_sortIndex)]
        [DisplayName(Param_2_displayName)]
        public uint Param_2 {
            get => GetData<uint>(7);
            set {
                if (GetData<uint>(7) == value) return;
                SetData(7, value);
                OnPropertyChanged(nameof(Param_2));
            }
        }

        public const string Param_3_displayName = "Param 3";
        public const int Param_3_sortIndex = 250;
        [SortOrder(Param_3_sortIndex)]
        [DisplayName(Param_3_displayName)]
        public uint Param_3 {
            get => GetData<uint>(11);
            set {
                if (GetData<uint>(11) == value) return;
                SetData(11, value);
                OnPropertyChanged(nameof(Param_3));
            }
        }

        public const string Param_4_displayName = "Param 4";
        public const int Param_4_sortIndex = 300;
        [SortOrder(Param_4_sortIndex)]
        [DisplayName(Param_4_displayName)]
        public uint Param_4 {
            get => GetData<uint>(15);
            set {
                if (GetData<uint>(15) == value) return;
                SetData(15, value);
                OnPropertyChanged(nameof(Param_4));
            }
        }

        public const string Param_5_displayName = "Param 5";
        public const int Param_5_sortIndex = 350;
        [SortOrder(Param_5_sortIndex)]
        [DisplayName(Param_5_displayName)]
        public ushort Param_5 {
            get => GetData<ushort>(19);
            set {
                if (GetData<ushort>(19) == value) return;
                SetData(19, value);
                OnPropertyChanged(nameof(Param_5));
            }
        }

        public const string Param_6_displayName = "Param 6";
        public const int Param_6_sortIndex = 400;
        [SortOrder(Param_6_sortIndex)]
        [DisplayName(Param_6_displayName)]
        public ushort Param_6 {
            get => GetData<ushort>(21);
            set {
                if (GetData<ushort>(21) == value) return;
                SetData(21, value);
                OnPropertyChanged(nameof(Param_6));
            }
        }

        public const string Param_7_displayName = "Param 7";
        public const int Param_7_sortIndex = 450;
        [SortOrder(Param_7_sortIndex)]
        [DisplayName(Param_7_displayName)]
        public ushort Param_7 {
            get => GetData<ushort>(23);
            set {
                if (GetData<ushort>(23) == value) return;
                SetData(23, value);
                OnPropertyChanged(nameof(Param_7));
            }
        }

        public const string Param_8_displayName = "Param 8";
        public const int Param_8_sortIndex = 500;
        [SortOrder(Param_8_sortIndex)]
        [DisplayName(Param_8_displayName)]
        public ushort Param_8 {
            get => GetData<ushort>(25);
            set {
                if (GetData<ushort>(25) == value) return;
                SetData(25, value);
                OnPropertyChanged(nameof(Param_8));
            }
        }
    }
}