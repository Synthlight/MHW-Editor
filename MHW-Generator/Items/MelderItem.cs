using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class MelderItem : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .mkit
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Result Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Research Points", typeof(uint)),
                    new MhwMultiStructData.Entry("Melding Points", typeof(uint)),
                    new MhwMultiStructData.Entry("Category", typeof(uint), enumReturn: typeof(ItemCategory)),
                    new MhwMultiStructData.Entry("Unlock Flag", typeof(uint)),
                    new MhwMultiStructData.Entry("Unknown (uint8)", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Items", "MelderItem", new MhwMultiStructData(structs, "mkit"));
        }
    }
}