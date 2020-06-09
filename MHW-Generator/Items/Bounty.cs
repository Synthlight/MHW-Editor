using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class Bounty : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .odr
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk2", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk3", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk5", typeof(int)),
                    new MhwMultiStructData.Entry("Rank", typeof(uint), enumReturn: typeof(RankType)),
                    new MhwMultiStructData.Entry("Type", typeof(uint), enumReturn: typeof(BountyType)),
                    new MhwMultiStructData.Entry("Unk8", typeof(uint)),
                    new MhwMultiStructData.Entry("Monster Type", typeof(int), enumReturn: typeof(MonsterType)),
                    new MhwMultiStructData.Entry("Unk10", typeof(uint)),
                    new MhwMultiStructData.Entry("Map", typeof(uint), enumReturn: typeof(Location)),
                    new MhwMultiStructData.Entry("Target Count", typeof(uint)),
                    new MhwMultiStructData.Entry("Item Id 1", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Item Id 1 Cnt", typeof(uint)),
                    new MhwMultiStructData.Entry("Item Id 2", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Item Id 2 Cnt", typeof(uint)),
                    new MhwMultiStructData.Entry("Item Id 3", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Item Id 3 Cnt", typeof(uint)),
                    new MhwMultiStructData.Entry("Research Points", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("MHW_Editor.Items", "Bounty", new MhwMultiStructData(structs, "odr"));
        }
    }
}