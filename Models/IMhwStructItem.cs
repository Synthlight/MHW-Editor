using System.ComponentModel;

namespace MHW_Editor.Models {
    public interface IMhwStructItem : INotifyPropertyChanged, IOnPropertyChanged {
        ulong Index { get; }
    }
}