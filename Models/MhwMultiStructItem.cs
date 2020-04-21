using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Controls;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public abstract class MhwMultiStructItem : IMhwMultiStructItem {
        [UsedImplicitly]
        public static void SetupViews(List<MhwStructWrapper> data, Grid grid, MainWindow main) {
            foreach (var entry in data) {
                if (IsHidden(entry)) continue;

                grid.AddControl(new Label {Content = GetLabel(entry), FontSize = MainWindow.FONT_SIZE});

                if (entry.type.IsGeneric(typeof(IHasCustomView<>))) {
                    main.AddDataGrid(((IHasCustomView<MultiStructItemCustomView>) entry.list[0]).GetCustomView());
                } else {
                    main.AddDataGrid(entry.list);
                }
            }
        }

        protected static bool IsHidden(MhwStructWrapper entry) {
            return (bool) (entry.type.GetField("Hidden", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null) ?? false);
        }

        protected static string GetLabel(MhwStructWrapper entry) {
            return (string) entry.type.GetField("DisplayName", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)?.GetValue(null);
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

        protected static void SaveData(List<MhwStructWrapper> data, string targetFile, string encryptionKey) {
            using var memoryStream = new MemoryStream();
            using var writer = new BinaryWriter(memoryStream, Encoding.ASCII, true);
            foreach (var entry in data) {
                foreach (MhwStructItem obj in entry.list) {
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