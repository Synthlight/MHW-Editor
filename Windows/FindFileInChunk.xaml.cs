using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using JetBrains.Annotations;
using MHW_Editor.Assets;

namespace MHW_Editor.Windows {
    public partial class FindFileInChunk {
        private readonly Dictionary<string, ChunkPathEntry> data = new Dictionary<string, ChunkPathEntry>();

        public FindFileInChunk() {
            InitializeComponent();

            foreach (var key in DataHelper.GOOD_CHUNK_MAP.Keys) {
                data[key] = new ChunkPathEntry {
                    Chunk = DataHelper.GOOD_CHUNK_MAP[key],
                    Path  = DataHelper.FILE_PATH_MAP[key]
                };
            }

            box.ItemsSource = data;
        }

        private void Filter_OnTextChanged(object sender, TextChangedEventArgs e) {
            var view = CollectionViewSource.GetDefaultView(data);
            view.Filter = o => {
                if (o is KeyValuePair<string, ChunkPathEntry> kvp) {
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

        private struct ChunkPathEntry {
            public string Chunk {
                [UsedImplicitly]
                get;
                set;
            }

            public string Path {
                [UsedImplicitly]
                get;
                set;
            }
        }
    }
}