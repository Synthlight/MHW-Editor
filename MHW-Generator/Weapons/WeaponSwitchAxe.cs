using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class WeaponSwitchAxe : ISingleStruct {
        public SingleStruct Generate() { // .wep_saxe
            return new SingleStruct("MHW_Editor.Weapons", "WeaponSwitchAxe", new MhwStructData {
                size             = 7,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Phial Type", 4, typeof(byte), typeof(PhialType)),
                    new MhwStructData.Entry("Phial Amount", 5, typeof(ushort))
                }
            });
        }
    }
}