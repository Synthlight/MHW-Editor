using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using JetBrains.Annotations;

namespace MHW_Editor {
    public static class Extensions {
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T> {
            if (val.CompareTo(min) < 0) {
                return min;
            } else if (val.CompareTo(max) > 0) {
                return max;
            } else {
                return val;
            }
        }

        public static T[] Subsequence<T>(this IEnumerable<T> arr, int startIndex, int length) {
            return arr.Skip(startIndex).Take(length).ToArray();
        }

        public static V TryGet<K, V>(this Dictionary<K, V> dict, K key, V defaultValue) {
            if (dict == null) return defaultValue;
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }

        public static DataGridColumn FindColumn(this IEnumerable<DataGridColumn> list, string name) {
            return list.FirstOrDefault(x => x.Header.ToString() == name);
        }
    }
}