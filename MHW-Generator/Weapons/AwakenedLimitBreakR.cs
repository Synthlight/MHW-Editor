using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class AwakenedLimitBreakR : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .em104lbr
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Great Sword", typeof(ushort)),
                    new MhwMultiStructData.Entry("Sword & Shield", typeof(ushort)),
                    new MhwMultiStructData.Entry("Dual Blades", typeof(ushort)),
                    new MhwMultiStructData.Entry("Long Sword", typeof(ushort)),
                    new MhwMultiStructData.Entry("Hammer", typeof(ushort)),
                    new MhwMultiStructData.Entry("Hunting Horn", typeof(ushort)),
                    new MhwMultiStructData.Entry("Lance", typeof(ushort)),
                    new MhwMultiStructData.Entry("Gunlance", typeof(ushort)),
                    new MhwMultiStructData.Entry("Switch Axe", typeof(ushort)),
                    new MhwMultiStructData.Entry("Charge Blade", typeof(ushort)),
                    new MhwMultiStructData.Entry("Insect Glaive", typeof(ushort)),
                    new MhwMultiStructData.Entry("Bow", typeof(ushort)),
                    new MhwMultiStructData.Entry("HBG", typeof(ushort)),
                    new MhwMultiStructData.Entry("LBG", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Weapons", "AwakenedLimitBreakR", new MhwMultiStructData(structs, "em104lbr"));
        }
    }
}