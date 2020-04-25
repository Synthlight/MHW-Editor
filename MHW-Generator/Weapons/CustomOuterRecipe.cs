using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Generator.Weapons {
    public class CustomOuterRecipe : ISingleStruct {
        public SingleStruct Generate() { // .cus_otr
            return new SingleStruct("MHW_Editor.Weapons", "CustomOuterRecipe", new MhwStructData {
                size = 31,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                autoOffset = true,
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".cus_otr"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", typeof(byte)),
                    new MhwStructData.Entry("Needed Item Id to Unlock", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk3", typeof(int)),
                    new MhwStructData.Entry("Unk4", typeof(int)),
                    new MhwStructData.Entry("Cost", typeof(uint)),
                    new MhwStructData.Entry("Mat 1 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", typeof(byte)),
                    new MhwStructData.Entry("Unk5", typeof(byte)),
                    new MhwStructData.Entry("Unk6", typeof(byte)),
                    new MhwStructData.Entry("Unk7", typeof(byte)),
                    new MhwStructData.Entry("Unk8", typeof(byte))
                }
            });
        }
    }
}