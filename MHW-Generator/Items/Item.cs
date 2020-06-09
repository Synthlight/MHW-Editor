using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class Item : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .itm
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Sub Type", typeof(byte), enumReturn: typeof(ItemSubType)),
                    new MhwMultiStructData.Entry("Type", typeof(uint), enumReturn: typeof(ItemType)),
                    new MhwMultiStructData.Entry("Rarity", typeof(byte)),
                    new MhwMultiStructData.Entry("Carry Limit", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unknown (sint8)", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Sort Order", typeof(ushort)),
                    new MhwMultiStructData.Entry("Flags Raw", typeof(uint), accessLevel: "private", extraOnPropertyChanged: new[] {"Flags"}, overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Icon Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Icon Color Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Sell Price", typeof(uint)),
                    new MhwMultiStructData.Entry("Buy Price", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Items", "Item", new MhwMultiStructData(structs, "itm"));
        }
    }
}