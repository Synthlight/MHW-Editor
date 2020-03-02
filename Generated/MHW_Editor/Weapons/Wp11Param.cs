using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp11Param {
        public const uint StructSize = 2736;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";
        public override string UniqueId => $"0";

        public const string Dragonpiercer_X1_displayName = "Dragonpiercer X1";
        public const int Dragonpiercer_X1_sortIndex = 50;
        [SortOrder(Dragonpiercer_X1_sortIndex)]
        [DisplayName(Dragonpiercer_X1_displayName)]
        public virtual float Dragonpiercer_X1 {
            get => GetData<float>(1313);
            set {
                if (GetData<float>(1313) == value) return;
                SetData(1313, value, nameof(Dragonpiercer_X1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragonpiercer_X1));
            }
        }

        public const string Dragonpiercer_Y1_displayName = "Dragonpiercer Y1";
        public const int Dragonpiercer_Y1_sortIndex = 100;
        [SortOrder(Dragonpiercer_Y1_sortIndex)]
        [DisplayName(Dragonpiercer_Y1_displayName)]
        public virtual float Dragonpiercer_Y1 {
            get => GetData<float>(1317);
            set {
                if (GetData<float>(1317) == value) return;
                SetData(1317, value, nameof(Dragonpiercer_Y1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragonpiercer_Y1));
            }
        }

        public const string Dragonpiercer_X2_displayName = "Dragonpiercer X2";
        public const int Dragonpiercer_X2_sortIndex = 150;
        [SortOrder(Dragonpiercer_X2_sortIndex)]
        [DisplayName(Dragonpiercer_X2_displayName)]
        public virtual float Dragonpiercer_X2 {
            get => GetData<float>(1321);
            set {
                if (GetData<float>(1321) == value) return;
                SetData(1321, value, nameof(Dragonpiercer_X2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragonpiercer_X2));
            }
        }

        public const string Dragonpiercer_Y2_displayName = "Dragonpiercer Y2";
        public const int Dragonpiercer_Y2_sortIndex = 200;
        [SortOrder(Dragonpiercer_Y2_sortIndex)]
        [DisplayName(Dragonpiercer_Y2_displayName)]
        public virtual float Dragonpiercer_Y2 {
            get => GetData<float>(1325);
            set {
                if (GetData<float>(1325) == value) return;
                SetData(1325, value, nameof(Dragonpiercer_Y2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragonpiercer_Y2));
            }
        }

        public const string __250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __250_sortIndex = 250;
        [SortOrder(__250_sortIndex)]
        [DisplayName(__250_displayName)]
        [IsReadOnly]
        public virtual byte __250 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__250));
            }
        }

        public const string Thousand_Dragons_X1_displayName = "Thousand Dragons X1";
        public const int Thousand_Dragons_X1_sortIndex = 300;
        [SortOrder(Thousand_Dragons_X1_sortIndex)]
        [DisplayName(Thousand_Dragons_X1_displayName)]
        public virtual float Thousand_Dragons_X1 {
            get => GetData<float>(2569);
            set {
                if (GetData<float>(2569) == value) return;
                SetData(2569, value, nameof(Thousand_Dragons_X1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thousand_Dragons_X1));
            }
        }

        public const string Thousand_Dragons_Y1_displayName = "Thousand Dragons Y1";
        public const int Thousand_Dragons_Y1_sortIndex = 350;
        [SortOrder(Thousand_Dragons_Y1_sortIndex)]
        [DisplayName(Thousand_Dragons_Y1_displayName)]
        public virtual float Thousand_Dragons_Y1 {
            get => GetData<float>(2573);
            set {
                if (GetData<float>(2573) == value) return;
                SetData(2573, value, nameof(Thousand_Dragons_Y1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thousand_Dragons_Y1));
            }
        }

        public const string Thousand_Dragons_X2_displayName = "Thousand Dragons X2";
        public const int Thousand_Dragons_X2_sortIndex = 400;
        [SortOrder(Thousand_Dragons_X2_sortIndex)]
        [DisplayName(Thousand_Dragons_X2_displayName)]
        public virtual float Thousand_Dragons_X2 {
            get => GetData<float>(2577);
            set {
                if (GetData<float>(2577) == value) return;
                SetData(2577, value, nameof(Thousand_Dragons_X2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thousand_Dragons_X2));
            }
        }

        public const string Thousand_Dragons_Y2_displayName = "Thousand Dragons Y2";
        public const int Thousand_Dragons_Y2_sortIndex = 450;
        [SortOrder(Thousand_Dragons_Y2_sortIndex)]
        [DisplayName(Thousand_Dragons_Y2_displayName)]
        public virtual float Thousand_Dragons_Y2 {
            get => GetData<float>(2581);
            set {
                if (GetData<float>(2581) == value) return;
                SetData(2581, value, nameof(Thousand_Dragons_Y2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thousand_Dragons_Y2));
            }
        }

        public const int lastSortIndex = 500;
    }
}