using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class AwakenedWpUpgrade : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .em104wud
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk1", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk2", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk3", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk4", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk5", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Weapons", "AwakenedWpUpgrade", new MhwMultiStructData(structs, "em104wud"));
        }
    }
}