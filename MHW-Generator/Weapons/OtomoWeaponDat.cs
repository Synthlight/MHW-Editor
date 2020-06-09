using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class OtomoWeaponDat : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .owp_dat
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Set Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Element", typeof(byte), enumReturn: typeof(Element)),
                    new MhwMultiStructData.Entry("Attack Type", typeof(ushort), enumReturn: typeof(AttackType)),
                    new MhwMultiStructData.Entry("Melee Damage", typeof(ushort)),
                    new MhwMultiStructData.Entry("Ranged Damage", typeof(ushort)),
                    new MhwMultiStructData.Entry("Elemental Damage", typeof(ushort)),
                    new MhwMultiStructData.Entry("Affinity", typeof(short)),
                    new MhwMultiStructData.Entry("Defense", typeof(ushort)),
                    new MhwMultiStructData.Entry("Elderseal", typeof(byte)),
                    new MhwMultiStructData.Entry("Rarity", typeof(byte)),
                    new MhwMultiStructData.Entry("Order", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk", typeof(uint)),
                    new MhwMultiStructData.Entry("Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Unknown (byte) 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Id", typeof(ushort), overrideSortIndex: true),
                    new MhwMultiStructData.Entry("GMD Name Index", typeof(ushort), true),
                    new MhwMultiStructData.Entry("GMD Description Index", typeof(ushort), true)
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("MHW_Editor.Weapons", "OtomoWeaponDat", new MhwMultiStructData(structs, "owp_dat", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".owp_dat"]));
        }
    }
}