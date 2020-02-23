using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "28"
    // Unique Id Formula: "{Id}"
    public struct RodInsect {
        public uint Index; // Offset: 0
        public byte Attack_Type; // Offset: 4
        public byte Id; // Offset: 5
        public byte Tree_Position_Id; // Offset: 6
        public ushort Base_Model_Id; // Offset: 7
        public byte Tree_Id; // Offset: 9
        public uint Craft_Cost; // Offset: 10
        public byte Rarity; // Offset: 14
        public ushort Power; // Offset: 15
        public ushort Speed; // Offset: 17
        public ushort Heal; // Offset: 19
        public ushort Element; // Offset: 21
        public ushort Dust_Effect; // Offset: 23
        public byte Tree_Pos; // Offset: 25
        public ushort Equip_Id; // Offset: 26
    }
}