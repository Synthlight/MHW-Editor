using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class MelderExchange : ISingleStruct {
        public SingleStruct Generate() { // .mkex
            const ulong size = 438;
            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Source Item Id", 0, typeof(uint), dataSourceType: DataSourceType.Items),
                new MhwStructData.Entry("Unknown (int32) 1", 4, typeof(int))
            };

            var index = 0;
            for (ulong i = 8; i < size; i += 2) {
                entries.Add(new MhwStructData.Entry($"It {index++}", i, typeof(ushort)));
            }

            return new SingleStruct("MHW_Editor.Items", "MelderExchange", new MhwStructData {
                size = size,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = entries
            });
        }
    }
}