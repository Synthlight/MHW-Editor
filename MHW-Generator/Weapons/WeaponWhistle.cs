using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class WeaponWhistle : ISingleStruct {
        public SingleStruct Generate() { // .wep_wsl
            return new SingleStruct("MHW_Editor.Weapons", "WeaponWhistle", new MhwStructData {
                size             = 7,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Note 1", 4, typeof(byte), typeof(NoteColor)),
                    new MhwStructData.Entry("Note 2", 5, typeof(byte), typeof(NoteColor)),
                    new MhwStructData.Entry("Note 3", 6, typeof(byte), typeof(NoteColor))
                }
            });
        }
    }
}