using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class ItemList : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .itlist
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Quantity", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Items", "ItemList", new MhwMultiStructData(structs, "itlist"));
        }
    }
}