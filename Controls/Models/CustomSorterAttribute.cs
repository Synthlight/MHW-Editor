using System;

namespace MHW_Editor.Controls.Models {
    public class CustomSorterAttribute : Attribute {
        public readonly Type customSorterType;

        public CustomSorterAttribute(Type customSorterType) {
            this.customSorterType = customSorterType;
        }
    }
}