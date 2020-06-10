using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Json {
    public interface IJsonItem : INotifyPropertyChanged, IOnPropertyChanged {
        public string          UniqueId     { get; }
        public HashSet<string> ChangedItems { get; }
    }
}