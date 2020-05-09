using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class RodInsect : ISingleStruct {
        public SingleStruct Generate() { // .rod_inse
            return new SingleStruct("MHW_Editor.Weapons", "RodInsect", new MhwStructData {
                size             = 28,
                offsetInitial    = 10,
                entryCountOffset = 6,
                encryptionKey    = EncryptionKeys.ROD_INSE_KEY,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Attack Type", 4, typeof(byte), typeof(AttackType)),
                    new MhwStructData.Entry("Id", 5, typeof(byte), true),
                    new MhwStructData.Entry("Base Model Id", 7, typeof(ushort)),
                    new MhwStructData.Entry("Craft Cost", 10, typeof(uint)),
                    new MhwStructData.Entry("Rarity", 14, typeof(byte)),
                    new MhwStructData.Entry("Power", 15, typeof(ushort)),
                    new MhwStructData.Entry("Speed", 17, typeof(ushort)),
                    new MhwStructData.Entry("Heal", 19, typeof(ushort)),
                    new MhwStructData.Entry("Element", 21, typeof(ushort)),
                    new MhwStructData.Entry("Dust Effect", 23, typeof(ushort), typeof(DustEffect)),
                    new MhwStructData.Entry("Tree Position Id", 6, typeof(byte)),
                    new MhwStructData.Entry("Tree Id", 9, typeof(byte)),
                    new MhwStructData.Entry("Tree Position", 25, typeof(byte)),
                    new MhwStructData.Entry("Equip Id", 26, typeof(ushort))
                }
            });
        }
    }
}