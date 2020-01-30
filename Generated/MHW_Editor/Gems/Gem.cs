
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Index")]
        private ushort Index {
            get => GetData<ushort>(4);
        }
        [DisplayName("Id")]
        public ushort Id {
            get => GetData<ushort>(0);
        }
        [DisplayName("Size")]
        public byte Size {
            get => GetData<byte>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Size));
            }
        }
        [DisplayName("Skill 1")]
        public ushort Skill_1 {
            get => GetData<ushort>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Skill_1));
            }
        }
        [DisplayName("Skill 1 Level")]
        public byte Skill_1_Level {
            get => GetData<byte>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Skill_1_Level));
            }
        }
        [DisplayName("Skill 2")]
        public ushort Skill_2 {
            get => GetData<ushort>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Skill_2));
            }
        }
        [DisplayName("Skill 2 Level")]
        public byte Skill_2_Level {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Skill_2_Level));
            }
        }
    }
}