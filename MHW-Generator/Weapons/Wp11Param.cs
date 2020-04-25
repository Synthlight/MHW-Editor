using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class Wp11Param : IVerticalStruct {
        public VerticalStruct Generate() { // .w11p
            return new VerticalStruct("MHW_Editor.Weapons", "Wp11Param", new MhwStructData {
                size = 2736,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w11p"],
                ext = "w11p",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Dragonpiercer X1", 1313, typeof(float)),
                    new MhwStructData.Entry("Dragonpiercer Y1", 1317, typeof(float)),
                    new MhwStructData.Entry("Dragonpiercer X2", 1321, typeof(float)),
                    new MhwStructData.Entry("Dragonpiercer Y2", 1325, typeof(float)),
                    VerticalStruct.Spacer,
                    new MhwStructData.Entry("Thousand Dragons X1", 2569, typeof(float)),
                    new MhwStructData.Entry("Thousand Dragons Y1", 2573, typeof(float)),
                    new MhwStructData.Entry("Thousand Dragons X2", 2577, typeof(float)),
                    new MhwStructData.Entry("Thousand Dragons Y2", 2581, typeof(float))
                }
            });
        }
    }
}