using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class PlantItem : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .plit
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Cultivation category", typeof(uint), enumReturn: typeof(CultivationCategory)),
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unlocked from start", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Item", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Required time", typeof(uint)),
                    new MhwMultiStructData.Entry("Catalyst time bonus", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Amount (Base)", typeof(uint)),
                    new MhwMultiStructData.Entry("Amount (+1)", typeof(uint)),
                    new MhwMultiStructData.Entry("Amount (+2)", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Item}", canAddRows: true)
            };

            return new MultiStruct("Items", "PlantItem", new MhwMultiStructData(structs, "plit"));
        }
    }
}