using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Monsters {
    public class SmallMonsterSizeParams : IMultiStruct {
        public MultiStruct Generate() { // .em_ss
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Small Monster Size Params", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 3", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Number of Size Settings", typeof(uint), true)
                }, 1),
                new MhwMultiStructData.StructData("Size Settings", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Header", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Min Size", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Max Size", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk (f32)", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Monster Id", typeof(uint))
                })
            };

            return new MultiStruct("MHW_Editor.Monsters", "SmallMonsterSizeParams", new MhwMultiStructData(structs));
        }
    }
}