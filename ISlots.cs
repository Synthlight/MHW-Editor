namespace MHW_Editor {
    public interface ISlots : IMhwItem {
        byte Slot_Count { get; set; }
        byte Slot_1_Size { get; set; }
        byte Slot_2_Size { get; set; }
        byte Slot_3_Size { get; set; }
    }
}