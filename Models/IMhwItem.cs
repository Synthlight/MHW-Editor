using System.ComponentModel;

namespace MHW_Editor.Models {
    public interface IMhwItem : INotifyPropertyChanged {
        byte[] Bytes { get; }
        ulong Offset { get; }
        string Name { get; }
        bool Changed { get; }
    }
}