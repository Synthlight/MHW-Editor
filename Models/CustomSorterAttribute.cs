using System;

namespace MHW_Editor.Models {
    public class CustomSorterAttribute : Attribute {
        public readonly Type customSorterType;
        public readonly bool needsPropertyName;

        public CustomSorterAttribute(Type customSorterType, bool needsPropertyName = false) {
            this.customSorterType = customSorterType;
            this.needsPropertyName = needsPropertyName;
        }
    }
}