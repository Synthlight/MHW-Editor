using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "31"
    // Initial Offset: "10"
    // Unique Id Formula: "{Index}"
    public struct CustomOuterRecipe {
        public byte Unk1; // Offset: 0
        public byte Unk6; // Offset: 1
        public byte Unk5; // Offset: 2
        public byte Mat_4_Count; // Offset: 3
        public ushort Mat_4_Id; // Offset: 4
        public byte Mat_3_Count; // Offset: 6
        public ushort Mat_3_Id; // Offset: 7
        public byte Unk7; // Offset: 9
        public byte Mat_2_Count; // Offset: 10
        public byte Mat_1_Count; // Offset: 11
        public ushort Mat_1_Id; // Offset: 12
        public uint Cost; // Offset: 14
        public int Unk4; // Offset: 18
        public int Unk3; // Offset: 22
        public ushort Needed_Item_Id_to_Unlock; // Offset: 26
        public ushort Mat_2_Id; // Offset: 28
        public byte Unk8; // Offset: 30
    }
}