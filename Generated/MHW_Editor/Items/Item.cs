


namespace MHW_Editor.Items {
    public partial class Item {
        public const ushort StructSize = 32;
        public const ushort InitialOffset = 10;
        public uint Id {
            get => GetData<uint>(0);
            set => SetData(0, value);
        }
        public MHW_Template.Items.ItemSubType Sub_Type {
            get => (MHW_Template.Items.ItemSubType) GetData<byte>(4);
            set => SetData(4, (byte) value);
        }
        public MHW_Template.Items.ItemType Type {
            get => (MHW_Template.Items.ItemType) GetData<uint>(5);
            set => SetData(5, (uint) value);
        }
        public byte Rarity {
            get => GetData<byte>(9);
            set => SetData(9, value);
        }
        public byte Carry_Limit {
            get => GetData<byte>(10);
            set => SetData(10, value);
        }
        public byte Unknown_1 {
            get => GetData<byte>(11);
            set => SetData(11, value);
        }
        public ushort Sort_Order {
            get => GetData<ushort>(12);
            set => SetData(12, value);
        }
        public uint Unknown_2 {
            get => GetData<uint>(14);
            set => SetData(14, value);
        }
        public uint Icon_Id {
            get => GetData<uint>(18);
            set => SetData(18, value);
        }
        public ushort Icon_Color_Id {
            get => GetData<ushort>(22);
            set => SetData(22, value);
        }
        public uint Sell_Price {
            get => GetData<uint>(24);
            set => SetData(24, value);
        }
        public uint Buy_Price {
            get => GetData<uint>(28);
            set => SetData(28, value);
        }
    }
}