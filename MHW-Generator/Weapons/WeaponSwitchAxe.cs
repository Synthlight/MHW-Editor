using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class WeaponSwitchAxe : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .wep_saxe
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Phial Type", typeof(byte), enumReturn: typeof(PhialType)),
                    new MhwMultiStructData.Entry("Phial Amount", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("MHW_Editor.Weapons", "WeaponSwitchAxe", new MhwMultiStructData(structs, "wep_saxe"));
        }
    }
}