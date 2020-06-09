namespace MHW_Editor.Models {
    public interface ISaveLoad {
        string EncryptionKey { get; }
        void   LoadFile(string targetFile);
        void   SaveFile(string targetFile);
    }
}