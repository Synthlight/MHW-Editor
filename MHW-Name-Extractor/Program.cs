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
        private const string ROOT_OUTPUT = @"..\..\..\Assets";
        private const string COMMON_TEXT_ROOT = @"V:\MHW\IB\chunk\common\text";
        private static readonly List<string> WEAPONS = new List<string> {"bow", "c_axe", "g_lance", "hammer", "hbg", "lance", "lbg", "l_sword", "rod", "sword", "s_axe", "tachi", "whistle", "w_sword"};

        [STAThread]
        public static void Main() {
            // ReSharper disable StringLiteralTypo
            GetAndWriteGmdStringsAsJson($@"{COMMON_TEXT_ROOT}\steam\armor_eng.gmd", $@"{ROOT_OUTPUT}\armorData.json");
            GetAndWriteGmdStringsAsJson($@"{COMMON_TEXT_ROOT}\steam\item_eng.gmd", $@"{ROOT_OUTPUT}\itemData.json");
            GetAndWriteGmdStringsAsJson($@"{COMMON_TEXT_ROOT}\vfont\skill_pt_eng.gmd", $@"{ROOT_OUTPUT}\skillData.json");

            foreach (var weapon in WEAPONS) {
                GetAndWriteGmdStringsAsJson($@"{COMMON_TEXT_ROOT}\steam\{weapon}_eng.gmd", $@"{ROOT_OUTPUT}\WeaponData\{weapon}.json");
            }
        }

        private static void GetAndWriteGmdStringsAsJson(string targetFile, string destFile) {
            var gmdStrings = GetGmdStrings(targetFile);
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
    }
}