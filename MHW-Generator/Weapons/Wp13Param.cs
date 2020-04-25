using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.Weapons {
    public class Wp13Param : IVerticalStruct {
        public VerticalStruct Generate() { // .w13p
            return new VerticalStruct("MHW_Editor.Weapons", "Wp13Param", new MhwStructData {
                size = 3200,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w13p"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Shield 1 Small", 2238, typeof(byte)),
                    new MhwStructData.Entry("Shield 1 Medium", 2239, typeof(byte)),
                    new MhwStructData.Entry("Shield 1 Large", 2240, typeof(byte)),
                    VerticalStruct.Spacer,
                    new MhwStructData.Entry("Shield 2 Small", 2241, typeof(byte)),
                    new MhwStructData.Entry("Shield 2 Medium", 2242, typeof(byte)),
                    new MhwStructData.Entry("Shield 2 Large", 2243, typeof(byte)),
                    VerticalStruct.Spacer,
                    new MhwStructData.Entry("Shield 3 Small", 2244, typeof(byte)),
                    new MhwStructData.Entry("Shield 3 Medium", 2245, typeof(byte)),
                    new MhwStructData.Entry("Shield 3 Large", 2246, typeof(byte)),
                    VerticalStruct.Spacer,
                    new MhwStructData.Entry("Shield 4 Small", 2247, typeof(byte)),
                    new MhwStructData.Entry("Shield 4 Medium", 2248, typeof(byte)),
                    new MhwStructData.Entry("Shield 4 Large", 2249, typeof(byte))
                }
            });
        }
    }
}