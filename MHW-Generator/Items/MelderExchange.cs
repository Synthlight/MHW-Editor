using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class MelderExchange : IMultiStruct {
        public MultiStruct Generate() { // .mkex
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Melder Exchange", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Entry Count", typeof(uint), true).Out(out var entryCount)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Item Box", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Source Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),

                    new MhwMultiStructData.Entry("Items", typeof(void), subStruct: new MhwMultiStructData.StructData("Items", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Unk", typeof(ushort))
                    }, 239))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, entryCount))
            };

            return new MultiStruct("Items", "MelderExchange", new MhwMultiStructData(structs, "mkex"));
        }
    }
}