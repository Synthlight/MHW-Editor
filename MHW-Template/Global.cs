using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MHW_Template {
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public static class Global {
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
        public static readonly string[] FILE_TYPES = {
            "*.am_dat",
            "*.arm_up",
            "*.ask",
            "*.bbtbl",
            "*.ch_dat",
            "*.cus_pa",
            "*.cus_par",
            "*.dglt",
            "*.diot",
            "*.emst",
            "*.eq_crt",
            "*.eq_cus",
            "*.gun_rd",
            "*.gun_sd",
            "*.imk",
            "*.itlist",
            "*.itlot",
            "*.itm",
            "*.kire",
            "*.lbm_base",
            "*.lbm_skill",
            "*.mkex",
            "*.mkit",
            "*.msk",
            "*.new_lb",
            "*.new_lbr",
            "*.odr",
            "*.owp_dat",
            "*.oam_dat",
            "*.plfe",
            "*.plip",
            "*.plit",
            "*.plp",
            "*.rem",
            "*.rod_inse",
            "*.sed",
            "*.sgpa",
            "*.shl_tbl",
            "*.skl_dat",
            "*.skl_pt_dat",
            "*.stmp",
            "*.swer",
            "*.swpc",
            "*.swpi",
            "*.swpn",
            "*.trdr",
            "*.trsr",
            "*.wep_glan",
            "*.wep_saxe",
            "*.wep_wsd",
            "*.wep_wsl",
            "*.wp_dat",
            "*.wp_dat_g"
        };
        public const string ASSETS_ROOT = @"..\..\..\Assets";
        public const string GENERATED_ROOT = @"..\..\..\Generated";
        public const string STRUCT_OUTPUT_ROOT = @"..\..\..\Structs";
        public const string CHUNK_HASHING_ROOT = @"V:\MHW\IB\For Hashing";
        public const string CHUNK_ROOT = @"V:\MHW\IB\chunk_combined";
        public const string COMMON_TEXT_ROOT = CHUNK_ROOT + @"\common\text";
    }
}