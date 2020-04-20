using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Controls;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class SupplyData : ICustomSaveLoad {
        public static void SetupViews(List<List<dynamic>> data, Grid grid, MainWindow main) {
            foreach (var entry in data) {
                if (entry.Count == 0) continue;
                grid.AddControl(new Label {Content = GetLabel(entry), FontSize = MainWindow.FONT_SIZE});
                main.AddDataGrid(entry);
            }
        }

        private static string GetLabel(List<dynamic> entry) {
            var type = entry[0].GetType();
            return (string) type.GetField("DisplayName", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).GetValue(null);
        }

        public partial class Item_Box_Scaling {
            public string Name {
                get {
                    return index switch {
                        0 => "1 Player",
                        1 => "2 Players",
                        2 => "3/4 Players",
                        _ => throw new ArgumentOutOfRangeException()
                    };
                }
            }
        }

        public partial class Ammo_Box_Scaling {
            public string Name {
                get {
                    return index switch {
                        0 => "1 Player",
                        1 => "2 Players",
                        2 => "3/4 Players",
                        _ => throw new ArgumentOutOfRangeException()
                    };
                }
            }
        }
    }
}