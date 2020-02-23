using MHW_Template;

namespace MHW_Editor.Weapons {
    // Struct Size: "38"
    // Unique Id Formula: "{Id_1}|{Id_2}"
    public struct NewLimitBreakR {
        public ushort Id_1; // Offset: 0
        public ushort Id_2; // Offset: 2
        public ushort Needed_Item_Id_to_Unlock; // Offset: 4
        public int Unk1; // Offset: 6
        public ushort Mat_1_Id; // Offset: 14
        public byte Mat_1_Count; // Offset: 16
        public ushort Mat_2_Id; // Offset: 17
        public byte Mat_2_Count; // Offset: 19
        public ushort Mat_3_Id; // Offset: 20
        public byte Mat_3_Count; // Offset: 22
        public ushort Mat_4_Id; // Offset: 23
        public byte Mat_4_Count; // Offset: 25
        public byte Id_3; // Offset: 37
    }
}