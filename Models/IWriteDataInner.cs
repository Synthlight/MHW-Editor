using System.IO;

namespace MHW_Editor.Models {
    public interface IWriteDataInner<in T> {
        public void WriteData(BinaryWriter writer, T parent);
    }
}