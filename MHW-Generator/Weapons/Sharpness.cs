using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Sharpness : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .kire
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true),
                    new MhwMultiStructData.Entry("Red", typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwMultiStructData.Entry("Orange", typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwMultiStructData.Entry("Yellow", typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwMultiStructData.Entry("Green", typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwMultiStructData.Entry("Blue", typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwMultiStructData.Entry("White", typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwMultiStructData.Entry("Purple", typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)")
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("MHW_Editor.Weapons", "Sharpness", new MhwMultiStructData(structs, "kire"));
        }
    }
}