using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class EqCrt_Base : ISingleStruct {
        public SingleStruct Generate() { // .eq_crt
            return new SingleStruct("MHW_Editor.Items", "EqCrt_Base", new MhwStructData {
                size = 37,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Equipment_Category_Raw}|{Equipment_Index_Raw}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Equipment Category Raw", 0, typeof(byte), true),
                    new MhwStructData.Entry("Equipment Index Raw", 1, typeof(ushort), true),
                    new MhwStructData.Entry("Needed Item Id to Unlock", 3, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Monster Unlock", 5, typeof(int)),
                    new MhwStructData.Entry("Story Unlock", 9, typeof(uint)),
                    new MhwStructData.Entry("Unknown (uint32)", 13, typeof(uint)),
                    new MhwStructData.Entry("Item Rank", 17, typeof(uint)),
                    new MhwStructData.Entry("Mat 1 Id", 21, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", 23, typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", 24, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", 26, typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", 27, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", 29, typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", 30, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", 32, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8) 1", 33, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8) 2", 34, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8) 3", 35, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8) 4", 36, typeof(byte))
                }
            });
        }
    }
}