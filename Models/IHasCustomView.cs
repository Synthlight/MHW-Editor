using System.Collections.ObjectModel;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public interface IHasCustomView<T> {
        [UsedImplicitly]
        ObservableCollection<T> GetCustomView();
    }
}