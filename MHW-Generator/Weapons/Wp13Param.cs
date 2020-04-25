using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Weapons {
    public class Wp13Param : IMultiStruct {
        public MultiStruct Generate() { // .w13p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(Wp12Param.baseStructs);
            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("W13p Params (7)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk287", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk288", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk289", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk290", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk291", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk292", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk293", typeof(short)),
                    new MhwMultiStructData.Entry("Unk293.1", typeof(short)),
                    new MhwMultiStructData.Entry("Unk294", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk295", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk296", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk297", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk298", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk299", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk300", typeof(short)),
                    new MhwMultiStructData.Entry("Unk300.1", typeof(short)),
                    new MhwMultiStructData.Entry("Unk301", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk302", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk303", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk304", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk305", typeof(short)),
                    new MhwMultiStructData.Entry("Unk306", typeof(short)),
                    new MhwMultiStructData.Entry("Unk307", typeof(short)),
                    new MhwMultiStructData.Entry("Unk307.1", typeof(short)),
                    new MhwMultiStructData.Entry("Unk308", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk309", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk310", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk311", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk312", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk313", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk314", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk314.1", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk315", typeof(float)),
                    new MhwMultiStructData.Entry("Unk316", typeof(float)),
                    new MhwMultiStructData.Entry("Unk317", typeof(float)),
                    new MhwMultiStructData.Entry("Unk318", typeof(float)),
                    new MhwMultiStructData.Entry("Unk319", typeof(float)),
                    new MhwMultiStructData.Entry("Unk320", typeof(float)),
                    new MhwMultiStructData.Entry("Unk321", typeof(float)),
                    new MhwMultiStructData.Entry("Unk322", typeof(float)),
                    new MhwMultiStructData.Entry("Unk323", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk324", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk325", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk326", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk327", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk328", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk329", typeof(float)),
                    new MhwMultiStructData.Entry("Unk330", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk331", typeof(float)),
                    new MhwMultiStructData.Entry("Unk332", typeof(float)),
                    new MhwMultiStructData.Entry("Unk333", typeof(float)),
                    new MhwMultiStructData.Entry("Unk334", typeof(float)),
                    new MhwMultiStructData.Entry("Unk335", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Unk Struct 6", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk1", typeof(float)),
                    new MhwMultiStructData.Entry("Unk2", typeof(float)),
                    new MhwMultiStructData.Entry("Unk3", typeof(float)),
                    new MhwMultiStructData.Entry("Unk4", typeof(float)),
                    new MhwMultiStructData.Entry("Unk5", typeof(float)),
                    new MhwMultiStructData.Entry("Unk6", typeof(float)),
                    new MhwMultiStructData.Entry("Unk7", typeof(float)),
                    new MhwMultiStructData.Entry("Unk8", typeof(byte))
                }, 9)
            });

            foreach (var @struct in structs) {
                @struct.name = @struct.name.Replace("W12p", "W13p");
            }

            return new MultiStruct("MHW_Editor.Weapons", "Wp13Param", new MhwMultiStructData(structs, "w13p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w13p"]));
        }
    }
}