using System.Collections.Generic;
using System.Linq;
using System.Text;
using MHW_Editor.Models;
using Newtonsoft.Json;

namespace MHW_Editor.Assets {
    public static class DataHelper {
        public static readonly Dictionary<uint, string> itemData;
        public static readonly Dictionary<ushort, Skill> skillData;
        public static readonly Dictionary<string, ushort> skillDataNameLookup;
        public static readonly Dictionary<ushort, string> armorData;
        public static readonly Dictionary<string, Dictionary<uint, string>> weaponData = new Dictionary<string, Dictionary<uint, string>>();
        public static readonly Dictionary<uint, string> dummyDict = new Dictionary<uint, string>();

        static DataHelper() {
            itemData = LoadDict<uint, string>(Assets.itemData);

            var skillDataJson = Encoding.UTF8.GetString(Assets.skillData);
            var skillDataList = JsonConvert.DeserializeObject<List<Skill>>(skillDataJson);
            skillData = skillDataList.ToDictionary(skill => skill.value);
            skillDataNameLookup = skillDataList.ToDictionary(skill => skill.name, skill => skill.value);

            armorData = LoadDict<ushort, string>(Assets.armorData);

            weaponData.Add(nameof(Assets.bow), LoadDict<uint, string>(Assets.bow));
            weaponData.Add(nameof(Assets.c_axe), LoadDict<uint, string>(Assets.c_axe));
            weaponData.Add(nameof(Assets.g_lance), LoadDict<uint, string>(Assets.g_lance));
            weaponData.Add(nameof(Assets.hammer), LoadDict<uint, string>(Assets.hammer));
            weaponData.Add(nameof(Assets.hbg), LoadDict<uint, string>(Assets.hbg));
            weaponData.Add(nameof(Assets.l_sword), LoadDict<uint, string>(Assets.l_sword));
            weaponData.Add(nameof(Assets.lance), LoadDict<uint, string>(Assets.lance));
            weaponData.Add(nameof(Assets.lbg), LoadDict<uint, string>(Assets.lbg));
            weaponData.Add(nameof(Assets.rod), LoadDict<uint, string>(Assets.rod));
            weaponData.Add(nameof(Assets.s_axe), LoadDict<uint, string>(Assets.s_axe));
            weaponData.Add(nameof(Assets.sword), LoadDict<uint, string>(Assets.sword));
            weaponData.Add(nameof(Assets.tachi), LoadDict<uint, string>(Assets.tachi));
            weaponData.Add(nameof(Assets.w_sword), LoadDict<uint, string>(Assets.w_sword));
            weaponData.Add(nameof(Assets.whistle), LoadDict<uint, string>(Assets.whistle));
        }

        private static Dictionary<K, V> LoadDict<K, V>(byte[] data) {
            var json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Dictionary<K, V>>(json);
        }
    }
}