using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using JetBrains.Annotations;
using MHW_Editor.Armors;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Weapons;
using MHW_Template;

namespace MHW_Editor {
    public class SaveLoad {
        [NotNull] private readonly string targetFile;
        [NotNull] private readonly Type   targetFileType;

        private readonly ObservableCollection<dynamic> items;

        public SaveLoad([NotNull] string targetFile, [NotNull] Type targetFileType, [CanBeNull] ObservableCollection<dynamic> items) {
            this.targetFile     = targetFile;
            this.targetFileType = targetFileType;
            if (items == null) {
                this.items = new ObservableCollection<dynamic>();
            } else {
                this.items = items;
            }
        }

        [CanBeNull]
        public static ObservableCollection<dynamic> LoadFile([NotNull] string targetFile, [NotNull] Type targetFileType) {
            return new SaveLoad(targetFile, targetFileType, null).LoadFile();
        }

        [CanBeNull]
        private ObservableCollection<dynamic> LoadFile() {
            var fileName = Path.GetFileName(targetFile);

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;
            // ReSharper disable PossibleNullReferenceException
            var initialOffset    = (ulong) targetFileType.GetField(nameof(Armor.InitialOffset), flags).GetValue(null);
            var structSize       = (uint) targetFileType.GetField(nameof(Armor.StructSize), flags).GetValue(null);
            var entryCountOffset = (long) targetFileType.GetField(nameof(Armor.EntryCountOffset), flags).GetValue(null);
            var encryptionKey    = (string) targetFileType.GetField(nameof(Armor.EncryptionKey), flags).GetValue(null);

            var weaponFilename = Path.GetFileNameWithoutExtension(targetFile);

            CheckHashAndSize(targetFile);

            using var dat = new BinaryReader(GetFileStream(encryptionKey));
            ReadStructs(dat, structSize, initialOffset, weaponFilename, entryCountOffset);

            return items;
        }

        public static void CheckHashAndSize(string targetFile, bool ignoreBadSizes = false) {
            var       fileName     = Path.GetFileName(targetFile);
            using var file         = File.OpenRead(targetFile);
            var       ourLength    = (ulong) file.Length;
            var       properLength = DataHelper.FILE_SIZE_MAP.TryGet(Path.GetFileName(targetFile), (ulong) 0);
            var       sha512       = file.SHA512();

            // Look for known bad hashes first to ensure it's not an unedited file from a previous chunk.
            foreach (var pair in DataHelper.BAD_FILE_HASH_MAP) {
                // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
                foreach (var fileAndHash in pair.Value) {
                    if (fileName == fileAndHash.Key && fileAndHash.Value.Contains(sha512)) {
                        var newChunk = DataHelper.GOOD_CHUNK_MAP.TryGet(fileName);
                        MessageBox.Show($"This file ({fileName}) is from {pair.Key} and is obsolete.\r\n" +
                                        $"The newest version of the file is in {newChunk}.\r\n\r\n" +
                                        "Using obsolete files is known to cause anything from blackscreens to crashes or incorrect data.\r\n\r\n" +
                                        "The editor will attempt to load the file, but understand, it may fail due to obsolete data.", "Obsolete File Detected", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                }
            }

            // Length check as a fallback.
            if (ourLength == properLength || ignoreBadSizes) return;

            MessageBox.Show($"The file size of {fileName} does not match the known file size in v{MainWindow.CURRENT_GAME_VERSION}.\r\n" +
                            $"Expected: {properLength}\r\n" +
                            $"Found: {ourLength}\r\n" +
                            "Please make sure you've extracted the file from the highest numbered chunk that contains it.", "File Size Mismatch", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void ReadStructs(BinaryReader dat, uint structSize, ulong initialOffset, string weaponFilename, long entryCountOffset) {
            if (entryCountOffset >= 0) {
                ReadStructsAsKnownLength(dat, structSize, initialOffset, weaponFilename, entryCountOffset);
            } else {
                ReadStructsAsUnknownLength(dat, structSize, initialOffset, weaponFilename);
            }
        }

        private void ReadStructsAsKnownLength(BinaryReader dat, uint structSize, ulong initialOffset, string weaponFilename, long entryCountOffset) {
            dat.BaseStream.Seek(entryCountOffset, SeekOrigin.Begin);
            var count = dat.ReadUInt32();

            dat.BaseStream.Seek((long) initialOffset, SeekOrigin.Begin);

            for (var i = 0; i < count; i++) {
                var position = dat.BaseStream.Position;

                if (position + structSize > dat.BaseStream.Length) {
                    throw new IOException("Malformed file. Entry count goes past the end of the file.");
                }

                var buff = dat.ReadBytes((int) structSize);

                object obj;
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (targetFileType.Is(typeof(IWeapon))) {
                    obj = Activator.CreateInstance(targetFileType, buff, (ulong) position, weaponFilename);
                } else {
                    obj = Activator.CreateInstance(targetFileType, buff, (ulong) position);
                }

                if (obj == null) return;

                items.Add(obj);
            }
        }

        private void ReadStructsAsUnknownLength(BinaryReader dat, uint structSize, ulong offset, string weaponFilename) {
            var len = (ulong) dat.BaseStream.Length;
            do {
                var buff = new byte[structSize];
                dat.BaseStream.Seek((long) offset, SeekOrigin.Begin);
                dat.Read(buff, 0, (int) structSize);

                object obj;
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (targetFileType.Is(typeof(IWeapon))) {
                    obj = Activator.CreateInstance(targetFileType, buff, offset, weaponFilename);
                } else {
                    obj = Activator.CreateInstance(targetFileType, buff, offset);
                }

                if (obj == null) return;

                items.Add(obj);

                offset += structSize;
            } while (offset + structSize <= len);
        }

        public static bool SaveFile([NotNull] string targetFile, [NotNull] Type targetFileType, [NotNull] ObservableCollection<dynamic> items) {
            return new SaveLoad(targetFile, targetFileType, items).SaveFile();
        }

        private bool SaveFile() {
            bool changesSaved;
            var  encryptionKey = (string) targetFileType.GetField(nameof(Armor.EncryptionKey), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).GetValue(null);

            using var dat = GetFileStream(encryptionKey);

            // Save as normal. Leave base stream OPEN.
            using (var writer = new BinaryWriter(dat, Encoding.Default, true)) {
                changesSaved = WriteChanges(writer);
            }

            if (encryptionKey != null) {
                // If there are no changes, then we don't need to write the result back out.
                if (changesSaved) {
                    // Re-encrypt and write it back out.
                    File.WriteAllBytes(targetFile, EncryptionHelper.Encrypt(encryptionKey, ((MemoryStream) dat).ToArray()));
                }
            }

            return changesSaved;
        }

        private bool WriteChanges(BinaryWriter dat) {
            var changesSaved = false;

            foreach (MhwItem item in items) {
                if (item.changed.Count == 0) continue;

                dat.BaseStream.Seek((long) item.Offset, SeekOrigin.Begin);
                dat.Write(item.Bytes);

                item.changed.Clear();
                changesSaved = true;
            }

            return changesSaved;
        }

        private Stream GetFileStream([CanBeNull] string encryptionKey) {
            if (encryptionKey != null) {
                // Read & decrypt file.
                var encryptedBytes = File.ReadAllBytes(targetFile);
                return EncryptionHelper.DecryptToStream(encryptionKey, encryptedBytes);
            } else {
                // No encryption, just open stream as normal.
                return new FileStream(targetFile, FileMode.Open, FileAccess.ReadWrite);
            }
        }
    }
}