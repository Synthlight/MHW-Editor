using MHW_Template;

namespace MHW_Editor.Weapons {
    // Unique Id Formula: "{Id}"
    public struct WeaponWSword {
        public uint Id; // Offset: 0
        public byte Element_1_Type; // Offset: 4
        public short Element_1_Dmg; // Offset: 5
        public byte Element_2_Type; // Offset: 7
        public short Element_2_Dmg; // Offset: 8
    }
}