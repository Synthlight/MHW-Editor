using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MHW_Editor {
    public static class Extensions {
        public static DataGridColumn FindColumn(this IEnumerable<DataGridColumn> list, string name) {
            return list.FirstOrDefault(x => x.Header.ToString() == name);
        }

        public static bool Is(this Type source, params Type[] types) {
            return types.Any(type => type.IsAssignableFrom(source));
        }

        public static bool IsGeneric(this Type source, Type genericType) {
            while (source != null && source != typeof(object)) {
                var cur = source.IsGenericType ? source.GetGenericTypeDefinition() : source;
                if (genericType == cur) {
                    return true;
                }

                if (source.GetInterfaces().Any(@interface => @interface.IsGeneric(genericType))) return true;

                source = source.BaseType;
            }

            return false;
        }

        public static Visibility VisibleIfTrue(this bool b) {
            return b ? Visibility.Visible : Visibility.Collapsed;
        }

        public static T GetParent<T>(this DependencyObject d) where T : class {
            while (d != null && !(d is T)) {
                d = VisualTreeHelper.GetParent(d);
            }

            return d as T;
        }
    }
}