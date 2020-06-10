using System;

namespace MHW_Editor.Models {
    public abstract class MhwSingleStructFile<T, E> : MhwMultiStructFile<T>, IShowAsSingleStruct<E> where T : ISaveLoad, IMhwMultiStructFile, new()
                                                                                                    where E : class, IMhwStructItem, IWriteData {
        public Type GetSingleStructType() {
            return typeof(E);
        }

        public ObservableMhwStructCollection<E> GetSingleStructList() {
            return GetStructList<E>();
        }

        public MhwStructDataContainer GetSingleStructContainer() {
            return GetStructContainer<E>();
        }
    }
}