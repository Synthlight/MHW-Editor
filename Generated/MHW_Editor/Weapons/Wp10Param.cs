using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp10Param {
        public const uint StructSize = 3408;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";
        public override string UniqueId => $"0";

        public const string Air_Time_1_displayName = "Air-Time 1";
        public const int Air_Time_1_sortIndex = 50;
        [SortOrder(Air_Time_1_sortIndex)]
        [DisplayName(Air_Time_1_displayName)]
        public virtual float Air_Time_1 {
            get => GetData<float>(1153);
            set {
                if (GetData<float>(1153) == value) return;
                SetData(1153, value, nameof(Air_Time_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Air_Time_1));
            }
        }

        public const string Air_Time_2_displayName = "Air-Time 2";
        public const int Air_Time_2_sortIndex = 100;
        [SortOrder(Air_Time_2_sortIndex)]
        [DisplayName(Air_Time_2_displayName)]
        public virtual float Air_Time_2 {
            get => GetData<float>(1157);
            set {
                if (GetData<float>(1157) == value) return;
                SetData(1157, value, nameof(Air_Time_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Air_Time_2));
            }
        }

        public const string Air_Time_3_displayName = "Air-Time 3";
        public const int Air_Time_3_sortIndex = 150;
        [SortOrder(Air_Time_3_sortIndex)]
        [DisplayName(Air_Time_3_displayName)]
        public virtual float Air_Time_3 {
            get => GetData<float>(1161);
            set {
                if (GetData<float>(1161) == value) return;
                SetData(1161, value, nameof(Air_Time_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Air_Time_3));
            }
        }

        public const string Air_Time_4_displayName = "Air-Time 4";
        public const int Air_Time_4_sortIndex = 200;
        [SortOrder(Air_Time_4_sortIndex)]
        [DisplayName(Air_Time_4_displayName)]
        public virtual float Air_Time_4 {
            get => GetData<float>(1165);
            set {
                if (GetData<float>(1165) == value) return;
                SetData(1165, value, nameof(Air_Time_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Air_Time_4));
            }
        }

        public const int lastSortIndex = 250;
    }
}