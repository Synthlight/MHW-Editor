using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.Weapons {
    public class Wp13Param : IMultiStruct {
        public MultiStruct Generate() { // .w13p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(Wp12Param.baseStructs);
            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("W13p Params (7)", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Unk287", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk288", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk289", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk290", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk291", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk292", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk293", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk293.1", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk294", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk295", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk296", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk297", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk298", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk299", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk300", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk300.1", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk301", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk302", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk303", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk304", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk305", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk306", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk307", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk307.1", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk308", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk309", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk310", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk311", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk312", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk313", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk314", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk314.1", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk315", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk316", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk317", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk318", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk319", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk320", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk321", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk322", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk323", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry("Unk324", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry("Unk325", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry("Unk326", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry("Unk327", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry("Unk328", typeof(ushort)),
                    new MhwMultiStructData.StructData.Entry("Unk329", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk330", typeof(byte)),
                    new MhwMultiStructData.StructData.Entry("Unk331", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk332", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk333", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk334", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk335", typeof(float))
                }, 1, showVertically: true),
                new MhwMultiStructData.StructData("Unk Struct 6", new List<MhwMultiStructData.StructData.Entry> {
                    new MhwMultiStructData.StructData.Entry("Unk1", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk2", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk3", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk4", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk5", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk6", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk7", typeof(float)),
                    new MhwMultiStructData.StructData.Entry("Unk8", typeof(byte))
                }, 9)
            });

            foreach (var @struct in structs) {
                @struct.name = @struct.name.Replace("W12p", "W13p");
            }

            return new MultiStruct("MHW_Editor.Weapons", "Wp13Param", new MhwMultiStructData(structs, EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w13p"]));
        }
    }
}