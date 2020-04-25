using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class WeaponGunLance : ISingleStruct {
        public SingleStruct Generate() { // .wep_glan
            return new SingleStruct("MHW_Editor.Weapons", "WeaponGunLance", new MhwStructData {
                size = 8,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Shell Type", 4, typeof(ushort), typeof(ShellType)),
                    new MhwStructData.Entry("Shell Level", 6, typeof(ushort))
                }
            });
        }
    }
}