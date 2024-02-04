using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Skills {
    public class CatSkill : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .cat_skill
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(int)),
                    new MhwMultiStructData.Entry("Rarity", typeof(uint)),
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Skills", "CatSkill", new MhwMultiStructData(structs, "cat_skill"));
        }
    }
}