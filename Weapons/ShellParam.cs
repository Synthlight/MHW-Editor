using System.Collections.Generic;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellParam : ICustomSaveLoad {
        public partial class Assets {
            public string Name {
                get {
                    return index switch {
                        0 => "Model",
                        1 => "Effect",
                        2 => "Muzzle Effect",
                        3 => "Scroll Hit Effect",
                        4 => "Wall Scroll Hit Effect",
                        5 => "Object Hit Effect",
                        6 => "Delay Set Effect",
                        7 => "Life End Effect",
                        8 => "Locus Epv Res",
                        9 => "Em Reflect Epv Res",
                        10 => "Custom Epv Res 0",
                        11 => "Custom Epv Res 1",
                        12 => "Custom Epv Res 2",
                        13 => "Sound",
                        14 => "Muzzle Effect Sound",
                        15 => "Scroll Hit Effect Sound",
                        16 => "Wall Scroll Hit Effect Sound",
                        17 => "Object Hit Effect Sound",
                        18 => "Delay Set Effect Sound",
                        19 => "Life End Effect Sound",
                        20 => "Locus Epv Sound",
                        21 => "Em Reflect Epv Sound",
                        22 => "Custom Epv Sound 0",
                        23 => "Custom Epv Sound 1",
                        24 => "Custom Epv Sound 2",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Linked_Shell_Params {
            public static ulong GetEntryCount(List<MhwStructWrapper> data) {
                return data.GetEntry<Number_of_Linked_Shell_Params_Holder>(typeof(Number_of_Linked_Shell_Params_Holder))?.Number_of_Linked_Shell_Params ?? 0;
            }
        }

        public partial class Modifiers {
            public static ulong GetEntryCount(List<MhwStructWrapper> data) {
                return data.GetEntry<Number_of_Modifiers_Holder>(typeof(Number_of_Modifiers_Holder))?.Number_of_Modifiers ?? 0;
            }
        }
    }
}