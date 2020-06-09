using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class WeaponWhistle : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .wep_wsl
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Note 1", typeof(byte), enumReturn: typeof(NoteColor)),
                    new MhwMultiStructData.Entry("Note 2", typeof(byte), enumReturn: typeof(NoteColor)),
                    new MhwMultiStructData.Entry("Note 3", typeof(byte), enumReturn: typeof(NoteColor))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Weapons", "WeaponWhistle", new MhwMultiStructData(structs, "wep_wsl"));
        }
    }
}