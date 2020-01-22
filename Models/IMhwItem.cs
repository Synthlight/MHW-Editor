using System.ComponentModel;

namespace MHW_Editor.Models {
    public interface IMhwItem : INotifyPropertyChanged {
        byte[] Bytes { get; }
        int Offset { get; }
        string Name { get; }
        bool Changed { get; }
    }
}