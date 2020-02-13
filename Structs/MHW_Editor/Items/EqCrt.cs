using MHW_Template;

namespace MHW_Editor.Items {
    // Unique Id Formula: "{Equipment_Category}|{Equipment_Id}"
    public struct EqCrt {
        public byte Equipment_Category; // Offset: 0
        public ushort Equipment_Id; // Offset: 1
        public ushort Needed_Item_Id_to_Unlock; // Offset: 3
        public int Monster_Unlock; // Offset: 5
        public uint Story_Unlock; // Offset: 9
        public uint Unknown_uint32_; // Offset: 13
        public uint Item_Rank; // Offset: 17
        public ushort Mat_1_Id; // Offset: 21
        public byte Mat_1_Count; // Offset: 23
        public ushort Mat_2_Id; // Offset: 24
        public byte Mat_2_Count; // Offset: 26
        public ushort Mat_3_Id; // Offset: 27
        public byte Mat_3_Count; // Offset: 29
        public ushort Mat_4_Id; // Offset: 30
        public byte Mat_4_Count; // Offset: 32
        public byte Unknown_uint8_1; // Offset: 33
        public byte Unknown_uint8_2; // Offset: 34
        public byte Unknown_uint8_3; // Offset: 35
        public byte Unknown_uint8_4; // Offset: 36
    }
}