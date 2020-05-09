using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class Sharpness : ISingleStruct {
        public SingleStruct Generate() { // .kire
            return new SingleStruct("MHW_Editor.Weapons", "Sharpness", new MhwStructData {
                size             = 18,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Red", 4, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Orange", 6, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Yellow", 8, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Green", 10, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Blue", 12, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("White", 14, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Purple", 16, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)")
                }
            });
        }
    }
}