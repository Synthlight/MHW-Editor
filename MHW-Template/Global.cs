using System.Collections.Generic;

namespace MHW_Template {
    public static class Global {
        // ReSharper disable StringLiteralTypo
        public static readonly Dictionary<string, string> LANGUAGE_NAME_LOOKUP = new Dictionary<string, string> {
            {"ara", "العربية"},
            {"chS", "简体中文"},
            {"chT", "繁體中文"},
            {"eng", "English"},
            {"fre", "Français"},
            {"ger", "Deutsch"},
            {"ita", "Italiano"},
            {"jpn", "日本語"},
            {"kor", "한국어"},
            {"pol", "Polski"},
            {"ptB", "Português do Brasil"},
            {"rus", "Русский"},
            {"spa", "Español"}
        };
        public static readonly List<string> LANGUAGES = new List<string>(LANGUAGE_NAME_LOOKUP.Keys);
        public static readonly List<string> WEAPONS = new List<string> {
            "bow",
            "c_axe",
            "g_lance",
            "hammer",
            "hbg",
            "l_sword",
            "lance",
            "lbg",
            "rod",
            "s_axe",
            "sword",
            "tachi",
            "w_sword",
            "whistle"
        };
    }
}