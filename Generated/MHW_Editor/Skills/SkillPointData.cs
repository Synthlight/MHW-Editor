using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class SkillPointData {
        public const uint StructSize = 2;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public byte Unk_1 {
            get => GetData<byte>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Unk_1));
            }
        }
        public byte Unk_2 {
            get => GetData<byte>(1);
            set {
                SetData(1, value);
                OnPropertyChanged(nameof(Unk_2));
            }
        }
    }
}