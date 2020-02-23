using MHW_Template;

namespace MHW_Editor.Armors {
    // Struct Size: "60"
    // Unique Id Formula: "{Set_Group}|{Variant}|{Type}|{Equip_Slot}"
    public struct Armor {
        public uint Index; // Offset: 0
        public ushort Order; // Offset: 4
        public byte Variant; // Offset: 6
        public ushort Set_Layered_Id; // Offset: 7
        public byte Type; // Offset: 9
        public byte Equip_Slot; // Offset: 10
        public ushort Defense; // Offset: 11
        public ushort Model_Id_1; // Offset: 13
        public ushort Model_Id_2; // Offset: 15
        public ushort Icon_Color; // Offset: 17
        public byte Icon_Effect; // Offset: 19
        public byte Rarity; // Offset: 20
        public uint Cost; // Offset: 21
        public sbyte Fire_Res; // Offset: 25
        public sbyte Water_Res; // Offset: 26
        public sbyte Ice_Res; // Offset: 27
        public sbyte Thunder_Res; // Offset: 28
        public sbyte Dragon_Res; // Offset: 29
        public byte Slot_Count; // Offset: 30
        public byte Slot_1_Size; // Offset: 31
        public byte Slot_2_Size; // Offset: 32
        public byte Slot_3_Size; // Offset: 33
        public ushort Set_Skill_1; // Offset: 34
        public byte Set_Skill_1_Level; // Offset: 36
        public ushort Set_Skill_2; // Offset: 37
        public byte Set_Skill_2_Level; // Offset: 39
        public ushort Skill_1; // Offset: 40
        public byte Skill_1_Level; // Offset: 42
        public ushort Skill_2; // Offset: 43
        public byte Skill_2_Level; // Offset: 45
        public ushort Skill_3; // Offset: 46
        public byte Skill_3_Level; // Offset: 48
        public uint Gender; // Offset: 49
        public ushort Set_Group; // Offset: 53
        public ushort GMD_Name_Index; // Offset: 55
        public ushort GMD_Description_Index; // Offset: 57
        public byte Is_Permanent_Raw; // Offset: 59
    }
}