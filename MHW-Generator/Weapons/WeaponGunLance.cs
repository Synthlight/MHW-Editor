using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class WeaponGunLance : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .wep_glan
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Shell Type", typeof(ushort), enumReturn: typeof(ShellType)),
                    new MhwMultiStructData.Entry("Shell Level", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Weapons", "WeaponGunLance", new MhwMultiStructData(structs, "wep_glan"));
        }
    }
}