using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Generator.Items {
    public class ItemList : ISingleStruct {
        public SingleStruct Generate() { // .itlist
            return new SingleStruct("MHW_Editor.Items", "ItemList", new MhwStructData {
                size = 8,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Item Id", 0, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Quantity", 4, typeof(uint))
                }
            });
        }
    }
}