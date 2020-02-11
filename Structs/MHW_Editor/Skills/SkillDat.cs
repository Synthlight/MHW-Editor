using MHW_Template;

namespace MHW_Editor.Skills {
    // Unique Id Formula: "{Id}|{Level}"
    public struct SkillDat {
        public ushort Id; // Offset: 0
        public byte Level; // Offset: 2
        public uint Unlock_Skill_1; // Offset: 3
        public uint Unlock_Skill_2; // Offset: 7
        public uint Unlock_Skill_3; // Offset: 11
        public uint Unlock_Skill_4; // Offset: 15
        public ushort Param_5; // Offset: 19
        public ushort Param_6; // Offset: 21
        public ushort Param_7; // Offset: 23
        public ushort Param_8; // Offset: 25
    }
}