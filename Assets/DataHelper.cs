using System;
using System.Collections.Generic;
using System.Text;
using MHW_Template;
using MHW_Template.Armors;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Weapons;
using Newtonsoft.Json;

namespace MHW_Editor.Assets {
    public static class DataHelper {
        public static readonly LangMap                     armorData                     = new LangMap(); // Uses GMD reference.
        public static readonly LangMap                     awakeningNames                = new LangMap();
        public static readonly LangMap                     awakeningDescriptions         = new LangMap();
        public static readonly LangMap                     bountyNames                   = new LangMap();
        public static readonly LangMap                     bountyDescriptions            = new LangMap();
        public static readonly LangMap                     customPartsNames              = new LangMap();
        public static readonly LangMap                     customPartsDescriptions       = new LangMap();
        public static readonly LangMap                     customPartsRecipeNames        = new LangMap();
        public static readonly LangMap                     customPartsRecipeDescriptions = new LangMap();
        public static readonly LangMap                     gcBackgroundsGmd              = new LangMap();
        public static readonly LangMap                     gcTitles1Gmd                  = new LangMap();
        public static readonly LangMap                     gcTitles2Gmd                  = new LangMap();
        public static readonly LangMap                     gcExpressionsGmd              = new LangMap();
        public static readonly LangMap                     gcPosesGmd                    = new LangMap();
        public static readonly LangMap                     itemNames                     = new LangMap();
        public static readonly LangMap                     itemDescriptions              = new LangMap();
        public static readonly LangMap                     kinsectNames                  = new LangMap();
        public static readonly LangMap                     mantleNames                   = new LangMap();
        public static readonly LangMapNeg                  mantleNamesNeg                = new LangMapNeg();
        public static readonly LangMap                     mantleDescriptions            = new LangMap();
        public static readonly LangMap                     monsterNames                  = new LangMap();
        public static readonly LangMap                     monsterDescriptions           = new LangMap();
        public static readonly LangMapNeg                  monsterNamesNeg               = new LangMapNeg();
        public static readonly LangMapNeg                  monsterDescriptionsNeg        = new LangMapNeg();
        public static readonly LangMap                     otomoArmorData                = new LangMap(); // Uses GMD reference.
        public static readonly LangMap                     otomoWeaponData               = new LangMap(); // Uses GMD reference.
        public static readonly LangMap                     pendantNames                  = new LangMap();
        public static readonly LangMap                     skillNames                    = new LangMap();
        public static readonly LangMap                     skillDescriptions             = new LangMap();
        public static readonly Dictionary<uint, string>    songNames                     = new Dictionary<uint, string>(); // Has no lang.
        public static readonly Dictionary<string, LangMap> weaponData                    = new Dictionary<string, LangMap>(); // Has wp file name too. Uses GMD reference.

        public static readonly Dictionary<string, Dictionary<int, NameDescPair>> collisionTranslationsData;
        public static readonly Dictionary<string, Dictionary<string, string>>    translations;

        public static readonly Dictionary<ArmorType, LangMap>     armorIdNameLookup;
        public static readonly Dictionary<ArmorType, LangMap>     armorIndexNameLookup;
        public static readonly Dictionary<ArmorType, LangMapNeg>  armorIndexNegNameLookup;
        public static readonly LangMapNeg                         armorFileIndexNegNameLookup;
        public static readonly Dictionary<WeaponType, LangMap>    weaponIdNameLookup;
        public static readonly Dictionary<WeaponType, LangMap>    weaponIndexNameLookup;
        public static readonly LangMap                            palicoArmorBodyLookupByModelId;
        public static readonly LangMap                            palicoArmorHeadLookupByModelId;
        public static readonly Dictionary<EquipmentType, LangMap> equipmentIdNameLookup = new Dictionary<EquipmentType, LangMap>();
        public static readonly List<uint>                         gemItemIds;
        public static readonly Dictionary<uint, byte>             itemRarityById;

        public static readonly Dictionary<string, Dictionary<string, List<string>>> BAD_FILE_HASH_MAP;
        public static readonly Dictionary<string, string>                           GOOD_CHUNK_MAP;
        public static readonly Dictionary<string, string>                           FILE_PATH_MAP;
        public static readonly Dictionary<string, ulong>                            FILE_SIZE_MAP;

        static DataHelper() {
            BAD_FILE_HASH_MAP = LoadDict<string, Dictionary<string, List<string>>>(EditorAssets.BadHashMap);
            GOOD_CHUNK_MAP    = LoadDict<string, string>(EditorAssets.GoodChunkMap);
            FILE_PATH_MAP     = LoadDict<string, string>(EditorAssets.FilePathMap);
            FILE_SIZE_MAP     = LoadDict<string, ulong>(EditorAssets.FileSizeMap);

            collisionTranslationsData = LoadDict<string, Dictionary<int, NameDescPair>>(EditorAssets.CollisionTranslationsData);
            translations              = LoadDict<string, Dictionary<string, string>>(EditorAssets.Translations);

            armorIdNameLookup              = LoadDict<ArmorType, LangMap>(EditorAssets.ArmorNameLookupById);
            armorIndexNameLookup           = LoadDict<ArmorType, LangMap>(EditorAssets.ArmorNameLookupByIndex);
            armorIndexNegNameLookup        = LoadDict<ArmorType, LangMapNeg>(EditorAssets.ArmorNameLookupByIndex);
            armorFileIndexNegNameLookup    = Load<LangMapNeg>(EditorAssets.ArmorNameLookupByFileIndex);
            weaponIdNameLookup             = LoadDict<WeaponType, LangMap>(EditorAssets.WeaponNameLookupById);
            weaponIndexNameLookup          = LoadDict<WeaponType, LangMap>(EditorAssets.WeaponNameLookupByIndex);
            palicoArmorBodyLookupByModelId = Load<LangMap>(EditorAssets.PalicoArmorBodyLookupByModelId);
            palicoArmorHeadLookupByModelId = Load<LangMap>(EditorAssets.PalicoArmorHeadLookupByModelId);

            MergeEquipmentIdLookups();

            gemItemIds     = LoadList<uint>(EditorAssets.GemItemIds);
            itemRarityById = LoadDict<uint, byte>(EditorAssets.ItemRarityById);

            foreach (var lang in Global.LANGUAGES) {
                armorFileIndexNegNameLookup[lang][-1] = "None";

                foreach (ArmorType type in Enum.GetValues(typeof(ArmorType))) {
                    armorIndexNegNameLookup[type][lang][-1] = "None";
                }

                ParseItemData(lang);
                ParseSkillData(lang);
                ParseSongData();
                ParseBountyData(lang);
                ParseMantleData(lang);
                ParseAwakeningData(lang);
                ParseMonsterData(lang);
                ParseCustomPartsData(lang);

                armorData[lang]       = LoadDict<uint, string>(GetAsset($"{lang}_armorData"));
                otomoArmorData[lang]  = LoadDict<uint, string>(GetAsset($"{lang}_otomo_armorData"));
                otomoWeaponData[lang] = LoadDict<uint, string>(GetAsset($"{lang}_otomo_weaponData"));
                kinsectNames[lang]    = LoadDict<uint, string>(GetAsset($"{lang}_insectData"));
                pendantNames[lang]    = LoadDict<uint, string>(GetAsset($"{lang}_pendantData"));

                weaponData[lang] = new LangMap();
                foreach (var weapon in Global.WEAPONS) {
                    weaponData[lang][weapon] = LoadDict<uint, string>(GetAsset($"{lang}_{weapon}"));
                }

                gcBackgroundsGmd[lang] = LoadDict<uint, string>(GetAsset($"{lang}_backgroundData"));
                gcTitles1Gmd[lang]     = LoadDict<uint, string>(GetAsset($"{lang}_titles1Data"));
                gcTitles2Gmd[lang]     = LoadDict<uint, string>(GetAsset($"{lang}_titles2Data"));
                gcExpressionsGmd[lang] = LoadDict<uint, string>(GetAsset($"{lang}_expressionData"));
                gcPosesGmd[lang]       = LoadDict<uint, string>(GetAsset($"{lang}_poseData"));
            }
        }

        private static void MergeEquipmentIdLookups() {
            foreach (var weaponType in weaponIdNameLookup.Keys) {
                equipmentIdNameLookup[weaponType.ToEquipmentType()] = weaponIdNameLookup[weaponType];
            }

            foreach (var armorType in armorIdNameLookup.Keys) {
                equipmentIdNameLookup[armorType.ToEquipmentType()] = armorIdNameLookup[armorType];
            }
        }

        private static void ParseItemData(string lang) {
            itemNames[lang]        = new Dictionary<uint, string>();
            itemDescriptions[lang] = new Dictionary<uint, string>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_itemData"));
            rawItemData[0] = "--------";

            const uint step = 2;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                itemNames[lang][key]        = rawItemData[index];
                itemDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseSkillData(string lang) {
            skillNames[lang]        = new Dictionary<uint, string>();
            skillDescriptions[lang] = new Dictionary<uint, string>();

            var rawSkillData = LoadDict<uint, string>(GetAsset($"{lang}_skillData"));
            rawSkillData[0] = "--------";

            const uint step = 3;
            for (uint index = 0; index < rawSkillData.Count; index += step) {
                var key = index / step;

                skillNames[lang][key]        = rawSkillData[index];
                skillDescriptions[lang][key] = rawSkillData[index + 2].Replace("\r\n", " ");
            }
        }

        private static void ParseSongData() {
            var rawSongData = LoadDict<uint, string>(Assets.songData);

            foreach (var pair in rawSongData) {
                songNames[pair.Key] = pair.Value;
            }
        }

        private static void ParseBountyData(string lang) {
            bountyNames[lang]        = new Dictionary<uint, string>();
            bountyDescriptions[lang] = new Dictionary<uint, string>();

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_bountyData"));

            const uint step = 2;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                bountyNames[lang][key]        = rawItemData[index];
                bountyDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseMantleData(string lang) {
            mantleNames[lang]        = new Dictionary<uint, string>();
            mantleNamesNeg[lang]     = new Dictionary<int, string>();
            mantleDescriptions[lang] = new Dictionary<uint, string>();

            mantleNamesNeg[lang][-1] = "None";

            var rawItemData = LoadDict<uint, string>(GetAsset($"{lang}_mantleData"));

            const uint step = 4;
            for (uint index = 0; index < rawItemData.Count; index += step) {
                var key = index / step;

                mantleNames[lang][key]        = mantleNamesNeg[lang][(int) key] = rawItemData[index];
                mantleDescriptions[lang][key] = rawItemData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseAwakeningData(string lang) {
            awakeningNames[lang]        = new Dictionary<uint, string>();
            awakeningDescriptions[lang] = new Dictionary<uint, string>();

            var rawAwakeningData = LoadDict<uint, string>(GetAsset($"{lang}_awakeningData"));

            const uint step = 2;
            for (uint index = 0; index < rawAwakeningData.Count; index += step) {
                var key = index / step;

                awakeningNames[lang][key]        = rawAwakeningData[index];
                awakeningDescriptions[lang][key] = rawAwakeningData[index + 1].Replace("\r\n", " ");
            }
        }

        private static void ParseMonsterData(string lang) {
            monsterNames[lang]           = new Dictionary<uint, string>();
            monsterNamesNeg[lang]        = new Dictionary<int, string>();
            monsterDescriptions[lang]    = new Dictionary<uint, string>();
            monsterDescriptionsNeg[lang] = new Dictionary<int, string>();

            monsterNamesNeg[lang][-1] = monsterDescriptionsNeg[lang][-1] = "None";

            var rawMonsterData = LoadDict<uint, string>(GetAsset($"{lang}_monsterData"));

            const uint step = 2;
            for (uint index = 0; index < rawMonsterData.Count; index += step) {
                var key           = index / step;
                if (key > 59) key -= 2; // Fixes crazy shit with the GMD. There's more strings than keys.

                monsterNamesNeg[lang][(int) key]        = monsterNames[lang][key]        = rawMonsterData[index];
                monsterDescriptionsNeg[lang][(int) key] = monsterDescriptions[lang][key] = rawMonsterData[index + 1].Replace("\r\n", " ");

                monsterNamesNeg[lang][(int) key] = monsterNames[lang][key] = key switch {
                    57 => "Small Barrel",
                    58 => "Large Barrel",
                    59 => "Training Pole",
                    _ => monsterNames[lang][key]
                };
            }
        }

        private static void ParseCustomPartsData(string lang) {
            customPartsNames[lang]              = new Dictionary<uint, string>();
            customPartsDescriptions[lang]       = new Dictionary<uint, string>();
            customPartsRecipeNames[lang]        = new Dictionary<uint, string>();
            customPartsRecipeDescriptions[lang] = new Dictionary<uint, string>();

            var rawCustomPartsData = LoadDict<uint, string>(GetAsset($"{lang}_customPartsData"));

            var        s    = 1U;
            const uint step = 2;
            for (uint index = 0; index < rawCustomPartsData.Count; index += step) {
                var key  = index / 2;
                var name = rawCustomPartsData[index];
                var desc = rawCustomPartsData[index + 1].Replace("\r\n", " ");

                customPartsNames[lang][key]        = name;
                customPartsDescriptions[lang][key] = desc;

                if (name == "Unavailable") continue;
                customPartsRecipeNames[lang][s]          = name;
                customPartsRecipeDescriptions[lang][s++] = desc;
            }
        }

        private static T Load<T>(byte[] data) {
            var json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<T>(json);
        }

        private static List<T> LoadList<T>(byte[] data) {
            var json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<List<T>>(json);
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