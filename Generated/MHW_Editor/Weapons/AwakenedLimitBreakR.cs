using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class AwakenedLimitBreakR {
        public const uint StructSize = 34;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 50;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual ushort Unk1 {
            get => GetData<ushort>(0);
            set {
                if (GetData<ushort>(0) == value) return;
                SetData(0, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 100;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual ushort Unk2 {
            get => GetData<ushort>(2);
            set {
                if (GetData<ushort>(2) == value) return;
                SetData(2, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 150;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual ushort Unk3 {
            get => GetData<ushort>(8);
            set {
                if (GetData<ushort>(8) == value) return;
                SetData(8, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 200;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual ushort Unk4 {
            get => GetData<ushort>(10);
            set {
                if (GetData<ushort>(10) == value) return;
                SetData(10, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 250;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual ushort Unk5 {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 300;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual ushort Unk6 {
            get => GetData<ushort>(14);
            set {
                if (GetData<ushort>(14) == value) return;
                SetData(14, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 350;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual ushort Unk7 {
            get => GetData<ushort>(16);
            set {
                if (GetData<ushort>(16) == value) return;
                SetData(16, value, nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 400;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual ushort Unk8 {
            get => GetData<ushort>(18);
            set {
                if (GetData<ushort>(18) == value) return;
                SetData(18, value, nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 450;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual ushort Unk9 {
            get => GetData<ushort>(20);
            set {
                if (GetData<ushort>(20) == value) return;
                SetData(20, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 500;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual ushort Unk10 {
            get => GetData<ushort>(22);
            set {
                if (GetData<ushort>(22) == value) return;
                SetData(22, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 550;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual ushort Unk11 {
            get => GetData<ushort>(24);
            set {
                if (GetData<ushort>(24) == value) return;
                SetData(24, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 600;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual ushort Unk12 {
            get => GetData<ushort>(28);
            set {
                if (GetData<ushort>(28) == value) return;
                SetData(28, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 650;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual byte Unk13 {
            get => GetData<byte>(33);
            set {
                if (GetData<byte>(33) == value) return;
                SetData(33, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const int lastSortIndex = 700;
    }
}