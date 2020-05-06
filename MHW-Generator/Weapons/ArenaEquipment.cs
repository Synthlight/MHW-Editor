using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Multi;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class ArenaEquipment : IMultiStruct {
        public MultiStruct Generate() { // .aeq
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Aeq", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Magic 2", typeof(ushort)),
                    new MhwMultiStructData.Entry("Entry Count", typeof(uint)).Out(out var entryCount)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Weapon Type", typeof(uint), enumReturn: typeof(WeaponType)),
                    new MhwMultiStructData.Entry("Weapon Id", typeof(uint), dataSourceType: DataSourceType.WeaponsByIndex),

                    new MhwMultiStructData.Entry("Custom Mods", typeof(void), subStruct: new MhwMultiStructData.StructData("Custom Mods", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Mod", typeof(int))
                    }, 5)),

                    new MhwMultiStructData.Entry("Armors", typeof(void), subStruct: new MhwMultiStructData.StructData("Armors", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Armor Id", typeof(int), dataSourceType: DataSourceType.ArmorByFileIndexNeg)
                    }, 6)),

                    new MhwMultiStructData.Entry("Mantles", typeof(void), subStruct: new MhwMultiStructData.StructData("Mantles", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Mantle Id", typeof(int), dataSourceType: DataSourceType.MantleByIdNeg)
                    }, 2)),

                    new MhwMultiStructData.Entry("Armor Level", typeof(void), subStruct: new MhwMultiStructData.StructData("Armor Level", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Armor Lvl", typeof(uint))
                    }, 5)),

                    new MhwMultiStructData.Entry("Unk 3", typeof(ushort)),

                    new MhwMultiStructData.Entry("Decorations", typeof(void), subStruct: new MhwMultiStructData.StructData("Decorations", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Deco 1", typeof(uint), dataSourceType: DataSourceType.Items),
                        new MhwMultiStructData.Entry("Deco 2", typeof(uint), dataSourceType: DataSourceType.Items),
                        new MhwMultiStructData.Entry("Deco 3", typeof(uint), dataSourceType: DataSourceType.Items)
                    }, 9)),

                    new MhwMultiStructData.Entry("Kinsect Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Kinsect Lvl", typeof(uint)),

                    new MhwMultiStructData.Entry("Unk 4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 8", typeof(uint)),

                    new MhwMultiStructData.Entry("Items", typeof(void), subStruct: new MhwMultiStructData.StructData("Items", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                        new MhwMultiStructData.Entry("Item Cnt", typeof(uint))
                    }, 24)),

                    new MhwMultiStructData.Entry("Ammo", typeof(void), subStruct: new MhwMultiStructData.StructData("Ammo", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Ammo Id", typeof(uint), dataSourceType: DataSourceType.Items),
                        new MhwMultiStructData.Entry("Ammo Cnt", typeof(uint))
                    }, 16))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, entryCount))
            };

            return new MultiStruct("MHW_Editor.Weapons", "ArenaEquipment", new MhwMultiStructData(structs, "aeq", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".aeq"]));
        }
    }
}