using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Controls;

namespace MHW_Editor.Models {
    public abstract class MhwMultiStructItem : IMhwMultiStructItem {
        // Make SURE the list type is dynamic. Auto-generated columns will be empty if it's a base class.
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
                var decryptedBytes = EncryptionHelper.Decrypt(encryptionKey, encryptedBytes);

                // Don't use 'using', we need it open.
                var dat = new MemoryStream();

                // Write to a stream for the loader. Leave base stream OPEN.
                using (var writer = new BinaryWriter(dat, Encoding.Default, true)) {
                    writer.Write(decryptedBytes);
                }

                dat.Seek(0, SeekOrigin.Begin);
                return dat;
            }
        }
    }
}