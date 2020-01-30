
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class SkillPointData {
        public const uint StructSize = 2;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Unknown (uint8) 1")]
        public byte Unknown_uint8_1 {
            get => GetData<byte>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Unknown_uint8_1));
            }
        }
        [DisplayName("Unknown (uint8) 2")]
        public byte Unknown_uint8_2 {
            get => GetData<byte>(1);
            set {
                SetData(1, value);
                OnPropertyChanged(nameof(Unknown_uint8_2));
            }
        }
    }
}