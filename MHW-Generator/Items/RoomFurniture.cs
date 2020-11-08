using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class RoomFurniture : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .rfur
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Unk1", typeof(uint)),
                    new MhwMultiStructData.Entry("Model Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Model Sub Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk4", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk5", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk6", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk7", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk8", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk9", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk10", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk11", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk12", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk13", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk14", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk15", typeof(int)),
                    new MhwMultiStructData.Entry("Unk16", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk17", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk18", typeof(ushort)),
                    new MhwMultiStructData.Entry("Story Progression", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk21", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Items", "RoomFurniture", new MhwMultiStructData(structs, "rfur"));
        }
    }
}