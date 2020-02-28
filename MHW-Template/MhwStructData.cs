using System;
using System.CodeDom;
using System.Collections.Generic;
using MHW_Template.Models;

namespace MHW_Template {
    public class MhwStructData {
        public List<Entry> entries;
        public ulong size;
        public ulong offsetInitial;
        public long entryCountOffset = -1;
        public string encryptionKey = null;
        public string uniqueIdFormula;

        public class Entry {
            public readonly string displayName;
            public readonly ulong offset;
            public readonly CodeTypeReference type;
            public readonly CodeTypeReference enumReturn;
            public readonly bool readOnly;
            public readonly string valueString;
            public readonly string accessLevel;
            public readonly DataSourceType? dataSourceType;
            public readonly string[] extraOnPropertyChanged;
            public readonly string dataSourceCustomSorter;
            public readonly bool forceUnique;
            public readonly bool asBoolean;

            public Entry(string displayName, ulong offset, Type type,
                         bool readOnly = false,
                         Type enumReturn = null,
                         string valueString = "value",
                         string accessLevel = "public",
                         DataSourceType? dataSourceType = null,
                         string[] extraOnPropertyChanged = null,
                         string dataSourceCustomSorter = "ButtonSorter",
                         bool forceUnique = false,
                         bool asBoolean = false) {
                this.displayName = displayName;
                this.offset = offset;
                this.type = new CodeTypeReference(type);
                this.readOnly = readOnly;
                this.valueString = valueString;
                this.accessLevel = accessLevel;
                this.enumReturn = enumReturn == null ? null : new CodeTypeReference(enumReturn);
                this.dataSourceType = dataSourceType;
                this.extraOnPropertyChanged = extraOnPropertyChanged;
                this.dataSourceCustomSorter = dataSourceCustomSorter;
                this.forceUnique = forceUnique;
                this.asBoolean = asBoolean;
            }

            public Entry(string name, ulong offset, Type type, Type enumReturn) : this(name, offset, type) {
                this.enumReturn = new CodeTypeReference(enumReturn);
            }
        }
    }
}