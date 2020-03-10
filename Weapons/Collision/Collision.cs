using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;
using MHW_Editor.Weapons.Collision.Models;

namespace MHW_Editor.Weapons.Collision {
    public partial class Collision {
        public static void SetupViews(Models.Collision collision, Grid grid, Action<IEnumerable> addDataGrid) {
            grid.AddControl(new Label {Content = "Collision"});
            addDataGrid(new[] {collision});

            grid.AddControl(new Label {Content = "Move Names"});
            addDataGrid(collision.names);

            grid.AddControl(new Label {Content = "CLND"});
            addDataGrid(new[] {collision.clnd});

            grid.AddControl(new Label {Content = "CLGM"});
            addDataGrid(collision.clnd.clgm);

            for (var i = 0; i < collision.clnd.clgm.Count; i++) {
                grid.AddControl(new Label {Content = $"CLGM {i + 1}: Inner Array"});
                addDataGrid(collision.clnd.clgm[i].clgmInner);
            }

            grid.AddControl(new Label {Content = "Moves (ATKs)"});
            if (collision.atkType == 1) {
                addDataGrid(collision.atks);
            } else if (collision.atkType == 3) {
                addDataGrid(collision.atks);
            }
        }
    }
}