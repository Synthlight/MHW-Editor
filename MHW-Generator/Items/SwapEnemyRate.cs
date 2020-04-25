using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class SwapEnemyRate : ISingleStruct {
        public SingleStruct Generate() { // .swer
            return new SingleStruct("MHW_Editor.Items", "SwapEnemyRate", new MhwStructData {
                size = 12,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 8, typeof(uint))
                }
            });
        }
    }
}