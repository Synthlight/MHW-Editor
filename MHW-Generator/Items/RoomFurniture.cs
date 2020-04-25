using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Generator.Items {
    public class RoomFurniture : ISingleStruct {
        public SingleStruct Generate() { // .rfur
            return new SingleStruct("MHW_Editor.Items", "RoomFurniture", new MhwStructData {
                size = 47,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Item Id", 0, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk1", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 8, typeof(uint)),
                    new MhwStructData.Entry("Unk3", 12, typeof(uint)),
                    new MhwStructData.Entry("Unk4", 16, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk5", 17, typeof(byte)),
                    new MhwStructData.Entry("Unk6", 18, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk7", 19, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk8", 20, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk9", 21, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk10", 22, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk11", 23, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk12", 24, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk13", 25, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk14", 26, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk15", 27, typeof(int)),
                    new MhwStructData.Entry("Unk16", 31, typeof(uint)),
                    new MhwStructData.Entry("Unk17", 35, typeof(ushort)),
                    new MhwStructData.Entry("Unk18", 37, typeof(ushort)),
                    new MhwStructData.Entry("Unk19", 39, typeof(uint)),
                    new MhwStructData.Entry("Unk21", 43, typeof(uint))
                }
            });
        }
    }
}