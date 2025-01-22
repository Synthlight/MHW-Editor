using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items;

public class ExpeditionRewards : SingleStructBase, IMultiStruct {
    public MultiStruct Generate() { // .ex_rem
        List<MhwMultiStructData.Entry> entries = [
            new("Unk 1 (uint)", typeof(uint)),
            new("Unk 2 (sbyte)", typeof(sbyte)),
            new("Pad 1", typeof(byte), accessLevel: "private"),
            new("Pad 2", typeof(byte), accessLevel: "private"),
            new("Pad 3", typeof(byte), accessLevel: "private"),
            new("Unk 3 (uint)", typeof(uint))
        ];

        for (var i = 1; i <= 15; i++) {
            entries.AddRange([
                new($"Quantity {i}", typeof(byte)),
                new($"Weight {i}", typeof(byte)),
                new($"Item Id {i}", typeof(uint), dataSourceType: DataSourceType.Items)
            ]);
        }

        entries.Add(new("Unk 4 (uint16)", typeof(ushort)));

        var structs = new List<MhwMultiStructData.StructData> {
            CreateSingleStructBase(out var header, out var itemCount),

            new("Entries", entries, _010Link: new(header, itemCount))
        };

        return new("Items", "ExpeditionRewards", new(structs, "ex_rem"));
    }
}