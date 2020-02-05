
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Sharpness {
        public const uint StructSize = 18;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
        }

        protected const string Red_displayName = "Red";
        protected const int Red_sortIndex = 100;
        [SortOrder(Red_sortIndex)]
        [DisplayName(Red_displayName)]
        public ushort Red {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value.Clamp((ushort) 0, (ushort) 400)) return;
                SetData(4, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Red));
            }
        }

        protected const string Orange_displayName = "Orange";
        protected const int Orange_sortIndex = 150;
        [SortOrder(Orange_sortIndex)]
        [DisplayName(Orange_displayName)]
        public ushort Orange {
            get => GetData<ushort>(6);
            set {
                if (GetData<ushort>(6) == value.Clamp((ushort) 0, (ushort) 400)) return;
                SetData(6, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Orange));
            }
        }

        protected const string Yellow_displayName = "Yellow";
        protected const int Yellow_sortIndex = 200;
        [SortOrder(Yellow_sortIndex)]
        [DisplayName(Yellow_displayName)]
        public ushort Yellow {
            get => GetData<ushort>(8);
            set {
                if (GetData<ushort>(8) == value.Clamp((ushort) 0, (ushort) 400)) return;
                SetData(8, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Yellow));
            }
        }

        protected const string Green_displayName = "Green";
        protected const int Green_sortIndex = 250;
        [SortOrder(Green_sortIndex)]
        [DisplayName(Green_displayName)]
        public ushort Green {
            get => GetData<ushort>(10);
            set {
                if (GetData<ushort>(10) == value.Clamp((ushort) 0, (ushort) 400)) return;
                SetData(10, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Green));
            }
        }

        protected const string Blue_displayName = "Blue";
        protected const int Blue_sortIndex = 300;
        [SortOrder(Blue_sortIndex)]
        [DisplayName(Blue_displayName)]
        public ushort Blue {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value.Clamp((ushort) 0, (ushort) 400)) return;
                SetData(12, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Blue));
            }
        }

        protected const string White_displayName = "White";
        protected const int White_sortIndex = 350;
        [SortOrder(White_sortIndex)]
        [DisplayName(White_displayName)]
        public ushort White {
            get => GetData<ushort>(14);
            set {
                if (GetData<ushort>(14) == value.Clamp((ushort) 0, (ushort) 400)) return;
                SetData(14, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(White));
            }
        }

        protected const string Purple_displayName = "Purple";
        protected const int Purple_sortIndex = 400;
        [SortOrder(Purple_sortIndex)]
        [DisplayName(Purple_displayName)]
        public ushort Purple {
            get => GetData<ushort>(16);
            set {
                if (GetData<ushort>(16) == value.Clamp((ushort) 0, (ushort) 400)) return;
                SetData(16, value.Clamp((ushort) 0, (ushort) 400));
                OnPropertyChanged(nameof(Purple));
            }
        }
    }
}