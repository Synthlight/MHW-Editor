using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Monsters {
    public class MonsterRandomSize : IMultiStruct {
        public MultiStruct Generate() { // .dtt_rsz
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Random Sizes", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Number of Monsters", typeof(uint), true).Out(out var monsterCount)
                }, 1).Out(out var monsterCountHolder),

                new MhwMultiStructData.StructData("Monsters", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Monster Id", typeof(uint), true, dataSourceType: DataSourceType.Monsters),
                    new MhwMultiStructData.Entry("Gold Small Crown Limit", typeof(uint)),
                    new MhwMultiStructData.Entry("Silver Crown Limit", typeof(uint)),
                    new MhwMultiStructData.Entry("Gold Big Crown Limit", typeof(uint)),
                    new MhwMultiStructData.Entry("Base Size", typeof(float))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(monsterCountHolder, monsterCount)),

                new MhwMultiStructData.StructData("Crown Table Count", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Number of Crown Tables", typeof(uint), true).Out(out var crownCount)
                }, 1, true).Out(out var crownCountHolder),

                new MhwMultiStructData.StructData("Crown Tables", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Name (Jap)", typeof(string), isNullTerminatedString: true),

                    new MhwMultiStructData.Entry("Crown Sizes", typeof(void), subStruct: new MhwMultiStructData.StructData("Crown Sizes", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Crown Size Multiplier", typeof(int)),
                        new MhwMultiStructData.Entry("Crown Size Rarity", typeof(int))
                    }, 38))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(crownCountHolder, crownCount))
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterRandomSize", new MhwMultiStructData(structs, "dtt_rsz"));
        }
    }
}