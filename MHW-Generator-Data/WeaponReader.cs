using System;
using System.Collections.Generic;
using System.IO;
using MHW_Editor;
using MHW_Editor.Assets;
using MHW_Editor.Structs.Weapons;
using MHW_Template;
using MHW_Template.Weapons;

namespace MHW_Generator_Data {
    public static class WeaponReader {
        private const string TARGET_FILE_BASE = @"V:\MHW\IB\chunk_combined\common\equip";

        public static Dictionary<WeaponType, LangMap> GetAllWeapons(IndexOrId by) {
            var values      = new Dictionary<WeaponType, LangMap>();
            var weaponTypes = (WeaponType[]) Enum.GetValues(typeof(WeaponType));

            foreach (var weaponType in weaponTypes) {
                var datFileName = weaponType.ToDatFileName();
                values[weaponType] = GetWeaponsOfType($@"{TARGET_FILE_BASE}\{datFileName}", weaponType, by);
            }

            return values;
        }

        public static LangMap GetWeaponsOfType(string targetFile, WeaponType weaponType, IndexOrId by) {
            var weaponClassType = weaponType.ToClassType();
            var weaponTypeName  = Path.GetFileNameWithoutExtension(weaponType.ToDatFileName());
            var values          = new LangMap();

            IEnumerable<IWeapon> weapons;

            if (weaponClassType == typeof(Melee)) {
                weapons = Melee.LoadData(targetFile).GetSingleStructList();
            } else if (weaponClassType == typeof(Ranged)) {
                weapons = Ranged.LoadData(targetFile).GetSingleStructList();
            } else {
                throw new InvalidOperationException($"Unrecognized weapon type: {weaponClassType.Name}");
            }

            foreach (var weapon in weapons) {
                foreach (var lang in Global.LANGUAGES) {
                    if (!values.ContainsKey(lang)) values[lang] = new Dictionary<uint, string>();

                    values[lang][(uint) (by == IndexOrId.Id ? weapon.Id : weapon.Index)] = DataHelper.weaponData[lang][weaponTypeName ?? throw new InvalidOperationException()][weapon.GMD_Name_Index];
                }
            }

            return values;
        }
    }
}