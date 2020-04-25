using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using MHW_Template.Armors;
using MHW_Template.Items;
using MHW_Template.Weapons;

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

        public static bool Is(this Type source, params Type[] types) {
            return types.Any(type => type.IsAssignableFrom(source));
        }

        public static T[] Subsequence<T>(this IEnumerable<T> arr, int startIndex, int length) {
            return arr.Skip(startIndex).Take(length).ToArray();
        }

        public static bool ContainsIgnoreCase(this IEnumerable<string> arr, string needle) {
            return arr.Any(s => string.Equals(s, needle, StringComparison.CurrentCultureIgnoreCase));
        }

        public static V TryGet<K, V>(this IDictionary<K, V> dict, K key, V defaultValue) {
            if (dict == null) return defaultValue;
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }

        public static string TryGet<K>(this IDictionary<K, string> dict, K key, string defaultValue = "Unknown") {
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

        public static string SHA512(this string fileName) {
            using (var file = File.OpenRead(fileName)) {
                return file.SHA512();
            }
        }

        public static string SHA512(this Stream stream) {
            using (var sha512 = System.Security.Cryptography.SHA512.Create()) {
                var hash = sha512.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        public static string SHA512(this byte[] bytes) {
            using (var sha512 = System.Security.Cryptography.SHA512.Create()) {
                var hash = sha512.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        public static Dictionary<K, V> Sort<K, V, O>(this Dictionary<K, V> dict, Func<KeyValuePair<K, V>, O> keySelector) {
            return dict.OrderBy(keySelector)
                       .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public static Dictionary<K, V> SortDescending<K, V, O>(this Dictionary<K, V> dict, Func<KeyValuePair<K, V>, O> keySelector) {
            return dict.OrderByDescending(keySelector)
                       .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public static Dictionary<K2, V> GetOrCreate<K1, K2, V>(this Dictionary<K1, Dictionary<K2, V>> dict, K1 key) {
            if (dict.ContainsKey(key)) return dict[key];
            dict[key] = new Dictionary<K2, V>();
            return dict[key];
        }

        public static List<V> GetOrCreate<K, V>(this Dictionary<K, List<V>> dict, K key) {
            if (dict.ContainsKey(key)) return dict[key];
            dict[key] = new List<V>();
            return dict[key];
        }

        public static string ToDatFileName(this WeaponType weaponType) {
            switch (weaponType) {
                case WeaponType.Greatsword: return "l_sword.wp_dat";
                case WeaponType.Sword_and_Shield: return "sword.wp_dat";
                case WeaponType.Dual_Blades: return "w_sword.wp_dat";
                case WeaponType.Longsword: return "tachi.wp_dat";
                case WeaponType.Hammer: return "hammer.wp_dat";
                case WeaponType.Hunting_Horn: return "whistle.wp_dat";
                case WeaponType.Lance: return "lance.wp_dat";
                case WeaponType.Gunlance: return "g_lance.wp_dat";
                case WeaponType.Switch_Axe: return "s_axe.wp_dat";
                case WeaponType.Charge_Blade: return "c_axe.wp_dat";
                case WeaponType.Insect_Glaive: return "rod.wp_dat";
                case WeaponType.Bow: return "bow.wp_dat_g";
                case WeaponType.Light_Bowgun: return "lbg.wp_dat_g";
                case WeaponType.Heavy_Bowgun: return "hbg.wp_dat_g";
                default: return null;
            }
        }

        public static string ToDatFileName(this EquipmentType equipmentType) {
            switch (equipmentType) {
                case EquipmentType.Greatsword: return "l_sword.wp_dat";
                case EquipmentType.Sword_and_Shield: return "sword.wp_dat";
                case EquipmentType.Dual_Blades: return "w_sword.wp_dat";
                case EquipmentType.Longsword: return "tachi.wp_dat";
                case EquipmentType.Hammer: return "hammer.wp_dat";
                case EquipmentType.Hunting_Horn: return "whistle.wp_dat";
                case EquipmentType.Lance: return "lance.wp_dat";
                case EquipmentType.Gunlance: return "g_lance.wp_dat";
                case EquipmentType.Switch_Axe: return "s_axe.wp_dat";
                case EquipmentType.Charge_Blade: return "c_axe.wp_dat";
                case EquipmentType.Insect_Glaive: return "rod.wp_dat";
                case EquipmentType.Bow: return "bow.wp_dat_g";
                case EquipmentType.Light_Bowgun: return "lbg.wp_dat_g";
                case EquipmentType.Heavy_Bowgun: return "hbg.wp_dat_g";
                case EquipmentType.Armor_Head:
                case EquipmentType.Armor_Chest:
                case EquipmentType.Armor_Arms:
                case EquipmentType.Armor_Waist:
                case EquipmentType.Armor_Legs:
                case EquipmentType.Armor_Charm:
                    return "armor.am_dat";
                default: return null;
            }
        }

        public static string ToDatFileName(this ArmorType armorType) {
            switch (armorType) {
                case ArmorType.Head:
                case ArmorType.Chest:
                case ArmorType.Arms:
                case ArmorType.Waist:
                case ArmorType.Legs:
                case ArmorType.Charm:
                    return "armor.am_dat";
                default: return null;
            }
        }
    }
}