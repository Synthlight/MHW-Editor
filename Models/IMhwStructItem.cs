using System.ComponentModel;
using System.IO;

namespace MHW_Editor.Models {
    public interface IMhwStructItem : INotifyPropertyChanged, IOnPropertyChanged {
        ulong Index { get; }

        void WriteData(BinaryWriter writer);
    }
}