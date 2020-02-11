using MHW_Template;

namespace MHW_Editor.Weapons {
    // Unique Id Formula: "{Id}"
    public struct WeaponWhistle {
        public uint Id; // Offset: 0
        public byte Note_1; // Offset: 4
        public byte Note_2; // Offset: 4
        public byte Note_3; // Offset: 4
    }
}