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
            var colTrans = new Dictionary<string, Dictionary<int, NameDescPair>>();

            foreach (var file in Directory.EnumerateFiles(@"..\..\..\CollisionTranslations", "*.csv", SearchOption.TopDirectoryOnly)) {
                var entries = ParseCsv(file);
                if (entries.Count == 0) continue;

                var fileName = Path.GetFileNameWithoutExtension(file)?.Replace('-', '\\');

                colTrans[fileName ?? throw new InvalidOperationException()] = entries;
            }

            var colTransFile = $@"{Global.ASSETS_ROOT}\CollisionTranslationsData.json";
            var dir = Path.GetDirectoryName(colTransFile);
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir ?? throw new InvalidOperationException());
            }

            File.WriteAllText(colTransFile, JsonConvert.SerializeObject(colTrans, Formatting.Indented));

            if (Environment.GetCommandLineArgs().ContainsIgnoreCase("-transOnly")) return;

            foreach (var lang in Global.LANGUAGES) {
                // ReSharper disable once StringLiteralTypo
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\charm_{lang}.gmd", $@"{Global.ASSETS_ROOT}\PendantData\{lang}_pendantData.json"); // .ch_dat
                //GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\l_delivery_{lang}.gmd", $@"{Global.ASSETS_ROOT}\DeliveryData\{lang}_deliveryData.json"); // .stmp
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\l_mission_{lang}.gmd", $@"{Global.ASSETS_ROOT}\BountyData\{lang}_bountyData.json"); // .odr
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\armor_{lang}.gmd", $@"{Global.ASSETS_ROOT}\ArmorData\{lang}_armorData.json"); // .am_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\item_{lang}.gmd", $@"{Global.ASSETS_ROOT}\ItemData\{lang}_itemData.json"); // .itm
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\ot_armor_{lang}.gmd", $@"{Global.ASSETS_ROOT}\OtomoData\{lang}_otomo_armorData.json"); // .oam_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\ot_weapon_{lang}.gmd", $@"{Global.ASSETS_ROOT}\OtomoData\{lang}_otomo_weaponData.json"); // .owp_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\rod_insect_{lang}.gmd", $@"{Global.ASSETS_ROOT}\InsectData\{lang}_insectData.json"); // .rod_inse
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\a_skill_{lang}.gmd", $@"{Global.ASSETS_ROOT}\MantleData\{lang}_mantleData.json"); // .rod_inse
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\skill_pt_{lang}.gmd", $@"{Global.ASSETS_ROOT}\SkillData\{lang}_skillData.json"); // .sgpa

                // Not sure how it connects to skill id.
                //GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\music_skill_{lang}.gmd", $@"{Global.ASSETS_ROOT}\MusicSkillData\{lang}_musicSkillData.json");

                foreach (var weapon in Global.WEAPONS) {
                    GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\{weapon}_{lang}.gmd", $@"{Global.ASSETS_ROOT}\WeaponData\{lang}_{weapon}.json");
                }
            }
        }

        private static Dictionary<int, NameDescPair> ParseCsv(string file) {
            var dict = new Dictionary<int, NameDescPair>();

            var text = File.ReadAllText(file);
            var lines = text.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            var entries = from line in lines.Subsequence(1, lines.Length - 2)
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

        private static void GetAndWriteGmdStringsAsJson(string targetFile, string destFile) {
            try {
                var gmdStrings = GetGmdStrings(targetFile);
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
                var len = dat.BaseStream.Length;

                // Header
                dat.BaseStream.Seek(20, SeekOrigin.Begin);
                var keyCount = dat.ReadInt32();
                var stringCount = dat.ReadInt32();
                var keyBlockSize = dat.ReadInt32();
                var stringBlockSize = dat.ReadInt32();
                var fileName = Encoding.UTF8.GetString(dat.ReadBytes(dat.ReadInt32()));

                dat.BaseStream.Seek(1, SeekOrigin.Current);

                var gmdInfoEntrySize = Marshal.SizeOf(typeof(GmdInfoEntry));
                var gmdInfoEntries = new List<GmdInfoEntry>();
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

                var dictionary = new Dictionary<ulong, string>();
                for (long i = 0; i < stringBlocks.LongLength; i++) {
                    dictionary.Add((ulong) i, stringBlocks[i]
                                              .Replace("<ICON ALPHA>", " α")
                                              .Replace("<ICON BETA>", " β")
                                              .Replace("<ICON GAMMA>", " γ"));
                }

                return dictionary;
            }
        }
    }
}