using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Controls;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public abstract class MhwMultiStructItem : IMhwMultiStructItem {
        // Make SURE the list type is dynamic. Auto-generated columns will be empty if it's a base class.
        [UsedImplicitly]
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

        protected static Stream OpenFile(string targetFile, string encryptionKey) {
            if (encryptionKey == null) {
                return File.OpenRead(targetFile);
            } else {
                var encryptedBytes = File.ReadAllBytes(targetFile);
                var decryptedStream = EncryptionHelper.DecryptToStream(encryptionKey, encryptedBytes);
                decryptedStream.Seek(0, SeekOrigin.Begin);
                return decryptedStream;
            }
        }

        protected static void SaveData(List<List<dynamic>> data, string targetFile, string encryptionKey) {
            using var memoryStream = new MemoryStream();
            using var writer = new BinaryWriter(memoryStream, Encoding.ASCII, true);
            foreach (var list in data) {
                foreach (MhwStructItem obj in list) {
                    obj.WriteData(writer);
                }
            }

            const int paddingBlockSize = 8;
            var paddingNeeded = memoryStream.Length % paddingBlockSize;
            if (paddingNeeded > 0) {
                for (var i = 0; i < paddingBlockSize - paddingNeeded; i++) {
                    writer.Write((byte) 0);
                }
            }

            SaveFile(targetFile, memoryStream, encryptionKey);
        }

        private static void SaveFile(string targetFile, MemoryStream stream, string encryptionKey) {
            stream.Seek(0, SeekOrigin.Begin);

            if (encryptionKey == null) {
                File.WriteAllBytes(targetFile, stream.ToArray());
            } else {
                var encryptedBytes = EncryptionHelper.Encrypt(encryptionKey, stream);
                File.WriteAllBytes(targetFile, encryptedBytes);
            }
        }
    }
}