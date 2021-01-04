using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Wp05Param : WpParamBase, IMultiStruct {
        private const string N = "05";

        public MultiStruct Generate() { // .w05p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(CreateBase(N));

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)), // 91
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Buff Range", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Self-Improvement Movement Speed", typeof(float)), // 101
                    new MhwMultiStructData.Entry("Self Improvement Movement Speed Additive Bonus With Speed Boost", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 1", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 2", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 3", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 4", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 5", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 6", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 7", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 8", typeof(float)),
                    new MhwMultiStructData.Entry("Dragon Seal of Echo Wave 'Dragon' 9", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Deflected Attack Prevention Self Buff Multiplier", typeof(float))
                }, 1, showVertically: true)
            });

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}