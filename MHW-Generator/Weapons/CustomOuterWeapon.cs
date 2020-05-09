using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class CustomOuterWeapon : ISingleStruct {
        public SingleStruct Generate() { // .cus_ou
            return new SingleStruct("MHW_Editor.Weapons", "CustomOuterWeapon", new MhwStructData {
                size             = 35,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Index}",
                autoOffset       = true,
                encryptionKey    = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".cus_ou"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", typeof(uint)),
                    new MhwStructData.Entry("Unk2", typeof(uint)),
                    new MhwStructData.Entry("Unk3", typeof(int)),
                    new MhwStructData.Entry("Unk4", typeof(uint)),
                    new MhwStructData.Entry("Unk5", typeof(int)),
                    new MhwStructData.Entry("Unk6", typeof(int)),
                    new MhwStructData.Entry("Unk7", typeof(int)),
                    new MhwStructData.Entry("Unk8", typeof(ushort)),
                    new MhwStructData.Entry("Unk9", typeof(uint)),
                    new MhwStructData.Entry("Unk10", typeof(byte))
                }
            });
        }
    }
}