using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Skills {
    public class SkillPointData : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .skl_pt_dat
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Is Set Bonus", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Icon Color Id", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("MHW_Editor.Skills", "SkillPointData", new MhwMultiStructData(structs, "skl_pt_dat"));
        }
    }
}