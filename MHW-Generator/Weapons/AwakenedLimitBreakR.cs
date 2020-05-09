using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class AwakenedLimitBreakR : ISingleStruct {
        public SingleStruct Generate() { // .em104lbr
            return new SingleStruct("MHW_Editor.Weapons", "AwakenedLimitBreakR", new MhwStructData {
                size             = 34,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(ushort)),
                    new MhwStructData.Entry("Great Sword", 2, typeof(ushort)),
                    new MhwStructData.Entry("Sword & Shield", 4, typeof(ushort)),
                    new MhwStructData.Entry("Dual Blades", 6, typeof(ushort)),
                    new MhwStructData.Entry("Long Sword", 8, typeof(ushort)),
                    new MhwStructData.Entry("Hammer", 10, typeof(ushort)),
                    new MhwStructData.Entry("Hunting Horn", 12, typeof(ushort)),
                    new MhwStructData.Entry("Lance", 14, typeof(ushort)),
                    new MhwStructData.Entry("Gunlance", 16, typeof(ushort)),
                    new MhwStructData.Entry("Switch Axe", 18, typeof(ushort)),
                    new MhwStructData.Entry("Charge Blade", 20, typeof(ushort)),
                    new MhwStructData.Entry("Insect Glaive", 22, typeof(ushort)),
                    new MhwStructData.Entry("Bow", 24, typeof(ushort)),
                    new MhwStructData.Entry("HBG", 26, typeof(ushort)),
                    new MhwStructData.Entry("LBG", 28, typeof(ushort)),
                    new MhwStructData.Entry("Unk13", 33, typeof(byte))
                }
            });
        }
    }
}