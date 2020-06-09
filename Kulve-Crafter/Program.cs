using System;
using System.Collections.Generic;
using System.IO;
using MHW_Editor.Assets;
using MHW_Editor.Items;
using MHW_Template.Armors;
using MHW_Template.Weapons;

namespace Kulve_Crafter {
    public static class Program {
        private const string SOURCE_FILE_EQ_CUS_BASE = @"V:\MHW\IB\chunk_combined\common\equip\weapon.eq_cus";
        private const string TARGET_FILE_EQ_CUS_BASE = @"C:\SteamLibrary\common\Monster Hunter World\nativePC\common\equip\weapon.eq_cus";
        private const string SOURCE_FILE_EQ_CRT_BASE = @"V:\MHW\IB\chunk_combined\common\equip\weapon.eq_crt";
        private const string TARGET_FILE_EQ_CRT_BASE = @"C:\SteamLibrary\common\Monster Hunter World\nativePC\common\equip\weapon.eq_crt";

        [STAThread]
        public static void Main() {
            GoEqCus();
            GoEqCrt();
        }

        private static bool IsValid(KeyValuePair<uint, string> kvp) {
            var valid = (kvp.Value.Contains("Taroth") || kvp.Value.Contains("Kjárr") || kvp.Value.Contains("Gold"))
                        && kvp.Key < 200
                        && kvp.Value != "Demonlord Goldrod"
                        && kvp.Value != "Gold Chordmaker"
                        && kvp.Value != "Golden Crescent";
            return !valid;
        }

        public static void GoEqCus() {
            File.Copy(SOURCE_FILE_EQ_CUS_BASE, TARGET_FILE_EQ_CUS_BASE, true);

            var instance = EqCus.LoadData(TARGET_FILE_EQ_CUS_BASE);
            var items    = instance.GetStructList();

            foreach (WeaponType weaponType in Enum.GetValues(typeof(WeaponType))) {
                var           i       = (ushort) items.Count;
                EqCus.Entries newItem = null;

                foreach (var kvp in DataHelper.weaponIndexNameLookup[weaponType]["eng"]) {
                    if (IsValid(kvp)) continue;

                    newItem = new EqCus.Entries {
                        Equipment_Category_Weapon = weaponType,
                        Equipment_Index_Weapon    = (ushort) kvp.Key,
                        Monster_Unlock            = -1,
                        Story_Unlock              = 1,
                        Needed_Item_Id_to_Unlock  = 888,
                        Mat_1_Id                  = 888,
                        Mat_1_Count               = 1,
                        Unk_2                     = 1,
                        Child_index_1             = ++i,
                        Item_Rank                 = CharmRankType.High_Rank
                    };
                    items.Add(newItem);
                }

                if (newItem != null) newItem.Child_index_1 = 0;
            }

            instance.SaveFile(TARGET_FILE_EQ_CUS_BASE);
        }

        public static void GoEqCrt() {
            File.Copy(SOURCE_FILE_EQ_CRT_BASE, TARGET_FILE_EQ_CRT_BASE, true);

            var instance = EqCrt.LoadData(TARGET_FILE_EQ_CRT_BASE);
            var items    = instance.GetStructList();

            foreach (WeaponType weaponType in Enum.GetValues(typeof(WeaponType))) {
                foreach (var kvp in DataHelper.weaponIndexNameLookup[weaponType]["eng"]) {
                    if (IsValid(kvp)) continue;

                    var newItem = new EqCrt.Entries {
                        Equipment_Category_Weapon = weaponType,
                        Equipment_Index_Weapon    = (ushort) kvp.Key,
                        Monster_Unlock            = -1,
                        Story_Unlock              = 1,
                        Needed_Item_Id_to_Unlock  = 888,
                        Mat_1_Id                  = 888,
                        Mat_1_Count               = 1,
                        Unknown_uint8_2           = 1,
                        Item_Rank                 = CharmRankType.High_Rank
                    };
                    items.Add(newItem);
                }
            }

            instance.SaveFile(TARGET_FILE_EQ_CRT_BASE);
        }
    }
}