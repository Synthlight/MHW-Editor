using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class Treasure : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .trsr
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Unk2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk3", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk5", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk6", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk7", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk8", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk9", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk10", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk11", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk12", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk13", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk14", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Items", "Treasure", new MhwMultiStructData(structs, "trsr"));
        }
    }
}