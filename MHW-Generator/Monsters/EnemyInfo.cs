using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Misc;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Monsters {
    public class EnemyInfo : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .emi
            var partWeakness = new MhwMultiStructData.StructData("Part Weakness", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Modifier", typeof(uint)),
                new MhwMultiStructData.Entry("Part 1", typeof(uint)),
                new MhwMultiStructData.Entry("Part 2", typeof(uint)),
                new MhwMultiStructData.Entry("Part 3", typeof(uint))
            });

            var breakConfig = new MhwMultiStructData.StructData("Break Config", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Name Displayed", typeof(uint)),
                new MhwMultiStructData.Entry("Unk 1", typeof(int)),
                new MhwMultiStructData.Entry("Unk 2", typeof(int))
            });

            var availableStageEntries = new List<MhwMultiStructData.Entry>();
            for (var i = 1; i <= 6; i++) {
                availableStageEntries.Add(new MhwMultiStructData.Entry($"Stage {i}", typeof(uint), enumReturn: typeof(Stage)));
            }
            var availableStages = new MhwMultiStructData.StructData("Available Stages", availableStageEntries);

            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Monster", typeof(uint), dataSourceType: DataSourceType.Monsters),
                    new MhwMultiStructData.Entry("Stages", typeof(void), subStruct: new MhwMultiStructData.StructData("Available Stages", availableStages.entries, fixedSizeCount: 1)),
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Part Weakness: Cut", typeof(void), subStruct: new MhwMultiStructData.StructData("Part Weakness: Cut", partWeakness.entries, fixedSizeCount: 1)),
                    new MhwMultiStructData.Entry("Part Weakness: Blunt", typeof(void), subStruct: new MhwMultiStructData.StructData("Part Weakness: Blunt", partWeakness.entries, fixedSizeCount: 1)),
                    new MhwMultiStructData.Entry("Part Weakness: Shot", typeof(void), subStruct: new MhwMultiStructData.StructData("Part Weakness: Shot", partWeakness.entries, fixedSizeCount: 1)),
                    new MhwMultiStructData.Entry("Break Config 1", typeof(void), subStruct: new MhwMultiStructData.StructData("Break Config 1", breakConfig.entries, fixedSizeCount: 1)),
                    new MhwMultiStructData.Entry("Break Config 2", typeof(void), subStruct: new MhwMultiStructData.StructData("Break Config 2", breakConfig.entries, fixedSizeCount: 1)),
                    new MhwMultiStructData.Entry("Break Config 3", typeof(void), subStruct: new MhwMultiStructData.StructData("Break Config 3", breakConfig.entries, fixedSizeCount: 1)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(int)),
                    new MhwMultiStructData.Entry("Fire", typeof(int)),
                    new MhwMultiStructData.Entry("Water", typeof(int)),
                    new MhwMultiStructData.Entry("Thunder", typeof(int)),
                    new MhwMultiStructData.Entry("Ice", typeof(int)),
                    new MhwMultiStructData.Entry("Dragon", typeof(int)),
                    new MhwMultiStructData.Entry("Poison", typeof(int)),
                    new MhwMultiStructData.Entry("Sleep", typeof(int)),
                    new MhwMultiStructData.Entry("Paralysis", typeof(int)),
                    new MhwMultiStructData.Entry("Blast", typeof(int)),
                    new MhwMultiStructData.Entry("Stun", typeof(int)),
                    new MhwMultiStructData.Entry("Conditional Fire", typeof(int)),
                    new MhwMultiStructData.Entry("Conditional Water", typeof(int)),
                    new MhwMultiStructData.Entry("Conditional Thunder", typeof(int)),
                    new MhwMultiStructData.Entry("Conditional Ice", typeof(int)),
                    new MhwMultiStructData.Entry("Conditional Dragon", typeof(int)),
                    new MhwMultiStructData.Entry("Condition", typeof(int), enumReturn: typeof(Condition)),
                    new MhwMultiStructData.Entry("Skeleton", typeof(int)),
                    new MhwMultiStructData.Entry("Rewards Skeleton", typeof(int)),
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Monsters", "EnemyInfo", new MhwMultiStructData(structs, "emi"));
        }
    }
}