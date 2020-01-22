


namespace MHW_Editor.Gems {
    public partial class Gem {
        public const ushort StructSize = 28;
        public const ushort InitialOffset = 10;
        public ushort Index___ {
            get => GetData<ushort>(4);
        }
        public ushort Id {
            get => GetData<ushort>(0);
        }
        public byte Size {
            get => GetData<byte>(8);
            set => SetData(8, value);
        }
        public ushort Skill_1_Raw {
            get => GetData<ushort>(12);
            set => SetData(12, value);
        }
        public byte Skill_1_Level {
            get => GetData<byte>(16);
            set => SetData(16, value);
        }
        public ushort Skill_2_Raw {
            get => GetData<ushort>(20);
            set => SetData(20, value);
        }
        public byte Skill_2_Level {
            get => GetData<byte>(24);
            set => SetData(24, value);
        }
    }
}