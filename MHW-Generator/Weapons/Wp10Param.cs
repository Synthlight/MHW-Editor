using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Wp10Param : WpParamBase, IMultiStruct {
        private const string N = "10";

        public MultiStruct Generate() { // .w10p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(CreateBase(N));

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Red Extract Duration", typeof(float)),
                    new MhwMultiStructData.Entry("White Extract Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Orange Extract Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Triple Extract Duration", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Damage Buff: Red + White", typeof(float)),
                    new MhwMultiStructData.Entry("Damage Buff: All Three Extracts", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Buff: White", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 4}", typeof(float)),
                    new MhwMultiStructData.Entry("Defense Buff: Orange", typeof(float)),
                    new MhwMultiStructData.Entry("Defense Buff: Orange + White", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Action Param (Relate Vault)", actionParam, 16),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 3}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Action Param (Relate Vault Dance)", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Jumping Advancing Slashes Repeat Limit Count (Can vault dance N times per jump.)", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Action Param (Relate Mid-air Evade)", actionParam, 9),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Action Param (Relate Jumping Attacks)", actionParam, 22),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Action Param (Relate Wall Vault, Wall Opposite Vault, White Extract or Not)", actionParam, 4),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Sever Boost", typeof(float)),
                    new MhwMultiStructData.Entry("Blunt Boost", typeof(float)),
                    new MhwMultiStructData.Entry("Elemental Boost", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Boost", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Stamina Extract Boost", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Stamina On Recall Boost", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Stamina Drain Boost", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Healing Extract Boost", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 9}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Max Flight Range", typeof(float)),
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
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Stamina Drain per Second", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Max Stamina", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 3}", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Stamina on Recall", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Dust Interval: Blast", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Dust Interval: Heal", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Dust Interval: Paralysis", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Dust Interval: Poison", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 5}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Kinsect Stats", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level 1", typeof(float)),
                    new MhwMultiStructData.Entry("Level 2", typeof(float)),
                    new MhwMultiStructData.Entry("Level 3", typeof(float)),
                    new MhwMultiStructData.Entry("Level 4", typeof(float)),
                    new MhwMultiStructData.Entry("Level 5", typeof(float)),
                    new MhwMultiStructData.Entry("Level 6", typeof(float)),
                    new MhwMultiStructData.Entry("Level 7", typeof(float)),
                    new MhwMultiStructData.Entry("Level 8", typeof(float)),
                    new MhwMultiStructData.Entry("Level 9", typeof(float)),
                    new MhwMultiStructData.Entry("Level 10", typeof(float)),
                    new MhwMultiStructData.Entry("Level 11", typeof(float)),
                    new MhwMultiStructData.Entry("Level 12", typeof(float)),
                    new MhwMultiStructData.Entry("Level 13", typeof(float)),
                    new MhwMultiStructData.Entry("Level 14", typeof(float)),
                    new MhwMultiStructData.Entry("Level 15", typeof(float)),
                    new MhwMultiStructData.Entry("Level 16", typeof(float)),
                    new MhwMultiStructData.Entry("Level 17", typeof(float)),
                    new MhwMultiStructData.Entry("Level 18", typeof(float)),
                    new MhwMultiStructData.Entry("Level 19", typeof(float)),
                    new MhwMultiStructData.Entry("Level 20", typeof(float))
                }, 9),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Buff: Red", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Buff: White", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Buff: Orange", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Buff: All Three Extracts", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge(Power) Attack Power", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge(Power) Elemental Attack Power", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge(Power) Dust Effect Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge(Spirit) Max + Regen Stamina", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge(Power) Dust Interval", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Piercing Pod", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Stone", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Redpit", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Scatternut", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Crystalburst", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Thorn Pod", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Torch Pod", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Puddle Pod", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Dragon Pod", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Bomb Pod", typeof(float)),
                    new MhwMultiStructData.Entry("Kinsect Charge: Brightmoss", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Unk Arr {arrayIndex += 2} (All sint8)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(sbyte))
                }, 14),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 21}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex} (All sint8)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 8", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 9", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 10", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 11", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk 12", typeof(sbyte))
                }, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Descending Thrust Kinsect Following Speed Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry("Descending Thrust Kinsect Following Coordinate Y Offset", typeof(float)),
                    new MhwMultiStructData.Entry("Descending Thrust Kinsect Following Coordinate Z Offset", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Action Param (Relate Clutch Attack Finish)", actionParam, 1)
            });

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}