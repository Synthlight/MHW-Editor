using System.Collections.Generic;
using System.Text;
using MHW_Template;
using Newtonsoft.Json;

namespace MHW_Editor.Assets {
    public static class DataHelper {
        public static readonly LangMap armorData = new LangMap(); // Uses GMD reference.
        public static readonly LangMap bountyData = new LangMap();
        public static readonly LangMap bountyDataDescriptions = new LangMap();
        public static readonly LangMap itemData = new LangMap();
        public static readonly LangMap itemDataDescriptions = new LangMap();
        public static readonly LangMap kinsectData = new LangMap();
        public static readonly LangMap mantleData = new LangMap();
        public static readonly LangMap mantleDataDescriptions = new LangMap();
        public static readonly LangMap otomoArmorData = new LangMap(); // Uses GMD reference.
        public static readonly LangMap otomoWeaponData = new LangMap(); // Uses GMD reference.
        public static readonly LangMap pendantData = new LangMap();
        public static readonly LangMap skillData = new LangMap();
        public static readonly LangMap skillDataDescriptions = new LangMap();
        public static readonly Dictionary<uint, string> songData = new Dictionary<uint, string>(); // Has no lang.
        public static readonly Dictionary<string, LangMap> weaponData = new Dictionary<string, LangMap>(); // Has wp file name too. Uses GMD reference.

        static DataHelper() {
            foreach (var lang in Global.LANGUAGES) {
                ParseItemData(lang);
                ParseSkillData(lang);
                ParseSongData();
                ParseBountyData(lang);
                ParseMantleData(lang);

                armorData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_armorData"));
                otomoArmorData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_otomo_armorData"));
                otomoWeaponData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_otomo_weaponData"));
                kinsectData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_insectData"));
                pendantData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_pendantData"));

                weaponData[lang] = new LangMap();
                foreach (var weapon in Global.WEAPONS) {
                    weaponData[lang][weapon] = LoadDict<uint, string>(GetAsset($"{lang}_{weapon}"));
                }
            }
        }

        private static void ParseItemData(string lang) {
            itemData[lang] = new Dictionary<uint, string>();
            itemDataDescriptions[lang] = new Dictionary<uint, string>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_itemData"));
            rawItemData[0] = "--------";

            const uint step = 2;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                itemData[lang][key] = rawItemData[index];
                itemDataDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseSkillData(string lang) {
            skillData[lang] = new Dictionary<uint, string>();
            skillDataDescriptions[lang] = new Dictionary<uint, string>();

            var rawSkillData = LoadDict<uint, string>(GetAsset($"{lang}_skillData"));
            rawSkillData[0] = "--------";

            const uint step = 3;
            for (uint index = 0; index < rawSkillData.Count; index += step) {
                var key = index / step;

                skillData[lang][key] = rawSkillData[index];
                skillDataDescriptions[lang][key] = rawSkillData[index + 2].Replace("\r\n", " ");
            }
        }

        private static void ParseSongData() {
            var rawSongData = LoadDict<uint, string>(Assets.songData);

            foreach (var pair in rawSongData) {
                songData[pair.Key] = pair.Value;
            }
        }

        private static void ParseBountyData(string lang) {
            bountyData[lang] = new Dictionary<uint, string>();
            bountyDataDescriptions[lang] = new Dictionary<uint, string>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_bountyData"));

            const uint step = 2;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                bountyData[lang][key] = rawItemData[index];
                bountyDataDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseMantleData(string lang) {
            mantleData[lang] = new Dictionary<uint, string>();
            mantleDataDescriptions[lang] = new Dictionary<uint, string>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_mantleData"));

            const uint step = 4;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                mantleData[lang][key] = rawItemData[index];
                mantleDataDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
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