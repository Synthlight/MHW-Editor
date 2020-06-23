using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MHW_Name_Extractor.Structs;
using MHW_Template;
using MHW_Template.Models;
using Newtonsoft.Json;

namespace MHW_Name_Extractor {
    public static class Program {
        [STAThread]
        public static void Main() {
            CreateColTranslations();
            CreateEditorTranslations();

            if (Environment.GetCommandLineArgs().ContainsIgnoreCase("-transOnly")) return;

            foreach (var lang in Global.LANGUAGES) {
                // ReSharper disable once StringLiteralTypo
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\charm_{lang}.gmd", $@"{Global.ASSETS_ROOT}\PendantData\{lang}_pendantData.json"); // .ch_dat
                //GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\l_delivery_{lang}.gmd", $@"{Global.ASSETS_ROOT}\DeliveryData\{lang}_deliveryData.json"); // .stmp
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\l_mission_{lang}.gmd", $@"{Global.ASSETS_ROOT}\BountyData\{lang}_bountyData.json"); // .odr
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\armor_{lang}.gmd", $@"{Global.ASSETS_ROOT}\ArmorData\{lang}_armorData.json"); // .am_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\item_{lang}.gmd", $@"{Global.ASSETS_ROOT}\ItemData\{lang}_itemData.json"); // .itm
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\ot_armor_{lang}.gmd", $@"{Global.ASSETS_ROOT}\OtomoData\{lang}_otomo_armorData.json"); // .oam_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\ot_weapon_{lang}.gmd", $@"{Global.ASSETS_ROOT}\OtomoData\{lang}_otomo_weaponData.json"); // .owp_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\rod_insect_{lang}.gmd", $@"{Global.ASSETS_ROOT}\InsectData\{lang}_insectData.json"); // .rod_inse
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\a_skill_{lang}.gmd", $@"{Global.ASSETS_ROOT}\MantleData\{lang}_mantleData.json"); // .rod_inse
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\ew_limit_break_{lang}.gmd", $@"{Global.ASSETS_ROOT}\AwakeningData\{lang}_awakeningData.json"); // .em104lb/r
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\skill_pt_{lang}.gmd", $@"{Global.ASSETS_ROOT}\SkillData\{lang}_skillData.json"); // .sgpa
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\customParts_{lang}.gmd", $@"{Global.ASSETS_ROOT}\CustomPartsData\{lang}_customPartsData.json"); // .cus_pa/r

                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\GC_BG_{lang}.gmd", $@"{Global.ASSETS_ROOT}\GuildCardData\Backgrounds\{lang}_backgroundData.json"); // .gcod
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\GC_Title_1_{lang}.gmd", $@"{Global.ASSETS_ROOT}\GuildCardData\Titles\{lang}_titles1Data.json"); // .gcod
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\GC_Title_2_{lang}.gmd", $@"{Global.ASSETS_ROOT}\GuildCardData\Titles\{lang}_titles2Data.json"); // .gcod
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\GC_Facial_{lang}.gmd", $@"{Global.ASSETS_ROOT}\GuildCardData\Expressions\{lang}_expressionData.json"); // .gcod
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\GC_Pose_{lang}.gmd", $@"{Global.ASSETS_ROOT}\GuildCardData\Poses\{lang}_poseData.json"); // .gcod

                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\em_names_{lang}.gmd", $@"{Global.ASSETS_ROOT}\MonsterData\{lang}_monsterData.json"); // Monster Id lookup.

                // Not sure how it connects to skill id.
                //GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\music_skill_{lang}.gmd", $@"{Global.ASSETS_ROOT}\MusicSkillData\{lang}_musicSkillData.json");

                foreach (var weapon in Global.WEAPONS) {
                    GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\{weapon}_{lang}.gmd", $@"{Global.ASSETS_ROOT}\WeaponData\{lang}_{weapon}.json");
                }
            }
        }

        private static void CreateEditorTranslations() {
            var trans = new Dictionary<string, Dictionary<string, string>>();

            foreach (var file in Directory.EnumerateFiles(@"..\..\..\Translations", "*.csv", SearchOption.TopDirectoryOnly)) {
                var langKey = Path.GetFileNameWithoutExtension(file);
                var entries = ParseEditorCsv(file);
                if (entries.Count == 0) continue;

                trans[langKey ?? throw new InvalidOperationException()] = entries;
            }

            WriteToFile($@"{Global.ASSETS_ROOT}\EditorData\Translations.json", trans);
        }

        private static Dictionary<string, string> ParseEditorCsv(string file) {
            var dict = new Dictionary<string, string>();

            var text  = File.ReadAllText(file);
            var lines = text.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            var entries = from line in lines.Subsequence(1, lines.Length - 1)
                          let parts = line.Split('|')
                          let original = parts[0]
                          let translated = parts[1]
                          select new {
                              original,
                              translated
                          };

            foreach (var entry in entries) {
                dict[entry.original] = entry.translated;
            }

            return dict;
        }

        private static void CreateColTranslations() {
            var colTrans = new Dictionary<string, Dictionary<int, NameDescPair>>();

            foreach (var file in Directory.EnumerateFiles(@"..\..\..\CollisionTranslations", "*.csv", SearchOption.TopDirectoryOnly)) {
                var entries = ParseColCsv(file);
                if (entries.Count == 0) continue;

                var fileName = Path.GetFileNameWithoutExtension(file)?.Replace('-', '\\');

                colTrans[fileName ?? throw new InvalidOperationException()] = entries;
            }

            WriteToFile($@"{Global.ASSETS_ROOT}\EditorData\CollisionTranslationsData.json", colTrans);
        }

        private static Dictionary<int, NameDescPair> ParseColCsv(string file) {
            var dict = new Dictionary<int, NameDescPair>();

            var text  = File.ReadAllText(file);
            var lines = text.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            var entries = from line in lines.Subsequence(1, lines.Length - 1)
                          where !line.EndsWith(",,,")
                          let parts = line.Split(',')
                          let name = parts[2]
                          let desc = parts[3]
                          where !string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(desc)
                          select new {
                              id = int.Parse(parts[0]), // Skip 1, the untranslated name.
                              name,
                              desc
                          };

            foreach (var entry in entries) {
                dict[entry.id] = new NameDescPair(entry.name, entry.desc);
            }

            return dict;
        }

        private static void WriteToFile(string file, object data) {
            var dir = Path.GetDirectoryName(file);
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir ?? throw new InvalidOperationException());
            }

            File.WriteAllText(file, JsonConvert.SerializeObject(data, Formatting.Indented));
        }

        private static void GetAndWriteGmdStringsAsJson(string targetFile, string destFile, bool includeKeys = false) {
            try {
                object gmdStrings;
                if (includeKeys) {
                    gmdStrings = GetGmdStringsWithKeys(targetFile);
                } else {
                    gmdStrings = GetGmdStrings(targetFile);
                }

                var dir = Path.GetDirectoryName(destFile);
                if (!Directory.Exists(dir)) {
                    Directory.CreateDirectory(dir ?? throw new InvalidOperationException());
                }

                File.WriteAllText(destFile, JsonConvert.SerializeObject(gmdStrings, Formatting.Indented));
            } catch (FileNotFoundException) { // If the file doesn't exist we write empty json.
                File.WriteAllText(destFile, JsonConvert.SerializeObject(new Dictionary<ulong, string>(), Formatting.Indented));
            }
        }

        private static Dictionary<ulong, string> GetGmdStrings(string targetFile) {
            using (var dat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read))) {
                // Header
                dat.BaseStream.Seek(20, SeekOrigin.Begin);
                var keyCount        = dat.ReadInt32();
                var stringCount     = dat.ReadInt32();
                var keyBlockSize    = dat.ReadInt32();
                var stringBlockSize = dat.ReadInt32();
                // ReSharper disable once UnusedVariable (Needed to position ourselves right.)
                var fileName = Encoding.UTF8.GetString(dat.ReadBytes(dat.ReadInt32()));

                dat.BaseStream.Seek(1, SeekOrigin.Current);

                var gmdInfoEntrySize = Marshal.SizeOf(typeof(GmdInfoEntry));
                var gmdInfoEntries   = new List<GmdInfoEntry>();
                for (var i = 0; i < keyCount; i++) {
                    gmdInfoEntries.Add(dat.ReadBytes(gmdInfoEntrySize).GetData<GmdInfoEntry>());
                }

                var buckets = new ulong[256];
                for (var i = 0; i < buckets.Length; i++) {
                    buckets[i] = dat.ReadUInt64();
                }

                var keyBlocks = Encoding.UTF8.GetString(dat.ReadBytes(keyBlockSize)).Split('\0');
                Array.Resize(ref keyBlocks, keyCount); // Last null-term becomes an extra entry.

                var stringBlocks = Encoding.UTF8.GetString(dat.ReadBytes(stringBlockSize)).Split('\0');
                Array.Resize(ref stringBlocks, stringCount); // Last null-term becomes an extra entry.

                if (keyCount != stringCount) {
                    Console.Error.WriteLine($"key/string count mismatch: {targetFile}");
                }

                var dictionary = new Dictionary<ulong, string>();
                for (long i = 0; i < keyBlocks.LongLength; i++) {
                    dictionary.Add((ulong) i, stringBlocks[i]
                                              .Replace("<ICON ALPHA>", " α")
                                              .Replace("<ICON BETA>", " β")
                                              .Replace("<ICON GAMMA>", " γ"));
                }

                return dictionary;
            }
        }

        private static Dictionary<string, string> GetGmdStringsWithKeys(string targetFile) {
            using (var dat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read))) {
                // Header
                dat.BaseStream.Seek(20, SeekOrigin.Begin);
                var keyCount        = dat.ReadInt32();
                var stringCount     = dat.ReadInt32();
                var keyBlockSize    = dat.ReadInt32();
                var stringBlockSize = dat.ReadInt32();
                // ReSharper disable once UnusedVariable (Needed to position ourselves right.)
                var fileName = Encoding.UTF8.GetString(dat.ReadBytes(dat.ReadInt32()));

                dat.BaseStream.Seek(1, SeekOrigin.Current);

                var gmdInfoEntrySize = Marshal.SizeOf(typeof(GmdInfoEntry));
                var gmdInfoEntries   = new List<GmdInfoEntry>();
                for (var i = 0; i < keyCount; i++) {
                    gmdInfoEntries.Add(dat.ReadBytes(gmdInfoEntrySize).GetData<GmdInfoEntry>());
                }

                var buckets = new ulong[256];
                for (var i = 0; i < buckets.Length; i++) {
                    buckets[i] = dat.ReadUInt64();
                }

                var keyBlocks = Encoding.UTF8.GetString(dat.ReadBytes(keyBlockSize)).Split('\0');
                Array.Resize(ref keyBlocks, keyCount); // Last null-term becomes an extra entry.

                var stringBlocks = Encoding.UTF8.GetString(dat.ReadBytes(stringBlockSize)).Split('\0');
                Array.Resize(ref stringBlocks, stringCount); // Last null-term becomes an extra entry.

                if (keyCount != stringCount) {
                    Console.Error.WriteLine($"key/string count mismatch: {targetFile}");
                }

                var dictionary = new Dictionary<string, string>();
                for (long i = 0; i < keyBlocks.LongLength; i++) {
                    dictionary[keyBlocks[i]] = stringBlocks[i]
                                               .Replace("<ICON ALPHA>", " α")
                                               .Replace("<ICON BETA>", " β")
                                               .Replace("<ICON GAMMA>", " γ");
                }

                return dictionary;
            }
        }
    }
}