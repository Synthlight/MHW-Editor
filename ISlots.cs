namespace MHW_Editor {
    public interface ISlots : IMhwItem {
        byte Slots { get; set; }
        byte Slot1Size { get; set; }
        byte Slot2Size { get; set; }
        byte Slot3Size { get; set; }
    }
}