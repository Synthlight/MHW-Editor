using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.GuildCard;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.GuildCard {
    public class GcData : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .gcod
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unlock Type", typeof(int), enumReturn: typeof(UnlockType)),
                    new MhwMultiStructData.Entry("Unlock Param", typeof(uint)),
                    new MhwMultiStructData.Entry("Monster Id", typeof(uint), dataSourceType: DataSourceType.Monsters),
                    new MhwMultiStructData.Entry("Unk", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("GuildCard", "GcData", new MhwMultiStructData(structs, "gcod"));
        }
    }
}