using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Gems {
    public class Gem : ISingleStruct {
        public SingleStruct Generate() { // .sgpa
            return new SingleStruct("MHW_Editor.Gems", "Gem", new MhwStructData {
                size             = 28,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 4, typeof(ushort), true),
                    new MhwStructData.Entry("Id", 0, typeof(ushort), true, dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Size", 8, typeof(byte)),
                    new MhwStructData.Entry("Skill 1", 12, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 1 Level", 16, typeof(byte)),
                    new MhwStructData.Entry("Skill 2", 20, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 2 Level", 24, typeof(byte))
                }
            });
        }
    }
}