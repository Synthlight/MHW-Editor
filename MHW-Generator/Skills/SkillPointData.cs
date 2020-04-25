using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.Skills {
    public class SkillPointData : ISingleStruct {
        public SingleStruct Generate() { // .skl_pt_dat
            return new SingleStruct("MHW_Editor.Skills", "SkillPointData", new MhwStructData {
                size = 2,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Is Set Bonus", 0, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Icon Color Id", 1, typeof(byte))
                }
            });
        }
    }
}