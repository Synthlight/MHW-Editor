using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class SwapC : ISingleStruct {
        public SingleStruct Generate() { // .swpc
            return new SingleStruct("MHW_Editor.Items", "SwapC", new MhwStructData {
                size = 16,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk3", 8, typeof(uint)),
                    new MhwStructData.Entry("Unk4", 12, typeof(uint))
                }
            });
        }
    }
}