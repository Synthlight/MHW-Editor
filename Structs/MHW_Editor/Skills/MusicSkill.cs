using MHW_Template;

namespace MHW_Editor.Skills {
    // Unique Id Formula: "{Song_Id_Raw}"
    public struct MusicSkill {
        public uint Song_Id_Raw; // Offset: 0
        public int Note_1; // Offset: 4
        public int Note_2; // Offset: 8
        public int Note_3; // Offset: 12
        public int Note_4; // Offset: 16
    }
}