using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public abstract class CustomSaveLoad<T> where T : ICustomSaveLoad, new() {
        [UsedImplicitly]
        public static T LoadData(string targetFile) {
            var instance = new T();
            instance.LoadFile(targetFile);
            return instance;
        }

        [UsedImplicitly]
        public static void SaveData(T instance, string targetFile) {
            instance.SaveFile(targetFile);
        }
    }
}