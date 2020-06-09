using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class ItemLottery : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .itlot
            var subArrayView = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Items".Out(out var itemName), typeof(void), subStruct: new MhwMultiStructData.StructData(itemName, new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Id", typeof(ushort), dataSourceType: DataSourceType.Items)
                }, 10)),
                new MhwMultiStructData.Entry("Counts".Out(out var countsName), typeof(void), subStruct: new MhwMultiStructData.StructData(countsName, new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Count", typeof(byte))
                }, 10)),
                new MhwMultiStructData.Entry("Percents".Out(out var percentsName), typeof(void), subStruct: new MhwMultiStructData.StructData(percentsName, new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item %", typeof(byte), valueString: "value.Clamp((byte) 0, (byte) 100)")
                }, 10)),
                new MhwMultiStructData.Entry("Carve Animations".Out(out var carveName), typeof(void), subStruct: new MhwMultiStructData.StructData(carveName, new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Carve Animation", typeof(byte), enumReturn: typeof(CarveAnimation))
                }, 10))
            };

            var flatLongView = new List<MhwMultiStructData.Entry>();
            for (var i = 0; i < 10; i++) {
                flatLongView.Add(new MhwMultiStructData.Entry($"Item {i + 1} Id", typeof(ushort), dataSourceType: DataSourceType.Items, overrideSortIndex: true));
            }
            for (var i = 0; i < 10; i++) {
                flatLongView.Add(new MhwMultiStructData.Entry($"Item {i + 1} Count", typeof(byte), overrideSortIndex: true));
            }
            for (var i = 0; i < 10; i++) {
                flatLongView.Add(new MhwMultiStructData.Entry($"Item {i + 1} %", typeof(byte), valueString: "value.Clamp((byte) 0, (byte) 100)", overrideSortIndex: true));
            }
            for (var i = 0; i < 10; i++) {
                flatLongView.Add(new MhwMultiStructData.Entry($"Item {i + 1} Carve Animation", typeof(byte), enumReturn: typeof(CarveAnimation), overrideSortIndex: true));
            }

            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", flatLongView, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Items", "ItemLottery", new MhwMultiStructData(structs, "itlot", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".itlot"]));
        }
    }
}