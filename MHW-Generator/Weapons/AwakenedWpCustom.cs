using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class AwakenedWpCustom : ISingleStruct {
        public SingleStruct Generate() { // .em104wcd
            return new SingleStruct("MHW_Editor.Weapons", "AwakenedWpCustom", new MhwStructData {
                size             = 10,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(short)),
                    new MhwStructData.Entry("Unk2", 2, typeof(short)),
                    new MhwStructData.Entry("Unk3", 4, typeof(ushort)),
                    new MhwStructData.Entry("Unk4", 6, typeof(ushort)),
                    new MhwStructData.Entry("Unk5", 8, typeof(ushort))
                }
            });
        }
    }
}