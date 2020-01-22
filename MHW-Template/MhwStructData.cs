using System;
using System.CodeDom;
using System.Collections.Generic;

namespace MHW_Template {
    public class MhwStructData {
        public List<Entry> entries;
        public ulong size;
        public ulong offsetInitial;

        public class Entry {
            public readonly string name;
            public readonly ulong offset;
            public readonly CodeTypeReference type;
            public readonly CodeTypeReference enumReturn = null;
            public readonly bool readOnly;
            public readonly string valueString;
            public readonly string accessLevel;

            public Entry(string name, ulong offset, Type type, bool readOnly = false, string valueString = "value", string accessLevel = "public") {
                this.name = name;
                this.offset = offset;
                this.type = new CodeTypeReference(type);
                this.readOnly = readOnly;
                this.valueString = valueString;
                this.accessLevel = accessLevel;
            }

            public Entry(string name, ulong offset, Type type, Type enumReturn) : this(name, offset, type) {
                this.enumReturn = new CodeTypeReference(enumReturn);
            }
        }
    }
}