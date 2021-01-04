using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp12Param : MhwMultiStructFile<Wp12Param> {
        public partial class Ammo_Shifting {
            public string Name => GetAmmoShiftingName(Index);
        }

        public static string GetAmmoShiftingName(ulong index) {
            return index switch {
                0 => "Low Shifting",
                1 => "Average Shifting",
                2 => "Auto-Reload Shifting",
                5 => "Wyvernheart Shifting",
                6 => "High Shifting",
                7 => "High + Feline Meal Shifting",
                9 => "Wyvern Ammo Shifting",
                14 => "Wyvernsnipe Shifting",
                _ => "Unknown"
            };
        }

        public partial class Power_Long_Mod_Params {
            public string Name => GetAmmoShiftingName(Index);
        }

        public static string GetPowerModLongModParamName(ulong index) {
            return index switch {
                0 => "Normal Ammo Lv1",
                1 => "Normal Ammo Lv2",
                2 => "Normal Ammo Lv3",
                3 => "Pierce Ammo Lv1",
                4 => "Pierce Ammo Lv2",
                5 => "Pierce Ammo Lv3",
                6 => "Spread Ammo Lv1",
                7 => "Spread Ammo Lv2",
                8 => "Spread Ammo Lv3",
                9 => "Sticky Ammo Lv1",
                10 => "Sticky Ammo Lv2",
                11 => "Sticky Ammo Lv3",
                12 => "Slicing Ammo",
                13 => "Element Ammo",
                14 => "Dragon Ammo",
                15 => "Status Ammo Lv1",
                16 => "Status Ammo Lv2",
                17 => "Recover Ammo Lv1",
                18 => "Recover Ammo Lv2",
                19 => "Demon Ammo / Armor Ammo",
                20 => "Tranq Ammo",
                21 => "Wyvernheart",
                22 => "Wyvernsnipe",
                23 => "Wyvernsnipe Type 2",
                24 => "HZD Special Ammo?",
                _ => "Unknown"
            };
        }
    }
}