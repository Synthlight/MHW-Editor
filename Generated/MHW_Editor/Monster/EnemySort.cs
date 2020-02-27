using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Monster {
    public partial class EnemySort {
        public const uint StructSize = 56;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 50;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual int Unk1 {
            get => GetData<int>(0);
            set {
                if (GetData<int>(0) == value) return;
                SetData(0, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 100;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual uint Unk2 {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 150;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual uint Unk3 {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 200;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual uint Unk4 {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 250;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual uint Unk5 {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 300;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual uint Unk6 {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 350;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual uint Unk7 {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 400;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual uint Unk8 {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 450;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual uint Unk9 {
            get => GetData<uint>(32);
            set {
                if (GetData<uint>(32) == value) return;
                SetData(32, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 500;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual uint Unk10 {
            get => GetData<uint>(36);
            set {
                if (GetData<uint>(36) == value) return;
                SetData(36, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 550;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual uint Unk11 {
            get => GetData<uint>(40);
            set {
                if (GetData<uint>(40) == value) return;
                SetData(40, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 600;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual uint Unk12 {
            get => GetData<uint>(44);
            set {
                if (GetData<uint>(44) == value) return;
                SetData(44, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 650;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual uint Unk13 {
            get => GetData<uint>(48);
            set {
                if (GetData<uint>(48) == value) return;
                SetData(48, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 700;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual uint Unk14 {
            get => GetData<uint>(52);
            set {
                if (GetData<uint>(52) == value) return;
                SetData(52, value, nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const int lastSortIndex = 750;
    }
}