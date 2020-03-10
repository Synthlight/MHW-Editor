using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using MHW_Editor.Weapons.Collision.Models;

namespace MHW_Editor.Weapons.Collision {
    public partial class Collision {
        private const double FONT_SIZE = 20;

        public static void SetupViews(Models.Collision collision, Grid grid, MainWindow main) {
            grid.AddControl(new Label {Content = "Collision", FontSize = FONT_SIZE});
            main.AddDataGrid(new List<Models.Collision> {collision});

            grid.AddControl(new Label {Content = "CLND", FontSize = FONT_SIZE});
            main.AddDataGrid(new List<Clnd> {collision.clnd});

            for (var i = 0; i < collision.clnd.clgm.Count; i++) {
                grid.AddControl(new Label {Content = $"CLGM {i + 1}", FontSize = FONT_SIZE});
                main.AddDataGrid(new List<Clgm> {collision.clnd.clgm[i]});

                if (collision.clnd.clgm[i].clgmInner.Any()) {
                    grid.AddControl(new Label {Content = $"CLGM {i + 1}: Inner Array", FontSize = FONT_SIZE});
                    main.AddDataGrid(collision.clnd.clgm[i].clgmInner);
                }
            }

            grid.AddControl(new Label {Content = "Move Names", FontSize = FONT_SIZE});
            main.AddDataGrid(collision.names);

            grid.AddControl(new Label {Content = "Moves (ATKs)", FontSize = FONT_SIZE});
            main.AddDataGrid(collision.atks);

            if (collision.oapInner.Any()) {
                grid.AddControl(new Label {Content = "OAP Inner Array", FontSize = FONT_SIZE});
                main.AddDataGrid(collision.oapInner);
            }
        }
    }
}