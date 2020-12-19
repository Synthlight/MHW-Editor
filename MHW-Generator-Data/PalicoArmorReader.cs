using System.Collections.Generic;
using MHW_Editor.Assets;
using MHW_Editor.Structs.Armors;
using MHW_Template;
using MHW_Template.Armors;

namespace MHW_Generator_Data {
    public static class PalicoArmorReader {
        public static IEnumerable<OtomoArmorDat.Entries> GetPalicoArmors() {
            // ReSharper disable once StringLiteralTypo
            const string targetFile = @"V:\MHW\IB\chunk_combined\common\equip\otomoArmor.oam_dat";

            return OtomoArmorDat.LoadData(targetFile).GetSingleStructList();
        }

        public static LangMap GetPalicoArmorsByModelId(HeadOrBody headOrBody) {
            var map = new LangMap();
            foreach (var lang in Global.LANGUAGES) {
                map[lang] = new Dictionary<uint, string>();
            }

            foreach (var armor in GetPalicoArmors()) {
                if (armor.Equip_Slot == ArmorType.Head && headOrBody != HeadOrBody.Head) continue;
                if (armor.Equip_Slot == ArmorType.Chest && headOrBody != HeadOrBody.Body) continue;

                foreach (var lang in Global.LANGUAGES) {
                    map[lang][armor.Model_Id] = DataHelper.otomoArmorData[lang][armor.GMD_Name_Index];
                }
            }

            return map;
        }
    }
}