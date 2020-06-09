using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class PlantFertilizer : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .plfe
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Fertilizer Id", typeof(uint), enumReturn: typeof(Fertilizer)),
                    new MhwMultiStructData.Entry("Prize", typeof(uint)),
                    new MhwMultiStructData.Entry("Base duration", typeof(uint)),
                    new MhwMultiStructData.Entry("Unknown (int32) 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unknown (int32) 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unknown (int32) 3", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Fertilizer_Id}")
            };

            return new MultiStruct("Items", "PlantFertilizer", new MhwMultiStructData(structs, "plfe"));
        }
    }
}