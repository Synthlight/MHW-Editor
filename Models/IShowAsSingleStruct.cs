using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MHW_Editor.Models {
    public interface IShowAsSingleStruct<out T> where T : IMhwStructItem {
        ObservableCollection<object> GetStructList();
        IEnumerable<T>               GetIterableStructList();
    }
}