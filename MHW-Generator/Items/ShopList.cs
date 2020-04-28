using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Items {
    public class ShopList : IMultiStruct {
        public MultiStruct Generate() { // .slt
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Shop List", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Item Count", typeof(uint), true).Out(out var itemCount)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Story Unlock", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk", typeof(ushort))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Items", "ShopList", new MhwMultiStructData(structs, "slt"));
        }
    }
}