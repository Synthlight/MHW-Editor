using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace MHW_Editor {
    public partial class FindFileInChunk {
        public FindFileInChunk() {
            InitializeComponent();

            box.ItemsSource = FileHashes.GOOD_CHUNK_MAP;
        }

        private void Filter_OnTextChanged(object sender, TextChangedEventArgs e) {
            var view = CollectionViewSource.GetDefaultView(FileHashes.GOOD_CHUNK_MAP);
            view.Filter = (o) => {
                if (o is KeyValuePair<string, string> kvp) {
                    return string.IsNullOrEmpty(filter.Text) || kvp.Key.ToLower().Contains(filter.Text.ToLower());
                }

                return false;
            };
            box.ItemsSource = view;
        }

        private void BtnOk_OnKeyUp(object sender, KeyEventArgs e) {
            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (e.Key) {
                case Key.Escape:
                    Close();
                    break;
            }
        }

        private void BtnOk_OnClick(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}