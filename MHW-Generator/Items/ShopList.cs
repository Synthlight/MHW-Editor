using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Items {
    public class ShopList : IMultiStruct {
        public MultiStruct Generate() { // .slt
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Shop List", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.StructData.Entry("Magic 2", typeof(ushort), true),
                    new MhwMultiStructData.StructData.Entry("Item Count", typeof(uint), true).@out(out var itemCount)
                }, 1).@out(out var header),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Index", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.StructData.Entry("Story Unlock", typeof(uint)),
                    new MhwMultiStructData.StructData.Entry("Unk", typeof(ushort))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Items", "ShopList", new MhwMultiStructData(structs, "slt"));
        }
    }
}