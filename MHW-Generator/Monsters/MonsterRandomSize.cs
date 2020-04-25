using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Monsters {
    public class MonsterRandomSize : IMultiStruct {
        public MultiStruct Generate() { // .dtt_rsz 
            var crownTable = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Name (Jap)", typeof(string), isNullTerminatedString: true)
            }; // TODO: Add support for sub-sub-structs.

            for (var i = 0; i < 38; i++) {
                crownTable.Add(new MhwMultiStructData.Entry($"Crown Size Multiplier {i + 1}", typeof(int)));
                crownTable.Add(new MhwMultiStructData.Entry($"Crown Size Rarity {i + 1}", typeof(int)));
            }

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Random Sizes", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Number of Monsters", typeof(uint), true).@out(out var monsterCount)
                }, 1).@out(out var monsterCountHolder),

                new MhwMultiStructData.StructData("Monsters", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Monster Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Gold Small Crown Limit", typeof(uint)),
                    new MhwMultiStructData.Entry("Silver Crown Limit", typeof(uint)),
                    new MhwMultiStructData.Entry("Gold Big Crown Limit", typeof(uint)),
                    new MhwMultiStructData.Entry("Base Size", typeof(float))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(monsterCountHolder, monsterCount)),

                new MhwMultiStructData.StructData("Crown Table Count", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Number of Crown Tables", typeof(uint), true).@out(out var crownCount)
                }, 1, true).@out(out var crownCountHolder),

                new MhwMultiStructData.StructData("Crown Tables", crownTable, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(crownCountHolder, crownCount))
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterRandomSize", new MhwMultiStructData(structs, "dtt_rsz"));
        }
    }
}