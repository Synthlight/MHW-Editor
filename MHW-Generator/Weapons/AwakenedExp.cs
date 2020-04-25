using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class AwakenedExp : ISingleStruct {
        public SingleStruct Generate() { // .em104exp
            return new SingleStruct("MHW_Editor.Weapons", "AwakenedExp", new MhwStructData {
                size = 2,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Level}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Needed Exp for Next Level", 0, typeof(ushort))
                }
            });
        }
    }
}