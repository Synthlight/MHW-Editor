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

        public const string Red_Extract_Duration_displayName = "Red Extract Duration";
        public const int Red_Extract_Duration_sortIndex = 50;
        [SortOrder(Red_Extract_Duration_sortIndex)]
        [DisplayName(Red_Extract_Duration_displayName)]
        public virtual float Red_Extract_Duration {
            get => GetData<float>(1153);
            set {
                if (GetData<float>(1153) == value) return;
                SetData(1153, value, nameof(Red_Extract_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Red_Extract_Duration));
            }
        }

        public const string White_Extract_Duration_displayName = "White Extract Duration";
        public const int White_Extract_Duration_sortIndex = 100;
        [SortOrder(White_Extract_Duration_sortIndex)]
        [DisplayName(White_Extract_Duration_displayName)]
        public virtual float White_Extract_Duration {
            get => GetData<float>(1157);
            set {
                if (GetData<float>(1157) == value) return;
                SetData(1157, value, nameof(White_Extract_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(White_Extract_Duration));
            }
        }

        public const string Orange_Extract_Duration_displayName = "Orange Extract Duration";
        public const int Orange_Extract_Duration_sortIndex = 150;
        [SortOrder(Orange_Extract_Duration_sortIndex)]
        [DisplayName(Orange_Extract_Duration_displayName)]
        public virtual float Orange_Extract_Duration {
            get => GetData<float>(1161);
            set {
                if (GetData<float>(1161) == value) return;
                SetData(1161, value, nameof(Orange_Extract_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Orange_Extract_Duration));
            }
        }

        public const string Triple_Extract_Duration_displayName = "Triple Extract Duration";
        public const int Triple_Extract_Duration_sortIndex = 200;
        [SortOrder(Triple_Extract_Duration_sortIndex)]
        [DisplayName(Triple_Extract_Duration_displayName)]
        public virtual float Triple_Extract_Duration {
            get => GetData<float>(1165);
            set {
                if (GetData<float>(1165) == value) return;
                SetData(1165, value, nameof(Triple_Extract_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Triple_Extract_Duration));
            }
        }

        public const int lastSortIndex = 250;
    }
}