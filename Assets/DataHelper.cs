using System.Collections.Generic;
using System.Linq;
using System.Text;
using MHW_Editor.Models;
using Newtonsoft.Json;

namespace MHW_Editor.Assets {
    public static class DataHelper {
        public static readonly Dictionary<uint, string> rawItems;
        public static readonly Dictionary<ushort, Skill> skillData;
        public static readonly Dictionary<string, ushort> skillDataNameLookup;
        public static readonly Dictionary<ushort, string> armorData;
        public static readonly Dictionary<string, Dictionary<uint, string>> weaponData = new Dictionary<string, Dictionary<uint, string>>();
        public static readonly Dictionary<uint, string> dummyDict = new Dictionary<uint, string>();

        static DataHelper() {
            rawItems = LoadDict<uint, string>(MHW_Editor.Assets.Assets.rawItems);

            var skillDataJson = Encoding.UTF8.GetString(MHW_Editor.Assets.Assets.skillData);
            var skillDataList = JsonConvert.DeserializeObject<List<Skill>>(skillDataJson);
            skillData = skillDataList.ToDictionary(skill => skill.value);
            skillDataNameLookup = skillDataList.ToDictionary(skill => skill.name, skill => skill.value);

            armorData = LoadDict<ushort, string>(MHW_Editor.Assets.Assets.armorData);

            weaponData.Add(nameof(MHW_Editor.Assets.Assets.bow), LoadDict<uint, string>(MHW_Editor.Assets.Assets.bow));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.c_axe), LoadDict<uint, string>(MHW_Editor.Assets.Assets.c_axe));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.g_lance), LoadDict<uint, string>(MHW_Editor.Assets.Assets.g_lance));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.hammer), LoadDict<uint, string>(MHW_Editor.Assets.Assets.hammer));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.hbg), LoadDict<uint, string>(MHW_Editor.Assets.Assets.hbg));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.l_sword), LoadDict<uint, string>(MHW_Editor.Assets.Assets.l_sword));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.lance), LoadDict<uint, string>(MHW_Editor.Assets.Assets.lance));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.lbg), LoadDict<uint, string>(MHW_Editor.Assets.Assets.lbg));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.rod), LoadDict<uint, string>(MHW_Editor.Assets.Assets.rod));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.s_axe), LoadDict<uint, string>(MHW_Editor.Assets.Assets.s_axe));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.sword), LoadDict<uint, string>(MHW_Editor.Assets.Assets.sword));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.tachi), LoadDict<uint, string>(MHW_Editor.Assets.Assets.tachi));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.w_sword), LoadDict<uint, string>(MHW_Editor.Assets.Assets.w_sword));
            weaponData.Add(nameof(MHW_Editor.Assets.Assets.whistle), LoadDict<uint, string>(MHW_Editor.Assets.Assets.whistle));
        }

        private static Dictionary<K, V> LoadDict<K, V>(byte[] data) {
            var json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Dictionary<K, V>>(json);
        }
    }
}