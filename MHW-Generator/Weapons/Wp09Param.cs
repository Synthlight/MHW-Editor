using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Wp09Param : WpParamBase, IMultiStruct {
        private const string N = "09";

        public MultiStruct Generate() { // .w09p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(CreateBase(N));

            var unkCbArr = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                new MhwMultiStructData.Entry("Unk 4", typeof(float))
            };

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)), // 91
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("All Sword Phial Damage Interval", typeof(float)),
                    new MhwMultiStructData.Entry("Shield Thrust Phial Damage Interval", typeof(float)),
                    new MhwMultiStructData.Entry("Axe Elemental Discharge 1 / Rushing Element Discharge 1 Phial Damage Interval (Same Move Just Different Input)", typeof(float)),
                    new MhwMultiStructData.Entry("Axe Elemental Discharge 2 First Hit Phial Damage Interval", typeof(float)),
                    new MhwMultiStructData.Entry("Axe Elemental Discharge 2 Second Hit Phial Damage Interval", typeof(float)),
                    new MhwMultiStructData.Entry("AED Phial Damage Interval", typeof(float)),
                    new MhwMultiStructData.Entry("Charge to Reach Yellow Phial", typeof(byte)),
                    new MhwMultiStructData.Entry("Charge to Reach Red Phial", typeof(byte)),
                    new MhwMultiStructData.Entry("Charge Gained When Blocking a Small Knock-back", typeof(byte)),
                    new MhwMultiStructData.Entry("Charge Gained When Blocking a Medium Knock-back", typeof(byte)),
                    new MhwMultiStructData.Entry("Charge Gained When Blocking a Large Knock-back", typeof(byte)),
                    new MhwMultiStructData.Entry("Overcharged Phial", typeof(byte)),
                    new MhwMultiStructData.Entry("Phial Charge Limit", typeof(byte)),
                    new MhwMultiStructData.Entry("Axe Mode Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Guard Point Sharpness Cost Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Phial Damage Multiplier (Not for SAED)", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Phial Stun Buildup Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Phial Exhaust Buildup Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Elemental Phial Damage Multiplier (Not for SAED)", typeof(float)),
                    new MhwMultiStructData.Entry("Phial Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Shield Charge Guard Threshold Bonus", typeof(byte)),
                    new MhwMultiStructData.Entry("Charged Shield Warning Duration When About to End", typeof(float)),
                    new MhwMultiStructData.Entry("Charged Sword Warning Duration When About to End", typeof(float)),
                    new MhwMultiStructData.Entry("Sword Charge Duration", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 25}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)), // 123
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex}", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(float))
                }, 4),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)) // 132
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Charge of [Sword]: Charged Double Slash", typeof(float)), // 133
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Speed From a Different Move to [Sword]: Charged Double Slash", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Charge of [Sword]: Condensed Element Slash", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)) // 140
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData("Impact SAED Phial Spawn Interval", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Phial 1", typeof(float)),
                    new MhwMultiStructData.Entry("Phial 2", typeof(float)),
                    new MhwMultiStructData.Entry("Phial 3", typeof(float)),
                    new MhwMultiStructData.Entry("Phial 4", typeof(float)),
                    new MhwMultiStructData.Entry("Phial 5", typeof(float)),
                    new MhwMultiStructData.Entry("Phial 6", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Impact SAED Coordinates", unkCbArr, 21)
            });

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Elemental SAED Spawn Interval/Coords", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Spawn Intervals", typeof(void), subStruct: new MhwMultiStructData.StructData("Spawn Intervals", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Spawn Interval", typeof(float))
                    }, customCount: true)),

                    new MhwMultiStructData.Entry("Coordinates", typeof(void), subStruct: new MhwMultiStructData.StructData("Coordinates", unkCbArr, customCount: true))
                }, 6)
            });

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({paramIndex += 8})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 28}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Savage Axe Duration (Elemental Phial)", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Savage Axe Duration (Impact Phial) (Inverse Multiplier of Elemental Phial Duration)", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Savage Axe Tick Sharpness Use on N Hit", typeof(uint))
                }, 1, showVertically: true)
            });

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}