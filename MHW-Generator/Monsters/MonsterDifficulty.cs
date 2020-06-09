using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Monsters {
    public class MonsterDifficulty : IMultiStruct {
        public MultiStruct Generate() { // .dtt_dif
            var scalingValues = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Monster HP Multiplier", typeof(float)),
                new MhwMultiStructData.Entry("Monster Damage Multiplier", typeof(float)),
                new MhwMultiStructData.Entry("Player Damage Multiplier", typeof(float)),
                new MhwMultiStructData.Entry("Monster Part HP", typeof(float)),
                new MhwMultiStructData.Entry("Monster Status Base", typeof(float)),
                new MhwMultiStructData.Entry("Monster Status Buildup", typeof(float)),
                new MhwMultiStructData.Entry("Monster Stun", typeof(float)),
                new MhwMultiStructData.Entry("Monster Exhaust", typeof(float)),
                new MhwMultiStructData.Entry("Monster Mount", typeof(float))
            };

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Difficulty", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true)
                }, 1),

                new MhwMultiStructData.StructData("Solo Stats", scalingValues, 1000),

                new MhwMultiStructData.StructData("Multi Stats", scalingValues, 1000),

                new MhwMultiStructData.StructData("Unknown", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk 4", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk 5", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk 6", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk 7", typeof(uint), true)
                }, 1)
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterDifficulty", new MhwMultiStructData(structs, "dtt_dif"));
        }
    }
}