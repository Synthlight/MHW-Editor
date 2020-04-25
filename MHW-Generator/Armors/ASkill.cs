using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Armors {
    public class ASkill : ISingleStruct {
        public SingleStruct Generate() { // .ask
            return new SingleStruct("MHW_Editor.Armors", "ASkill", new MhwStructData {
                size = 28,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Mantle_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Mantle Id", 16, typeof(uint), true),
                    new MhwStructData.Entry("Icon Id", 0, typeof(uint)),
                    new MhwStructData.Entry("Color", 4, typeof(uint)),
                    new MhwStructData.Entry("Sort Order", 8, typeof(uint)),
                    new MhwStructData.Entry("Mantle Item Id", 12, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unlock Flag or Item Id?", 20, typeof(uint)),
                    new MhwStructData.Entry("Deco Count", 24, typeof(byte)),
                    new MhwStructData.Entry("Deco Lvl 1", 25, typeof(byte)),
                    new MhwStructData.Entry("Deco Lvl 2", 26, typeof(byte)),
                    new MhwStructData.Entry("Deco Lvl 3", 27, typeof(byte))
                }
            });
        }
    }
}