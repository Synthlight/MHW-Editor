using System.ComponentModel;

namespace MHW_Weapon_Editor {
    public interface IMhwItem : INotifyPropertyChanged {
        int Offset { get; set; }

        byte[] ToByteArray();
    }
}