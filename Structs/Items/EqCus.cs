using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Armors;
using MHW_Template.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Structs.Items {
    public partial class EqCus : MhwSingleStructFile<EqCus, EqCus.Entries> {
        public partial class Entries : IHasArmorType, IHasWeaponType {
            // Armor
            [SortOrder(Equipment_Category_Raw_sortIndex)]
            [DisplayName("Equipment Category")]
            [IsReadOnly]
            public ArmorType Equipment_Category_Armor {
                get => (ArmorType)Equipment_Category_Raw;
                set => Equipment_Category_Raw = (byte)value;
            }

            [SortOrder(Equipment_Index_Raw_sortIndex)]
            [DisplayName("Equipment Index")]
            [DataSource(DataSourceType.ArmorByIndex)]
            [IsReadOnly]
            public ushort Equipment_Index_Armor {
                get => Equipment_Index_Raw;
                set => Equipment_Index_Raw = value;
            }

            [SortOrder(Equipment_Index_Raw_sortIndex)]
            [DisplayName("Equipment Index")]
            [CustomSorter(typeof(ButtonSorter))]
            public string Equipment_Index_Armor_button {
                get
                {
                    if (!MainWindow.file_name.StartsWith("armor"))
                    {
                        return string.Empty;
                    } else
                    {
                        return DataHelper.armorIndexNameLookup[Equipment_Category_Armor][MainWindow.locale].TryGet(Equipment_Index_Armor).ToStringWithId(Equipment_Index_Armor);
                    }
                }
            }

            public ArmorType GetArmorType() {
                return Equipment_Category_Armor;
            }

            // Misc
            [SortOrder(Equipment_Category_Raw_sortIndex)]
            [DisplayName("Equipment Category")]
            [IsReadOnly]
            public byte Equipment_Category_Misc {
                get => Equipment_Category_Raw;
                set => Equipment_Category_Raw = value;
            }

            [SortOrder(Equipment_Index_Raw_sortIndex)]
            [DisplayName("Equipment Id")]
            [IsReadOnly]
            public ushort Equipment_Id_Misc {
                get => Equipment_Index_Raw;
                set => Equipment_Index_Raw = value;
            }

            // Weapon
            [SortOrder(Equipment_Category_Raw_sortIndex)]
            [DisplayName("Equipment Category")]
            [IsReadOnly]
            public WeaponType Equipment_Category_Weapon {
                get => (WeaponType) Equipment_Category_Raw;
                set => Equipment_Category_Raw = (byte) value;
            }

            [SortOrder(Equipment_Index_Raw_sortIndex)]
            [DisplayName("Equipment Index")]
            [DataSource(DataSourceType.WeaponsByIndex)]
            [IsReadOnly]
            public ushort Equipment_Index_Weapon {
                get => Equipment_Index_Raw;
                set => Equipment_Index_Raw = value;
            }

            [SortOrder(Equipment_Index_Raw_sortIndex)]
            [DisplayName("Equipment Index")]
            [CustomSorter(typeof(ButtonSorter))]
            public string Equipment_Index_Weapon_button {
                get
                {
                    if (!MainWindow.file_name.StartsWith("weapon"))
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return DataHelper.weaponIndexNameLookup[Equipment_Category_Weapon][MainWindow.locale].TryGet(Equipment_Index_Weapon).ToStringWithId(Equipment_Index_Weapon);
                    }
                }
            }

            public WeaponType GetWeaponType() {
                return Equipment_Category_Weapon;
            }
        }

        public static bool ShouldCancel(string propertyName, MainWindow mainWindow) {
            var isArmor  = mainWindow.Title.StartsWith("equip_custom"); // Armor
            var isMisc   = mainWindow.Title.StartsWith("insect_element") || mainWindow.Title.StartsWith("insect"); // Misc
            var isWeapon = mainWindow.Title.StartsWith("weapon");

            switch (propertyName) {
                case nameof(Entries.Equipment_Category_Armor):
                case nameof(Entries.Equipment_Index_Armor):
                case nameof(Entries.Equipment_Index_Armor_button):
                    return !isArmor;
                case nameof(Entries.Equipment_Category_Misc):
                case nameof(Entries.Equipment_Id_Misc):
                    return !isMisc;
                case nameof(Entries.Equipment_Category_Weapon):
                case nameof(Entries.Equipment_Index_Weapon):
                case nameof(Entries.Equipment_Index_Weapon_button):
                    return !isWeapon;
                default: return false;
            }
        }
    }
}