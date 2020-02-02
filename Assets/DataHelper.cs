using System.Collections.Generic;
using System.Text;
using MHW_Editor.Models;
using MHW_Template;
using Newtonsoft.Json;

namespace MHW_Editor.Assets {
    public static class DataHelper {
        public static readonly Dictionary<string, Dictionary<ushort, IdNamePair>> itemData = new Dictionary<string, Dictionary<ushort, IdNamePair>>();
        public static readonly Dictionary<string, Dictionary<ushort, IdNamePair>> skillData = new Dictionary<string, Dictionary<ushort, IdNamePair>>();
        public static readonly Dictionary<string, Dictionary<ushort, string>> skillDataDescriptions = new Dictionary<string, Dictionary<ushort, string>>();
        public static readonly Dictionary<string, Dictionary<ushort, string>> armorData = new Dictionary<string, Dictionary<ushort, string>>();
        public static readonly Dictionary<string, Dictionary<string, Dictionary<uint, string>>> weaponData = new Dictionary<string, Dictionary<string, Dictionary<uint, string>>>();
        public static readonly Dictionary<uint, string> dummyDict = new Dictionary<uint, string>();

        static DataHelper() {
            foreach (var lang in Global.LANGUAGES) {
                ParseItemData(lang);
                ParseSkillData(lang);

                armorData[lang] = LoadDict<ushort, string>(GetAsset($"{lang}_armorData"));

                weaponData[lang] = new Dictionary<string, Dictionary<uint, string>>();
                foreach (var weapon in Global.WEAPONS) {
                    weaponData[lang][weapon] = LoadDict<uint, string>(GetAsset($"{lang}_{weapon}"));
                }
            }
        }

        private static void ParseItemData(string lang) {
            itemData[lang] = new Dictionary<ushort, IdNamePair>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_itemData"));
            rawItemData[0] = "--------";

            const uint step = 2;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = (ushort) (index / step);
                var value = new IdNamePair(key, rawItemData[index]);

                itemData[lang][key] = value;
            }
        }

        private static void ParseSkillData(string lang) {
            skillData[lang] = new Dictionary<ushort, IdNamePair>();
            skillDataDescriptions[lang] = new Dictionary<ushort, string>();

            var rawSkillData = LoadDict<uint, string>(GetAsset($"{lang}_skillData"));
            rawSkillData[0] = "--------";

            const uint step = 3;
            for (uint index = 0; index < rawSkillData.Count; index += step) {
                var key = (ushort) (index / step);
                var value = new IdNamePair(key, rawSkillData[index]);
                var desc = rawSkillData[index + 2].Replace("\r\n", " ");

                skillData[lang][key] = value;
                skillDataDescriptions[lang][key] = desc;
            }
        }

        private static Dictionary<K, V> LoadDict<K, V>(byte[] data) {
            var json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Dictionary<K, V>>(json);
        }

        private static byte[] GetAsset(string assetName) {
            return (byte[]) Assets.ResourceManager.GetObject(assetName);
        }
    }
}