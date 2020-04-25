using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class PlantFertilizer : ISingleStruct { // .plfe
        public SingleStruct Generate() {
            return new SingleStruct("MHW_Editor.Items", "PlantFertilizer", new MhwStructData {
                size = 24,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Fertilizer_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Fertilizer Id", 0, typeof(uint), typeof(Fertilizer)),
                    new MhwStructData.Entry("Prize", 4, typeof(uint)),
                    new MhwStructData.Entry("Base duration", 8, typeof(uint)),
                    new MhwStructData.Entry("Unknown (int32) 1", 12, typeof(uint)),
                    new MhwStructData.Entry("Unknown (int32) 2", 16, typeof(uint)),
                    new MhwStructData.Entry("Unknown (int32) 3", 20, typeof(uint))
                }
            });
        }
    }
}