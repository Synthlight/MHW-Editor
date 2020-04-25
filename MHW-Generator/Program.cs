using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator {
    public static class Program {
        [STAThread]
        public static void Main() {
            var types = Assembly.GetExecutingAssembly()
                                .GetTypes()
                                .Where(type => (type.Is(typeof(ISingleStruct)) || type.Is(typeof(IVerticalStruct)) || type.Is(typeof(IMultiStruct))) && !type.IsInterface)
                                .ToList();

            foreach (var type in types) {
                if (type.Is(typeof(ISingleStruct))) {
                    var instance = (ISingleStruct) Activator.CreateInstance(type);
                    var data = instance.Generate();
                    GenerateSingleStructProps(data.@namespace, data.className, data.mhwStructData);
                } else if (type.Is(typeof(IVerticalStruct))) {
                    var instance = (IVerticalStruct) Activator.CreateInstance(type);
                    var data = instance.Generate();
                    GenerateVerticalStructProps(data.@namespace, data.className, data.mhwStructData);
                } else if (type.Is(typeof(IMultiStruct))) {
                    var instance = (IMultiStruct) Activator.CreateInstance(type);
                    var data = instance.Generate();
                    GenerateMultiStructProps(data.@namespace, data.className, data.mhwMultiStructData);
                }
            }
        }

        public static void GenerateSingleStructProps(string @namespace, string className, MhwStructData structData) {
            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new ItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });

            WriteResult($"{Global.STRUCT_OUTPUT_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new RawStructTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });
        }

        public static void GenerateVerticalStructProps(string @namespace, string className, MhwStructData structData) {
            GenerateSingleStructProps(@namespace, className, structData);

            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, $"{className}Internal", new PlDataItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });

            WriteResult($"{Global.HEX_010_OUTPUT_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, $"{className}", new Hex010Template {
                Session = new Dictionary<string, object> {
                    {"structData", structData}
                }
            }, "bt");
        }

        public static void GenerateMultiStructProps(string @namespace, string className, MhwMultiStructData structData) {
            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new MultiStructItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });

            // TODO: Need to do something to replace "GetEntryCount".
            //WriteResult($"{Global.HEX_010_OUTPUT_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new HexMultiStruct010Template {
            //    Session = new Dictionary<string, object> {
            //        {"_namespace", @namespace},
            //        {"className", className},
            //        {"structData", structData}
            //    }
            //}, "bt");
        }

        public static void WriteResult(string dir, string @namespace, string className, dynamic template, string ext = "cs") {
            template.Initialize();
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllText($"{dir}\\{className}.{ext}", (string) template.TransformText());
        }
    }
}