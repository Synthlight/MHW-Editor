using System;
using System.CodeDom;
using System.Collections.Generic;

namespace MHW_Template {
    public class MhwStructData {
        public List<Entry> entries;
        public ulong size;
        public ulong offsetInitial;

        public class Entry {
            public string name;
            public ulong offset;
            public CodeTypeReference type;
            public CodeTypeReference enumReturn = null;

            public Entry(string name, ulong offset, Type type) {
                this.name = name;
                this.offset = offset;
                this.type = new CodeTypeReference(type);
            }

            public Entry(string name, ulong offset, Type type, Type enumReturn) : this(name, offset, type) {
                this.enumReturn = new CodeTypeReference(enumReturn);
            }
        }
    }
}