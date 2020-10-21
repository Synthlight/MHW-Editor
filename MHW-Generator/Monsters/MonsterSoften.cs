using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Monsters {
    public class MonsterSoften : IMultiStruct {
        public MultiStruct Generate() { // .dtt_msf
            // 'Unk' counters.
            ushort i = 0;

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Soften Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic", typeof(uint), true),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry("Tender Duration", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(int)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry("Tender Duration (Fatalis)", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(int)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry("Claw: Max Swings To Tenderize (Claw goes up in increments of 20 per swing, 5 swings = 100 = tenderize)", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++i}", typeof(float))
                }, 1, showVertically: true)
            };

            return new MultiStruct("Monsters", "MonsterSoften", new MhwMultiStructData(structs, "dtt_msf"));
        }
    }
}