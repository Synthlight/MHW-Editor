using MHW_Template;

namespace MHW_Editor.Items {
    // Unique Id Formula: "{Result_Item_Id}"
    public struct MelderItem {
        public uint Result_Item_Id; // Offset: 0
        public uint Research_Points; // Offset: 4
        public uint Melding_Points; // Offset: 8
        public uint Category; // Offset: 12
        public uint Unlock_Flag; // Offset: 16
        public byte Unknown_uint8_; // Offset: 20
    }
}