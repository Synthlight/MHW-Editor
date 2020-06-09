using System.IO;

namespace MHW_Editor.Models {
    public interface IWriteData {
        public void WriteData(BinaryWriter writer);
    }
}