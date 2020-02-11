using System.ComponentModel;

namespace MHW_Editor.Models {
    public interface IMhwItem : INotifyPropertyChanged {
        string UniqueId { get; }
        byte[] Bytes { get; }
        ulong Offset { get; }
        string Name { get; }
        string Raw_Data { get; }
    }
}