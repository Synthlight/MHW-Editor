using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class NewLimitBreak : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .new_lb
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Aug Category", typeof(uint), true, typeof(AugmentationCategory)),
                    new MhwMultiStructData.Entry("Aug Level", typeof(uint), true),
                    new MhwMultiStructData.Entry("Aug Slot Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Research Cost (r10)", typeof(uint)),
                    new MhwMultiStructData.Entry("Research Cost (r11)", typeof(uint)),
                    new MhwMultiStructData.Entry("Research Cost (r12)", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Aug_Category}|{Aug_Level}")
            };

            return new MultiStruct("Weapons", "NewLimitBreak", new MhwMultiStructData(structs, "new_lb"));
        }
    }
}