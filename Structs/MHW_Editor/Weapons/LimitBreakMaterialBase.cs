using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "14"
    // Initial Offset: "10"
    // Unique Id Formula: "{Index}"
    public struct LimitBreakMaterialBase {
        public byte Rarity; // Offset: 0
        public byte Equip_Type; // Offset: 1
        public uint Cost; // Offset: 2
        public ushort Item_1_Id; // Offset: 6
        public ushort Item_1_Cnt; // Offset: 8
        public ushort Item_2_Id; // Offset: 10
        public ushort Item_2_Cnt; // Offset: 12
    }
}