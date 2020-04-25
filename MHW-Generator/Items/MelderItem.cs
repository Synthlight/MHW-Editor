using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class MelderItem : ISingleStruct {
        public SingleStruct Generate() { // .mkit
            return new SingleStruct("MHW_Editor.Items", "MelderItem", new MhwStructData {
                size = 21,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Result Item Id", 0, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Research Points", 4, typeof(uint)),
                    new MhwStructData.Entry("Melding Points", 8, typeof(uint)),
                    new MhwStructData.Entry("Category", 12, typeof(uint), typeof(ItemCategory)),
                    new MhwStructData.Entry("Unlock Flag", 16, typeof(uint)),
                    new MhwStructData.Entry("Unknown (uint8)", 20, typeof(byte))
                }
            });
        }
    }
}