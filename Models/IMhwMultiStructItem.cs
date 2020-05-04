using System.Collections.Generic;

namespace MHW_Editor.Models {
    public interface IMhwMultiStructItem {
        LinkedList<MhwStructDataContainer> data { get; }
    }
}