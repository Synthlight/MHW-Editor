using System.Collections.Generic;

namespace MHW_Editor.Models {
    public class JsonChanges {
        public string                                         targetFile;
        public uint                                           version = 1;
        public Dictionary<string, Dictionary<string, object>> changes = new Dictionary<string, Dictionary<string, object>>();
    }
}