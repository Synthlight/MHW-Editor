using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Misc;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Misc {
    public class FestivalSchedule : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .ysm
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Festival", typeof(uint), enumReturn: typeof(Festival)),
                    new MhwMultiStructData.Entry("Enable Event Quests", typeof(uint)),
                    new MhwMultiStructData.Entry("Resource Unknown High No", typeof(uint)),
                    new MhwMultiStructData.Entry("Resource Unknown Low No", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Misc", "FestivalSchedule", new MhwMultiStructData(structs, "ysm"));
        }
    }
}