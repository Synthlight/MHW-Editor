using System;
using System.ComponentModel;
using System.Reflection;

namespace MHW_Editor.Models {
    public class UInt16Sorter : ICustomSorterWithPropertyName {
        public ListSortDirection SortDirection { get; set; } = ListSortDirection.Ascending;
        public string PropertyName { get; set; }

        public int Compare(object x, object y) {
            var propXValue = x?.GetType().GetProperty(PropertyName.Replace("_button", ""), BindingFlags.Public | BindingFlags.Instance)?.GetValue(x);
            var propYValue = y?.GetType().GetProperty(PropertyName.Replace("_button", ""), BindingFlags.Public | BindingFlags.Instance)?.GetValue(y);

            if (propXValue == null || propYValue == null) return 0;

            var uShort1 = (ushort) Convert.ChangeType(propXValue, TypeCode.UInt16);
            var uShort2 = (ushort) Convert.ChangeType(propYValue, TypeCode.UInt16);
            return uShort1.CompareTo(uShort2) * (SortDirection == ListSortDirection.Ascending ? 1 : -1);
        }
    }
}