using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Wp03Param : WpParamBase, IMultiStruct {
        private const string N = "03";

        public MultiStruct Generate() { // .w03p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(CreateBase(N));

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Spirit Gauge Decay", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Gauge Required to Active Foresight That Gives 45 I-Frames", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Gauge Duration: White", typeof(float)),
                    new MhwMultiStructData.Entry("Gauge Duration: Yellow", typeof(float)),
                    new MhwMultiStructData.Entry("Gauge Duration: Red", typeof(float)),
                    new MhwMultiStructData.Entry("Gauge Consumption for Helm + Iai Spirit Slash", typeof(uint)),
                    new MhwMultiStructData.Entry("Gauge Damage Buff: White", typeof(float)),
                    new MhwMultiStructData.Entry("Gauge Damage Buff: Yellow", typeof(float)),
                    new MhwMultiStructData.Entry("Gauge Damage Buff: Red", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 8}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Gauge No-Decay Time after Spirit Gauge Upgrade", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Foresight Slash Damage Multiplier on Successful Evasion", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                    new MhwMultiStructData.Entry("Foresight Slash Super Armor Time on Successful Evasion", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Iai Move Speed (Higher Value Make Skill Faster)", typeof(float)),
                    new MhwMultiStructData.Entry("Iai Sheathe Time", typeof(float)),
                    new MhwMultiStructData.Entry("Iai Super Armor on Successful Counter", typeof(float)),
                    new MhwMultiStructData.Entry("Iai Spirit Slash Second Hit Part Damage on Successful Counter", typeof(float)),
                    new MhwMultiStructData.Entry("Iai Spirit Slash Second Hit Time Delay", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 6}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 3),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 2),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Helmbreaker Hit Delay of First Hit", typeof(float)),
                    new MhwMultiStructData.Entry("Helmbreaker Hit Delay of Hits Between First & Last", typeof(float)),
                    new MhwMultiStructData.Entry("Helmbreaker Hit Delay of Last Hit", typeof(float)),
                    new MhwMultiStructData.Entry("Helmbreaker Hit Limit", typeof(uint)),
                    new MhwMultiStructData.Entry("Helmbreaker Unk", typeof(float)),
                    new MhwMultiStructData.Entry("Helmbreaker Red Line Delay", typeof(float))
                }, 1, showVertically: true, description:"For Helmbreaker Hit Delay, some situations, like low or unstable fps, may cause less than 7 hits if the hit delays are <= 0."),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1)
            });

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}