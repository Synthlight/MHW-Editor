using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class AwakenedExp : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .em104exp
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Needed Exp for Next Level", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Weapons", "AwakenedExp", new MhwMultiStructData(structs, "em104exp"));
        }
    }
}