using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Monsters {
    public class SmallMonsterSizeParams : IMultiStruct {
        public MultiStruct Generate() { // .em_ss
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Small Monster Size Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 3", typeof(uint), true),
                    new MhwMultiStructData.Entry("Number of Size Settings", typeof(uint), true).Out(out var count)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Size Settings", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Header", typeof(uint)),
                    new MhwMultiStructData.Entry("Min Size", typeof(float)),
                    new MhwMultiStructData.Entry("Max Size", typeof(float)),
                    new MhwMultiStructData.Entry("Unk (f32)", typeof(float)),
                    new MhwMultiStructData.Entry("Monster Id", typeof(uint), dataSourceType: DataSourceType.Monsters)
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, count))
            };

            return new MultiStruct("Monsters", "SmallMonsterSizeParams", new MhwMultiStructData(structs, "em_ss"));
        }
    }
}