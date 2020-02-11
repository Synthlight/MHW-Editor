using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Skills {
    public partial class SkillPointData {
        public const uint StructSize = 2;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Is_Set_Bonus_Raw_displayName = "Is Set Bonus Raw";
        public const int Is_Set_Bonus_Raw_sortIndex = 50;
        [SortOrder(Is_Set_Bonus_Raw_sortIndex)]
        [DisplayName(Is_Set_Bonus_Raw_displayName)]
        private byte Is_Set_Bonus_Raw {
            get => GetData<byte>(0);
            set {
                if (GetData<byte>(0) == value) return;
                SetData(0, value, nameof(Is_Set_Bonus_Raw));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Is_Set_Bonus_Raw));
                OnPropertyChanged(nameof(Is_Set_Bonus));
            }
        }

        public const string Icon_Color_Id_displayName = "Icon Color Id";
        public const int Icon_Color_Id_sortIndex = 100;
        [SortOrder(Icon_Color_Id_sortIndex)]
        [DisplayName(Icon_Color_Id_displayName)]
        public virtual byte Icon_Color_Id {
            get => GetData<byte>(1);
            set {
                if (GetData<byte>(1) == value) return;
                SetData(1, value, nameof(Icon_Color_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Icon_Color_Id));
            }
        }

        public const int lastSortIndex = 150;
    }
}