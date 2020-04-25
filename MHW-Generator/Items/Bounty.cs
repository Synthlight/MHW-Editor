using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class Bounty : ISingleStruct {
        public SingleStruct Generate() { // .odr
            return new SingleStruct("MHW_Editor.Items", "Bounty", new MhwStructData {
                size = 77,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 8, typeof(byte)),
                    new MhwStructData.Entry("Unk3", 9, typeof(uint)),
                    new MhwStructData.Entry("Unk4", 13, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 17, typeof(int)),
                    new MhwStructData.Entry("Rank", 21, typeof(uint), typeof(RankType)),
                    new MhwStructData.Entry("Type", 25, typeof(uint), typeof(BountyType)),
                    new MhwStructData.Entry("Unk8", 29, typeof(uint)),
                    new MhwStructData.Entry("Monster Type", 33, typeof(int), typeof(MonsterType)),
                    new MhwStructData.Entry("Unk10", 37, typeof(uint)),
                    new MhwStructData.Entry("Map", 41, typeof(uint), typeof(Location)),
                    new MhwStructData.Entry("Target Count", 45, typeof(uint)),
                    new MhwStructData.Entry("Item Id 1", 49, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Item Id 1 Cnt", 61, typeof(uint)),
                    new MhwStructData.Entry("Item Id 2", 53, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Item Id 2 Cnt", 65, typeof(uint)),
                    new MhwStructData.Entry("Item Id 3", 57, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Item Id 3 Cnt", 69, typeof(uint)),
                    new MhwStructData.Entry("Research Points", 72, typeof(uint))
                }
            });
        }
    }
}