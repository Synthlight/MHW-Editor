using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Monsters {
    public class MonsterEnrage : IMultiStruct {
        public MultiStruct Generate() { // .dtt_agr
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Monster Rage", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Monster Id", typeof(uint), dataSourceType: DataSourceType.Monsters),
                    new MhwMultiStructData.Entry("Magic 3", typeof(uint), true)
                }, 1),

                new MhwMultiStructData.StructData("Rage Stats", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Build to Trigger", typeof(int), valueString: "value.Clamp((int) -1, (int) int.MaxValue)"),
                    new MhwMultiStructData.Entry("Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Modifier", typeof(float)),
                    new MhwMultiStructData.Entry("Damage Modifier", typeof(float)),
                    new MhwMultiStructData.Entry("Player Damage Modifier", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (100%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (88%-99%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (77%-88%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (66%-77%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (55%-66%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (44%-55%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (33%-44%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (22%-33%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (11%-22%)", typeof(float)),
                    new MhwMultiStructData.Entry("Build Multiplier by HP (0%-11%)", typeof(float)),
                    new MhwMultiStructData.Entry("Out of Combat Decay Multiplier", typeof(float))
                }, 2)
            };

            return new MultiStruct("MHW_Editor.Monsters", "MonsterEnrage", new MhwMultiStructData(structs, "dtt_agr"));
        }
    }
}