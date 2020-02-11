using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class NewLimitBreak {
        public const uint StructSize = 24;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Aug_Category_displayName = "Aug Category";
        public const int Aug_Category_sortIndex = 50;
        [SortOrder(Aug_Category_sortIndex)]
        [DisplayName(Aug_Category_displayName)]
        public virtual MHW_Template.Weapons.AugmentationCategory Aug_Category {
            get => (MHW_Template.Weapons.AugmentationCategory) GetData<uint>(0);
        }

        public const string Aug_Level_displayName = "Aug Level";
        public const int Aug_Level_sortIndex = 100;
        [SortOrder(Aug_Level_sortIndex)]
        [DisplayName(Aug_Level_displayName)]
        public virtual uint Aug_Level {
            get => GetData<uint>(4);
        }

        public const string Aug_Slot_Cost_displayName = "Aug Slot Cost";
        public const int Aug_Slot_Cost_sortIndex = 150;
        [SortOrder(Aug_Slot_Cost_sortIndex)]
        [DisplayName(Aug_Slot_Cost_displayName)]
        public virtual uint Aug_Slot_Cost {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Aug_Slot_Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Aug_Slot_Cost));
            }
        }

        public const string Research_Cost_r10__displayName = "Research Cost (r10)";
        public const int Research_Cost_r10__sortIndex = 200;
        [SortOrder(Research_Cost_r10__sortIndex)]
        [DisplayName(Research_Cost_r10__displayName)]
        public virtual uint Research_Cost_r10_ {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Research_Cost_r10_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Research_Cost_r10_));
            }
        }

        public const string Research_Cost_r11__displayName = "Research Cost (r11)";
        public const int Research_Cost_r11__sortIndex = 250;
        [SortOrder(Research_Cost_r11__sortIndex)]
        [DisplayName(Research_Cost_r11__displayName)]
        public virtual uint Research_Cost_r11_ {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Research_Cost_r11_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Research_Cost_r11_));
            }
        }

        public const string Research_Cost_r12__displayName = "Research Cost (r12)";
        public const int Research_Cost_r12__sortIndex = 300;
        [SortOrder(Research_Cost_r12__sortIndex)]
        [DisplayName(Research_Cost_r12__displayName)]
        public virtual uint Research_Cost_r12_ {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Research_Cost_r12_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Research_Cost_r12_));
            }
        }

        public const int lastSortIndex = 350;
    }
}