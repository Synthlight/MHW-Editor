using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class ItemMake : ISingleStruct {
        public SingleStruct Generate() { // .imk
            return new SingleStruct("MHW_Editor.Items", "ItemMake", new MhwStructData {
                size             = 31,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(ushort)),
                    new MhwStructData.Entry("Mat 1 Id", 6, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Id", 10, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Result Id", 14, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Quantity", 18, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 22, typeof(uint)),
                    new MhwStructData.Entry("Category", 26, typeof(uint), typeof(ItemCategory)),
                    new MhwStructData.Entry("Can Auto-Craft", 30, typeof(byte), typeof(bool))
                }
            });
        }
    }
}