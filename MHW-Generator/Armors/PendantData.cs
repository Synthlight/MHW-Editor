using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Armors {
    public class PendantData : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .ch_dat
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Unk1", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk2", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk3", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk4", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk5", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk6", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk7", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk8", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk9", typeof(byte)),
                    new MhwMultiStructData.Entry("Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Story Unlock", typeof(int)),
                    new MhwMultiStructData.Entry("Unk10", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk11", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Armors", "PendantData", new MhwMultiStructData(structs, "ch_dat"));
        }
    }
}