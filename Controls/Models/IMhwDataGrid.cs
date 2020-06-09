using System.Collections.ObjectModel;
using MHW_Editor.Windows;

namespace MHW_Editor.Controls.Models {
    public interface IMhwDataGrid<T> {
        ObservableCollection<T> Items { get; }

        void SetItems(MainWindow mainWindow, ObservableCollection<T> items);
    }
}