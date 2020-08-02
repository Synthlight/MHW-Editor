using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class RoomAnimal : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .ranml
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Entry Count", typeof(ushort), true).Out(out var entryCount),
                    new MhwMultiStructData.Entry("Unk 1", typeof(byte), true)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Display Multiplier", typeof(byte)),
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items)
                }.Out(out var entries), _010Link: new MhwMultiStructData.ArrayLink(header, entryCount), uniqueIdFormula: "{Index}")
            };

            for (var i = 0; i < 53; i++) {
                entries.Add(new MhwMultiStructData.Entry($"Slot {i + 1}", typeof(byte)));
            }

            return new MultiStruct("Items", "RoomAnimal", new MhwMultiStructData(structs, "ranml"));
        }
    }
}