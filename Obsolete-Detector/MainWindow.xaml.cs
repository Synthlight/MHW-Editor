using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MHW_Template;
using Microsoft.Win32;
using Newtonsoft.Json;
using Obsolete_Detector.Assets;

namespace Obsolete_Detector {
    public partial class MainWindow {
        private const           string   NEXUS_LINK = "https://www.nexusmods.com/monsterhunterworld/mods/3191";
        private static readonly DateTime PRE_IB     = new DateTime(2020, 1, 9);
        private static readonly DateTime CHUNK_0    = PRE_IB;
        private static readonly DateTime CHUNK_1    = new DateTime(2020, 2, 5);
        private static readonly DateTime CHUNK_2    = new DateTime(2020, 3, 11);
        private static readonly DateTime CHUNK_3    = new DateTime(2020, 4, 8);
        private static readonly DateTime CHUNK_4    = new DateTime(2020, 4, 22);
        private static readonly DateTime CHUNK_5    = new DateTime(2020, 6, 9);
        private static readonly DateTime CHUNK_6    = new DateTime(2020, 7, 20);
        private static readonly DateTime CHUNK_7    = new DateTime(2020, 9, 30);
        private static readonly DateTime CHUNK_8    = new DateTime(2020, 12, 3);
        private static readonly DateTime CHUNK_9    = new DateTime(2023, 10, 16);

        public static readonly Dictionary<string, string> GOOD_CHUNK_MAP;

        static MainWindow() {
            GOOD_CHUNK_MAP = LoadDict<string, string>(EditorAssets.GoodChunkMap);
        }

        public MainWindow() {
            InitializeComponent();
            main_text.Text = "This detects mods that are outdated for the current version of MHW.\n" +
                             $"Currently designed for {Global.CURRENT_GAME_VERSION}. If you have a newer version of MHW, please update this program.\n" +
                             "Click anywhere on the text here to go to the mod page.\n" +
                             "\n" +
                             "This isn't perfect. It may miss something obsolete, it may have false positives. YMMV\n" +
                             "If you still have a blackscreen after, test without mods by renaming nativePC to anything else.\n" +
                             "\n" +
                             "Select MHW install folder and press scan to begin.";
        }

        private void NexusLink_OnMouseUp(object sender, MouseButtonEventArgs e) {
            try {
                Process.Start(NEXUS_LINK);
            } catch (Exception err) when (!Debugger.IsAttached) {
                ShowError(err);
            }
        }

        private void Browse_OnClick(object sender, RoutedEventArgs e) {
            try {
                var ofdResult = new OpenFileDialog {
                    Filter           = "MonsterHunterWorld.exe|MonsterHunterWorld.exe",
                    InitialDirectory = txt_path.Text,
                    Multiselect      = false
                };
                var result = ofdResult.ShowDialog();
                if (result == true) {
                    txt_path.Text = Path.GetDirectoryName(ofdResult.FileName) ?? throw new InvalidOperationException();
                }
            } catch (Exception err) when (!Debugger.IsAttached) {
                ShowError(err);
            }
        }

        private async void Scan_OnClick(object sender, RoutedEventArgs e) {
            try {
                btn_scan.Visibility = Visibility.Hidden;
                progress.Visibility = Visibility.Visible;

                await DoScan();
            } catch (Exception err) when (!Debugger.IsAttached) {
                ShowError(err);
            } finally {
                btn_scan.Visibility = Visibility.Visible;
                progress.Visibility = Visibility.Hidden;
            }
        }

        private Task DoScan() {
            return Task.Run(() => {
                var path        = GetOnUiThread(() => txt_path.Text);
                var nativePcDir = path.PathCombine("nativePC");
                if (!Directory.Exists(nativePcDir)) {
                    MessageBox.Show("No nativePC folder found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var obsoleteFiles = new List<string>();

                foreach (var file in Directory.EnumerateFiles(nativePcDir, "*", SearchOption.AllDirectories)) {
                    var attr = File.GetAttributes(file);
                    if ((attr & FileAttributes.Directory) != 0) continue;

                    var info         = new FileInfo(file);
                    var modifiedDate = info.LastWriteTime.Date;
                    var filename     = info.Name;

                    // Didn't change in IB, ignore.
                    if (info.Extension == ".mod3" || info.Extension == ".tex") continue;

                    if (PRE_IB > modifiedDate) {
                        obsoleteFiles.Add(file);
                    }

                    var chunk = GOOD_CHUNK_MAP.TryGet(filename, null);
                    if (chunk == null) continue;
                    var chunkDate = GetDateForChunk(chunk);

                    if (chunkDate > modifiedDate) {
                        obsoleteFiles.Add(file);
                    }
                }

                if (obsoleteFiles.Count == 0) {
                    MessageBox.Show("No obsolete files found.", "Nothing Found", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                RunOnUiThread(() => {
                    new ModListWindow(obsoleteFiles).Show();
                    Close();
                });
            });
        }

        private static DateTime GetDateForChunk(string chunk) {
            switch (chunk) {
                case "chunkG0": return CHUNK_0;
                case "chunkG1": return CHUNK_1;
                case "chunkG2": return CHUNK_2;
                case "chunkG3": return CHUNK_3;
                case "chunkG4": return CHUNK_4;
                case "chunkG5": return CHUNK_5;
                case "chunkG6": return CHUNK_6;
                case "chunkG7": return CHUNK_7;
                case "chunkG8": return CHUNK_8;
                case "chunkG9": return CHUNK_9;
                default: throw new Exception($"No date for: {chunk}");
            }
        }

        public void RunOnUiThread(Action action) {
            Dispatcher.BeginInvoke(action);
        }

        public T GetOnUiThread<T>(Func<T> action) {
            return Dispatcher.Invoke(action);
        }

        public static void ShowError(Exception err) {
            MessageBox.Show("Error occurred. Press Ctrl+C to copy the contents of ths window and report to the developer.\r\n\r\n" + err, "Error Occurred", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private static Dictionary<K, V> LoadDict<K, V>(byte[] data) {
            var json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Dictionary<K, V>>(json);
        }
    }

    public static class Extensions {
        public static string PathCombine(this string a, string b) {
            return Path.Combine(a, b);
        }
    }
}