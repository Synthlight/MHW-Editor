using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using MHW_Template;
using MHW_Template.Models;
using Newtonsoft.Json;

namespace MHW_Generator_Data {
    public static class Program {
        private const string CHUNK_PREFIX = "chunkG";

        [STAThread]
        public static void Main() {
            CreateArmorDataValueClass();
            CreateSkillDataValueClass();
            GenKnownLengths();
            GenOutdatedHashes();
        }

        private static void GenOutdatedHashes() {
            ExtractFilesToHash();

            var allFilesMap = new Dictionary<string, List<string>>();

            // Get all known editable files in all chunks.
            foreach (var tld in Directory.EnumerateDirectories(Global.CHUNK_HASHING_ROOT, "*", SearchOption.TopDirectoryOnly)) {
                var tldFolder = Path.GetFileName(tld);
                allFilesMap[tldFolder ?? throw new InvalidOperationException()] = GetMatchingFiles(tld);
            }

            // So we go through with latest chunk being first.
            allFilesMap = allFilesMap.SortDescending(pair => int.Parse(pair.Key.Replace(CHUNK_PREFIX, "")));

            var hashMap = new Dictionary<string, Dictionary<string, string>>();
            var foundGoodFiles = new Dictionary<string, string>();

            foreach (var tld in allFilesMap.Keys) {
                var chunkFiles = allFilesMap[tld];

                // First time through is always & only good files.
                if (foundGoodFiles.Count == 0) {
                    foreach (var chunkFile in chunkFiles) {
                        foundGoodFiles[Path.GetFileName(chunkFile) ?? throw new InvalidOperationException()] = tld;
                    }

                    continue;
                }

                foreach (var chunkFile in chunkFiles) {
                    var fileName = Path.GetFileName(chunkFile);

                    if (foundGoodFiles.ContainsKey(fileName)) {
                        hashMap.GetOrCreate(tld)[fileName] = chunkFile.SHA512();
                    } else {
                        foundGoodFiles[fileName] = tld;
                    }
                }
            }

            foundGoodFiles = foundGoodFiles.Sort(pair => pair.Key);
            hashMap = hashMap.Sort(pair => int.Parse(pair.Key.Replace(CHUNK_PREFIX, "")));

            foreach (var key in hashMap.Keys.ToList()) {
                hashMap[key] = hashMap[key].Sort(pair => pair.Key);
            }

            const string @namespace = "MHW_Editor";
            const string className = "FileHashes";

            MHW_Generator.Program.WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new FileHashesTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"hashMap", hashMap},
                    {"goodChunkMap", foundGoodFiles}
                }
            });
        }

        private static void ExtractFilesToHash() {
            // Clear old files first.
            DeleteDirectories(Global.CHUNK_HASHING_ROOT);

            const string mhwNoChunkRoot = @"..\..\..\..\MHWNoChunk\MHWNoChunk\bin\x64\Release";

            var startInfo = new ProcessStartInfo($@"{mhwNoChunkRoot}\MHWNoChunk.exe") {
                WorkingDirectory = mhwNoChunkRoot,
                Arguments = $"^(.*\\.(({string.Join("|", Global.FILE_TYPES.ToList().Select(s => s.Replace("*.", "")))})$))?[^.]*$",
                UseShellExecute = false
            };

            Process.Start(startInfo)?.WaitForExit();
        }

        private static void DeleteDirectories(string startLocation) {
            foreach (var directory in Directory.GetDirectories(startLocation)) {
                DeleteDirectories(directory);
                foreach (var file in Directory.EnumerateFiles(directory)) {
                    File.Delete(file);
                }

                try {
                    Directory.Delete(directory);
                } catch (Exception) {
                    // https://stackoverflow.com/a/47398010
                    // Workaround because the recursive delete will throw with an "Directory is not empty" exception after it deletes all the contents of the directory
                    // if the directory is open in the left nav of Windows's explorer tree. This appears to be a caching or queuing latency issue.
                    Thread.Sleep(2000);
                    Directory.Delete(directory);
                }
            }
        }

        private static void GenKnownLengths() {
            var map = new Dictionary<string, ulong>();

            // Limit the roots so we don't spend forever searching the whole thing.
            var rootsToSearch = new List<string> {
                $@"{Global.CHUNK_ROOT}\common",
                $@"{Global.CHUNK_ROOT}\hm",
                $@"{Global.CHUNK_ROOT}\quest",
                $@"{Global.CHUNK_ROOT}\stage"
            };

            foreach (var path in rootsToSearch.SelectMany(GetMatchingFiles)) {
                using (var file = File.OpenRead(path)) {
                    map[Path.GetFileName(path)] = (ulong) file.Length;
                }
            }

            map = map.Sort(pair => pair.Key);

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

        private static List<string> GetMatchingFiles(string rootPath) {
            return (from path in Directory.EnumerateFiles(rootPath, "*.*", SearchOption.AllDirectories)
                    from fileType in Global.FILE_TYPES
                    where path.EndsWith(fileType.Substring(1))
                    select path).ToList();
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