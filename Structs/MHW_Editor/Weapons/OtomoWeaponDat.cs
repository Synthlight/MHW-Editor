using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "38"
    // Unique Id Formula: "{Id}"
    public struct OtomoWeaponDat {
        public uint Index; // Offset: 0
        public ushort Set_Id; // Offset: 4
        public byte Element; // Offset: 6
        public ushort Attack_Type; // Offset: 7
        public ushort Melee_Damage; // Offset: 9
        public ushort Ranged_Damage; // Offset: 11
        public ushort Elemental_Damage; // Offset: 13
        public short Affinity; // Offset: 15
        public ushort Defense; // Offset: 17
        public byte Elderseal; // Offset: 19
        public byte Rarity; // Offset: 20
        public ushort Order; // Offset: 21
        public uint Unk; // Offset: 23
        public uint Cost; // Offset: 27
        public byte Unknown_byte_1; // Offset: 31
        public ushort Id; // Offset: 32
        public ushort GMD_Name_Index; // Offset: 34
        public ushort GMD_Description_Index; // Offset: 36
    }
}