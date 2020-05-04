using System.Collections.ObjectModel;

namespace MHW_Editor.Controls.Models {
    public interface IMhwDataGrid<T> where T : class {
        ObservableCollection<T> Items { get; }

        void SetItems(MainWindow mainWindow, ObservableCollection<T> items);
    }
}