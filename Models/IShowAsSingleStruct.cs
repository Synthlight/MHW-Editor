using System;

namespace MHW_Editor.Models {
    public interface IShowAsSingleStruct {
        public Type GetSingleStructType();
    }

    public interface IShowAsSingleStruct<T> : IShowAsSingleStruct where T : IMhwStructItem {
        public ObservableMhwStructCollection<T> GetSingleStructList();
    }
}