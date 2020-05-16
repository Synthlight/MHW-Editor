using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Weapons {
    public class Wp13Param : Wp12Param, IMultiStruct {
        private const string N = "13";

        public override MultiStruct Generate() { // .w13p
            var structs = CreateBase(N);

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("HZD Ammo Guage Levels", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                    new MhwMultiStructData.Entry("HP Red", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(float)),
                    new MhwMultiStructData.Entry("Physical Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Element Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(byte))
                }, 9)
            });

            return new MultiStruct("MHW_Editor.Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}