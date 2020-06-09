using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class ItemMake : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .imk
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk1", typeof(ushort)),
                    new MhwMultiStructData.Entry("Mat 1 Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 2 Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Result Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Quantity", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk2", typeof(uint)),
                    new MhwMultiStructData.Entry("Category", typeof(uint), enumReturn: typeof(ItemCategory)),
                    new MhwMultiStructData.Entry("Can Auto-Craft", typeof(byte), enumReturn: typeof(bool))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Items", "ItemMake", new MhwMultiStructData(structs, "imk"));
        }
    }
}