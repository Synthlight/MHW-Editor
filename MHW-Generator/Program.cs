using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator {
    public static class Program {
        [STAThread]
        public static void Main() {
            var types = Assembly.GetExecutingAssembly()
                                .GetTypes()
                                .Where(type => type.Is(typeof(IMultiStruct)) && !type.IsInterface)
                                .ToList();

            // TODO: Check file name & file type generation for duplicates.

            foreach (var type in types) {
                var instance = (IMultiStruct) Activator.CreateInstance(type);
                var data     = instance.Generate();
                GenerateMultiStructProps(data.@namespace, data.className, data.mhwMultiStructData);
            }
        }

        public static void GenerateMultiStructProps(string @namespace, string className, MhwMultiStructData structData) {
            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", className, new MultiStructItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });

            WriteResult($"{Global._010_OUTPUT_ROOT}", structData.ext, new MultiStruct010Template {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"structData", structData}
                }
            }, "bt");
        }

        public static void WriteResult(string dir, string className, dynamic template, string ext = "cs") {
            template.Initialize();
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllText($"{dir}\\{className}.{ext}", (string) template.TransformText());
        }
    }
}