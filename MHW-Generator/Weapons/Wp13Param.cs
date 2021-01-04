using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Wp13Param : Wp12Param, IMultiStruct {
        private const string N = "13";

        public override MultiStruct Generate() { // .w13p
            var structs = CreateBase(N);

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)), // 284
                    new MhwMultiStructData.Entry("Wyvernblast (S) Charge Consumption", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(ushort)),
                    new MhwMultiStructData.Entry("Wyvernblast (M) Charge Consumption", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(ushort)),
                    new MhwMultiStructData.Entry("Wyvernblast (L) Charge Consumption", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(short)),
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
                    new MhwMultiStructData.Entry("Wyvernblast Cooldown", typeof(float)), // 323
                    new MhwMultiStructData.Entry("Wyvernblast Capacity", typeof(byte)),
                    new MhwMultiStructData.Entry("Wyvernblast Initial Charges", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 4}", typeof(byte)),
                    new MhwMultiStructData.Entry("Wyvernblast Lifespan", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(byte)),
                    new MhwMultiStructData.Entry("Wyvernblast Counter Explosion Lifespan?", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData("HZD Ammo Gauge Levels", new List<MhwMultiStructData.Entry> {
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

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}