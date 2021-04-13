using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using MHW_Editor;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;
using Newtonsoft.Json;

namespace MHW_Generator_Data {
    public static class Program {
        private const           string       CHUNK_PREFIX = "chunkG";
        private static readonly List<string> FILE_TYPES_TO_CHECK;

        static Program() {
            FILE_TYPES_TO_CHECK = Global.FILE_TYPES.ToList().Select(s => s.Replace("*.", "")).ToList();

            FILE_TYPES_TO_CHECK.AddRange(new List<string> {
                "gmd",
                "sobj"
            });
            for (var i = 0; i <= 13; i++) {
                FILE_TYPES_TO_CHECK.Add($"w{i.ToString().PadLeft(2, '0')}p");
            }

            FILE_TYPES_TO_CHECK = FILE_TYPES_TO_CHECK.Distinct().ToList();
        }

        [STAThread]
        public static void Main() {
            CreateEditorDataLookup();
            CreateArmorDataValueClass();
            CreateSkillDataValueClass();
            GenButtonLocalizationAndIdList();
            if (Environment.GetCommandLineArgs().ContainsIgnoreCase("-justData")) return;
            GenKnownLengths();
            GenOutdatedHashes(); // This can take a while as it does extraction. Use '-skipExtract' to skip the extraction part.
        }

        private static void CreateEditorDataLookup() {
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\ArmorNameLookupById.json", JsonConvert.SerializeObject(ArmorReader.GetAllArmors(IndexOrId.Id), Formatting.Indented));
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\ArmorNameLookupByIndex.json", JsonConvert.SerializeObject(ArmorReader.GetAllArmors(IndexOrId.Index), Formatting.Indented));
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\ArmorNameLookupByFileIndex.json", JsonConvert.SerializeObject(ArmorReader.GetArmorByFileIndex(), Formatting.Indented));
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\WeaponNameLookupById.json", JsonConvert.SerializeObject(WeaponReader.GetAllWeapons(IndexOrId.Id), Formatting.Indented));
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\WeaponNameLookupByIndex.json", JsonConvert.SerializeObject(WeaponReader.GetAllWeapons(IndexOrId.Index), Formatting.Indented));
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\GemItemIds.json", JsonConvert.SerializeObject(ItemReader.GetGemIds(), Formatting.Indented));
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\PalicoArmorHeadLookupByModelId.json", JsonConvert.SerializeObject(PalicoArmorReader.GetPalicoArmorsByModelId(HeadOrBody.Head), Formatting.Indented));
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\PalicoArmorBodyLookupByModelId.json", JsonConvert.SerializeObject(PalicoArmorReader.GetPalicoArmorsByModelId(HeadOrBody.Body), Formatting.Indented));
            File.WriteAllText($@"{Global.ASSETS_ROOT}\EditorData\ItemRarityById.json", JsonConvert.SerializeObject(ItemReader.GetItemRarityByIds(), Formatting.Indented));
        }

        private static void GenButtonLocalizationAndIdList() {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                                 .SelectMany(s => s.GetTypes())
                                 .Where(p => p.Is(typeof(MhwStructItem)));

            var typesWithButtons = new SortedSet<string>();
            var buttonNames      = new SortedSet<string>();
            var typeAndName      = new Dictionary<Type, List<string>>();

            foreach (var type in types) {
                var propertyNames = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                                        .Select(p => p.Name)
                                        .ToList();

                var buttons = propertyNames.Where(name => name.EndsWith("_button") && propertyNames.Contains(name.Replace("_button", "")))
                                           .Distinct()
                                           .ToList();

                if (buttons.Any()) {
                    typesWithButtons.Add(type.Name);
                    if (type.DeclaringType?.IsGeneric(typeof(MhwMultiStructFile<>)) ?? false) {
                        typesWithButtons.Add(type.DeclaringType.Name);
                    }

                    typeAndName[type] = buttons;
                }

                foreach (var button in buttons) {
                    buttonNames.Add(button);
                }
            }

            const string @namespace = "MHW_Editor";
            const string className  = "ButtonTypeInfo";

            MHW_Generator.Program.WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", className, new ButtonTypeInfoTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"typesWithButtons", typesWithButtons},
                    {"buttonNames", buttonNames},
                    {"typeAndName", typeAndName}
                }
            });
        }

        private static void GenOutdatedHashes() {
            if (!Environment.GetCommandLineArgs().ContainsIgnoreCase("-skipExtract")) {
                ExtractFilesToHash();
            }

            var allFilesMap = new Dictionary<string, List<string>>();

            // Get all known editable files in all chunks.
            foreach (var tld in Directory.EnumerateDirectories(Global.CHUNK_HASHING_ROOT, "*", SearchOption.TopDirectoryOnly)) {
                var tldFolder = Path.GetFileName(tld);
                allFilesMap[tldFolder ?? throw new InvalidOperationException()] = GetMatchingFiles(tld);
            }

            var allFilesMapKeys = allFilesMap.Keys.OrderByDescending(key => int.Parse(key.Replace(CHUNK_PREFIX, ""))).ToList();
            allFilesMapKeys.Remove("chunkG60");

            var    badHashMap     = new Dictionary<string, Dictionary<string, List<string>>>();
            var    foundGoodFiles = new Dictionary<string, string>();
            var    filePathMap    = new Dictionary<string, string>();
            ushort loopCount      = 0;

            // So we go through with latest chunk being first.
            foreach (var tld in allFilesMapKeys) {
                var chunkFiles = allFilesMap[tld];

                foreach (var chunkFile in chunkFiles) {
                    var fileName = Path.GetFileName(chunkFile) ?? throw new InvalidOperationException();
                    var rootPath = $"{Global.CHUNK_HASHING_ROOT}\\{tld}";
                    var filePath = chunkFile.Replace(rootPath, "");

                    if (loopCount == 0) {
                        if (foundGoodFiles.ContainsKey(fileName)) continue; // Happens when we have a duplicate file.

                        foundGoodFiles[fileName] = tld;
                        filePathMap[fileName]    = filePath;
                        continue;
                    }

                    if (foundGoodFiles.ContainsKey(fileName)) {
                        // Happens for duplicates too.
                        badHashMap.GetOrCreate(tld).GetOrCreate(fileName).Add(chunkFile.SHA512());
                    } else {
                        foundGoodFiles[fileName] = tld;
                        filePathMap[fileName]    = filePath;
                    }
                }

                loopCount++;
            }

            // Ignore as the wales was reverted in chunk2 and has the same hash as in chunk0.
            badHashMap["chunkG0"].Remove("deco_lot.diot");

            foundGoodFiles = foundGoodFiles.Sort(pair => pair.Key);
            filePathMap    = filePathMap.Sort(pair => pair.Key);
            badHashMap     = badHashMap.Sort(pair => int.Parse(pair.Key.Replace(CHUNK_PREFIX, "")));

            foreach (var key in badHashMap.Keys.ToList()) {
                badHashMap[key] = badHashMap[key].Sort(pair => pair.Key);
            }

            File.WriteAllText(@$"{Global.ASSETS_ROOT}\EditorData\BadHashMap.json", JsonConvert.SerializeObject(badHashMap, Formatting.Indented));
            File.WriteAllText(@$"{Global.ASSETS_ROOT}\EditorData\GoodChunkMap.json", JsonConvert.SerializeObject(foundGoodFiles, Formatting.Indented));
            File.WriteAllText(@$"{Global.ASSETS_ROOT}\EditorData\FilePathMap.json", JsonConvert.SerializeObject(filePathMap, Formatting.Indented));
        }

        private static void ExtractFilesToHash() {
            // Clear old files first.
            DeleteDirectories(Global.CHUNK_HASHING_ROOT);

            const string mhwNoChunkRoot = @"..\..\..\..\MHWNoChunk\MHWNoChunk\bin\x64\Release";

            const string ROOT = @"V:\MHW\IB";
            foreach (var chunkFile in Directory.EnumerateFiles(ROOT, "*.bin", SearchOption.TopDirectoryOnly)) {
                var startInfo = new ProcessStartInfo($@"{mhwNoChunkRoot}\MHWNoChunk.exe") {
                    WorkingDirectory = mhwNoChunkRoot,
                    Arguments        = $"{Path.GetFileNameWithoutExtension(chunkFile)} ^(.*\\.(({string.Join("|", FILE_TYPES_TO_CHECK)})$))?[^.]*$",
                    UseShellExecute  = false
                };

                Process.Start(startInfo)?.WaitForExit();
            }
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
            var fileSizeMap = new Dictionary<string, ulong>();

            // Limit the roots so we don't spend forever searching the whole thing.
            var rootsToSearch = new List<string> {
                $@"{Global.CHUNK_ROOT}\common",
                $@"{Global.CHUNK_ROOT}\em",
                $@"{Global.CHUNK_ROOT}\hm",
                $@"{Global.CHUNK_ROOT}\quest",
                $@"{Global.CHUNK_ROOT}\stage"
            };

            foreach (var path in rootsToSearch.SelectMany(GetMatchingFiles)) {
                using var file = File.OpenRead(path);
                fileSizeMap[Path.GetFileName(path)] = (ulong) file.Length;
            }

            fileSizeMap = fileSizeMap.Sort(pair => pair.Key);

            File.WriteAllText(@$"{Global.ASSETS_ROOT}\EditorData\FileSizeMap.json", JsonConvert.SerializeObject(fileSizeMap, Formatting.Indented));
        }

        private static List<string> GetMatchingFiles(string rootPath) {
            return (from path in Directory.EnumerateFiles(rootPath, "*", SearchOption.AllDirectories)
                    from fileType in FILE_TYPES_TO_CHECK
                    where path.EndsWith(fileType.Substring(1))
                    where !path.EndsWith("\\object.col") // Exclude due to there being 1600+ of them.
                    where !path.EndsWith(".dtt_agr") // Names aren't unique.
                    where !path.EndsWith(".dtt_eda") // Names aren't unique.
                    where !path.EndsWith(".dtt_epg") // Names aren't unique.
                    where !path.EndsWith(".dtt_sta") // Names aren't unique.
                    where !path.EndsWith(".mbd") // Names aren't unique.
                    select path)
                   .Distinct()
                   .ToList();
        }

        private static void CreateSkillDataValueClass() {
            var json         = File.ReadAllText($@"{Global.ASSETS_ROOT}\SkillData\eng_skillData.json");
            var rawSkillData = JsonConvert.DeserializeObject<Dictionary<uint, string>>(json);

            var values = new List<DataValuePair>();

            const uint step = 3;
            for (uint index = 0; index < rawSkillData.Count; index += step) {
                var value = (ushort) (index / step);
                var name  = Regex.Replace(rawSkillData[index], @"[^\w\d]+", "_");
                var desc  = rawSkillData[index + 2].Replace("\r\n", " ");

                if (name == "Unavailable") continue;
                if (desc == "Unavailable") desc = null;

                values.Add(new DataValuePair(value, name, desc));
            }

            const string @namespace = "MHW_Editor.Skills";
            const string className  = "SkillDataValueClass";

            MHW_Generator.Program.WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", className, new ValueClassTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"valueDataPairs", values}
                }
            });
        }

        private static void CreateArmorDataValueClass() {
            var json         = File.ReadAllText($@"{Global.ASSETS_ROOT}\ArmorData\eng_armorData.json");
            var armorGmdData = JsonConvert.DeserializeObject<Dictionary<ushort, string>>(json);
            var armors       = ArmorReader.GetArmor();

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
            const string className  = "ArmorDataValueClass";

            MHW_Generator.Program.WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", className, new ValueClassTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"valueDataPairs", values}
                }
            });
        }
    }
}