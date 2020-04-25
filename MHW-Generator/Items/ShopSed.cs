using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class ShopSed : ISingleStruct {
        public SingleStruct Generate() { // .sed
            return new SingleStruct("MHW_Editor.Items", "ShopSed", new MhwStructData {
                size = 12,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Equip Type", 0, typeof(uint), typeof(EquipmentType)),
                    new MhwStructData.Entry("Equip Id", 4, typeof(uint), dataSourceType: DataSourceType.EquipmentById),
                    new MhwStructData.Entry("Story Unlock", 8, typeof(uint))
                }
            });
        }
    }
}