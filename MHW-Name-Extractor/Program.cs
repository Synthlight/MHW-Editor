using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using MHW_Name_Extractor.Structs;
using MHW_Template;
using Newtonsoft.Json;

namespace MHW_Name_Extractor {
    public static class Program {
        [STAThread]
        public static void Main() {
            foreach (var lang in Global.LANGUAGES) {
                // ReSharper disable once StringLiteralTypo
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\armor_{lang}.gmd", $@"{Global.ASSETS_ROOT}\ArmorData\{lang}_armorData.json"); // .am_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\item_{lang}.gmd", $@"{Global.ASSETS_ROOT}\ItemData\{lang}_itemData.json"); // .itm
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\skill_pt_{lang}.gmd", $@"{Global.ASSETS_ROOT}\SkillData\{lang}_skillData.json"); // .sgpa
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\ot_weapon_{lang}.gmd", $@"{Global.ASSETS_ROOT}\OtomoData\{lang}_otomo_weaponData.json"); // .owp_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\ot_armor_{lang}.gmd", $@"{Global.ASSETS_ROOT}\OtomoData\{lang}_otomo_armorData.json"); // .oam_dat
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\rod_insect_{lang}.gmd", $@"{Global.ASSETS_ROOT}\InsectData\{lang}_insectData.json"); // .rod_inse
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\l_mission_{lang}.gmd", $@"{Global.ASSETS_ROOT}\BountyData\{lang}_bountyData.json"); // .odr
                // Not sure how it connects to skill id.
                GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\vfont\music_skill_{lang}.gmd", $@"{Global.ASSETS_ROOT}\MusicSkillData\{lang}_musicSkillData.json", true);

                foreach (var weapon in Global.WEAPONS) {
                    GetAndWriteGmdStringsAsJson($@"{Global.COMMON_TEXT_ROOT}\steam\{weapon}_{lang}.gmd", $@"{Global.ASSETS_ROOT}\WeaponData\{lang}_{weapon}.json");
                }
            }
        }

        private static void GetAndWriteGmdStringsAsJson(string targetFile, string destFile, bool includeKeys = false) {
            object gmdStrings;
            if (includeKeys) {
                gmdStrings = GetGmdStringsWithKeys(targetFile);
            } else {
                gmdStrings = GetGmdStrings(targetFile);
            }

            var dir = Path.GetDirectoryName(destFile);
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllText(destFile, JsonConvert.SerializeObject(gmdStrings, Formatting.Indented));
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

        private static Dictionary<ulong, List<string>> GetGmdStringsWithKeys(string targetFile) {
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

                var dictionary = new Dictionary<ulong, List<string>>();
                for (long i = 0; i < stringBlocks.LongLength; i++) {
                    dictionary.Add((ulong) i, new List<string> {
                        keyBlocks[i],
                        stringBlocks[i]
                            .Replace("<ICON ALPHA>", " α")
                            .Replace("<ICON BETA>", " β")
                            .Replace("<ICON GAMMA>", " γ")
                    });
                }

                return dictionary;
            }
        }
    }
}