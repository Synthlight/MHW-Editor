using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Wp11Param : WpParamBase, IMultiStruct {
        private const string N = "11";

        public MultiStruct Generate() { // .w11p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(CreateBase(N));

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Bow Charge", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level 1", typeof(float)),
                    new MhwMultiStructData.Entry("Level 2", typeof(float)),
                    new MhwMultiStructData.Entry("Level 3", typeof(float)),
                    new MhwMultiStructData.Entry("Level 4", typeof(float))
                }, 2),

                new MhwMultiStructData.StructData("Event Pad Vib", eventPadVib, 4),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
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
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Dragonpiercer X1", typeof(float)),
                    new MhwMultiStructData.Entry("Dragonpiercer Y1", typeof(float)),
                    new MhwMultiStructData.Entry("Dragonpiercer X2", typeof(float)),
                    new MhwMultiStructData.Entry("Dragonpiercer Y2", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Arrows Shot", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Level 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Level 3", typeof(uint)),
                    new MhwMultiStructData.Entry("Level 4", typeof(uint))
                }, 3),

                new MhwMultiStructData.StructData($"Unk Arr {arrayIndex += 3}", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 8", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 9", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 10", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 11", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 12", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 13", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 14", typeof(float))
                }, 12),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 2),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex}) - Bow Coating Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level Charge per Shot/Dash: Normal Shot", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Level Charge per Shot/Dash: Quick Shot", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Level Charge per Shot/Dash: Power Shot", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Level Charge per Shot/Dash: Arc Shot", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Level Charge per Shot/Dash: Unk 1", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Level Charge per Shot/Dash: Side Step", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Level Charge per Shot/Dash: Unk 2", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Close Range Coating Critical End Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Close Range Coating Critical Start Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 10}", typeof(float)),
                    new MhwMultiStructData.Entry("Close Range Coating Damage", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Power Coating Damage", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Paralysis Coating Damage", typeof(short)),
                    new MhwMultiStructData.Entry("Paralysis Coating+ Damage", typeof(short)),
                    new MhwMultiStructData.Entry("Poison Coating Damage", typeof(short)),
                    new MhwMultiStructData.Entry("Poison Coating+ Damage", typeof(short)),
                    new MhwMultiStructData.Entry("Sleep Coating Damage", typeof(short)),
                    new MhwMultiStructData.Entry("Sleep Coating+ Damage", typeof(short)),
                    new MhwMultiStructData.Entry("Blast Coating Damage", typeof(short)),
                    new MhwMultiStructData.Entry("Blast Coating+ Damage", typeof(short)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 9}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
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

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex}) - Thousand Dragons", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Critical Range End Multiplier?", typeof(float)),
                    new MhwMultiStructData.Entry("Critical Range Start Multiplier?", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 3}", typeof(byte)),
                    new MhwMultiStructData.Entry("Main Arrow Spread Angle?", typeof(float)),
                    new MhwMultiStructData.Entry("Number of Arrows Shot", typeof(uint))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex}", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(float))
                }, 7),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Thousand Dragons X1", typeof(float)),
                    new MhwMultiStructData.Entry("Thousand Dragons Y1", typeof(float)),
                    new MhwMultiStructData.Entry("Thousand Dragons X2", typeof(float)),
                    new MhwMultiStructData.Entry("Thousand Dragons Y2", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Stone Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Stone Exhaust", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Stone Stun", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Stone Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Redpit Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Redpit Exhaust", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Redpit Stun", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Redpit Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Brightmoss Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Brightmoss Element", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Brightmoss Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Scatternut/Crystalburst Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Scatternut/Crystalburst?", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Scatternut/Crystalburst Exhaust", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Scatternut/Crystalburst Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Torch Pod Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Torch Pod Element", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Torch Pod Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Bomb Pod Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Bomb Pod Element", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Bomb Pod 1?", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Bomb Pod 2?", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Bomb Pod Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Piercing Pod Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Piercing Pod Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Thorn Pod Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Thorn Pod Exhaust", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Thorn Pod Stun", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Thorn Pod Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Dragon Pod Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Dragon Pod Element", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Dragon Pod Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry("For Every Puddle Pod Attack", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Puddle Pod Element", typeof(float)),
                    new MhwMultiStructData.Entry("For Every Puddle Pod Attack Type", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 38}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true)
            });

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}