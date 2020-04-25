using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Armors {
    public class PendantData : ISingleStruct {
        public SingleStruct Generate() { // .ch_dat
            return new SingleStruct("MHW_Editor.Armors", "PendantData", new MhwStructData {
                size = 27,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(byte)),
                    new MhwStructData.Entry("Unk2", 5, typeof(byte)),
                    new MhwStructData.Entry("Unk3", 6, typeof(byte)),
                    new MhwStructData.Entry("Unk4", 7, typeof(byte)),
                    new MhwStructData.Entry("Unk5", 8, typeof(byte)),
                    new MhwStructData.Entry("Unk6", 9, typeof(ushort)),
                    new MhwStructData.Entry("Unk7", 11, typeof(ushort)),
                    new MhwStructData.Entry("Unk8", 13, typeof(byte)),
                    new MhwStructData.Entry("Unk9", 14, typeof(byte)),
                    new MhwStructData.Entry("Cost", 15, typeof(uint)),
                    new MhwStructData.Entry("Unk10", 19, typeof(int))
                }
            });
        }
    }
}