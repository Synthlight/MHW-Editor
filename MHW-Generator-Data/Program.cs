using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using MHW_Template;
using MHW_Template.Models;
using Newtonsoft.Json;

namespace MHW_Generator_Data {
    public static class Program {
        [STAThread]
        public static void Main() {
            CreateArmorDataValueClass();
            CreateSkillDataValueClass();
            GenKnownLengths();
        }

        private static void GenKnownLengths() {
            var map = new Dictionary<string, ulong>();
            foreach (var path in Directory.EnumerateFiles(Global.COMMON_ROOT, "*.*", SearchOption.AllDirectories)) {
                foreach (var fileType in Global.FILE_TYPES) {
                    if (!path.EndsWith(fileType.Substring(1))) continue;

                    using (var file = File.OpenRead(path)) {
                        map[Path.GetFileName(path)] = (ulong) file.Length;
                    }
                }
            }

            map = map.OrderBy(pair => pair.Key)
                     .ToDictionary(pair => pair.Key, pair => pair.Value);

            const string @namespace = "MHW_Editor";
            const string className = "FileSizes";

            MHW_Generator.Program.WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new FileSizeTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"map", map}
                }
            });
        }

        private static void CreateSkillDataValueClass() {
            var json = File.ReadAllText($@"{Global.ASSETS_ROOT}\SkillData\eng_skillData.json");
            var rawSkillData = JsonConvert.DeserializeObject<Dictionary<uint, string>>(json);

            var values = new List<DataValuePair>();

            const uint step = 3;
            for (uint index = 0; index < rawSkillData.Count; index += step) {
                var value = (ushort) (index / step);
                var name = Regex.Replace(rawSkillData[index], @"[^\w\d]+", "_");
                var desc = rawSkillData[index + 2].Replace("\r\n", " ");

                if (name == "Unavailable") continue;
                if (desc == "Unavailable") desc = null;

                values.Add(new DataValuePair(value, name, desc));
            }

            const string @namespace = "MHW_Editor.Skills";
            const string className = "SkillDataValueClass";

            MHW_Generator.Program.WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new ValueClassTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"valueDataPairs", values}
                }
            });
        }

        private static void CreateArmorDataValueClass() {
            var json = File.ReadAllText($@"{Global.ASSETS_ROOT}\ArmorData\eng_armorData.json");
            var armorGmdData = JsonConvert.DeserializeObject<Dictionary<ushort, string>>(json);
            var armors = ArmorReader.GetArmor();

            var values = new List<DataValuePair>();
            foreach (var armor in armors) {
                var id = armor.Index;
                var name = Regex.Replace(armorGmdData[armor.GMD_Name_Index], @"[^\w\d\+]+", "_")
                                .Replace('α', 'a')
                                .Replace('β', 'b')
                                .Replace('γ', 'y')
                                .Replace("+", "_plus");

                if (name == "Unavailable" || name == "HARDUMMY" || name.Length > 25) continue;
                if (values.Contains(new DataValuePair(0, name, null))) continue;

                values.Add(new DataValuePair((ushort) id, name, null));
            }

            const string @namespace = "MHW_Editor.Armors";
            const string className = "ArmorDataValueClass";

            MHW_Generator.Program.WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new ValueClassTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"valueDataPairs", values}
                }
            });
        }
    }
}