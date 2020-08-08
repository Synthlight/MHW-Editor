﻿using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Armors;
using MHW_Template.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Structs.Items {
    public partial class EqCrt : MhwSingleStructFile<EqCrt, EqCrt.Entries> {
        public partial class Entries : IHasArmorType, IHasWeaponType {
            // Armor
            [SortOrder(Equipment_Category_Raw_sortIndex)]
            [DisplayName("Equipment Category")]
            [IsReadOnly]
            public ArmorType Equipment_Category_Armor {
                get => (ArmorType) Equipment_Category_Raw;
                set => Equipment_Category_Raw = (byte) value;
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
                    }
                    else
                    {
                        return DataHelper.armorIndexNameLookup[Equipment_Category_Armor][MainWindow.locale].TryGet(Equipment_Index_Armor).ToStringWithId(Equipment_Index_Armor);
                    }
                }
            }

            public ArmorType GetArmorType() {
                return Equipment_Category_Armor;
            }

            // Charm
            [SortOrder(Equipment_Category_Raw_sortIndex)]
            [DisplayName("Equipment Category")]
            [IsReadOnly]
            public CharmType Equipment_Category_Charm {
                get => (CharmType) Equipment_Category_Raw;
                set => Equipment_Category_Raw = (byte) value;
            }

            [SortOrder(Equipment_Index_Raw_sortIndex)]
            [DisplayName("Equipment Id")]
            [IsReadOnly]
            public ushort Equipment_Id_Charm {
                get => Equipment_Index_Raw;
                set => Equipment_Index_Raw = value;
            }

            [DisplayName("Name")]
            public string Name_Charm => DataHelper.pendantNames[MainWindow.locale].TryGet(Equipment_Index_Raw);

            // Palico
            [SortOrder(Equipment_Category_Raw_sortIndex)]
            [DisplayName("Equipment Category")]
            [IsReadOnly]
            public PalicoEquipType Equipment_Category_Palico {
                get => (PalicoEquipType) Equipment_Category_Raw;
                set => Equipment_Category_Raw = (byte) value;
            }

            [SortOrder(Equipment_Index_Raw_sortIndex)]
            [DisplayName("Equipment Id")]
            [IsReadOnly]
            public ushort Equipment_Id_Palico {
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
            var isArmor  = mainWindow.Title.StartsWith("armor");
            var isCharm  = mainWindow.Title.StartsWith("charm");
            var isPalico = mainWindow.Title.StartsWith("ot_equip");
            var isWeapon = mainWindow.Title.StartsWith("weapon");

            switch (propertyName) {
                case nameof(Entries.Equipment_Category_Armor):
                case nameof(Entries.Equipment_Index_Armor):
                case nameof(Entries.Equipment_Index_Armor_button):
                    return !isArmor;
                case nameof(Entries.Equipment_Category_Charm):
                case nameof(Entries.Equipment_Id_Charm):
                case nameof(Entries.Name_Charm):
                    return !isCharm;
                case nameof(Entries.Equipment_Category_Palico):
                case nameof(Entries.Equipment_Id_Palico):
                    return !isPalico;
                case nameof(Entries.Equipment_Category_Weapon):
                case nameof(Entries.Equipment_Index_Weapon):
                case nameof(Entries.Equipment_Index_Weapon_button):
                    return !isWeapon;
                default: return false;
            }
        }
    }
}