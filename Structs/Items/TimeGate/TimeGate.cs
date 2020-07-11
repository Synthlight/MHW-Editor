using System.Collections.Generic;
using System.Windows.Controls;
using JetBrains.Annotations;
using MHW_Editor.Models;
using MHW_Editor.Windows;

namespace MHW_Editor.Structs.Items.TimeGate {
    public partial class TimeGate : SaveLoad<TimeGate>, ISaveLoad, IMhwMultiStructFile {
        public string EncryptionKey { get; }

        public LinkedList<MhwStructDataContainer> data { get; }

        [UsedImplicitly]
        public static void SetupViews(TimeGate timeGate, Grid grid, MainWindow main) {
            timeGate.SetupViews(grid, main);
        }

        public void SetupViews(Grid grid, MainWindow main) {
            grid.AddControl(new Label {Content = "Weapons", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(weapons);
            grid.AddControl(new Label {Content = "Armors", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(armors);
            grid.AddControl(new Label {Content = "Pendants", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(pendants);
            grid.AddControl(new Label {Content = "Items", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(items);
            grid.AddControl(new Label {Content = "Unk1", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(unk1);
            grid.AddControl(new Label {Content = "Unk2", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(unk2);
            grid.AddControl(new Label {Content = "Unk3", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(unk3);
        }

        public MhwStructDataContainer<F> GetStructContainer<F>() where F : IMhwStructItem, IWriteData {
            return null;
        }

        public ObservableMhwStructCollection<F> GetStructList<F>() where F : class, IMhwStructItem, IWriteData {
            return null;
        }

        public IEnumerable<F> GetAllEnumerableOfType<F>() {
            yield break;
        }
    }
}