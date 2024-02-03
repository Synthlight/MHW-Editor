using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Misc {
    public class Food : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .rfd
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(ushort)),
                    new MhwMultiStructData.Entry("Padding 1?", typeof(byte)),
                    new MhwMultiStructData.Entry("Story Flag", typeof(uint)),
                    new MhwMultiStructData.Entry("Padding 2?", typeof(byte)),
                    new MhwMultiStructData.Entry("Flags?", typeof(uint)),
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Misc", "Food", new MhwMultiStructData(structs, "rfd"));
        }
    }
}