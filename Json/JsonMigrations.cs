using System;
using System.Collections.Generic;
using MHW_Editor.Models;
using MHW_Editor.Structs.Armors;
using MHW_Editor.Windows;
using MHW_Template;
using Newtonsoft.Json;

namespace MHW_Editor.Json {
    public static class JsonMigrations {
        public const uint CURRENT_VERSION = 3;

        // ReSharper disable once ParameterTypeCanBeEnumerable.Global
        public static JsonChanges Migrate(string oldJson, string fileName, IMhwMultiStructFile fileData) {
            var changesToLoad = JsonConvert.DeserializeObject<JsonChanges>(oldJson);

            if (changesToLoad.version == 1) MigrateV1ToV2(changesToLoad, fileName, fileData);
            if (changesToLoad.version == 2) MigrateV2ToV3(changesToLoad, fileName, fileData);

            if (changesToLoad.version != CURRENT_VERSION) throw new InvalidOperationException($"Unable to migrate json. Version still: {changesToLoad.version}");

            changesToLoad.changesV1 = null;

            return changesToLoad;
        }

        /**
         * Originally used `Set_Layered_Id` for armor which is always 0 for charms.
         * This migrates that to `Set_Group` instead.
         */
        private static void MigrateV1ToV2(JsonChanges changesToLoad, string fileName, IMhwMultiStructFile fileData) {
            if (fileName == "armor.am_dat" && fileData is Armor armor) {
                var newChanges = new Dictionary<string, Dictionary<string, object>>();

                if (changesToLoad.changesV1 != null) {
                    foreach (var change in changesToLoad.changesV1) {
                        // Skip charms in v1 as the layered ID they use is always 0 an not usable.
                        if (change.Key.EndsWith("|Charm")) continue;

                        foreach (var item in armor.GetSingleStructList()) {
                            var v1UniqueId = $"{item.Set_Layered_Id}|{item.Variant}|{item.Type}|{item.Equip_Slot}";

                            if (change.Key == v1UniqueId) {
                                var newUniqueId = item.UniqueId;
                                newChanges[newUniqueId] = change.Value;
                            }
                        }
                    }
                }

                changesToLoad.changesV1 = newChanges;
            }

            changesToLoad.version = 2;
        }

        /**
         * Migrates single-struct json to multi-struct json.
         * Only works for single-struct files, but that shouldn't matter since only those supported json before this.
         */
        private static void MigrateV2ToV3(JsonChanges changesToLoad, string fileName, IMhwMultiStructFile fileData) {
            if (changesToLoad.changesV1 != null) {
                var targetType = MainWindow.GetFileType(fileName);

                if (targetType.Is(typeof(IShowAsSingleStruct))) {
                    var singleType     = (IShowAsSingleStruct) Activator.CreateInstance(targetType);
                    var singleTypeName = singleType.GetSingleStructType().Name;

                    changesToLoad.changesV3                 ??= new Dictionary<string, Dictionary<string, Dictionary<string, object>>>();
                    changesToLoad.changesV3[singleTypeName] =   new Dictionary<string, Dictionary<string, object>>();

                    foreach (var change in changesToLoad.changesV1) {
                        changesToLoad.changesV3[singleTypeName].Add(change.Key, change.Value);
                    }
                }
            }

            changesToLoad.changesV1 = null;
            changesToLoad.version   = 3;
        }
    }
}