using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class SwapN : ISingleStruct {
        public SingleStruct Generate() { // .swpn
            return new SingleStruct("MHW_Editor.Items", "SwapN", new MhwStructData {
                size             = 12,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(uint)),
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk2", 8, typeof(uint))
                }
            });
        }
    }
}