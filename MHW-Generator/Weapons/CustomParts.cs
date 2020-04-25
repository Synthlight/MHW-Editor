using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class CustomParts : ISingleStruct {
        public SingleStruct Generate() { // .cus_pa
            return new SingleStruct("MHW_Editor.Weapons", "CustomParts", new MhwStructData {
                size = 25,
                offsetInitial = 10,
                entryCountOffset = 6,
                encryptionKey = EncryptionKeys.CUS_PAR_KEY,
                uniqueIdFormula = "{Id}|{Weapon_Type}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Weapon Type", 4, typeof(uint), true, typeof(WeaponType)),
                    new MhwStructData.Entry("Part 1 Id", 8, typeof(uint)),
                    new MhwStructData.Entry("Unk (uint8)", 12, typeof(byte)),
                    new MhwStructData.Entry("Craft Cost", 13, typeof(uint)),
                    new MhwStructData.Entry("Attack", 17, typeof(ushort)),
                    new MhwStructData.Entry("Defense", 19, typeof(ushort)),
                    new MhwStructData.Entry("Affinity", 21, typeof(byte)),
                    new MhwStructData.Entry("Element", 22, typeof(ushort)),
                    new MhwStructData.Entry("Sharpness", 24, typeof(byte))
                }
            });
        }
    }
}