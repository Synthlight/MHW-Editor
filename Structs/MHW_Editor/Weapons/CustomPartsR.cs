using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "51"
    // Unique Id Formula: "{Id}|{Weapon_Type}"
    public struct CustomPartsR {
        public byte Weapon_Type; // Offset: 0
        public uint Id; // Offset: 1
        public ushort Needed_Item_Id_to_Unlock; // Offset: 5
        public int Unk2; // Offset: 7
        public ushort Mat_1_Id; // Offset: 15
        public byte Mat_1_Count; // Offset: 17
        public ushort Mat_2_Id; // Offset: 18
        public byte Mat_2_Count; // Offset: 20
        public ushort Mat_3_Id; // Offset: 21
        public byte Mat_3_Count; // Offset: 23
        public ushort Mat_4_Id; // Offset: 24
        public byte Mat_4_Count; // Offset: 26
        public ushort Unk3; // Offset: 27
        public ushort Unk4; // Offset: 29
        public ushort Unk5; // Offset: 31
        public ushort Unk6; // Offset: 33
        public byte Unk7; // Offset: 50
    }
}