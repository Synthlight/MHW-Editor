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

        public const string Unknown_uint8_1_displayName = "Unknown (uint8) 1";
        public const int Unknown_uint8_1_sortIndex = 50;
        [SortOrder(Unknown_uint8_1_sortIndex)]
        [DisplayName(Unknown_uint8_1_displayName)]
        public virtual byte Unknown_uint8_1 {
            get => GetData<byte>(0);
            set {
                if (GetData<byte>(0) == value) return;
                SetData(0, value, nameof(Unknown_uint8_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_uint8_1));
            }
        }

        public const string Unknown_uint8_2_displayName = "Unknown (uint8) 2";
        public const int Unknown_uint8_2_sortIndex = 100;
        [SortOrder(Unknown_uint8_2_sortIndex)]
        [DisplayName(Unknown_uint8_2_displayName)]
        public virtual byte Unknown_uint8_2 {
            get => GetData<byte>(1);
            set {
                if (GetData<byte>(1) == value) return;
                SetData(1, value, nameof(Unknown_uint8_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_uint8_2));
            }
        }

        public const int lastSortIndex = 150;
    }
}