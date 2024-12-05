using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Misc {
    public class EquipColor : IMultiStruct {
        public MultiStruct Generate() { // .evsc
            var entries = new List<MhwMultiStructData.Entry> {
                new("Unk 1 (byte)", typeof(byte)),
                new("Unk 2 (byte)", typeof(byte)),
                new("Unk 3 (byte)", typeof(byte)),
                new("Unk 4 (byte)", typeof(byte)),
                new("Unk 5 (uint)", typeof(uint)),
                new("Unk 6 (float)", typeof(float)),
                new("Unk 7 (float)", typeof(float)),
                new("Unk 8 (float)", typeof(float)),
                new("Unk 9 (float)", typeof(float)),
                new("Unk 10 (float)", typeof(float)),
                new("Unk 11 (float)", typeof(float)),
                new("Unk 12 (float)", typeof(float)),
                new("Unk 13 (float)", typeof(float)),
                new("Unk 14 (float)", typeof(float)),
            };

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", [
                    new("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("EVSC", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.Entry("Entry Count", typeof(uint), true).Out(out var entryCount)
                ], 1).Out(out var header),

                new("Parts", [
                    new MhwMultiStructData.Entry("Array Count", typeof(uint), true).Out(out var innerCount),

                    new("Part", typeof(void), subStruct: new("Part", [
                        new("Unk 1 (byte)", typeof(byte)),
                        new("Unk 2 (byte)", typeof(byte)),
                        new("Unk 3 (byte)", typeof(byte)),
                        new("Unk 4 (byte)", typeof(byte)),
                        new("Unk 5 (uint)", typeof(uint)),
                        new("Unk 6 (float)", typeof(float)),
                        new("Unk 7 (float)", typeof(float)),
                        new("Unk 8 (float)", typeof(float)),
                        new("Unk 9 (float)", typeof(float)),
                        new("Unk 10 (float)", typeof(float)),
                        new("Unk 11 (float)", typeof(float)),
                        new("Unk 12 (float)", typeof(float)),
                        new("Unk 13 (float)", typeof(float)),
                        new("Unk 14 (float)", typeof(float))
                    ], canAddRows: false, _010Link: new(null, innerCount)))
                ], canAddRows: false, _010Link: new(header, entryCount))
            };

            return new("Misc", "EquipColor", new(structs, "evsc"));
        }
    }
}