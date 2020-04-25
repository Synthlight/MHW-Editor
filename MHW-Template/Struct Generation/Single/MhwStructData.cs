using System;
using System.Collections.Generic;
using MHW_Template.Models;

namespace MHW_Template.Struct_Generation.Single {
    public class MhwStructData {
        public List<Entry> entries;
        public ulong size;
        public ulong offsetInitial;
        public long entryCountOffset = -1;
        public string encryptionKey = null;
        public string uniqueIdFormula;
        public bool autoOffset = false; // Auto increment offset by sizeof(type).

        public class Entry {
            public readonly string displayName;
            public readonly ulong offset;
            public readonly Type type;
            public readonly Type enumReturn;
            public readonly bool readOnly;
            public readonly string valueString; // Used mostly for clamping the value.
            public readonly string accessLevel;
            public readonly DataSourceType? dataSourceType;
            public readonly string[] extraOnPropertyChanged;
            public readonly string dataSourceCustomSorter;
            public readonly bool forceUnique; // Force the generated field to be unique. (Adds offset to end of field name.) Skipped in the struct generation.
            public readonly long addOffset = 0; // An offset to our offset for all subsequent offsets.
            public readonly bool createPercentField = false;

            public Entry(string displayName, ulong offset, Type type,
                         bool readOnly = false,
                         Type enumReturn = null,
                         string valueString = "value",
                         string accessLevel = "public",
                         DataSourceType? dataSourceType = null,
                         string[] extraOnPropertyChanged = null,
                         string dataSourceCustomSorter = "ButtonSorter",
                         bool forceUnique = false,
                         long addOffset = 0,
                         bool createPercentField = false) {
                this.displayName = displayName;
                this.offset = offset;
                this.type = type;
                this.readOnly = readOnly;
                this.valueString = valueString;
                this.accessLevel = accessLevel;
                this.enumReturn = enumReturn;
                this.dataSourceType = dataSourceType;
                this.extraOnPropertyChanged = extraOnPropertyChanged;
                this.dataSourceCustomSorter = dataSourceCustomSorter;
                this.forceUnique = forceUnique;
                this.addOffset = addOffset;
                this.createPercentField = createPercentField;
            }

            public Entry(string displayName, Type type,
                         bool readOnly = false,
                         Type enumReturn = null,
                         string valueString = "value",
                         string accessLevel = "public",
                         DataSourceType? dataSourceType = null,
                         string[] extraOnPropertyChanged = null,
                         string dataSourceCustomSorter = "ButtonSorter",
                         bool forceUnique = false,
                         long addOffset = 0,
                         bool createPercentField = false) : this(displayName, 0, type, readOnly, enumReturn, valueString, accessLevel, dataSourceType, extraOnPropertyChanged, dataSourceCustomSorter, forceUnique, addOffset, createPercentField) {
            }

            public Entry(string name, ulong offset, Type type, Type enumReturn) : this(name, offset, type) {
                this.enumReturn = enumReturn;
            }

            public Entry(string name, Type type, Type enumReturn) : this(name, 0, type, enumReturn) {
            }
        }
    }
}