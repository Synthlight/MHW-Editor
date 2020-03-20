using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "45"
    // Initial Offset: "10"
    // Unique Id Formula: "{Index}"
    public struct AwakenedLimitBreak {
        public ushort Skill_Id; // Offset: 0
        public uint Group_Id; // Offset: 2
        public uint Rarity_Tier; // Offset: 6
        public byte Has_Upgrade; // Offset: 10
        public ushort Previous_Upgrade_Id_When_Max_Lvl; // Offset: 11
        public ushort Next_Upgrade_Id; // Offset: 13
        public byte Unk7; // Offset: 15
        public byte Unk8; // Offset: 16
        public ushort Lvl_1_Id; // Offset: 17
        public ushort Lvl_2_Id; // Offset: 19
        public ushort Lvl_3_Id; // Offset: 21
        public ushort Lvl_4_Id; // Offset: 23
        public ushort Lvl_5_Id; // Offset: 25
        public byte Works_on_Great_Sword; // Offset: 27
        public byte Works_on_Sword_Shield; // Offset: 28
        public byte Works_on_Dual_Blades; // Offset: 29
        public byte Works_on_Long_Sword; // Offset: 30
        public byte Works_on_Hammer; // Offset: 31
        public byte Works_on_Hunting_Horn; // Offset: 32
        public byte Works_on_Lance; // Offset: 33
        public byte Works_on_Gunlance; // Offset: 34
        public byte Works_on_Switch_Axe; // Offset: 35
        public byte Works_on_Charge_Blade; // Offset: 36
        public byte Works_on_Insect_Glaive; // Offset: 37
        public byte Works_on_Bow; // Offset: 38
        public byte Works_on_HBG; // Offset: 39
        public byte Works_on_LBG; // Offset: 40
        public byte Unk28; // Offset: 44
    }
}