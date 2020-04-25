using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.Items {
    public class QuestReward : ISingleStruct {
        public SingleStruct Generate() { // .rem
            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Id", 0, typeof(uint), true)
            };

            const ulong itemIdStart = 8;
            const ulong itemCountStart = 72;
            const ulong itemWeightStart = 88;

            for (ulong i = 0; i <= 15; i++) {
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Id", itemIdStart + i * 4, typeof(uint)));
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Cnt", itemCountStart + i, typeof(byte)));
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Wt", itemWeightStart + i, typeof(byte)));
            }

            return new SingleStruct("MHW_Editor.Items", "QuestReward", new MhwStructData {
                size = 104,
                offsetInitial = 10,
                entryCountOffset = -1,
                uniqueIdFormula = "{Id}",
                entries = entries
            });
        }
    }
}