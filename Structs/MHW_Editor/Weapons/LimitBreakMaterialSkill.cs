using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "10"
    // Unique Id Formula: "{Index}"
    public struct LimitBreakMaterialSkill {
        public byte Rarity; // Offset: 0
        public byte Augment_Type; // Offset: 1
        public ushort Item_1_Id; // Offset: 2
        public ushort Item_1_Cnt; // Offset: 4
        public uint Unk; // Offset: 6
    }
}