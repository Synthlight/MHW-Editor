using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        private ushort Index {
            get => GetData<ushort>(4);
        }
        public ushort Id {
            get => GetData<ushort>(0);
        }
        public byte Size {
            get => GetData<byte>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Size));
            }
        }
        public ushort Skill_1 {
            get => GetData<ushort>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Skill_1));
            }
        }
        public byte Skill_1_Level {
            get => GetData<byte>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Skill_1_Level));
            }
        }
        public ushort Skill_2 {
            get => GetData<ushort>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Skill_2));
            }
        }
        public byte Skill_2_Level {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Skill_2_Level));
            }
        }
    }
}