using System;
using System.Collections.Generic;
using MHW_Template.Models;

namespace MHW_Template {
    public class MhwMultiStructData {
        public readonly List<StructData> structs;
        public readonly ulong offsetInitial;
        public readonly string encryptionKey;

        public MhwMultiStructData(List<StructData> structs, ulong offsetInitial, string encryptionKey = null) {
            this.structs = structs;
            this.offsetInitial = offsetInitial;
            this.encryptionKey = encryptionKey;
        }

        public class StructData {
            public readonly string name;
            public readonly List<Entry> entries;
            public readonly uint fixedSizeCount;

            public StructData(string name, List<Entry> entries, uint fixedSizeCount = 0) {
                this.name = name;
                this.entries = entries;
                this.fixedSizeCount = fixedSizeCount;
            }

            public class Entry {
                public readonly string displayName;
                public readonly Type type;
                public readonly Type enumReturn;
                public readonly bool readOnly;
                public readonly string valueString; // Used mostly for clamping the value.
                public readonly string accessLevel;
                public readonly DataSourceType? dataSourceType;
                public readonly string[] extraOnPropertyChanged;
                public readonly string dataSourceCustomSorter;
                public readonly bool forceUnique; // Force the generated field to be unique. (Adds offset to end of field name.) Skipped in the struct generation.
                public readonly bool createPercentField = false;
                public readonly int arrayCount; // If the type is an array, set the count;
                public readonly bool isNullTerminatedString;
                public readonly string condition; // Condition to read/write.

                public Entry(string displayName, Type type,
                             bool readOnly = false,
                             Type enumReturn = null,
                             string valueString = "value",
                             string accessLevel = "public",
                             DataSourceType? dataSourceType = null,
                             string[] extraOnPropertyChanged = null,
                             string dataSourceCustomSorter = "ButtonSorter",
                             bool forceUnique = false,
                             bool createPercentField = false,
                             int arrayCount = -1,
                             bool isNullTerminatedString = false,
                             string condition = null) {
                    this.displayName = displayName;
                    this.type = type;
                    this.readOnly = readOnly;
                    this.valueString = valueString;
                    this.accessLevel = accessLevel;
                    this.enumReturn = enumReturn;
                    this.dataSourceType = dataSourceType;
                    this.extraOnPropertyChanged = extraOnPropertyChanged;
                    this.dataSourceCustomSorter = dataSourceCustomSorter;
                    this.forceUnique = forceUnique;
                    this.createPercentField = createPercentField;
                    this.arrayCount = arrayCount;
                    this.isNullTerminatedString = isNullTerminatedString;
                    this.condition = condition;
                }
            }
        }
    }
}