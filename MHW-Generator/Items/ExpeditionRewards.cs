using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items;

public class ExpeditionRewards : SingleStructBase, IMultiStruct {
    public MultiStruct Generate() { // .ex_rem
        List<MhwMultiStructData.Entry> entries = [
            new("Monster ID", typeof(uint), true, dataSourceType: DataSourceType.Monsters),
            new("Gather Type", typeof(uint), true, enumReturn: typeof(ExpeditionRewardsType))
        ];

        for (var i = 1; i <= 16; i++) {
            entries.AddRange([
                new($"Item Id {i}", typeof(uint), dataSourceType: DataSourceType.Items),
                new($"Quantity {i}", typeof(byte)),
                new($"Weight {i}", typeof(byte))
            ]);
        }

        var structs = new List<MhwMultiStructData.StructData> {
            CreateSingleStructBase(out var header, out var itemCount),

            new("Entries", entries, _010Link: new(header, itemCount), uniqueIdFormula: "{Monster_ID}|{Gather_Type}")
        };

        return new("Items", "ExpeditionRewards", new(structs, "ex_rem"));
    }
}