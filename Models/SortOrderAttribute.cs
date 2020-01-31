using System;

namespace MHW_Editor.Models {
    public class SortOrderAttribute : Attribute {
        public readonly int sortOrder;

        public SortOrderAttribute(int sortOrder) {
            this.sortOrder = sortOrder;
        }
    }
}