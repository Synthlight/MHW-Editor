using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.Monsters {
    public class MonsterRandomSize : IMultiStruct {
        public MultiStruct Generate() { // .dtt_rsz 
            var crownTable = new List<MhwMultiStructData.StructData.Entry> {
                new MhwMultiStructData.StructData.Entry("Name (Jap)", typeof(string), isNullTerminatedString: true)
            }; // TODO: Add support for sub-sub-structs.

            for (var i = 0; i < 38; i++) {
                crownTable.Add(new MhwMultiStructData.StructData.Entry($"Crown Size Multiplier {i + 1}", typeof(int)));
                crownTable.Add(new MhwMultiStructData.StructData.Entry($"Crown Size Rarity {i + 1}", typeof(int)));
            }

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Random Sizes", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Number of Monsters", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Monsters", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Monster Id", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Gold Small Crown Limit", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Silver Crown Limit", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Gold Big Crown Limit", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Base Size", typeof(float))
                }, canAddRows: true),
                new MhwMultiStructData.StructData("Crown Table Count", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Number of Crown Tables", typeof(uint), true)
                }, 1, true),
                new MhwMultiStructData.StructData("Crown Tables", crownTable, canAddRows: true)
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterRandomSize", new MhwMultiStructData(structs));
        }
    }
}