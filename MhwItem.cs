using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace MHW_Weapon_Editor {
    public abstract class MhwItem : IMhwItem {
        public byte[] Bytes { get; private set; }
        public int Offset { get; private set; }

        public abstract string Name { get; }

        protected MhwItem(byte[] bytes, int offset) {
            Bytes = bytes;
            Offset = offset;
        }

        protected byte GetData(int offset) {
            return Bytes[offset];
        }

        protected sbyte GetSData(int offset) {
            unchecked {
                return (sbyte) Bytes[offset];
            }
        }

        protected void SetData(int offset, byte value) {
            Bytes[offset] = value;
        }

        protected void SetData(int offset, sbyte value) {
            unchecked {
                Bytes[offset] = (byte) value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}