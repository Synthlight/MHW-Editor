using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using MHW_Editor;
using MHW_Editor.Armors;
using MHW_Editor.Assets;
using MHW_Editor.Weapons;
using MHW_Template;
using MHW_Template.Weapons;

namespace MHW_Generator_Data {
    public static class WeaponReader {
        private const string TARGET_FILE_BASE = @"V:\MHW\IB\chunk_combined\common\equip";

        public static Dictionary<WeaponTypeOnlyWeapons, LangMap> GetAllWeapons() {
            var values = new Dictionary<WeaponTypeOnlyWeapons, LangMap>();
            var weaponTypes = (WeaponTypeOnlyWeapons[]) Enum.GetValues(typeof(WeaponTypeOnlyWeapons));

            foreach (var weaponType in weaponTypes) {
                var datFileName = weaponType.ToDatFileName();
                values[weaponType] = GetWeaponsOfType($@"{TARGET_FILE_BASE}\{datFileName}", weaponType);
            }

            return values;
        }

        public static LangMap GetWeaponsOfType(string targetFile, WeaponTypeOnlyWeapons weaponType) {
            using var dat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read));
            dat.BaseStream.Seek(6, SeekOrigin.Begin);
            var count = dat.ReadUInt32();

            dat.BaseStream.Seek(10, SeekOrigin.Begin);

            var weaponClassType = weaponType.ToClassType();

            var weaponTypeName = Path.GetFileNameWithoutExtension(weaponType.ToDatFileName());
            // ReSharper disable once PossibleNullReferenceException
            var structSize = (uint) weaponClassType.GetField(nameof(Armor.StructSize), BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).GetValue(null);

            var values = new LangMap();

            for (var i = 0; i < count; i++) {
                var position = dat.BaseStream.Position;
                var buff = dat.ReadBytes((int) structSize);

                var weapon = (IWeapon) Activator.CreateInstance(weaponClassType, buff, (ulong) position, "");

                foreach (var lang in Global.LANGUAGES) {
                    if (!values.ContainsKey(lang)) values[lang] = new Dictionary<uint, string>();

                    values[lang][weapon.Id] = DataHelper.weaponData[lang][weaponTypeName ?? throw new InvalidOperationException()][weapon.GMD_Name_Index];
                }
            }

            return values;
        }
    }
}