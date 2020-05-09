namespace MHW_Editor.Models {
    public interface ICustomSaveLoad {
        string EncryptionKey { get; }
        void LoadFile(string targetFile);
        void SaveFile(string targetFile);
    }
}