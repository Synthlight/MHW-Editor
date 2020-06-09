using System.ComponentModel;

namespace MHW_Editor.Models {
    public interface IJsonItem : INotifyPropertyChanged, IOnPropertyChanged {
        string UniqueId { get; }
    }
}