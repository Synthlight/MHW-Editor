using System.Collections.Generic;
using System.Windows.Controls;

namespace MHW_Editor.Models {
    public interface IMhwMultiStructItem {
        LinkedList<MhwStructDataContainer> data { get; }

        void SetupViews(Grid grid, MainWindow main);
    }
}