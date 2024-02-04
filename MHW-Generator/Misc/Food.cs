using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Misc;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Misc {
    public class Food : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .rfd
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Page", typeof(uint), enumReturn: typeof(FoodPage)),
                    new MhwMultiStructData.Entry("Column", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint)),
                    new MhwMultiStructData.Entry("Story Flag", typeof(uint)),
                    new MhwMultiStructData.Entry("Color", typeof(uint)),
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Misc", "Food", new MhwMultiStructData(structs, "rfd"));
        }
    }
}