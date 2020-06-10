using MHW_Editor.Json;

namespace MHW_Editor.Models {
    public interface ISlots : IJsonItem {
        byte Slot_Count  { get; set; }
        byte Slot_1_Size { get; set; }
        byte Slot_2_Size { get; set; }
        byte Slot_3_Size { get; set; }
    }
}