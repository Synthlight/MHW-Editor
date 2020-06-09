using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class RodInsect : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .rod_inse
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint), true),
                    new MhwMultiStructData.Entry("Attack Type", typeof(byte), enumReturn: typeof(AttackType)),
                    new MhwMultiStructData.Entry("Id", typeof(byte), true),
                    new MhwMultiStructData.Entry("Tree Position Id", typeof(byte), overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Base Model Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Tree Id", typeof(byte), overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Craft Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Rarity", typeof(byte)),
                    new MhwMultiStructData.Entry("Power", typeof(ushort)),
                    new MhwMultiStructData.Entry("Speed", typeof(ushort)),
                    new MhwMultiStructData.Entry("Heal", typeof(ushort)),
                    new MhwMultiStructData.Entry("Element", typeof(ushort)),
                    new MhwMultiStructData.Entry("Dust Effect", typeof(ushort), enumReturn: typeof(DustEffect)),
                    new MhwMultiStructData.Entry("Tree Position", typeof(byte)),
                    new MhwMultiStructData.Entry("Equip Id", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Weapons", "RodInsect", new MhwMultiStructData(structs, "rod_inse", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".rod_inse"]));
        }
    }
}