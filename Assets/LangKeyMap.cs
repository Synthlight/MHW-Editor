using System.Collections.Generic;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace MHW_Editor.Assets {
    public class LangKeyMap : Dictionary<string, Dictionary<string, string>> {
        public LangKeyMap() {
        }

        public LangKeyMap(int capacity) : base(capacity) {
        }

        public LangKeyMap(IEqualityComparer<string> comparer) : base(comparer) {
        }

        public LangKeyMap(int capacity, IEqualityComparer<string> comparer) : base(capacity, comparer) {
        }

        public LangKeyMap([NotNull] IDictionary<string, Dictionary<string, string>> dictionary) : base(dictionary) {
        }

        public LangKeyMap([NotNull] IDictionary<string, Dictionary<string, string>> dictionary, IEqualityComparer<string> comparer) : base(dictionary, comparer) {
        }

        protected LangKeyMap(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}