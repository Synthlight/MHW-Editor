using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Controls;
using JetBrains.Annotations;
using MHW_Editor.Util;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Models {
    public interface IMhwMultiStructFile {
        LinkedList<MhwStructDataContainer> data { get; }

        void                             SetupViews(Grid grid, MainWindow main);
        ObservableMhwStructCollection<F> GetStructList<F>() where F : class, IMhwStructItem, IWriteData;
        IEnumerable<F>                   GetAllEnumerableOfType<F>();
    }

    public abstract class MhwMultiStructFile<T> : SaveLoad<T>, ISaveLoad, IMhwMultiStructFile where T : ISaveLoad, IMhwMultiStructFile, new() {
        public LinkedList<MhwStructDataContainer> data { get; protected set; }

        public abstract string EncryptionKey { get; }

        [UsedImplicitly]
        public static void SetupViews(T instance, Grid grid, MainWindow main) {
            instance.SetupViews(grid, main);
        }

        public virtual void SetupViews(Grid grid, MainWindow main) {
            foreach (var entry in data) {
                entry.SetupView(grid, main);
            }
        }

        public ObservableMhwStructCollection<F> GetStructList<F>() where F : class, IMhwStructItem, IWriteData {
            foreach (var container in data) {
                if (container is MhwStructDataContainer<F> aaa) {
                    return aaa.list;
                }
            }
            throw new InvalidOperationException("GetSingleStructList can't find the requested type.");
        }

        public IEnumerable<F> GetAllEnumerableOfType<F>() {
            foreach (var container in data) {
                if (container.type.Is(typeof(F)) || container.type.IsGeneric(typeof(F))) {
                    foreach (var item in container.GetEnumerable<F>()) {
                        yield return item;
                    }
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
                try {
                    entry.WriteData(writer);
                } catch (Exception e) {
                    Console.Error.Write($"Save Error: {e}");
                }
            }

            // Only pad for encrypted files.
            if (EncryptionKey != null) {
                const int paddingBlockSize = 16;
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