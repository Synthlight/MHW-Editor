using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public abstract class MhwItem : IMhwItem {
        public byte[] Bytes { get; private set; }
        public int Offset { get; private set; }
        public abstract string Name { get; }
        public bool Changed { get; private set; }

        protected MhwItem(byte[] bytes, int offset) {
            Bytes = bytes;
            Offset = offset;
        }

        protected T GetData<T>(int offset) where T : struct {
            return GetData<T>(offset, Marshal.SizeOf(default(T)));
        }

        protected T GetData<T>(int offset, int size) where T : struct {
            var subsequence = Bytes.Subsequence(offset, size);
            var handle = GCHandle.Alloc(subsequence, GCHandleType.Pinned);

            try {
                var rawDataPtr = handle.AddrOfPinnedObject();
                return (T) Marshal.PtrToStructure(rawDataPtr, typeof(T));
            } finally {
                handle.Free();
            }
        }

        protected void SetData<T>(int offset, T value) where T : struct {
            var rawData = new byte[Marshal.SizeOf(value)];
            var handle = GCHandle.Alloc(rawData, GCHandleType.Pinned);

            try {
                var rawDataPtr = handle.AddrOfPinnedObject();
                Marshal.StructureToPtr(value, rawDataPtr, false);
            } finally {
                handle.Free();
            }

            // rawData is now a byte arr containing the value we want to save.
            // Copy rawData to the right offset in bytes.
            Array.Copy(rawData, 0, Bytes, offset, rawData.Length);

            Changed = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}