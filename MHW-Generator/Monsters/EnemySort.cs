using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Monsters {
    public class EnemySort : ISingleStruct {
        public SingleStruct Generate() { // .emst
            return new SingleStruct("MHW_Editor.Monsters", "EnemySort", new MhwStructData {
                size             = 56,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(int)),
                    new MhwStructData.Entry("Unk2", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk3", 8, typeof(uint)),
                    new MhwStructData.Entry("Unk4", 12, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 16, typeof(uint)),
                    new MhwStructData.Entry("Unk6", 20, typeof(uint)),
                    new MhwStructData.Entry("Unk7", 24, typeof(uint)),
                    new MhwStructData.Entry("Unk8", 28, typeof(uint)),
                    new MhwStructData.Entry("Unk9", 32, typeof(uint)),
                    new MhwStructData.Entry("Unk10", 36, typeof(uint)),
                    new MhwStructData.Entry("Unk11", 40, typeof(uint)),
                    new MhwStructData.Entry("Unk12", 44, typeof(uint)),
                    new MhwStructData.Entry("Unk13", 48, typeof(uint)),
                    new MhwStructData.Entry("Unk14", 52, typeof(uint))
                }
            });
        }
    }
}