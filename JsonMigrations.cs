using System.Collections.Generic;
using System.Collections.ObjectModel;
using MHW_Editor.Armors;
using MHW_Editor.Models;
using Newtonsoft.Json;

namespace MHW_Editor {
    public static class JsonMigrations {
        public static readonly Dictionary<string, uint> VERSION_MAP = new Dictionary<string, uint> {
            {"armor.am_dat", 2}
        };

        // ReSharper disable once ParameterTypeCanBeEnumerable.Global
        public static JsonChanges Migrate(string oldJson, string fileName, ObservableCollection<dynamic> items) {
            var changesToLoad = JsonConvert.DeserializeObject<JsonChanges>(oldJson);
/* TODO: Fix me.
            switch (fileName) {
                case "armor.am_dat":
                    if (changesToLoad.version == 1) {
                        var newChanges = new Dictionary<string, Dictionary<string, object>>();

                        foreach (var change in changesToLoad.changes) {
                            // Skip charms in v1 as the layered ID they use is always 0 an not usable.
                            if (change.Key.EndsWith("|Charm")) continue;

                            foreach (Armor item in items) {
                                if (item.Offset == 0) continue;

                                var v1UniqueId = $"{item.Set_Layered_Id}|{item.Variant}|{item.Type}|{item.Equip_Slot}";

                                if (change.Key == v1UniqueId) {
                                    var newUniqueId = item.UniqueId;
                                    newChanges[newUniqueId] = change.Value;
                                }
                            }
                        }

                        changesToLoad.changes = newChanges;
                        changesToLoad.version = 2;
                    }

                    break;
            }
*/
            return changesToLoad;
        }
    }
}