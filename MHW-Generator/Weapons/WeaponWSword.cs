using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class WeaponWSword : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .wep_wsd
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Element 1 Type", typeof(byte), enumReturn: typeof(Element)),
                    new MhwMultiStructData.Entry("Element 1 Dmg", typeof(short)),
                    new MhwMultiStructData.Entry("Element 2 Type", typeof(byte), enumReturn: typeof(Element)),
                    new MhwMultiStructData.Entry("Element 2 Dmg", typeof(short))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Weapons", "WeaponWSword", new MhwMultiStructData(structs, "wep_wsd"));
        }
    }
}