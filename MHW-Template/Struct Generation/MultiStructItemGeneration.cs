using System;
using System.CodeDom;
using System.Text.RegularExpressions;
using Microsoft.CSharp;

namespace MHW_Template.Struct_Generation {
    public static class MultiStructItemGeneration {
        public const            int                SORT_INDEX_STEP = 50;
        private static readonly CSharpCodeProvider COMPILER        = new CSharpCodeProvider();

        public static void Generate(MultiStructItemTemplateBase template, MhwMultiStructData structData) {
            foreach (var @struct in structData.structs) {
                GenerateInnerClass(template, @struct);
            }

            MasterLoadData(template, structData);
        }

        private static void GenerateInnerClass(MultiStructItemTemplateBase template, MhwMultiStructData.StructData @struct, MhwMultiStructData.StructData parent = null, uint indentation = 0) {
            var sortIndex  = SORT_INDEX_STEP;
            var name       = @struct.SafeName;
            var interfaces = "MhwStructItem";

            if (@struct.showVertically) interfaces += ", IHasCustomView<MultiStructItemCustomView>";
            if (parent == null) interfaces += ", IWriteData";
            else interfaces                += $", IWriteDataInner<{parent.SafeName}>";

            template.WriteLine("");
            template.WriteLine(indentation, $"        public partial class {name} : {interfaces} {{");
            template.WriteLine(indentation, $"            public const ulong FixedSizeCount = {@struct.fixedSizeCount};");
            template.WriteLine(indentation, $"            public const string GridName = \"{@struct.name}\";");

            if (@struct.uniqueIdFormula != null) {
                template.WriteLine(indentation, $"            public override string UniqueId => $\"{@struct.uniqueIdFormula}\";");
            }

            if (@struct.hidden) {
                template.WriteLine(indentation, $"            public const bool IsHidden = {@struct.hidden.ToString().ToLower()};");
            }

            if (@struct.description != null) {
                template.WriteLine(indentation, $"            public const string Description = \"{@struct.description}\";");
            }

            if (@struct.canAddRows) {
                template.WriteLine(indentation, $"            public const bool IsAddingAllowed = {@struct.canAddRows.ToString().ToLower()};");

                template.WriteLine("");
                template.WriteLine(indentation, "            [SortOrder(-1)]");
                template.WriteLine(indentation, "            [IsReadOnly]");
                template.WriteLine(indentation, "            [DisplayName(\"X\")]");
                template.WriteLine(indentation, "            public string Delete => \"X\";");
            }

            foreach (var entry in @struct.entries) {
                var propName  = entry.SafeName;
                var entryName = $"{propName}_raw";

                if (entry.HasSubStruct) {
                    GenerateInnerClass(template, entry.subStruct, @struct, indentation + 1);

                    MakeSubProperty(template, indentation, entry, entryName, propName, sortIndex);
                } else {
                    MakeMainProperty(template, indentation, entry, entryName, propName, sortIndex);

                    if (entry.dataSourceType != null) {
                        MakeButtonProperty(template, indentation, entry, propName);
                    }

                    if (entry.createPercentField) {
                        MakePercentProperty(template, indentation, propName);
                    }
                }

                sortIndex += SORT_INDEX_STEP;
            }

            template.WriteLine("");
            template.WriteLine(indentation, $"            public const int lastSortIndex = {sortIndex};");

            InnerLoadData(template, indentation, @struct, parent);
            InnerWriteData(template, indentation, @struct, parent);

            // GetCustomView (if needed).
            if (@struct.showVertically) {
                GetCustomView(template, indentation, @struct);
            }

            template.WriteLine(indentation, "        }");
        }

        private static void MakeMainProperty(MultiStructItemTemplateBase template, uint indentation, MhwMultiStructData.Entry entry, string entryName, string propName, int sortIndex) {
            var accessLevel = entry.accessLevel;
            if (entry.name == "Index") accessLevel         += " override";
            else if (accessLevel != "private") accessLevel += " virtual";

            var typeString                        = COMPILER.GetTypeOutput(new CodeTypeReference(entry.type));
            if (entry.arrayCount > -1) typeString += "[]";

            string returnString;
            var    setCast = "";
            var    getCast = "";

            if (entry.enumReturn == null) {
                returnString = typeString;
            } else {
                returnString = COMPILER.GetTypeOutput(new CodeTypeReference(entry.enumReturn));
                getCast      = $"({returnString}) ";
                setCast      = $"({typeString}) ";
            }

            if (entry.name == "Index") {
                getCast      = "(ulong) ";
                setCast      = $"({returnString}) ";
                returnString = "ulong";
            }

            // Main Property.
            template.WriteLine("");
            template.WriteLine(indentation, $"            protected {typeString} {entryName};");
            template.WriteLine(indentation, $"            public const string {propName}_displayName = \"{entry.name}\";");
            if (!entry.overrideSortIndex) {
                template.WriteLine(indentation, $"            public const int {propName}_sortIndex = {sortIndex};");
            }
            template.WriteLine(indentation, $"            [SortOrder({propName}_sortIndex)]");
            template.WriteLine(indentation, $"            [DisplayName({propName}_displayName)]");

            if (entry.dataSourceType != null) {
                template.WriteLine(indentation, $"            [DataSource(DataSourceType.{entry.dataSourceType})]");
            }

            if (entry.readOnly) {
                template.WriteLine(indentation, "            [IsReadOnly]");
            }

            template.WriteLine(indentation, $"            {accessLevel} {returnString} {propName} {{");

            if (returnString == "bool") {
                template.WriteLine(indentation, $"                get => {getCast}Convert.ToBoolean({entryName});");
            } else if (typeString == "char[]") {
                template.WriteLine(indentation, $"                get => {getCast}new string({entryName});");
            } else {
                template.WriteLine(indentation, $"                get => {getCast}{entryName};");
            }

            // Always include a setter, even for readOnly. This enables us to bypass readOnly via command line switch.
            template.WriteLine(indentation, "                set {");

            if (returnString == "bool") {
                template.WriteLine(indentation, $"                    if (Convert.ToBoolean({entryName}) == {entry.valueString}) return;"); // Do nothing if the value is the same.
                template.WriteLine(indentation, $"                    {entryName} = Convert.ToByte({entry.valueString});");
            } else if (typeString == "char[]") {
                template.WriteLine(indentation, $"                    if ({getCast}new string({entryName}) == {entry.valueString}) return;"); // Do nothing if the value is the same.
                template.WriteLine(indentation, $"                    {entryName} = {setCast}{entry.valueString}.ToCharArray(0, {entry.arrayCount - 1});");
            } else {
                template.WriteLine(indentation, $"                    if ({getCast}{entryName} == {entry.valueString}) return;"); // Do nothing if the value is the same.
                template.WriteLine(indentation, $"                    {entryName} = {setCast}{entry.valueString};");
            }

            template.WriteLine(indentation, $"                    OnPropertyChanged(nameof({propName}));");

            if (entry.dataSourceType != null) {
                template.WriteLine(indentation, $"                    OnPropertyChanged(nameof({propName}_button));");
            }

            if (entry.extraOnPropertyChanged != null) {
                foreach (var propertyToChange in entry.extraOnPropertyChanged) {
                    var propertyToChangeName = Regex.Replace(propertyToChange, @"[^\w\d]+", "_");

                    template.WriteLine(indentation, $"                    OnPropertyChanged(nameof({propertyToChangeName}));");
                }
            }

            template.WriteLine(indentation, "                }");
            template.WriteLine(indentation, "            }");
        }

        private static void MakeSubProperty(MultiStructItemTemplateBase template, uint indentation, MhwMultiStructData.Entry entry, string entryName, string propName, int sortIndex) {
            var accessLevel                           = entry.accessLevel;
            if (accessLevel != "private") accessLevel += " virtual";

            var typeString = $"ObservableCollection<{entry.subStruct.SafeName}>";

            // Auto-Property for sub-struct.
            template.WriteLine("");
            template.WriteLine(indentation, $"            public const string {propName}_displayName = \"{entry.name}\";");
            if (!entry.overrideSortIndex) {
                template.WriteLine(indentation, $"            public const int {propName}_sortIndex = {sortIndex};");
            }
            template.WriteLine(indentation, $"            [SortOrder({propName}_sortIndex)]");
            template.WriteLine(indentation, $"            [DisplayName({propName}_displayName)]");
            template.WriteLine(indentation, $"            {accessLevel} {typeString} {entryName} {{ get; {(accessLevel.Contains("protected") ? "" : "protected ")}set; }}");
        }

        private static void MakeButtonProperty(MultiStructItemTemplateBase template, uint indentation, MhwMultiStructData.Entry entry, string propName) {
            var dataSourceLookup = GenerationHelper.GetDataSourceType(entry.dataSourceType ?? throw new Exception());

            template.WriteLine("");
            template.WriteLine(indentation, $"            [SortOrder({propName}_sortIndex)]");
            template.WriteLine(indentation, $"            [DisplayName({propName}_displayName)]");
            template.WriteLine(indentation, $"            [CustomSorter(typeof({entry.dataSourceCustomSorter}))]");
            template.WriteLine(indentation, $"            public string {propName}_button => {dataSourceLookup}.TryGet({propName}).ToStringWithId({propName});");
        }

        private static void MakePercentProperty(MultiStructItemTemplateBase template, uint indentation, string propName) {
            template.WriteLine("");
            template.WriteLine(indentation, $"            private float _{propName}Percent;");
            template.WriteLine(indentation, $"            [SortOrder({propName}_sortIndex + 1)]");
            template.WriteLine(indentation, $"            [DisplayName({propName}_displayName + \"%\")]");
            template.WriteLine(indentation, $"            public float {propName}_percent {{");
            template.WriteLine(indentation, $"                get => _{propName}Percent;");
            template.WriteLine(indentation, "                set {");
            template.WriteLine(indentation, $"                    _{propName}Percent = value.Clamp(0f, 100f);");
            template.WriteLine(indentation, $"                    OnPropertyChanged(nameof({propName}_percent));");
            template.WriteLine(indentation, "                }");
            template.WriteLine(indentation, "            }");
        }

        private static void GetCustomView(MultiStructItemTemplateBase template, uint indentation, MhwMultiStructData.StructData @struct) {
            template.WriteLine("");
            template.WriteLine(indentation, "            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {");
            template.WriteLine(indentation, "                return new ObservableCollection<MultiStructItemCustomView> {");

            foreach (var entry in @struct.entries) {
                var propName = entry.SafeName;

                template.WriteLine(indentation, $"                    new MultiStructItemCustomView(this, \"{entry.name}\", \"{propName}\"),");
            }

            template.WriteLine(indentation, "                };");
            template.WriteLine(indentation, "            }");
        }

        private static void InnerWriteData(MultiStructItemTemplateBase template, uint indentation, MhwMultiStructData.StructData @struct, MhwMultiStructData.StructData parent) {
            // Individual WriteData.
            template.WriteLine("");
            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (parent != null) {
                template.WriteLine(indentation, $"            public void WriteData(BinaryWriter writer, {parent.SafeName} parent) {{");
            } else {
                template.WriteLine(indentation, "            public void WriteData(BinaryWriter writer) {");
            }

            // Do first since we need to update counts before writing them.
            foreach (var entry in @struct.entries) {
                var propName  = entry.SafeName;
                var entryName = $"{propName}_raw";

                if (entry.HasSubStruct) {
                    if (entry.subStruct._010Link != null) {
                        var linkEntry  = entry.subStruct._010Link.entry;
                        var typeString = COMPILER.GetTypeOutput(new CodeTypeReference(linkEntry.type));

                        var condition = "";
                        if (entry.condition != null) {
                            condition = $"{entry.condition} ".Replace("|ref|", "");
                        }

                        template.WriteLine(indentation, $"                {condition}{linkEntry.SafeName} = ({typeString}) {entryName}.Count;");
                    }
                }
            }

            foreach (var entry in @struct.entries) {
                var propName  = entry.SafeName;
                var entryName = $"{propName}_raw";

                var condition = "";
                if (entry.condition != null) {
                    condition = $"{entry.condition} ".Replace("|ref|", "");
                }

                if (entry.type == typeof(string)) {
                    template.WriteLine(indentation, $"                {condition}writer.Write({entryName}.ToNullTermCharArray());");
                } else if (entry.HasSubStruct) {
                    template.WriteLine(indentation, $"                {condition}foreach (var obj in {entryName}) {{");
                    template.WriteLine(indentation, "                    obj.WriteData(writer, this);");
                    template.WriteLine(indentation, "                }");
                } else {
                    template.WriteLine(indentation, $"                {condition}writer.Write({entryName});");
                }
            }

            template.WriteLine(indentation, "            }");
        }

        private static void InnerLoadData(MultiStructItemTemplateBase template, uint indentation, MhwMultiStructData.StructData @struct, MhwMultiStructData.StructData parent = null) {
            if (@struct.customSaveLoad) return;

            var name = @struct.SafeName;

            // Individual LoadData (loop).
            template.WriteLine("");

            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (parent != null) {
                template.WriteLine(indentation, $"            public static ObservableMhwStructCollection<{name}> LoadData(BinaryReader reader, {parent.SafeName} parent) {{");
            } else if (@struct.Has010Link) {
                var targetName = @struct._010Link.@struct.SafeName;
                template.WriteLine(indentation, $"            public static ObservableMhwStructCollection<{name}> LoadData(BinaryReader reader, ObservableMhwStructCollection<{targetName}> lastStruct) {{");
            } else {
                template.WriteLine(indentation, $"            public static ObservableMhwStructCollection<{name}> LoadData(BinaryReader reader) {{");
            }

            template.WriteLine(indentation, $"                var list = new ObservableMhwStructCollection<{name}>();");

            if (@struct.Has010Link) {
                var linkStruct = @struct._010Link.@struct;
                var linkEntry  = @struct._010Link.entry;

                if (linkStruct == null) {
                    template.WriteLine(indentation, $"                var count = (ulong) parent.{linkEntry.SafeName};");
                } else {
                    template.WriteLine(indentation, $"                var countTarget = ({linkStruct.SafeName}) lastStruct.Last();");
                    template.WriteLine(indentation, $"                var count = (ulong) countTarget.{linkEntry.SafeName};");
                }
            } else {
                template.WriteLine(indentation, $"                var count = {@struct.fixedSizeCount}UL;");
            }

            template.WriteLine(indentation, "                for (ulong i = 0; i < count; i++) {");

            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (parent != null) {
                template.WriteLine(indentation, "                    list.Add(LoadData(reader, i, parent));");
            } else {
                template.WriteLine(indentation, "                    list.Add(LoadData(reader, i));");
            }

            template.WriteLine(indentation, "                }");
            template.WriteLine(indentation, "                return list;");
            template.WriteLine(indentation, "            }");

            // Individual LoadData.
            template.WriteLine("");

            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (parent != null) {
                template.WriteLine(indentation, $"            public static {name} LoadData(BinaryReader reader, ulong i, {parent.SafeName} parent) {{");
            } else {
                template.WriteLine(indentation, $"            public static {name} LoadData(BinaryReader reader, ulong i) {{");
            }

            template.WriteLine(indentation, $"                var data = new {name}();");
            template.WriteLine(indentation, "                data.Index = i;");

            foreach (var entry in @struct.entries) {
                var propName  = entry.SafeName;
                var entryName = $"{propName}_raw";

                var condition = "";
                if (entry.condition != null) {
                    condition = $"{entry.condition} ".Replace("|ref|", "data.");
                }

                if (entry.arrayCount > -1) {
                    template.WriteLine(indentation, $"                {condition}data.{entryName} = reader.Read{GetReadType(entry.type)}s({entry.arrayCount});");
                } else if (entry.isNullTerminatedString) {
                    template.WriteLine(indentation, $"                {condition}data.{entryName} = reader.ReadNullTermString();");
                } else if (entry.HasSubStruct) {
                    template.WriteLine(indentation, $"                {condition}data.{entryName} = {entry.subStruct.SafeName}.LoadData(reader, data);");
                    if (!string.IsNullOrEmpty(condition)) {
                        template.WriteLine(indentation, $"                else data.{entryName} = new ObservableCollection<{entry.subStruct.SafeName}>();");
                    }
                } else {
                    template.WriteLine(indentation, $"                {condition}data.{entryName} = reader.Read{GetReadType(entry.type)}();");
                }
            }

            template.WriteLine(indentation, "                return data;");
            template.WriteLine(indentation, "            }");
        }

        private static void MasterLoadData(MultiStructItemTemplateBase template, MhwMultiStructData structData) {
            // Master LoadData.
            template.WriteLine("");
            template.WriteLine("        public override void LoadFile(string targetFile) {");
            template.WriteLine("            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);");
            template.WriteLine("            data = new LinkedList<MhwStructDataContainer>();");

            foreach (var @struct in structData.structs) {
                var name        = @struct.SafeName;
                var targetList  = "";
                var genericType = $"<{name}";

                if (@struct.Has010Link) {
                    var targetName = @struct._010Link.@struct.SafeName;
                    targetList  =  $", {targetName}_.list";
                    genericType += $", {targetName}";
                }

                genericType += ">";

                template.WriteLine($"            var {name}_ = new MhwStructDataContainer{genericType}({name}.LoadData(reader{targetList}), typeof({name}));");

                if (@struct.Has010Link) {
                    template.WriteLine($"            {name}_.SetCountTargetToUpdate({@struct._010Link.@struct.SafeName}_, -1, \"{@struct._010Link.entry.SafeName}\");");
                }

                template.WriteLine($"            data.AddLast({name}_);");
            }

            template.WriteLine("        }");
        }

        public static string GetReadType(Type type) {
            return Type.GetTypeCode(type).ToString();
        }

        public static void WriteLine(this MultiStructItemTemplateBase template, uint indentation, string line) {
            for (var i = 0; i < indentation; i++) {
                template.Write("    ");
            }
            template.WriteLine(line);
        }
    }
}