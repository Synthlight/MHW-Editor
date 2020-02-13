using MHW_Template;

namespace MHW_Editor.Items {
    // Unique Id Formula: "{Id}"
    public struct ItemMake {
        public uint Id; // Offset: 0
        public ushort Unk1; // Offset: 4
        public uint Mat_1_Id; // Offset: 6
        public uint Mat_2_Id; // Offset: 10
        public uint Result_Id; // Offset: 14
        public uint Quantity; // Offset: 18
        public uint Unk2; // Offset: 22
        public uint Category; // Offset: 26
        public byte Can_Auto_Craft_Raw; // Offset: 30
    }
}