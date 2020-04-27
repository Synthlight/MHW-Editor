using MHW_Template;

namespace MHW_Editor.GuildCard {
    // Struct Size: "20"
    // Initial Offset: "10"
    // Unique Id Formula: "{Index}"
    public struct GcData {
        public uint Id; // Offset: 0
        public int Unlock_Type; // Offset: 4
        public uint Unlock_Param; // Offset: 8
        public uint Monster_Id; // Offset: 12
        public uint Unk; // Offset: 16
    }
}