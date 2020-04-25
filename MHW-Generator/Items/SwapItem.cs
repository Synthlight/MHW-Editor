using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Generator.Items {
    public class SwapItem : ISingleStruct {
        public SingleStruct Generate() { // .swpi
            return new SingleStruct("MHW_Editor.Items", "SwapItem", new MhwStructData {
                size = 26,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(uint)),
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk2", 16, typeof(ushort)),
                    new MhwStructData.Entry("Unk3", 18, typeof(ushort)),
                    new MhwStructData.Entry("Unk4", 20, typeof(ushort)),
                    new MhwStructData.Entry("Unk5", 22, typeof(ushort)),
                    new MhwStructData.Entry("Unk6", 24, typeof(ushort))
                }
            });
        }
    }
}