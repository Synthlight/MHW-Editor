using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Items {
    public class BottleTable : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .bbtbl
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Close Range", typeof(byte), enumReturn: typeof(CoatingType)),
                    new MhwMultiStructData.Entry("Power", typeof(byte), enumReturn: typeof(CoatingType)),
                    new MhwMultiStructData.Entry("Paralysis", typeof(byte), enumReturn: typeof(CoatingType)),
                    new MhwMultiStructData.Entry("Poison", typeof(byte), enumReturn: typeof(CoatingType)),
                    new MhwMultiStructData.Entry("Sleep", typeof(byte), enumReturn: typeof(CoatingType)),
                    new MhwMultiStructData.Entry("Blast", typeof(byte), enumReturn: typeof(CoatingType))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Items", "BottleTable", new MhwMultiStructData(structs, "bbtbl"));
        }
    }
}