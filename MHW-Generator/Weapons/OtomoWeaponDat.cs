using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class OtomoWeaponDat : ISingleStruct {
        public SingleStruct Generate() { // .owp_dat
            return new SingleStruct("MHW_Editor.Weapons", "OtomoWeaponDat", new MhwStructData {
                size             = 38,
                offsetInitial    = 10,
                entryCountOffset = 6,
                encryptionKey    = EncryptionKeys.OWP_DAT_KEY,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint)),
                    new MhwStructData.Entry("Id", 32, typeof(ushort)),
                    new MhwStructData.Entry("Set Id", 4, typeof(ushort)),
                    new MhwStructData.Entry("Element", 6, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Attack Type", 7, typeof(ushort), typeof(AttackType)),
                    new MhwStructData.Entry("Melee Damage", 9, typeof(ushort)),
                    new MhwStructData.Entry("Ranged Damage", 11, typeof(ushort)),
                    new MhwStructData.Entry("Elemental Damage", 13, typeof(ushort)),
                    new MhwStructData.Entry("Affinity", 15, typeof(short)),
                    new MhwStructData.Entry("Defense", 17, typeof(ushort)),
                    new MhwStructData.Entry("Elderseal", 19, typeof(byte)),
                    new MhwStructData.Entry("Rarity", 20, typeof(byte)),
                    new MhwStructData.Entry("Order", 21, typeof(ushort)),
                    new MhwStructData.Entry("Unk", 23, typeof(uint)),
                    new MhwStructData.Entry("Cost", 27, typeof(uint)),
                    new MhwStructData.Entry("Unknown (byte) 1", 31, typeof(byte)),
                    new MhwStructData.Entry("GMD Name Index", 34, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 36, typeof(ushort), true)
                }
            });
        }
    }
}