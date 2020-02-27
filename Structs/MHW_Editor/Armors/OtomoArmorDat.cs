using MHW_Template;

namespace MHW_Editor.Armors {
    // Struct Size: "42"
    // Initial Offset: "10"
    // Unique Id Formula: "{Set_Id}|{Variant}|{Equip_Slot}"
    public struct OtomoArmorDat {
        public uint Index; // Offset: 0
        public ushort Set_Id; // Offset: 4
        public byte Equip_Slot; // Offset: 6
        public byte Is_Full_Set_Raw; // Offset: 7
        public uint Defense; // Offset: 8
        public byte Rarity; // Offset: 12
        public ushort Order; // Offset: 13
        public uint Model_Id; // Offset: 15
        public uint Cost; // Offset: 19
        public uint Variant; // Offset: 23
        public sbyte Fire_Res; // Offset: 27
        public sbyte Water_Res; // Offset: 28
        public sbyte Ice_Res; // Offset: 29
        public sbyte Thunder_Res; // Offset: 30
        public sbyte Dragon_Res; // Offset: 31
        public uint Unk; // Offset: 32
        public ushort Set_Group; // Offset: 36
        public ushort GMD_Name_Index; // Offset: 38
        public ushort GMD_Description_Index; // Offset: 40
    }
}