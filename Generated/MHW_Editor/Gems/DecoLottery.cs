using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Gems {
    public partial class DecoLottery {
        public const uint StructSize = 52;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Item_Id}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        public virtual uint Index {
            get => GetData<uint>(0);
        }

        public const string Item_Id_displayName = "Item Id";
        public const int Item_Id_sortIndex = 100;
        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        public virtual uint Item_Id {
            get => GetData<uint>(4);
        }

        public const string R5_displayName = "R5";
        public const int R5_sortIndex = 150;
        [SortOrder(R5_sortIndex)]
        [DisplayName(R5_displayName)]
        public virtual uint R5 {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(R5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R5));
            }
        }

        public const string R6_displayName = "R6";
        public const int R6_sortIndex = 200;
        [SortOrder(R6_sortIndex)]
        [DisplayName(R6_displayName)]
        public virtual uint R6 {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(R6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R6));
            }
        }

        public const string R7_displayName = "R7";
        public const int R7_sortIndex = 250;
        [SortOrder(R7_sortIndex)]
        [DisplayName(R7_displayName)]
        public virtual uint R7 {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(R7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R7));
            }
        }

        public const string R8_displayName = "R8";
        public const int R8_sortIndex = 300;
        [SortOrder(R8_sortIndex)]
        [DisplayName(R8_displayName)]
        public virtual uint R8 {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(R8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R8));
            }
        }

        public const string R9_displayName = "R9";
        public const int R9_sortIndex = 350;
        [SortOrder(R9_sortIndex)]
        [DisplayName(R9_displayName)]
        public virtual uint R9 {
            get => GetData<uint>(32);
            set {
                if (GetData<uint>(32) == value) return;
                SetData(32, value, nameof(R9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R9));
            }
        }

        public const string R10_displayName = "R10";
        public const int R10_sortIndex = 400;
        [SortOrder(R10_sortIndex)]
        [DisplayName(R10_displayName)]
        public virtual uint R10 {
            get => GetData<uint>(36);
            set {
                if (GetData<uint>(36) == value) return;
                SetData(36, value, nameof(R10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R10));
            }
        }

        public const string R11_displayName = "R11";
        public const int R11_sortIndex = 450;
        [SortOrder(R11_sortIndex)]
        [DisplayName(R11_displayName)]
        public virtual uint R11 {
            get => GetData<uint>(40);
            set {
                if (GetData<uint>(40) == value) return;
                SetData(40, value, nameof(R11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R11));
            }
        }

        public const string R12_displayName = "R12";
        public const int R12_sortIndex = 500;
        [SortOrder(R12_sortIndex)]
        [DisplayName(R12_displayName)]
        public virtual uint R12 {
            get => GetData<uint>(44);
            set {
                if (GetData<uint>(44) == value) return;
                SetData(44, value, nameof(R12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R12));
            }
        }

        public const string R13_displayName = "R13";
        public const int R13_sortIndex = 550;
        [SortOrder(R13_sortIndex)]
        [DisplayName(R13_displayName)]
        public virtual uint R13 {
            get => GetData<uint>(48);
            set {
                if (GetData<uint>(48) == value) return;
                SetData(48, value, nameof(R13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(R13));
            }
        }

        public const string Stream_R6__displayName = "Stream (R6)";
        public const int Stream_R6__sortIndex = 600;
        [SortOrder(Stream_R6__sortIndex)]
        [DisplayName(Stream_R6__displayName)]
        public virtual uint Stream_R6_ {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(Stream_R6_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stream_R6_));
            }
        }

        public const string Stream_R8__displayName = "Stream (R8)";
        public const int Stream_R8__sortIndex = 650;
        [SortOrder(Stream_R8__sortIndex)]
        [DisplayName(Stream_R8__displayName)]
        public virtual uint Stream_R8_ {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Stream_R8_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stream_R8_));
            }
        }

        public const int lastSortIndex = 700;
    }
}