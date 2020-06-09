using System.Collections.ObjectModel;
using System.Windows.Controls;
using MHW_Editor.Controls;

namespace MHW_Editor.Windows {
    public partial class SubStructView {
        public SubStructView() {
            InitializeComponent();
        }
    }

    public sealed class SubStructViewDynamic<T> : SubStructView where T : class {
        public SubStructViewDynamic(MainWindow mainWindow, string name, ObservableCollection<T> items, bool isReadOnly) {
            Title  = name;
            Owner  = mainWindow;
            Width  = mainWindow.Width;
            Height = mainWindow.Height * 0.8d;

            var dataGrid = new MhwDataGridGeneric<T> {
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                VerticalScrollBarVisibility   = ScrollBarVisibility.Auto,
                CanUserAddRows                = isReadOnly
            };
            dataGrid.SetItems(mainWindow, items);

            AddChild(dataGrid);
        }
    }
}