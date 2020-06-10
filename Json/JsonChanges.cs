using System.Collections.Generic;
using Newtonsoft.Json;

namespace MHW_Editor.Json {
    public class JsonChanges {
        /**
         * The filename (not path) of the intended target.
         */
        public string targetFile;

        /**
         * Singular version across all files. Makes migration much easier.
         */
        public uint version = 1;

        /**
         * Map of: [Unique ID, [Variable Name, Value]].
         */
        [JsonProperty("changes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, object>> changesV1;

        /**
         * Map of: [Struct Name, [Unique ID, [Variable Name, Value]]].
         */
        public Dictionary<string, Dictionary<string, Dictionary<string, object>>> changesV3 = new Dictionary<string, Dictionary<string, Dictionary<string, object>>>();
    }
}