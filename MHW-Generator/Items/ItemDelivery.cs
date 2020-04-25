using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Generator.Items {
    public class ItemDelivery : ISingleStruct {
        public SingleStruct Generate() { // .stmp
            return new SingleStruct("MHW_Editor.Items", "ItemDelivery", new MhwStructData {
                size = 44,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 8, typeof(uint)),
                    new MhwStructData.Entry("Client Id", 12, typeof(int)),
                    new MhwStructData.Entry("Decoration Reward", 16, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk3", 20, typeof(uint)),
                    new MhwStructData.Entry("Cost", 24, typeof(uint)),
                    new MhwStructData.Entry("Item 1 Id", 28, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Item 1 Cnt", 36, typeof(uint)),
                    new MhwStructData.Entry("Item 2 Id", 32, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Item 2 Cnt", 40, typeof(uint))
                }
            });
        }
    }
}