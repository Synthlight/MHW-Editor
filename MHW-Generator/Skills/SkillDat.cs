using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Skills {
    public class SkillDat : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .skl_dat
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(ushort), true, dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Level", typeof(byte), true),
                    new MhwMultiStructData.Entry("Unlock Skill 1", typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwMultiStructData.Entry("Unlock Skill 2", typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwMultiStructData.Entry("Unlock Skill 3", typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwMultiStructData.Entry("Unlock Skill 4", typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwMultiStructData.Entry("Unlock Skill 5", typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwMultiStructData.Entry("Unlock Skill 6", typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwMultiStructData.Entry("Param 5", typeof(ushort)),
                    new MhwMultiStructData.Entry("Param 6", typeof(ushort)),
                    new MhwMultiStructData.Entry("Param 7", typeof(ushort)),
                    new MhwMultiStructData.Entry("Param 8", typeof(ushort))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}|{Level}")
            };

            return new MultiStruct("Skills", "SkillDat", new MhwMultiStructData(structs, "skl_dat"));
        }
    }
}