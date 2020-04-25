using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Items;

namespace MHW_Generator.Items {
    public class Item : ISingleStruct {
        public SingleStruct Generate() { // .itm
            return new SingleStruct("MHW_Editor.Items", "Item", new MhwStructData {
                size = 32,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Sub Type", 4, typeof(byte), typeof(ItemSubType)),
                    new MhwStructData.Entry("Type", 5, typeof(uint), typeof(ItemType)),
                    new MhwStructData.Entry("Rarity", 9, typeof(byte)),
                    new MhwStructData.Entry("Carry Limit", 10, typeof(sbyte)),
                    new MhwStructData.Entry("Unknown (sint8)", 11, typeof(sbyte)),
                    new MhwStructData.Entry("Sort Order", 12, typeof(ushort)),
                    new MhwStructData.Entry("Icon Id", 18, typeof(uint)),
                    new MhwStructData.Entry("Icon Color Id", 22, typeof(ushort)),
                    new MhwStructData.Entry("Sell Price", 24, typeof(uint)),
                    new MhwStructData.Entry("Buy Price", 28, typeof(uint)),
                    new MhwStructData.Entry("Flags Raw", 14, typeof(uint), accessLevel: "private", extraOnPropertyChanged: new[] {"Flags"})
                }
            });
        }
    }
}