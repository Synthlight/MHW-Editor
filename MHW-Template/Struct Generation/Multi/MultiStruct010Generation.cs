using System.CodeDom;
using Microsoft.CSharp;

namespace MHW_Template.Struct_Generation.Multi {
    public static class MultiStruct010Generation {
        private static readonly CSharpCodeProvider COMPILER = new CSharpCodeProvider();

        public static void Generate(MultiStruct010TemplateBase template, MhwMultiStructData structData) {
            foreach (var @struct in structData.structs) {
                CreateStruct(template, @struct);
            }
        }

        private static void CreateStruct(MultiStruct010TemplateBase template, MhwMultiStructData.StructData @struct, uint indentation = 0) {
            var name             = @struct.SafeName;
            var innerIndentation = indentation;
            var isInnerStruct    = indentation > 0;

            template.WriteLine("");

            if (!@struct.showVertically || isInnerStruct) {
                template.WriteLine(indentation, $"// {@struct.name}");
                template.WriteLine(indentation, "typedef struct {");
                innerIndentation++;
            }

            foreach (var entry in @struct.entries) {
                if (entry.HasSubStruct) {
                    CreateStruct(template, entry.subStruct, innerIndentation);
                    template.WriteLine("");
                    CreateStructField(template, entry.subStruct, entry, innerIndentation);
                    continue;
                }

                var propName = entry.SafeName;

                var typeString                        = COMPILER.GetTypeOutput(new CodeTypeReference(entry.type));
                if (typeString == "byte") typeString  = "ubyte";
                if (typeString == "sbyte") typeString = "byte";

                if (entry.arrayCount > -1) propName += $"[{entry.arrayCount}]<optimize=false, name=\"{entry.name}\">";
                else propName                       += $"<name=\"{entry.name}\">";

                if (entry.condition != null) {
                    var condition = entry.condition.Replace("|ref|", "").Replace("_raw", "").Replace("parent.", "");
                    template.WriteLine(innerIndentation, $"{condition} {{ {typeString} {propName}; }}");
                } else {
                    template.WriteLine(innerIndentation, $"{typeString} {propName};");
                }
            }

            if (!@struct.showVertically || isInnerStruct) {
                template.WriteLine(indentation, $"}} {name};");

                if (indentation == 0) {
                    template.WriteLine("");
                    CreateStructField(template, @struct, indentation: indentation);
                }
            }
        }

        private static void CreateStructField(MultiStruct010TemplateBase template, MhwMultiStructData.StructData @struct, MhwMultiStructData.Entry entry = null, uint indentation = 0) {
            var name = @struct.SafeName;

            string entryText;

            if (@struct.fixedSizeCount > 1) {
                entryText = $"{name} {name}_[{@struct.fixedSizeCount}]<optimize=false, name=\"{@struct.name}\">;";
            } else if (@struct.Has010Link) {
                var linkStruct = @struct._010Link.@struct;
                var linkEntry  = @struct._010Link.entry;

                string countTarget;
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (linkStruct == null) {
                    countTarget = linkEntry.SafeName;
                } else {
                    countTarget = $"{linkStruct.SafeName}_.{linkEntry.SafeName}";
                }

                entryText = $"{name} {name}_[{countTarget}]<optimize=false, name=\"{@struct.name}\">;";
            } else {
                entryText = $"{name} {name}_<name=\"{@struct.name}\">;";
            }

            if (entry?.condition != null) {
                var condition = entry.condition.Replace("|ref|", "").Replace("_raw", "").Replace("parent.", "");
                template.WriteLine(indentation, $"{condition} {{ {entryText} }}");
            } else {
                template.WriteLine(indentation, entryText);
            }
        }

        public static void WriteLine(this MultiStruct010TemplateBase template, uint indentation, string line) {
            for (var i = 0; i < indentation; i++) {
                template.Write("    ");
            }
            template.WriteLine(line);
        }
    }
}