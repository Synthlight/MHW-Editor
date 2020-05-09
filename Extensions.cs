using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MHW_Editor.Armors;
using MHW_Editor.Weapons;
using MHW_Template;
using MHW_Template.Armors;
using MHW_Template.Items;
using MHW_Template.Weapons;

namespace MHW_Editor {
    public static class Extensions {
        public static DataGridColumn FindColumn(this IEnumerable<DataGridColumn> list, string name) {
            return list.FirstOrDefault(x => x.Header.ToString() == name);
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
            var size   = Marshal.SizeOf(@struct);
            var bytes  = new byte[size];
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
                default: throw new ArgumentOutOfRangeException(nameof(weaponType), weaponType, null);
            }
        }

        public static Type ToClassType(this EquipmentType equipmentType) {
            switch (equipmentType) {
                case EquipmentType.Greatsword:
                case EquipmentType.Sword_and_Shield:
                case EquipmentType.Dual_Blades:
                case EquipmentType.Longsword:
                case EquipmentType.Hammer:
                case EquipmentType.Hunting_Horn:
                case EquipmentType.Lance:
                case EquipmentType.Gunlance:
                case EquipmentType.Switch_Axe:
                case EquipmentType.Charge_Blade:
                case EquipmentType.Insect_Glaive:
                    return typeof(Melee);
                case EquipmentType.Bow: return typeof(Bow);
                case EquipmentType.Light_Bowgun:
                case EquipmentType.Heavy_Bowgun:
                    return typeof(BowGun);
                case EquipmentType.Armor_Head:
                case EquipmentType.Armor_Chest:
                case EquipmentType.Armor_Arms:
                case EquipmentType.Armor_Waist:
                case EquipmentType.Armor_Legs:
                case EquipmentType.Armor_Charm:
                    return typeof(Armor);
                default: throw new ArgumentOutOfRangeException(nameof(equipmentType), equipmentType, null);
            }
        }

        public static Type ToClassType(this ArmorType armorType) {
            switch (armorType) {
                case ArmorType.Head:
                case ArmorType.Chest:
                case ArmorType.Arms:
                case ArmorType.Waist:
                case ArmorType.Legs:
                case ArmorType.Charm:
                    return typeof(Armor);
                default: throw new ArgumentOutOfRangeException(nameof(armorType), armorType, null);
            }
        }

        public static EquipmentType ToEquipmentType(this WeaponType weaponType) {
            return weaponType switch {
                WeaponType.Greatsword => EquipmentType.Greatsword,
                WeaponType.Sword_and_Shield => EquipmentType.Sword_and_Shield,
                WeaponType.Dual_Blades => EquipmentType.Dual_Blades,
                WeaponType.Longsword => EquipmentType.Longsword,
                WeaponType.Hammer => EquipmentType.Hammer,
                WeaponType.Hunting_Horn => EquipmentType.Hunting_Horn,
                WeaponType.Lance => EquipmentType.Lance,
                WeaponType.Gunlance => EquipmentType.Gunlance,
                WeaponType.Switch_Axe => EquipmentType.Switch_Axe,
                WeaponType.Charge_Blade => EquipmentType.Charge_Blade,
                WeaponType.Insect_Glaive => EquipmentType.Insect_Glaive,
                WeaponType.Bow => EquipmentType.Bow,
                WeaponType.Light_Bowgun => EquipmentType.Light_Bowgun,
                WeaponType.Heavy_Bowgun => EquipmentType.Heavy_Bowgun,
                _ => throw new ArgumentOutOfRangeException(nameof(weaponType), weaponType, null)
            };
        }

        public static EquipmentType ToEquipmentType(this ArmorType armorType) {
            return armorType switch {
                ArmorType.Head => EquipmentType.Armor_Head,
                ArmorType.Chest => EquipmentType.Armor_Chest,
                ArmorType.Arms => EquipmentType.Armor_Arms,
                ArmorType.Waist => EquipmentType.Armor_Waist,
                ArmorType.Legs => EquipmentType.Armor_Legs,
                ArmorType.Charm => EquipmentType.Armor_Charm,
                _ => throw new ArgumentOutOfRangeException(nameof(armorType), armorType, null)
            };
        }

        public static string ReadNullTermString(this BinaryReader reader) {
            var stringBytes = new List<byte>();
            do {
                stringBytes.Add(reader.ReadByte());
            } while (stringBytes[stringBytes.Count - 1] != 0);

            return Encoding.UTF8.GetString(stringBytes.Subsequence(0, stringBytes.Count).ToArray());
        }

        public static char[] ToNullTermCharArray(this string str) {
            str ??= "\0";
            if (!str.EndsWith("\0")) str += "\0";
            return str.ToCharArray();
        }

        public static List<byte> ReadRemainderAsByteArray(this BinaryReader reader) {
            var list = new List<byte>();
            while (reader.BaseStream.Position < reader.BaseStream.Length) {
                list.Add(reader.ReadByte());
            }
            return list;
        }
    }
}