using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.Weapons {
    public class AwakenedWpUpgrade : ISingleStruct {
        public SingleStruct Generate() { // .em104wud
            return new SingleStruct("MHW_Editor.Weapons", "AwakenedWpUpgrade", new MhwStructData {
                size = 10,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(ushort)),
                    new MhwStructData.Entry("Unk2", 2, typeof(ushort)),
                    new MhwStructData.Entry("Unk3", 4, typeof(ushort)),
                    new MhwStructData.Entry("Unk4", 6, typeof(ushort)),
                    new MhwStructData.Entry("Unk5", 8, typeof(ushort))
                }
            });
        }
    }
}