using System;

namespace MHW_Editor.Models {
    public interface IShowAsSingleStruct {
        public Type                   GetSingleStructType();
        public MhwStructDataContainer GetSingleStructContainer();
    }

    public interface IShowAsSingleStruct<T> : IShowAsSingleStruct where T : IMhwStructItem {
        public ObservableMhwStructCollection<T> GetSingleStructList();
    }
}