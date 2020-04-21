using System;
using System.Collections.Generic;

namespace MHW_Editor.Models {
    public class MhwStructWrapper {
        public readonly List<object> list;
        public readonly Type type;

        public MhwStructWrapper(List<object> list, Type type) {
            this.list = list;
            this.type = type;
        }
    }
}