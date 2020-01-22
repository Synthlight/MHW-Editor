


namespace MHW_Editor.Items {
    public partial class BottleTable {
        public const ushort StructSize = 6;
        public const ushort InitialOffset = 10;
        public byte Close_Range {
            get => GetData<byte>(0);
            set => SetData(0, value);
        }
        public byte Power {
            get => GetData<byte>(1);
            set => SetData(1, value);
        }
        public byte Paralysis {
            get => GetData<byte>(2);
            set => SetData(2, value);
        }
        public byte Poison {
            get => GetData<byte>(3);
            set => SetData(3, value);
        }
        public byte Sleep {
            get => GetData<byte>(4);
            set => SetData(4, value);
        }
        public byte Blast {
            get => GetData<byte>(5);
            set => SetData(5, value);
        }
    }
}