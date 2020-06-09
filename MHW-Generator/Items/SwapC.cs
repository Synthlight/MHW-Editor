using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class SwapC : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .swpc
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk3", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk4", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Items", "SwapC", new MhwMultiStructData(structs, "swpc"));
        }
    }
}