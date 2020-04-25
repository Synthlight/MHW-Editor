using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class NewLimitBreak : ISingleStruct {
        public SingleStruct Generate() { // .new_lb
            return new SingleStruct("MHW_Editor.Weapons", "NewLimitBreak", new MhwStructData {
                size = 24,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Aug_Category}|{Aug_Level}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Aug Category", 0, typeof(uint), true, typeof(AugmentationCategory)),
                    new MhwStructData.Entry("Aug Level", 4, typeof(uint), true),
                    new MhwStructData.Entry("Aug Slot Cost", 8, typeof(uint)),
                    new MhwStructData.Entry("Research Cost (r10)", 12, typeof(uint)),
                    new MhwStructData.Entry("Research Cost (r11)", 16, typeof(uint)),
                    new MhwStructData.Entry("Research Cost (r12)", 20, typeof(uint))
                }
            });
        }
    }
}