using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class SteamRewardList : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .srl
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Type", typeof(int)),
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Quantity", typeof(uint)),
                    new MhwMultiStructData.Entry("Chance %", typeof(ulong)),
                    new MhwMultiStructData.Entry("Rarity", typeof(uint), enumReturn: typeof(SteamRarity))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Items", "SteamRewardList", new MhwMultiStructData(structs, "srl"));
        }
    }
}