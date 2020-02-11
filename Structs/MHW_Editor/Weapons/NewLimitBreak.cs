using MHW_Template;

namespace MHW_Editor.Weapons {
    // Unique Id Formula: "{Aug_Category}|{Aug_Level}"
    public struct NewLimitBreak {
        public uint Aug_Category; // Offset: 0
        public uint Aug_Level; // Offset: 4
        public uint Aug_Slot_Cost; // Offset: 8
        public uint Research_Cost_r10_; // Offset: 12
        public uint Research_Cost_r11_; // Offset: 16
        public uint Research_Cost_r12_; // Offset: 20
    }
}