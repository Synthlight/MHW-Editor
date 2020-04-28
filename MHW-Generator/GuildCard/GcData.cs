using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.GuildCard;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.GuildCard {
    public class GcData : ISingleStruct {
        public SingleStruct Generate() { // .gcod
            return new SingleStruct("MHW_Editor.GuildCard", "GcData", new MhwStructData {
                size             = 20,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                autoOffset       = true,
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", typeof(uint), true),
                    new MhwStructData.Entry("Unlock Type", typeof(int), typeof(UnlockType)),
                    new MhwStructData.Entry("Unlock Param", typeof(uint)),
                    new MhwStructData.Entry("Monster Id", typeof(uint), dataSourceType: DataSourceType.Monsters),
                    new MhwStructData.Entry("Unk", typeof(uint))
                }
            });
        }
    }
}