using System.Collections.ObjectModel;

namespace MHW_Editor.Controls.Models {
    public interface IMhwDataGrid {
        ObservableCollection<dynamic> Items { get; }

        void SetItems(MainWindow mainWindow, ObservableCollection<dynamic> items);
    }
}