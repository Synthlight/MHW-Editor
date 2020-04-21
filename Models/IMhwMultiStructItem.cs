using System;
using System.Collections.Generic;

namespace MHW_Editor.Models {
    public interface IMhwMultiStructItem {
        List<MhwStructDataContainer> data { get; }
        Dictionary<Type, MhwStructDataContainer> dataByType { get; }
    }
}