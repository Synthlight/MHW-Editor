using MHW_Template;

namespace MHW_Editor.Weapons {
    // Unique Id Formula: "{Id}"
    public struct Melee {
        public uint Index; // Offset: 0
        public short Unk1; // Offset: 4
        public short Base_Model_Id; // Offset: 6
        public short Part_1_Id; // Offset: 8
        public short Part_2_Id; // Offset: 10
        public byte Unk2; // Offset: 13
        public byte Unk3; // Offset: 14
        public byte Is_Fixed_Upgrade_Raw; // Offset: 15
        public uint Cost; // Offset: 16
        public byte Rarity; // Offset: 20
        public byte Sharpness_kire_Id; // Offset: 21
        public byte Sharpness_Amount; // Offset: 22
        public ushort Damage; // Offset: 23
        public ushort Defense; // Offset: 25
        public sbyte Affinity; // Offset: 27
        public byte Element; // Offset: 28
        public ushort Element_Damage; // Offset: 29
        public byte Element_Hidden_; // Offset: 31
        public ushort Element_Hidden_Damage; // Offset: 32
        public byte Elderseal; // Offset: 34
        public byte Slot_Count; // Offset: 35
        public byte Slot_1_Size; // Offset: 36
        public byte Slot_2_Size; // Offset: 37
        public byte Slot_3_Size; // Offset: 38
        public ushort Special_Ability_1_ID; // Offset: 39
        public ushort Special_Ability_2_ID; // Offset: 41
        public byte Unk4; // Offset: 55
        public ushort Id; // Offset: 56
        public ushort GMD_Name_Index; // Offset: 58
        public ushort GMD_Description_Index; // Offset: 60
        public ushort Skill; // Offset: 62
    }
}