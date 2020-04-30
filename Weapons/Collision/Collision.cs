using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using MHW_Editor.Models;
using MHW_Editor.Weapons.Collision.Models;

namespace MHW_Editor.Weapons.Collision {
    public partial class Collision : ICustomSaveLoad {
        public string EncryptionKey { get; }

        public static void SetupViews(Models.Collision collision, Grid grid, MainWindow main) {
            if (main.showAll) {
                grid.AddControl(new Label {Content = "Collision", FontSize = MainWindow.FONT_SIZE});
                main.AddDataGrid(new List<Models.Collision> {collision});

                grid.AddControl(new Label {Content = "CLND", FontSize = MainWindow.FONT_SIZE});
                main.AddDataGrid(new List<Clnd> {collision.clnd});

                for (var i = 0; i < collision.clnd.clgm.Count; i++) {
                    grid.AddControl(new Label {Content = $"CLGM {i + 1}", FontSize = MainWindow.FONT_SIZE});
                    main.AddDataGrid(new List<Clgm> {collision.clnd.clgm[i]});

                    if (collision.clnd.clgm[i].clgmInner.Any()) {
                        grid.AddControl(new Label {Content = $"CLGM {i + 1}: Inner Array", FontSize = MainWindow.FONT_SIZE});
                        main.AddDataGrid(collision.clnd.clgm[i].clgmInner);
                    }
                }
            }

            foreach (var name in collision.names.Where(name => name.moveId > -1).OrderBy(name => name.moveId)) {
                var nameString = $"Name & Move [{name.TranslatedName}{(string.IsNullOrEmpty(name.Description) ? "" : $", {name.Description}")}]"
                                 .Replace(" [,", " [") // For cases where only name null/empty.
                                 .Replace(" []", "") // For cases where name & desk is null/empty.
                                 .Replace(" [\0]", ""); // For cases where name is just \0.

                grid.AddControl(new Label {Content = nameString, FontSize = MainWindow.FONT_SIZE});
                main.AddDataGrid(new List<Name> {name});

                main.AddDataGrid(collision.atks.Where(o => ((IAtk) o).moveId == name.moveId));
            }

            if (main.showAll) {
                grid.AddControl(new Label {Content = "Raw Name List", FontSize = MainWindow.FONT_SIZE});
                main.AddDataGrid(collision.names);

                grid.AddControl(new Label {Content = "Raw Move List (ATKs)", FontSize = MainWindow.FONT_SIZE});
                main.AddDataGrid(collision.atks);

                if (collision.oapInner.Any()) {
                    grid.AddControl(new Label {Content = "OAP Inner Array", FontSize = MainWindow.FONT_SIZE});
                    main.AddDataGrid(collision.oapInner);
                }
            }
        }

        public void LoadFile(string targetFile) {
        }

        public void SaveFile(string targetFile) {
        }
    }
}