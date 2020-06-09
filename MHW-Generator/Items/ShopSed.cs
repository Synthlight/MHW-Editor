using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class ShopSed : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .sed
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Equip Type", typeof(uint), enumReturn: typeof(EquipmentType)),
                    new MhwMultiStructData.Entry("Equip Id", typeof(uint), dataSourceType: DataSourceType.EquipmentById),
                    new MhwMultiStructData.Entry("Story Unlock", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Items", "ShopSed", new MhwMultiStructData(structs, "sed"));
        }
    }
}