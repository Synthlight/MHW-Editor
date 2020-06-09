using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class Ranged : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .wp_dat_g
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk 1", typeof(short)),
                    new MhwMultiStructData.Entry("Base Model Id", typeof(short)),
                    new MhwMultiStructData.Entry("Part 1 Id", typeof(short)),
                    new MhwMultiStructData.Entry("Part 2 Id", typeof(short)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Color", typeof(byte)),
                    new MhwMultiStructData.Entry("Tree Id", typeof(byte), overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Is Fixed Upgrade", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Muzzle Type", typeof(byte), enumReturn: typeof(MuzzleType)),
                    new MhwMultiStructData.Entry("Barrel Type", typeof(byte), enumReturn: typeof(BarrelType)),
                    new MhwMultiStructData.Entry("Magazine Type", typeof(byte), enumReturn: typeof(MagazineType)),
                    new MhwMultiStructData.Entry("Scope Type", typeof(byte), enumReturn: typeof(ScopeType)),
                    new MhwMultiStructData.Entry("Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Rarity", typeof(byte)),
                    new MhwMultiStructData.Entry("Damage", typeof(ushort)),
                    new MhwMultiStructData.Entry("Defense", typeof(ushort)),
                    new MhwMultiStructData.Entry("Affinity", typeof(sbyte), valueString: "value.Clamp((sbyte) -100, (sbyte) 100)"),
                    new MhwMultiStructData.Entry("Element", typeof(byte), enumReturn: typeof(Element)),
                    new MhwMultiStructData.Entry("Element Damage", typeof(ushort)),
                    new MhwMultiStructData.Entry("Element (Hidden)", typeof(byte), enumReturn: typeof(Element)),
                    new MhwMultiStructData.Entry("Element (Hidden) Damage", typeof(ushort)),
                    new MhwMultiStructData.Entry("Elderseal", typeof(byte), enumReturn: typeof(Elderseal)),
                    new MhwMultiStructData.Entry("Shell Type Id", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Deviation", typeof(byte), enumReturn: typeof(Deviation)),
                    new MhwMultiStructData.Entry("Slot Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Slot 1 Size", typeof(byte)),
                    new MhwMultiStructData.Entry("Slot 2 Size", typeof(byte)),
                    new MhwMultiStructData.Entry("Slot 3 Size", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 8", typeof(byte)),
                    new MhwMultiStructData.Entry("Special Ammo Type", typeof(byte)),
                    new MhwMultiStructData.Entry("Tree Position", typeof(byte)),
                    new MhwMultiStructData.Entry("Id", typeof(ushort), true, overrideSortIndex: true),
                    new MhwMultiStructData.Entry("GMD Name Index", typeof(ushort), true),
                    new MhwMultiStructData.Entry("GMD Description Index", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Skill", typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Unk 6", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("MHW_Editor.Weapons", "Ranged", new MhwMultiStructData(structs, "wp_dat_g"));
        }
    }
}