using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class LimitBreakMaterialSkill : ISingleStruct {
        public SingleStruct Generate() { // .lbm_skill
            return new SingleStruct("MHW_Editor.Weapons", "LimitBreakMaterialSkill", new MhwStructData {
                size = 10,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Rarity", 0, typeof(byte)),
                    new MhwStructData.Entry("Augment Type", 1, typeof(byte), typeof(AugmentationType)),
                    new MhwStructData.Entry("Item 1 Id", 2, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Item 1 Cnt", 4, typeof(ushort)),
                    new MhwStructData.Entry("Unk", 6, typeof(uint))
                }
            });
        }
    }
}