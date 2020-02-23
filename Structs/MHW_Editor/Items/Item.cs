using MHW_Template;

namespace MHW_Editor.Items {
    // Struct Size: "32"
    // Unique Id Formula: "{Id}"
    public struct Item {
        public uint Id; // Offset: 0
        public byte Sub_Type; // Offset: 4
        public uint Type; // Offset: 5
        public byte Rarity; // Offset: 9
        public byte Carry_Limit; // Offset: 10
        public byte Unknown_uint8_; // Offset: 11
        public ushort Sort_Order; // Offset: 12
        public uint Flags_Raw; // Offset: 14
        public uint Icon_Id; // Offset: 18
        public ushort Icon_Color_Id; // Offset: 22
        public uint Sell_Price; // Offset: 24
        public uint Buy_Price; // Offset: 28
    }
}