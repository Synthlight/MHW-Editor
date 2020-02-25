using System.Collections.Generic;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace MHW_Editor.Assets {
    public class LangMap : Dictionary<string, Dictionary<uint, string>> {
        public LangMap() {
        }

        public LangMap(int capacity) : base(capacity) {
        }

        public LangMap(IEqualityComparer<string> comparer) : base(comparer) {
        }

        public LangMap(int capacity, IEqualityComparer<string> comparer) : base(capacity, comparer) {
        }

        public LangMap([NotNull] IDictionary<string, Dictionary<uint, string>> dictionary) : base(dictionary) {
        }

        public LangMap([NotNull] IDictionary<string, Dictionary<uint, string>> dictionary, IEqualityComparer<string> comparer) : base(dictionary, comparer) {
        }

        protected LangMap(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}