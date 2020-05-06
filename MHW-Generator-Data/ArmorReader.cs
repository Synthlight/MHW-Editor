using System.Collections.Generic;
using System.IO;
using MHW_Editor.Armors;
using MHW_Editor.Assets;
using MHW_Template;
using MHW_Template.Armors;

namespace MHW_Generator_Data {
    public static class ArmorReader {
        public static IEnumerable<Armor> GetArmor() {
            // ReSharper disable once StringLiteralTypo
            const string targetFile = @"V:\MHW\IB\chunk_combined\common\equip\armor.am_dat";

            using var dat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read));
            dat.BaseStream.Seek(6, SeekOrigin.Begin);
            var count = dat.ReadUInt32();

            dat.BaseStream.Seek(10, SeekOrigin.Begin);

            for (var i = 0; i < count; i++) {
                var position = dat.BaseStream.Position;
                var buff     = dat.ReadBytes((int) Armor.StructSize);

                yield return new Armor(buff, (ulong) position);
            }
        }

        public static LangMap GetArmorByFileIndex() {
            var map = new LangMap();
            foreach (var lang in Global.LANGUAGES) {
                map[lang] = new Dictionary<uint, string>();
            }

            foreach (var armor in GetArmor()) {
                foreach (var lang in Global.LANGUAGES) {
                    map[lang][armor.Index] = DataHelper.armorData[lang][armor.GMD_Name_Index];
                }
            }

            return map;
        }

        public static Dictionary<ArmorType, LangMap> GetAllArmors(IndexOrId by) {
            var values = new Dictionary<ArmorType, LangMap>();

            foreach (var armor in GetArmor()) {
                var armorType                                         = armor.Equip_Slot;
                if (!values.ContainsKey(armorType)) values[armorType] = new LangMap();

                foreach (var lang in Global.LANGUAGES) {
                    if (!values[armorType].ContainsKey(lang)) values[armorType][lang] = new Dictionary<uint, string>();

                    values[armorType][lang][by == IndexOrId.Id ? armor.Set_Group : armor.Index] = DataHelper.armorData[lang][armor.GMD_Name_Index];
                }
            }

            return values;
        }
    }
}