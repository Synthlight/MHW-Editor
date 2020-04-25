using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class NewLimitBreakR : ISingleStruct {
        public SingleStruct Generate() { // .new_lbr
            return new SingleStruct("MHW_Editor.Weapons", "NewLimitBreakR", new MhwStructData {
                size = 38,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id_1}|{Id_2}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id 1", 0, typeof(ushort), true),
                    new MhwStructData.Entry("Id 2", 2, typeof(ushort), true),
                    new MhwStructData.Entry("Needed Item Id to Unlock", 4, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk1", 6, typeof(int)),
                    new MhwStructData.Entry("Mat 1 Id", 14, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", 16, typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", 17, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", 19, typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", 20, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", 22, typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", 23, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", 25, typeof(byte)),
                    new MhwStructData.Entry("Id 3", 37, typeof(byte), true)
                }
            });
        }
    }
}