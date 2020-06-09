using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class CustomParts : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .cus_pa
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Weapon Type", typeof(uint), true, typeof(WeaponType)),
                    new MhwMultiStructData.Entry("Part 1 Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk (uint8)", typeof(byte)),
                    new MhwMultiStructData.Entry("Craft Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Attack", typeof(ushort)),
                    new MhwMultiStructData.Entry("Defense", typeof(ushort)),
                    new MhwMultiStructData.Entry("Affinity", typeof(byte)),
                    new MhwMultiStructData.Entry("Element", typeof(ushort)),
                    new MhwMultiStructData.Entry("Sharpness", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}|{Weapon_Type}")
            };

            return new MultiStruct("Weapons", "CustomParts", new MhwMultiStructData(structs, "cus_pa", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".cus_pa"]));
        }
    }
}