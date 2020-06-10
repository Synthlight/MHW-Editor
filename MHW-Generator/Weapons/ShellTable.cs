using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons.Model;

namespace MHW_Generator.Weapons {
    public class ShellTable : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .shl_tbl
            var types = new List<ShellTableTypes> {
                new ShellTableTypes("Normal", 3),
                new ShellTableTypes("Pierce", 3),
                new ShellTableTypes("Spread", 3),
                new ShellTableTypes("Cluster", 3),
                new ShellTableTypes("Wyvern", 1),
                new ShellTableTypes("Sticky", 3),
                new ShellTableTypes("Slicing", 1),
                new ShellTableTypes("Flaming", 1),
                new ShellTableTypes("Water", 1),
                new ShellTableTypes("Freeze", 1),
                new ShellTableTypes("Thunder", 1),
                new ShellTableTypes("Dragon", 1),
                new ShellTableTypes("Poison", 2),
                new ShellTableTypes("Paralysis", 2),
                new ShellTableTypes("Sleep", 2),
                new ShellTableTypes("Exhaust", 2),
                new ShellTableTypes("Recover", 2),
                new ShellTableTypes("Demon", 1),
                new ShellTableTypes("Armor", 1),
                new ShellTableTypes("Unknown", 2),
                new ShellTableTypes("Tranq", 1)
            };

            var entries = new List<MhwMultiStructData.Entry>();

            foreach (var type in types) {
                for (var i = 0; i < type.num; i++) {
                    var name = type.name;
                    if (type.num > 1) {
                        name += $" {i + 1}";
                    }

                    entries.Add(new MhwMultiStructData.Entry($"{name} Mag Cnt", typeof(byte), valueString: "value.Clamp((byte) 0, (byte) 10)"));
                    entries.Add(new MhwMultiStructData.Entry($"{name} Rec Amnt", typeof(byte), dataSourceType: DataSourceType.ShellRecoil));
                    entries.Add(new MhwMultiStructData.Entry($"{name} Rel Spd", typeof(byte), dataSourceType: DataSourceType.ShellReload));
                }
            }

            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", entries, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Weapons", "ShellTable", new MhwMultiStructData(structs, "shl_tbl"));
        }
    }
}