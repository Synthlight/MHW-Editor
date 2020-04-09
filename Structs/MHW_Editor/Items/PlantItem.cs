using MHW_Template;

namespace MHW_Editor.Items {
    // Struct Size: "37"
    // Initial Offset: "10"
    // Unique Id Formula: "{Item}"
    public struct PlantItem {
        public uint Cultivation_category; // Offset: 0
        public byte Unlocked_from_start; // Offset: 8
        public ushort Item; // Offset: 9
        public uint Required_time; // Offset: 13
        public uint Catalyst_time_bonus; // Offset: 17
        public uint Amount_Base_; // Offset: 25
        public uint Amount_1_; // Offset: 29
        public uint Amount_2_; // Offset: 33
        public uint Unknown_int32_1; // Offset: 4
    }
}