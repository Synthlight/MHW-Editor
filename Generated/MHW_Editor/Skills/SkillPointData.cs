
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Skills {
    public partial class SkillPointData {
        public const uint StructSize = 2;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Unknown_uint8_1_displayName = "Unknown (uint8) 1";
        protected const int Unknown_uint8_1_sortIndex = 50;
        [SortOrder(Unknown_uint8_1_sortIndex)]
        [DisplayName(Unknown_uint8_1_displayName)]
        public byte Unknown_uint8_1 {
            get => GetData<byte>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Unknown_uint8_1));
            }
        }
        protected const string Unknown_uint8_2_displayName = "Unknown (uint8) 2";
        protected const int Unknown_uint8_2_sortIndex = 100;
        [SortOrder(Unknown_uint8_2_sortIndex)]
        [DisplayName(Unknown_uint8_2_displayName)]
        public byte Unknown_uint8_2 {
            get => GetData<byte>(1);
            set {
                SetData(1, value);
                OnPropertyChanged(nameof(Unknown_uint8_2));
            }
        }
    }
}