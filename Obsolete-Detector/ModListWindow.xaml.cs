using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace Obsolete_Detector {
    public partial class ModListWindow {
        public ObservableCollection<ObsoleteMod> obsoleteMods { get; } = new ObservableCollection<ObsoleteMod>();

        public ModListWindow(IEnumerable<string> obsoleteFileList) {
            foreach (var mod in obsoleteFileList) {
                obsoleteMods.Add(new ObsoleteMod {
                    Path = mod,
                    ToDelete = true
                });
            }

            InitializeComponent();
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e) {
            try {
                foreach (var mod in obsoleteMods) {
                    if (mod.ToDelete) {
                        File.Delete(mod.Path);
                    }
                }

                MessageBox.Show("Checked files successfully deleted.\r\nIf you still have a blackscreen after,\r\ntest without mods by renaming nativePC to anything else.", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            } catch (Exception err) {
                MainWindow.ShowError(err);
            }
        }

        private void Rename_OnClick(object sender, RoutedEventArgs e) {
            try {
                foreach (var mod in obsoleteMods) {
                    if (mod.ToDelete) {
                        File.Move(mod.Path, mod.Path + ".old");
                    }
                }

                MessageBox.Show("Checked files successfully renamed to {file}.old.\r\nIf you still have a blackscreen after,\r\ntest without mods by renaming nativePC to anything else.", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            } catch (Exception err) {
                MainWindow.ShowError(err);
            }
        }
    }

    public class ObsoleteMod {
        public string Path { get; set; }
        public bool ToDelete { get; set; }
    }
}