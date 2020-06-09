using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class SwapItem : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .swpi
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk1", typeof(uint)),
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Unk2", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk3", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk4", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk5", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk6", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk7", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk8", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk9", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk10", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Items", "SwapItem", new MhwMultiStructData(structs, "swpi"));
        }
    }
}