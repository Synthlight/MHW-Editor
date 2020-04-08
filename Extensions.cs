using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MHW_Editor.Weapons;
using MHW_Template;
using MHW_Template.Weapons;

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

        public static void AddControl(this Grid grid, UIElement control) {
            var rowDefinition = new RowDefinition {Height = GridLength.Auto};
            grid.RowDefinitions.Add(rowDefinition);
            Grid.SetRow(control, grid.RowDefinitions.Count - 1);
            grid.Children.Add(control);
        }

        public static T GetDataAs<T>(this IEnumerable<byte> bytes) {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);

            try {
                return (T) Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            } finally {
                if (handle.IsAllocated) {
                    handle.Free();
                }
            }
        }

        public static byte[] GetBytes<T>(this T @struct) {
            var size = Marshal.SizeOf(@struct);
            var bytes = new byte[size];
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);

            try {
                Marshal.StructureToPtr(@struct, handle.AddrOfPinnedObject(), false);
                return bytes;
            } finally {
                if (handle.IsAllocated) {
                    handle.Free();
                }
            }
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

        public static Type ToClassType(this WeaponType weaponType) {
            switch (weaponType) {
                case WeaponType.Greatsword:
                case WeaponType.Sword_and_Shield:
                case WeaponType.Dual_Blades:
                case WeaponType.Longsword:
                case WeaponType.Hammer:
                case WeaponType.Hunting_Horn:
                case WeaponType.Lance:
                case WeaponType.Gunlance:
                case WeaponType.Switch_Axe:
                case WeaponType.Charge_Blade:
                case WeaponType.Insect_Glaive:
                    return typeof(Melee);
                case WeaponType.Bow: return typeof(Bow);
                case WeaponType.Light_Bowgun:
                case WeaponType.Heavy_Bowgun:
                    return typeof(BowGun);
                default: return null;
            }
        }

        public static Type ToClassType(this WeaponTypeOnlyWeapons weaponType) {
            return ((WeaponType) weaponType).ToClassType();
        }

        public static string ReadNullTermString(this BinaryReader reader) {
            var stringBytes = new List<byte>();
            do {
                stringBytes.Add(reader.ReadByte());
            } while (stringBytes[stringBytes.Count - 1] != 0);

            return Encoding.UTF8.GetString(stringBytes.Subsequence(0, stringBytes.Count).ToArray());
        }
    }
}