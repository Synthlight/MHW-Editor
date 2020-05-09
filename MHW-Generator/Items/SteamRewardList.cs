using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class SteamRewardList : ISingleStruct {
        public SingleStruct Generate() { // .srl
            return new SingleStruct("MHW_Editor.Items", "SteamRewardList", new MhwStructData {
                size             = 24,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Type", 0, typeof(int)),
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Quantity", 8, typeof(uint)),
                    new MhwStructData.Entry("Chance %", 12, typeof(ulong)),
                    new MhwStructData.Entry("Rarity", 20, typeof(uint), typeof(SteamRarity))
                }
            });
        }
    }
}