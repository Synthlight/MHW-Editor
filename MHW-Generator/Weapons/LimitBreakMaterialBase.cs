using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class LimitBreakMaterialBase : ISingleStruct {
        public SingleStruct Generate() { // .lbm_base
            return new SingleStruct("MHW_Editor.Weapons", "LimitBreakMaterialBase", new MhwStructData {
                size = 14,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Rarity", 0, typeof(byte)),
                    new MhwStructData.Entry("Equip Type", 1, typeof(byte), typeof(WeaponType)),
                    new MhwStructData.Entry("Cost", 2, typeof(uint)),
                    new MhwStructData.Entry("Item 1 Id", 6, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Item 1 Cnt", 8, typeof(ushort)),
                    new MhwStructData.Entry("Item 2 Id", 10, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Item 2 Cnt", 12, typeof(ushort))
                }
            });
        }
    }
}