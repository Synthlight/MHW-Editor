using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Monsters {
    public class AnimalSize : ISingleStruct {
        public SingleStruct Generate() { // .ransz
            return new SingleStruct("MHW_Editor.Monsters", "AnimalSize", new MhwStructData {
                size             = 72,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Endemic Id", 0, typeof(uint)),
                    new MhwStructData.Entry("Endemic Sub Species Id", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk3", 8, typeof(float)),
                    new MhwStructData.Entry("Unk4", 12, typeof(float)),
                    new MhwStructData.Entry("Unk5", 16, typeof(float)),
                    new MhwStructData.Entry("Unk6", 20, typeof(float)),
                    new MhwStructData.Entry("Animal Base Size", 24, typeof(float)),
                    new MhwStructData.Entry("Model Size Multi", 28, typeof(float)),
                    new MhwStructData.Entry("Minimum Size Limit", 32, typeof(float)),
                    new MhwStructData.Entry("Maximum Size Limit", 36, typeof(float)),
                    new MhwStructData.Entry("Unk11", 40, typeof(uint)),
                    new MhwStructData.Entry("Unk12", 44, typeof(float)),
                    new MhwStructData.Entry("Unk13", 48, typeof(float)),
                    new MhwStructData.Entry("Unk14", 52, typeof(float)),
                    new MhwStructData.Entry("Unk15", 56, typeof(float)),
                    new MhwStructData.Entry("Unk16", 60, typeof(uint)),
                    new MhwStructData.Entry("Small Gold Crown Limit", 64, typeof(float)),
                    new MhwStructData.Entry("Big Gold Crown Limit", 68, typeof(float))
                }
            });
        }
    }
}