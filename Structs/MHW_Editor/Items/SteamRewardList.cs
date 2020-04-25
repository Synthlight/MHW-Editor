using MHW_Template;

namespace MHW_Editor.Items {
    // Struct Size: "24"
    // Initial Offset: "10"
    // Unique Id Formula: "{Index}"
    public struct SteamRewardList {
        public int Type; // Offset: 0
        public uint Item_Id; // Offset: 4
        public uint Quantity; // Offset: 8
        public ulong Chance_; // Offset: 12
        public uint Rarity; // Offset: 20
    }
}