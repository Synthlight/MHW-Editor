using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Json {
    public interface IJsonItem : INotifyPropertyChanged, IOnPropertyChanged {
        string UniqueId { get; }
    }
}