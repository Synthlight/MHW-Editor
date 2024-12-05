using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Otomo;

public class OtomoLevel : SingleStructBase, IMultiStruct {
    public MultiStruct Generate() { // .ot_lv
        var structs = new List<MhwMultiStructData.StructData> {
            CreateSingleStructBase(out var header, out var itemCount),

            new("Entries", [
                new("Index", typeof(byte), true),
                new("Unk 1 (uint)", typeof(uint)),
                new("Unk 2 (ushort)", typeof(ushort)),
                new("Unk 3 (ushort)", typeof(ushort)),
                new("Unk 4 (ushort)", typeof(ushort)),
                new("Unk 5 (byte)", typeof(byte))
            ], _010Link: new(header, itemCount))
        };

        return new("Otomo", "OtomoLevel", new(structs, "ot_lv"));
    }
}