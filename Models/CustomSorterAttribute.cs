using System;

namespace MHW_Editor.Models {
    public class CustomSorterAttribute : Attribute {
        public readonly Type customSorterType;

        public CustomSorterAttribute(Type customSorterType) {
            this.customSorterType = customSorterType;
        }
    }
}