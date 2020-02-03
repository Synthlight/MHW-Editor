using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace MHW_Template {
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

        public static V TryGet<K, V>(this IDictionary<K, V> dict, K key, V defaultValue) {
            if (dict == null) return defaultValue;
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }

        public static T GetData<T>(this IEnumerable<byte> bytes) where T : struct {
            return bytes.GetData<T>(0, Marshal.SizeOf(default(T)));
        }

        public static T GetData<T>(this IEnumerable<byte> bytes, int offset) where T : struct {
            return bytes.GetData<T>(offset, Marshal.SizeOf(default(T)));
        }

        public static T GetData<T>(this IEnumerable<byte> bytes, int offset, int size) where T : struct {
            var subsequence = bytes.Subsequence(offset, size);
            var handle = GCHandle.Alloc(subsequence, GCHandleType.Pinned);

            try {
                var rawDataPtr = handle.AddrOfPinnedObject();
                return (T) Marshal.PtrToStructure(rawDataPtr, typeof(T));
            } finally {
                handle.Free();
            }
        }
    }
}