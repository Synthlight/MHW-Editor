using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Otomo;

public class OtomoToolLevel : SingleStructBase, IMultiStruct {
    public MultiStruct Generate() { // .ot_tlv
        var structs = new List<MhwMultiStructData.StructData> {
            CreateSingleStructBase(out var header, out var itemCount),

            new("Entries", [
                new("Unk 1 (ushort)", typeof(ushort)),
                new("Unk 2 (ushort)", typeof(ushort)),
                new("Unk 3 (ushort)", typeof(ushort)),
                new("Unk 4 (ushort)", typeof(ushort)),
                new("Unk 5 (ushort)", typeof(ushort)),
                new("Unk 6 (ushort)", typeof(ushort)),
                new("Unk 7 (ushort)", typeof(ushort)),
                new("Unk 8 (ushort)", typeof(ushort)),
                new("Unk 9 (ushort)", typeof(ushort)),
                new("Unk 10 (ushort)", typeof(ushort)),
                new("Unk 11 (ushort)", typeof(ushort)),
                new("Unk 12 (ushort)", typeof(ushort)),
                new("Unk 13 (ushort)", typeof(ushort)),
                new("Unk 14 (uint)", typeof(uint))
            ], _010Link: new(header, itemCount))
        };

        return new("Otomo", "OtomoToolLevel", new(structs, "ot_tlv"));
    }
}