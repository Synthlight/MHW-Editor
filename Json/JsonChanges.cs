using System.Collections.Generic;
using Newtonsoft.Json;

namespace MHW_Editor.Json {
    public class JsonChanges {
        public string targetFile;
        public uint   version = 3;

        /**
         * Map of: [Unique ID, [Variable Name, Value]].
         */
        [JsonProperty("changes")]
        public Dictionary<string, Dictionary<string, object>> changesV1 = new Dictionary<string, Dictionary<string, object>>();

        /**
         * Map of: [Struct Name, [Unique ID, [Variable Name, Value]]].
         */
        public Dictionary<string, Dictionary<string, Dictionary<string, object>>> changesV3 = new Dictionary<string, Dictionary<string, Dictionary<string, object>>>();
    }
}