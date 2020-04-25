using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class Wp10Param : IVerticalStruct {
        public VerticalStruct Generate() { // .w10p
            return new VerticalStruct("MHW_Editor.Weapons", "Wp10Param", new MhwStructData {
                size = 3408,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w10p"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Red Extract Duration", 1153, typeof(float)),
                    new MhwStructData.Entry("White Extract Duration", 1157, typeof(float)),
                    new MhwStructData.Entry("Orange Extract Duration", 1161, typeof(float)),
                    new MhwStructData.Entry("Triple Extract Duration", 1165, typeof(float))
                }
            });
        }
    }
}