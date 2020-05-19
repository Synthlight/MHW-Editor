using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Armors;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class EqCus_Base : ISingleStruct {
        public SingleStruct Generate() { // .eq_cus
            return new SingleStruct("MHW_Editor.Items", "EqCus_Base", new MhwStructData {
                size             = 41,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Equipment_Category_Raw}|{Equipment_Index_Raw}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Equipment Category Raw", 0, typeof(byte), true),
                    new MhwStructData.Entry("Equipment Index Raw", 1, typeof(ushort), true),
                    new MhwStructData.Entry("Needed Item Id to Unlock", 3, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Monster Unlock", 5, typeof(int), dataSourceType: DataSourceType.MonstersNeg),
                    new MhwStructData.Entry("Story Unlock", 9, typeof(uint)),
                    new MhwStructData.Entry("Item Rank", 13, typeof(uint), typeof(CharmRankType)),
                    new MhwStructData.Entry("Mat 1 Id", 17, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", 19, typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", 20, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", 22, typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", 23, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", 25, typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", 26, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", 28, typeof(byte)),
                    new MhwStructData.Entry("Child index 1", 29, typeof(ushort)),
                    new MhwStructData.Entry("Child index 2", 31, typeof(ushort)),
                    new MhwStructData.Entry("Child index 3", 33, typeof(ushort)),
                    new MhwStructData.Entry("Child index 4", 35, typeof(ushort)),
                    new MhwStructData.Entry("Unk 1", 37, typeof(byte)),
                    new MhwStructData.Entry("Unk 2", 38, typeof(byte)),
                    new MhwStructData.Entry("Unk 3", 39, typeof(byte)),
                    new MhwStructData.Entry("Unk 4", 40, typeof(byte))
                }
            });
        }
    }
}