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

        public static bool IsSigned(this Type type) {
            // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
            return Type.GetTypeCode(type) switch {
                TypeCode.Byte => false,
                TypeCode.UInt16 => false,
                TypeCode.UInt32 => false,
                TypeCode.UInt64 => false,
                TypeCode.SByte => true,
                TypeCode.Int16 => true,
                TypeCode.Int32 => true,
                TypeCode.Int64 => true,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static string ToStringWithId<T>(this string name, T id) where T : struct {
            return MainWindow.showIdBeforeName ? $"{id}: {name}" : $"{name}: {id}";
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