using System.Windows.Controls;
using MHW_Editor.Models;

namespace MHW_Editor.Items.TimeGate {
    public partial class TimeGate : CustomSaveLoad<TimeGate>, ICustomSaveLoad {
        public string EncryptionKey { get; }

        public static void SetupViews(TimeGate timeGate, Grid grid, MainWindow main) {
            grid.AddControl(new Label {Content = "Weapons", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(timeGate.weapons);
            grid.AddControl(new Label {Content = "Armors", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(timeGate.armors);
            grid.AddControl(new Label {Content = "Pendants", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(timeGate.pendants);
            grid.AddControl(new Label {Content = "Items", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(timeGate.items);
            grid.AddControl(new Label {Content = "Unk1", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(timeGate.unk1);
            grid.AddControl(new Label {Content = "Unk2", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(timeGate.unk2);
            grid.AddControl(new Label {Content = "Unk3", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(timeGate.unk3);
        }
    }
}