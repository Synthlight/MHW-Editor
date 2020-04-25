using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class PlantItem : ISingleStruct {
        public SingleStruct Generate() { // .plit
            return new SingleStruct("MHW_Editor.Items", "PlantItem", new MhwStructData {
                size = 37,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Item}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Cultivation category", 0, typeof(uint), typeof(CultivationCategory)),
                    new MhwStructData.Entry("Unlocked from start", 8, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Item", 9, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Required time", 13, typeof(uint)),
                    new MhwStructData.Entry("Catalyst time bonus", 17, typeof(uint)),
                    new MhwStructData.Entry("Amount (Base)", 25, typeof(uint)),
                    new MhwStructData.Entry("Amount (+1)", 29, typeof(uint)),
                    new MhwStructData.Entry("Amount (+2)", 33, typeof(uint)),
                    new MhwStructData.Entry("Unknown (int32) 1", 4, typeof(uint))
                }
            });
        }
    }
}