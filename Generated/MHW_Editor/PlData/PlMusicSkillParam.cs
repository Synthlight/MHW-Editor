using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.PlData {
    public partial class PlMusicSkillParam {
        public const uint StructSize = 56;
        public const ulong InitialOffset = 14;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = "qm7psvaMXQoay7kARXpNPcLNWqsbqcOyI4lqHtxFh26HSuE6RHNq7J4e";
        public override string UniqueId => $"{Index}";

        public const string Duration_displayName = "Duration";
        public const int Duration_sortIndex = 50;
        [SortOrder(Duration_sortIndex)]
        [DisplayName(Duration_displayName)]
        public virtual float Duration {
            get => GetData<float>(0);
            set {
                if (GetData<float>(0) == value) return;
                SetData(0, value, nameof(Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Duration));
            }
        }

        public const string Extension_displayName = "Extension";
        public const int Extension_sortIndex = 100;
        [SortOrder(Extension_sortIndex)]
        [DisplayName(Extension_displayName)]
        public virtual float Extension {
            get => GetData<float>(12);
            set {
                if (GetData<float>(12) == value) return;
                SetData(12, value, nameof(Extension));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Extension));
            }
        }

        public const string M1_Duration_displayName = "M1 Duration";
        public const int M1_Duration_sortIndex = 150;
        [SortOrder(M1_Duration_sortIndex)]
        [DisplayName(M1_Duration_displayName)]
        public virtual float M1_Duration {
            get => GetData<float>(4);
            set {
                if (GetData<float>(4) == value) return;
                SetData(4, value, nameof(M1_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(M1_Duration));
            }
        }

        public const string M1_Extension_displayName = "M1 Extension";
        public const int M1_Extension_sortIndex = 200;
        [SortOrder(M1_Extension_sortIndex)]
        [DisplayName(M1_Extension_displayName)]
        public virtual float M1_Extension {
            get => GetData<float>(16);
            set {
                if (GetData<float>(16) == value) return;
                SetData(16, value, nameof(M1_Extension));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(M1_Extension));
            }
        }

        public const string M2_Duration_displayName = "M2 Duration";
        public const int M2_Duration_sortIndex = 250;
        [SortOrder(M2_Duration_sortIndex)]
        [DisplayName(M2_Duration_displayName)]
        public virtual float M2_Duration {
            get => GetData<float>(8);
            set {
                if (GetData<float>(8) == value) return;
                SetData(8, value, nameof(M2_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(M2_Duration));
            }
        }

        public const string M2_Extension_displayName = "M2 Extension";
        public const int M2_Extension_sortIndex = 300;
        [SortOrder(M2_Extension_sortIndex)]
        [DisplayName(M2_Extension_displayName)]
        public virtual float M2_Extension {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(M2_Extension));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(M2_Extension));
            }
        }

        public const string Effect_displayName = "Effect";
        public const int Effect_sortIndex = 350;
        [SortOrder(Effect_sortIndex)]
        [DisplayName(Effect_displayName)]
        public virtual float Effect {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(Effect));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Effect));
            }
        }

        public const string Recast_Effect_displayName = "Recast Effect";
        public const int Recast_Effect_sortIndex = 400;
        [SortOrder(Recast_Effect_sortIndex)]
        [DisplayName(Recast_Effect_displayName)]
        public virtual float Recast_Effect {
            get => GetData<float>(28);
            set {
                if (GetData<float>(28) == value) return;
                SetData(28, value, nameof(Recast_Effect));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Recast_Effect));
            }
        }

        public const string Unk_1_displayName = "Unk 1";
        public const int Unk_1_sortIndex = 450;
        [SortOrder(Unk_1_sortIndex)]
        [DisplayName(Unk_1_displayName)]
        public virtual uint Unk_1 {
            get => GetData<uint>(32);
            set {
                if (GetData<uint>(32) == value) return;
                SetData(32, value, nameof(Unk_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_1));
            }
        }

        public const string Unk_2_displayName = "Unk 2";
        public const int Unk_2_sortIndex = 500;
        [SortOrder(Unk_2_sortIndex)]
        [DisplayName(Unk_2_displayName)]
        public virtual uint Unk_2 {
            get => GetData<uint>(36);
            set {
                if (GetData<uint>(36) == value) return;
                SetData(36, value, nameof(Unk_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_2));
            }
        }

        public const string Unk_3_displayName = "Unk 3";
        public const int Unk_3_sortIndex = 550;
        [SortOrder(Unk_3_sortIndex)]
        [DisplayName(Unk_3_displayName)]
        public virtual uint Unk_3 {
            get => GetData<uint>(40);
            set {
                if (GetData<uint>(40) == value) return;
                SetData(40, value, nameof(Unk_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_3));
            }
        }

        public const string Unk_4_displayName = "Unk 4";
        public const int Unk_4_sortIndex = 600;
        [SortOrder(Unk_4_sortIndex)]
        [DisplayName(Unk_4_displayName)]
        public virtual uint Unk_4 {
            get => GetData<uint>(44);
            set {
                if (GetData<uint>(44) == value) return;
                SetData(44, value, nameof(Unk_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_4));
            }
        }

        public const string Unk_5_displayName = "Unk 5";
        public const int Unk_5_sortIndex = 650;
        [SortOrder(Unk_5_sortIndex)]
        [DisplayName(Unk_5_displayName)]
        public virtual uint Unk_5 {
            get => GetData<uint>(48);
            set {
                if (GetData<uint>(48) == value) return;
                SetData(48, value, nameof(Unk_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_5));
            }
        }

        public const string Unk_6_displayName = "Unk 6";
        public const int Unk_6_sortIndex = 700;
        [SortOrder(Unk_6_sortIndex)]
        [DisplayName(Unk_6_displayName)]
        public virtual uint Unk_6 {
            get => GetData<uint>(52);
            set {
                if (GetData<uint>(52) == value) return;
                SetData(52, value, nameof(Unk_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_6));
            }
        }

        public const int lastSortIndex = 750;
    }
}