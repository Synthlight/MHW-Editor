using System.ComponentModel;

namespace MHW_Weapon_Editor {
    public interface IMhwItem : INotifyPropertyChanged {
        byte[] Bytes { get; }
        int Offset { get; }
        string Name { get; }
    }
}