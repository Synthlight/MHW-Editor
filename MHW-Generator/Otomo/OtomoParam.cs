using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Otomo;

public class OtomoParam : IMultiStruct {
    public MultiStruct Generate() { // .oprm
        ushort i           = 0;
        uint   paramsIndex = 0;

        var structs = new List<MhwMultiStructData.StructData> {
            new("Header", [
                new("Magic 1", typeof(uint), true),
                new("OPRM", typeof(char), true, typeof(string), arrayCount: 4),
                new("Unk 1", typeof(uint))
            ], 1),

            new($"Params ({++paramsIndex})", [
                new("Unk 1 (float)", typeof(float)),
                new("Unk 2 (float)", typeof(float)),
                new("Unk 3 (float)", typeof(float)),
                new("Unk 4 (float)", typeof(float)),
                new("Unk 5 (float)", typeof(float))
            ], 37),

            new($"Params ({++paramsIndex})", [
                new("Unk 1 (float)", typeof(uint))
            ], 4),

            new($"Params ({++paramsIndex})", [
                new("Unk 1 (uint)", typeof(uint)),
                new("Unk 2 (uint)", typeof(uint)),
                new("Unk 3 (uint)", typeof(uint)),
                new("Unk 4 (uint)", typeof(uint)),
                new("Unk 5 (uint)", typeof(uint)),
                new("Unk 6 (uint)", typeof(uint)),
                new("Unk 7 (uint)", typeof(uint)),
                new("Unk 8 (uint)", typeof(uint)),
                new("Unk 9 (uint)", typeof(uint))
            ], 5),

            new($"Params ({++paramsIndex})", [
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (uint)", typeof(uint)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (uint)", typeof(uint)),
                new($"Unk {++i} (uint)", typeof(uint)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(uint)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(byte)),
                new($"Unk {++i} (float)", typeof(byte)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(byte)),
                new($"Unk {++i} (float)", typeof(byte)),
                new($"Unk {++i} (float)", typeof(byte)),
                new($"Unk {++i} (float)", typeof(byte)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(byte)),
                new($"Unk {++i} (float)", typeof(byte)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(uint)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(uint)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float)),
                new($"Unk {++i} (float)", typeof(float))
            ], 1, showVertically: true)
        };

        return new("Otomo", "OtomoParam", new(structs, "oprm"));
    }
}