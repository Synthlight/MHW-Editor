using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MHW_Editor {
    public static class Extensions {
        public static DataGridColumn FindColumn(this IEnumerable<DataGridColumn> list, string name) {
            return list.FirstOrDefault(x => x.Header.ToString() == name);
        }

        public static bool Is(this Type source, params Type[] types) {
            return types.Any(type => type.IsAssignableFrom(source));
        }

        public static Visibility VisibleIfTrue(this bool b) {
            return b ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}