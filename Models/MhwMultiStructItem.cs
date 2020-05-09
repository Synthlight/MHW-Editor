using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public abstract class MhwMultiStructItem<T> : CustomSaveLoad<T>, ICustomSaveLoad, IMhwMultiStructItem where T : ICustomSaveLoad, IMhwMultiStructItem, new() {
        public LinkedList<MhwStructDataContainer> data { get; protected set; }

        public abstract string EncryptionKey { get; }

        [UsedImplicitly]
        public static void SetupViews(T instance, Grid grid, MainWindow main) {
            foreach (var entry in instance.data) {
                if (entry.IsHidden) continue;

                if (entry.IsAddingAllowed) {
                    var panel = new StackPanel {Orientation = Orientation.Horizontal};
                    panel.Children.Add(new Label {Content   = entry.GridName, FontSize       = MainWindow.FONT_SIZE, HorizontalAlignment    = HorizontalAlignment.Left});
                    var button = new Button {Content        = "Add Row", HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Center};
                    button.Click += entry.Add_Click;
                    panel.Children.Add(button);
                    grid.AddControl(panel);
                } else {
                    grid.AddControl(new Label {Content = entry.GridName, FontSize = MainWindow.FONT_SIZE});
                }

                if (entry.type.IsGeneric(typeof(IHasCustomView<>))) {
                    main.AddDataGrid(((IHasCustomView<MultiStructItemCustomView>) entry.list[0]).GetCustomView());
                } else {
                    var dataGrid = main.AddDataGrid(entry.list);
                    dataGrid.CanUserDeleteRows = entry.IsAddingAllowed;
                }
            }
        }

        public abstract void LoadFile(string targetFile);

        protected static Stream OpenFile(string targetFile, string encryptionKey) {
            if (encryptionKey == null) {
                return File.OpenRead(targetFile);
            } else {
                var encryptedBytes  = File.ReadAllBytes(targetFile);
                var decryptedStream = EncryptionHelper.DecryptToStream(encryptionKey, encryptedBytes);
                decryptedStream.Seek(0, SeekOrigin.Begin);
                return decryptedStream;
            }
        }

        public void SaveFile(string targetFile) {
            foreach (var entry in data) {
                entry.PrepSave();
            }

            using var memoryStream = new MemoryStream();
            using var writer       = new BinaryWriter(memoryStream, Encoding.UTF8, true);
            foreach (var entry in data) {
                foreach (dynamic obj in entry.list) {
                    try {
                        obj.WriteData(writer);
                    } catch (Exception e) {
                        Console.Error.Write($"Save Error: {e}");
                    }
                }
            }

            // Only pad for encrypted files.
            if (EncryptionKey != null) {
                const int paddingBlockSize = 8;
                var       paddingNeeded    = memoryStream.Length % paddingBlockSize;
                if (paddingNeeded > 0) {
                    for (var i = 0; i < paddingBlockSize - paddingNeeded; i++) {
                        writer.Write((byte) 0);
                    }
                }
            }

            SaveFile(targetFile, memoryStream);
        }

        private void SaveFile(string targetFile, MemoryStream stream) {
            stream.Seek(0, SeekOrigin.Begin);

            if (EncryptionKey == null) {
                File.WriteAllBytes(targetFile, stream.ToArray());
            } else {
                var encryptedBytes = EncryptionHelper.Encrypt(EncryptionKey, stream);
                File.WriteAllBytes(targetFile, encryptedBytes);
            }
        }
    }
}