using System.ComponentModel;
using System.IO;

namespace MHW_Editor.Models {
    public interface IMhwStructItem : INotifyPropertyChanged, IOnPropertyChanged {
        [IsReadOnly]
        ulong Index { get; set; }
    }
}