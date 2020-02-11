using MHW_Template;

namespace MHW_Editor.Armors {
    // Unique Id Formula: "{Mantle_Id}"
    public struct ASkill {
        public uint Icon_Id; // Offset: 0
        public uint Color; // Offset: 4
        public uint Sort_Order; // Offset: 8
        public uint Mantle_Item_Id; // Offset: 12
        public uint Mantle_Id; // Offset: 16
        public uint Unlock_Flag_or_Item_Id_; // Offset: 20
        public byte Deco_Count; // Offset: 24
        public byte Deco_Lvl_1; // Offset: 25
        public byte Deco_Lvl_2; // Offset: 26
        public byte Deco_Lvl_3; // Offset: 27
    }
}