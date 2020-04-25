using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Weapons.Model;

namespace MHW_Generator.Weapons {
    public class ShellTable : ISingleStruct {
        public SingleStruct Generate() { // .shl_tbl
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

            var entries = new List<MhwStructData.Entry>();

            ulong x = 0;
            foreach (var type in types) {
                for (var i = 0; i < type.num; i++) {
                    if (type.name == "Unknown") {
                        x += 3;
                        continue;
                    }

                    var name = type.name;
                    if (type.num > 1) {
                        name += $" {i + 1}";
                    }

                    entries.Add(new MhwStructData.Entry($"{name} Mag Cnt", x++, typeof(byte), valueString: "value.Clamp((byte) 0, (byte) 10)"));
                    entries.Add(new MhwStructData.Entry($"{name} Rec Amnt", x++, typeof(byte)));
                    entries.Add(new MhwStructData.Entry($"{name} Rel Spd", x++, typeof(byte)));
                }
            }

            return new SingleStruct("MHW_Editor.Weapons", "ShellTable", new MhwStructData {
                size = 111,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = entries
            });
        }
    }
}