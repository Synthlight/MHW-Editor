using System.Collections.Generic;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace MHW_Editor.Assets {
    public class LangMapNeg : Dictionary<string, Dictionary<int, string>> {
        public LangMapNeg() {
        }

        public LangMapNeg(int capacity) : base(capacity) {
        }

        public LangMapNeg(IEqualityComparer<string> comparer) : base(comparer) {
        }

        public LangMapNeg(int capacity, IEqualityComparer<string> comparer) : base(capacity, comparer) {
        }

        public LangMapNeg([NotNull] IDictionary<string, Dictionary<int, string>> dictionary) : base(dictionary) {
        }

        public LangMapNeg([NotNull] IDictionary<string, Dictionary<int, string>> dictionary, IEqualityComparer<string> comparer) : base(dictionary, comparer) {
        }

        protected LangMapNeg(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}