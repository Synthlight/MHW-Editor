using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.PlData {
    public class PlMusicSkillParam : ISingleStruct {
        public SingleStruct Generate() { // .mske
            return new SingleStruct("MHW_Editor.PlData", "PlMusicSkillParam", new MhwStructData {
                size             = 56,
                offsetInitial    = 14,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                encryptionKey    = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".mske"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Duration", 0, typeof(float)),
                    new MhwStructData.Entry("Extension", 12, typeof(float)),
                    new MhwStructData.Entry("M1 Duration", 4, typeof(float)),
                    new MhwStructData.Entry("M1 Extension", 16, typeof(float)),
                    new MhwStructData.Entry("M2 Duration", 8, typeof(float)),
                    new MhwStructData.Entry("M2 Extension", 20, typeof(float)),
                    new MhwStructData.Entry("Effect", 24, typeof(float)),
                    new MhwStructData.Entry("Recast Effect", 28, typeof(float)),
                    new MhwStructData.Entry("Unk 1", 32, typeof(uint)),
                    new MhwStructData.Entry("Unk 2", 36, typeof(uint)),
                    new MhwStructData.Entry("Unk 3", 40, typeof(uint)),
                    new MhwStructData.Entry("Unk 4", 44, typeof(uint)),
                    new MhwStructData.Entry("Unk 5", 48, typeof(uint)),
                    new MhwStructData.Entry("Unk 6", 52, typeof(uint))
                }
            });
        }
    }
}