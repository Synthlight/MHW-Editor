using System.Collections.Generic;
using System.Windows.Controls;
using MHW_Editor.Windows;

namespace MHW_Editor.Models {
    public interface IMhwMultiStructItem {
        LinkedList<MhwStructDataContainer> data { get; }

        void SetupViews(Grid grid, MainWindow main);
    }
}