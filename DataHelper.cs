using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using MHW_Editor.Gems;
using Newtonsoft.Json;

namespace MHW_Editor {
    public static class DataHelper {
        public static TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        public static readonly Dictionary<uint, string> rawItems;
        public static readonly Dictionary<ushort, Skill> skillData;
        public static readonly Dictionary<string, ushort> skillDataNameLookup;
        public static readonly Dictionary<ushort, string> armorData;

        static DataHelper() {
            var rawItemsJson = Encoding.UTF8.GetString(Assets.Assets.rawItems);
            rawItems = JsonConvert.DeserializeObject<Dictionary<uint, string>>(rawItemsJson);

            var skillDataJson = Encoding.UTF8.GetString(Assets.Assets.skillData);
            var skillDataList = JsonConvert.DeserializeObject<List<Skill>>(skillDataJson);
            skillData = skillDataList.ToDictionary(skill => skill.value);
            skillDataNameLookup = skillDataList.ToDictionary(skill => skill.name, skill => skill.value);

            var armorDataJson = Encoding.UTF8.GetString(Assets.Assets.armorData);
            armorData = JsonConvert.DeserializeObject<Dictionary<ushort, string>>(armorDataJson);
        }
    }
}