using System.Diagnostics;
using System.IO;
using System.Text;
using MHW_Template;

namespace MHW_Editor.Weapons.Shlp {
    public partial class Shlp {
        public static Models.Shlp LoadData(string targetFile) {
            //Debug.Assert(Marshal.SizeOf(typeof(Atk0)) == 179);

            // Read & decrypt file.
            var encryptedBytes = File.ReadAllBytes(targetFile);
            var decryptedBytes = EncryptionHelper.Decrypt(EncryptionKeys.FILE_EXT_KEY_LOOKUP[".shlp"], encryptedBytes);

            using var dat = new MemoryStream();

            // Write to a stream for the loader. Leave base stream OPEN.
            using (var writer = new BinaryWriter(dat, Encoding.Default, true)) {
                writer.Write(decryptedBytes);
            }

            // Load as normal.
            using var reader = new BinaryReader(dat);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            var shlp = new Models.Shlp {
                magicSlp1 = reader.ReadUInt32(),
                nameSlp = new string(reader.ReadChars(4)),
                magicSlp2 = reader.ReadUInt32()
            };

            ReadAsset(reader, shlp, "epv", 12);
            ReadAsset(reader, shlp, "sound", 12);

            return shlp;
        }

        private static void ReadAsset(BinaryReader reader, Models.Shlp shlp, string prefix, byte count) {
            for (var i = 0; i < count; i++) {
                var header = reader.ReadUInt32();
                if (header != 0) {
                    var headerProp = shlp.GetType().GetProperty($"{prefix}{i + 1}Header");
                    Debug.Assert(headerProp != null, nameof(headerProp) + " != null");
                    headerProp.GetSetMethod().Invoke(shlp, new object[] {header});

                    var pathProp = shlp.GetType().GetProperty($"{prefix}{i + 1}Path");
                    Debug.Assert(pathProp != null, nameof(pathProp) + " != null");

                    var path = reader.ReadNullTermString();
                    pathProp.GetSetMethod().Invoke(shlp, new object[] {path});
                }
            }
        }

        public static void SaveData(Models.Shlp collision, string targetFile) {
            // Don't erase file, we just want to write what we have.
            // This ensures extra bytes at the end (if any) are not lost.
            using var writer = new BinaryWriter(File.Open(targetFile, FileMode.Open, FileAccess.Write));

            writer.Write(collision.magicSlp1);
            writer.Write(collision.nameSlp.ToCharArray());
            writer.Write(collision.magicSlp2);
        }
    }
}