using System;
using System.CodeDom;
using System.Text.RegularExpressions;
using Microsoft.CSharp;

namespace MHW_Template.Struct_Generation.Multi {
    public static class MultiStructGeneration {
        private static readonly CSharpCodeProvider COMPILER = new CSharpCodeProvider();

        public static void Generate(MultiStructItemTemplateBase template, MhwMultiStructData structData) {
            foreach (var @struct in structData.structs) {
                var sortIndex = 50;
                var name      = @struct.SafeName();

                template.WriteLine("");
                //template.WriteLine("        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode, Pack = 1)]");
                template.WriteLine($"        public partial class {name} : MhwStructItem{(@struct.showVertically ? ", IHasCustomView<MultiStructItemCustomView>" : "")} {{");
                template.WriteLine($"            public const ulong FixedSizeCount = {@struct.fixedSizeCount};");
                template.WriteLine($"            public const string GridName = \"{@struct.name}\";");

                if (@struct.hidden) {
                    template.WriteLine($"            public const bool IsHidden = {@struct.hidden.ToString().ToLower()};");
                }

                if (@struct.canAddRows) {
                    template.WriteLine($"            public const bool IsAddingAllowed = {@struct.canAddRows.ToString().ToLower()};");

                    template.WriteLine("");
                    template.WriteLine("            [SortOrder(-1)]");
                    template.WriteLine("            [IsReadOnly]");
                    template.WriteLine("            [DisplayName(\"X\")]");
                    template.WriteLine("            public string Delete => \"X\";");
                }

                foreach (var entry in @struct.entries) {
                    var accessLevel = entry.accessLevel;
                    if (entry.name == "Index") accessLevel         += " override";
                    else if (accessLevel != "private") accessLevel += " virtual";

                    var propName                    = entry.SafeName();
                    if (entry.forceUnique) propName += $"_{sortIndex}";
                    var entryName                   = $"{propName}_raw";

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
                    template.WriteLine($"            protected {typeString} {entryName};");
                    template.WriteLine($"            public const string {propName}_displayName = \"{entry.name}\";");
                    template.WriteLine($"            public const int {propName}_sortIndex = {sortIndex};");
                    template.WriteLine($"            [SortOrder({propName}_sortIndex)]");
                    template.WriteLine($"            [DisplayName({propName}_displayName)]");

                    if (entry.dataSourceType != null) {
                        template.WriteLine($"            [DataSource(DataSourceType.{entry.dataSourceType})]");
                    }

                    if (entry.readOnly) {
                        template.WriteLine("            [IsReadOnly]");
                    }

                    template.WriteLine($"            {accessLevel} {returnString} {propName} {{");

                    if (returnString == "bool") {
                        template.WriteLine($"                get => {getCast}Convert.ToBoolean({entryName});");
                    } else if (typeString == "char[]") {
                        template.WriteLine($"                get => {getCast}new string({entryName});");
                    } else {
                        template.WriteLine($"                get => {getCast}{entryName};");
                    }

                    // Always include a setter, even for readOnly. This enables us to bypass readOnly via command line switch.
                    template.WriteLine("                set {");

                    if (returnString == "bool") {
                        template.WriteLine($"                    if (Convert.ToBoolean({entryName}) == {entry.valueString}) return;"); // Do nothing if the value is the same.
                        template.WriteLine($"                    {entryName} = Convert.ToByte({entry.valueString});");
                    } else if (typeString == "char[]") {
                        template.WriteLine($"                    if ({getCast}new string({entryName}) == {entry.valueString}) return;"); // Do nothing if the value is the same.
                        template.WriteLine($"                    {entryName} = {setCast}{entry.valueString}.ToCharArray(0, {entry.arrayCount - 1});");
                    } else {
                        template.WriteLine($"                    if ({getCast}{entryName} == {entry.valueString}) return;"); // Do nothing if the value is the same.
                        template.WriteLine($"                    {entryName} = {setCast}{entry.valueString};");
                    }

                    template.WriteLine($"                    OnPropertyChanged(nameof({propName}));");

                    if (entry.dataSourceType != null) {
                        template.WriteLine($"                    OnPropertyChanged(nameof({propName}_button));");
                    }

                    if (entry.extraOnPropertyChanged != null) {
                        foreach (var propertyToChange in entry.extraOnPropertyChanged) {
                            var propertyToChangeName = Regex.Replace(propertyToChange, @"[^\w\d]+", "_");

                            template.WriteLine($"                    OnPropertyChanged(nameof({propertyToChangeName}));");
                        }
                    }

                    template.WriteLine("                }");
                    template.WriteLine("            }");
                    // End Main Property.

                    if (entry.dataSourceType != null) {
                        var dataSourceLookup = GenerationHelper.GetDataSourceType(entry.dataSourceType ?? throw new Exception());

                        template.WriteLine("");
                        template.WriteLine($"            [SortOrder({propName}_sortIndex)]");
                        template.WriteLine($"            [DisplayName({propName}_displayName)]");
                        template.WriteLine($"            [CustomSorter(typeof({entry.dataSourceCustomSorter}))]");
                        template.WriteLine($"            public string {propName}_button => {dataSourceLookup}.TryGet({propName}).ToStringWithId({propName});");
                    }

                    if (entry.createPercentField) {
                        template.WriteLine("");
                        template.WriteLine($"            private float _{propName}Percent;");
                        template.WriteLine($"            [SortOrder({propName}_sortIndex + 1)]");
                        template.WriteLine($"            [DisplayName({propName}_displayName + \"%\")]");
                        template.WriteLine($"            public float {propName}_percent {{");
                        template.WriteLine($"                get => _{propName}Percent;");
                        template.WriteLine("                set {");
                        template.WriteLine($"                    _{propName}Percent = value.Clamp(0f, 100f);");
                        template.WriteLine($"                    OnPropertyChanged(nameof({propName}_percent));");
                        template.WriteLine("                }");
                        template.WriteLine("            }");
                    }

                    sortIndex += 50;
                }

                //template.WriteLine("");
                //template.WriteLine("            public override void WriteData(BinaryWriter writer) {");

                InnerLoadData(template, @struct, sortIndex);
                InnerWriteData(template, @struct, sortIndex);

                // GetCustomView (if needed).
                if (@struct.showVertically) {
                    GetCustomView(template, @struct, sortIndex);
                }

                template.WriteLine("        }"); // Inner Class
            }

            MasterLoadData(template, structData);
        }

        private static void GetCustomView(MultiStructItemTemplateBase template, MhwMultiStructData.StructData @struct, int sortIndex) {
            template.WriteLine("");
            template.WriteLine("            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {");
            template.WriteLine("                return new ObservableCollection<MultiStructItemCustomView> {");

            foreach (var entry in @struct.entries) {
                var propName                    = entry.SafeName();
                if (entry.forceUnique) propName += $"_{sortIndex}";

                template.WriteLine($"                    new MultiStructItemCustomView(this, \"{entry.name}\", \"{propName}\"),");
            }

            template.WriteLine("                };");
            template.WriteLine("            }");
        }

        private static void InnerWriteData(MultiStructItemTemplateBase template, MhwMultiStructData.StructData @struct, int sortIndex) {
            // Individual WriteData.
            template.WriteLine("");
            template.WriteLine("            public override void WriteData(BinaryWriter writer) {");

            foreach (var entry in @struct.entries) {
                var propName                    = entry.SafeName();
                if (entry.forceUnique) propName += $"_{sortIndex}";
                var entryName                   = $"{propName}_raw";

                var condition = "";
                if (entry.condition != null) {
                    condition = $"{entry.condition} ".Replace("|ref|", "");
                }

                if (entry.type == typeof(string)) {
                    template.WriteLine($"                {condition}writer.Write({entryName}.ToNullTermCharArray());");
                } else {
                    template.WriteLine($"                {condition}writer.Write({entryName});");
                }
            }

            template.WriteLine("            }");
        }

        private static void MasterLoadData(MultiStructItemTemplateBase template, MhwMultiStructData structData) {
            // Master LoadData.
            template.WriteLine("");
            template.WriteLine("        public override void LoadFile(string targetFile) {");
            template.WriteLine("            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));");
            template.WriteLine("            data = new LinkedList<MhwStructDataContainer>();");

            foreach (var @struct in structData.structs) {
                var name       = @struct.SafeName();
                var targetList = "null";

                if (@struct.fixedSizeCount == 0) {
                    targetList = $"{@struct._010Link.@struct.SafeName()}_.list";
                }

                template.WriteLine($"            var {name}_ = new MhwStructDataContainer({name}.LoadData(reader, {targetList}), typeof({name}));");

                if (@struct.fixedSizeCount == 0) {
                    template.WriteLine($"            {name}_.SetCountTargetToUpdate({@struct._010Link.@struct.SafeName()}_, -1, \"{@struct._010Link.entry.SafeName()}\");");
                }

                template.WriteLine($"            data.AddLast({name}_);");
            }

            template.WriteLine("        }");
        }

        private static void InnerLoadData(MultiStructItemTemplateBase template, MhwMultiStructData.StructData @struct, int sortIndex) {
            var name = @struct.SafeName();

            // Individual LoadData (loop).
            template.WriteLine("");
            template.WriteLine("            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {");
            template.WriteLine("                var list = new ObservableCollection<object>();");

            if (@struct.fixedSizeCount > 0) {
                template.WriteLine("                var count = 1UL;");
            } else {
                template.WriteLine($"                var countTarget = ({@struct._010Link.@struct.SafeName()}) lastStruct.Last();");
                template.WriteLine($"                var count = (ulong) countTarget.{@struct._010Link.entry.SafeName()};");
            }

            template.WriteLine("                for (ulong i = 0; i < count; i++) {");
            template.WriteLine("                    list.Add(LoadData(reader, i));");
            template.WriteLine("                }");
            template.WriteLine("                return list;");
            template.WriteLine("            }");

            // Individual LoadData.
            template.WriteLine("");
            template.WriteLine("            public static MhwStructItem LoadData(BinaryReader reader, ulong i) {");
            template.WriteLine($"                var data = new {name}();");
            template.WriteLine("                data.Index = i;");

            foreach (var entry in @struct.entries) {
                var propName                    = entry.SafeName();
                if (entry.forceUnique) propName += $"_{sortIndex}";
                var entryName                   = $"{propName}_raw";

                var condition = "";
                if (entry.condition != null) {
                    condition = $"{entry.condition} ".Replace("|ref|", "data.");
                }

                if (entry.arrayCount > -1) {
                    template.WriteLine($"                {condition}data.{entryName} = reader.Read{GetReadType(entry.type)}s({entry.arrayCount});");
                } else if (entry.isNullTerminatedString) {
                    template.WriteLine($"                {condition}data.{entryName} = reader.ReadNullTermString();");
                } else {
                    template.WriteLine($"                {condition}data.{entryName} = reader.Read{GetReadType(entry.type)}();");
                }
            }

            template.WriteLine("                return data;");
            template.WriteLine("            }");
        }

        public static string GetReadType(Type type) {
            return Type.GetTypeCode(type).ToString();
        }
    }
}