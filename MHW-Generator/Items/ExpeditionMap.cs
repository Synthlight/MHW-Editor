using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items;

public class ExpeditionMap : SingleStructBase, IMultiStruct {
    public MultiStruct Generate() { // .ex_map
        List<MhwMultiStructData.Entry> entries = [
            new("Unk 1 (uint)", typeof(uint)),
            new("Unk 2 (uint)", typeof(uint)),
            new("Unk 3 (byte)", typeof(byte)),
            new("Unk 4 (byte)", typeof(byte)),
            new("Unk 5 (byte)", typeof(byte)),
            new("Unk 6 (byte)", typeof(byte)),
            new("Unk 7 (byte)", typeof(byte)),
            new("Unk 8 (byte)", typeof(byte)),
            new("Unk 9 (byte)", typeof(byte)),
            new("Unk 10 (byte)", typeof(byte))
        ];

        var structs = new List<MhwMultiStructData.StructData> {
            CreateSingleStructBase(out var header, out var itemCount),

            new("Entries", entries, _010Link: new(header, itemCount))
        };

        return new("Items", "ExpeditionMap", new(structs, "ex_map"));
    }
}