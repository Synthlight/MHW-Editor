using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Generator.Skills {
    public class SkillDat : ISingleStruct {
        public SingleStruct Generate() { // .skl_dat
            return new SingleStruct("MHW_Editor.Skills", "SkillDat", new MhwStructData {
                size = 27,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}|{Level}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(ushort), true),
                    new MhwStructData.Entry("Level", 2, typeof(byte), true),
                    new MhwStructData.Entry("Unlock Skill 1", 3, typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwStructData.Entry("Unlock Skill 2", 7, typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwStructData.Entry("Unlock Skill 3", 11, typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwStructData.Entry("Unlock Skill 4", 15, typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwStructData.Entry("Param 5", 19, typeof(ushort)),
                    new MhwStructData.Entry("Param 6", 21, typeof(ushort)),
                    new MhwStructData.Entry("Param 7", 23, typeof(ushort)),
                    new MhwStructData.Entry("Param 8", 25, typeof(ushort))
                }
            });
        }
    }
}