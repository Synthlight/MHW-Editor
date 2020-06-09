using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class LimitBreakMaterialSkill : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .lbm_skill
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Rarity", typeof(byte)),
                    new MhwMultiStructData.Entry("Augment Type", typeof(byte), enumReturn: typeof(AugmentationType)),
                    new MhwMultiStructData.Entry("Item 1 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Item 1 Cnt", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Weapons", "LimitBreakMaterialSkill", new MhwMultiStructData(structs, "lbm_skill"));
        }
    }
}