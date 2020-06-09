using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class ItemDelivery : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .stmp
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk2", typeof(uint)),
                    new MhwMultiStructData.Entry("Client Id", typeof(int)),
                    new MhwMultiStructData.Entry("Decoration Reward", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Unk3", typeof(uint)),
                    new MhwMultiStructData.Entry("Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Item 1 Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Item 1 Cnt", typeof(uint)),
                    new MhwMultiStructData.Entry("Item 2 Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Item 2 Cnt", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Items", "ItemDelivery", new MhwMultiStructData(structs, "stmp"));
        }
    }
}