using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Armors;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Armors {
    public class Opst : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .opst
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Iceborne Identifier", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic", typeof(uint), true),
                    new MhwMultiStructData.Entry("Entry Count", typeof(uint), true).Out(out var entryCount)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Bit Flags 1 Raw", typeof(byte), enumReturn: typeof(Opst1Flags), accessLevel: "private"),
                    new MhwMultiStructData.Entry("Bit Flags 2 Raw", typeof(byte), enumReturn: typeof(Opst2Flags), accessLevel: "private"),
                    new MhwMultiStructData.Entry("Bit Flags 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Bit Flags 4", typeof(byte)),
                    new MhwMultiStructData.Entry("Bit Flags 5", typeof(byte), enumReturn: typeof(bool)),
                }, _010Link: new MhwMultiStructData.ArrayLink(header, entryCount))
            };

            return new MultiStruct("Armors", "Opst", new MhwMultiStructData(structs, "opst"));
        }
    }
}