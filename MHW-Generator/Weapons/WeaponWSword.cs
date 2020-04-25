using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class WeaponWSword : ISingleStruct {
        public SingleStruct Generate() { // .wep_wsd
            return new SingleStruct("MHW_Editor.Weapons", "WeaponWSword", new MhwStructData {
                size = 10,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Element 1 Type", 4, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element 1 Dmg", 5, typeof(short)),
                    new MhwStructData.Entry("Element 2 Type", 7, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element 2 Dmg", 8, typeof(short))
                }
            });
        }
    }
}