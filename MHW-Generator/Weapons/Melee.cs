using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class Melee : ISingleStruct {
        public SingleStruct Generate() { // .wp_dat
            return new SingleStruct("MHW_Editor.Weapons", "Melee", new MhwStructData {
                size             = 66,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Id", 56, typeof(ushort), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(short)),
                    new MhwStructData.Entry("Base Model Id", 6, typeof(short)),
                    new MhwStructData.Entry("Part 1 Id", 8, typeof(short)),
                    new MhwStructData.Entry("Part 2 Id", 10, typeof(short)),
                    new MhwStructData.Entry("Color", 13, typeof(byte)),
                    new MhwStructData.Entry("Is Fixed Upgrade", 15, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Cost", 16, typeof(uint)),
                    new MhwStructData.Entry("Rarity", 20, typeof(byte)),
                    new MhwStructData.Entry("Sharpness (.kire) Id", 21, typeof(byte)),
                    new MhwStructData.Entry("Sharpness Amount", 22, typeof(byte)),
                    new MhwStructData.Entry("Damage", 23, typeof(ushort)),
                    new MhwStructData.Entry("Defense", 25, typeof(ushort)),
                    new MhwStructData.Entry("Affinity", 27, typeof(sbyte), valueString: "value.Clamp((sbyte) -100, (sbyte) 100)"),
                    new MhwStructData.Entry("Element", 28, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element Damage", 29, typeof(ushort)),
                    new MhwStructData.Entry("Element (Hidden)", 31, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element (Hidden) Damage", 32, typeof(ushort)),
                    new MhwStructData.Entry("Elderseal", 34, typeof(byte), typeof(Elderseal)),
                    new MhwStructData.Entry("Slot Count", 35, typeof(byte)),
                    new MhwStructData.Entry("Slot 1 Size", 36, typeof(byte)),
                    new MhwStructData.Entry("Slot 2 Size", 37, typeof(byte)),
                    new MhwStructData.Entry("Slot 3 Size", 38, typeof(byte)),
                    new MhwStructData.Entry("Special Ability 1 ID", 39, typeof(ushort)),
                    new MhwStructData.Entry("Special Ability 2 ID", 41, typeof(ushort)),
                    new MhwStructData.Entry("Tree Id", 14, typeof(byte)),
                    new MhwStructData.Entry("Tree Position", 55, typeof(byte)),
                    new MhwStructData.Entry("Skill", 62, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("GMD Name Index", 58, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 60, typeof(ushort), true)
                }
            });
        }
    }
}