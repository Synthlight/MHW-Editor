using System.CodeDom;
using Microsoft.CSharp;

namespace MHW_Template.Struct_Generation.Multi {
    public static class MultiStruct010Generation {
        private static readonly CSharpCodeProvider COMPILER = new CSharpCodeProvider();

        public static void Generate(MultiStruct010TemplateBase template, MhwMultiStructData structData) {
            foreach (var @struct in structData.structs) {
                CreateStruct(template, @struct);
            }

            template.WriteLine("");

            foreach (var @struct in structData.structs) {
                CreateStructField(template, @struct);
            }
        }

        private static void CreateStruct(MultiStruct010TemplateBase template, MhwMultiStructData.StructData @struct) {
            foreach (var entry in @struct.entries) {
                if (!entry.HasSubStruct) continue;
                CreateStruct(template, entry.subStruct);
            }

            var name = @struct.SafeName;

            template.WriteLine("");
            template.WriteLine("typedef struct {");

            foreach (var entry in @struct.entries) {
                if (entry.HasSubStruct) {
                    CreateStructField(template, entry.subStruct, 1);
                    continue;
                }

                var propName = entry.SafeName;

                var typeString                        = COMPILER.GetTypeOutput(new CodeTypeReference(entry.type));
                if (typeString == "byte") typeString  = "ubyte";
                if (typeString == "sbyte") typeString = "byte";

                if (entry.arrayCount > -1) propName += $"[{entry.arrayCount}]<optimize=false>";

                if (entry.condition != null) {
                    var condition = $"{entry.condition} ".Replace("|ref|", "").Replace("_raw", "");
                    template.WriteLine($"    {condition} {{ {typeString} {propName}; }}");
                } else {
                    template.WriteLine($"    {typeString} {propName};");
                }
            }

            template.WriteLine($"}} {name};");
        }

        private static void CreateStructField(MultiStruct010TemplateBase template, MhwMultiStructData.StructData @struct, uint indentation = 0) {
            var name = @struct.SafeName;

            if (@struct.fixedSizeCount > 1) {
                template.WriteLine(indentation, $"{name} {name}_[{@struct.fixedSizeCount}]<optimize=false>;");
            } else if (@struct._010Link != null) {
                var link = @struct._010Link;
                template.WriteLine(indentation, $"{name} {name}_[{link.@struct.SafeName}_.{link.entry.SafeName}]<optimize=false>;");
            } else {
                template.WriteLine(indentation, $"{name} {name}_;");
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