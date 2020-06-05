using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Weapons {
    public class Wp07Param : WpParamBase, IMultiStruct {
        private const string N = "07";

        public MultiStruct Generate() { // .w07p
            var shellParams = new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("1", typeof(float)),
                new MhwMultiStructData.Entry("2", typeof(float)),
                new MhwMultiStructData.Entry("3", typeof(float)),
                new MhwMultiStructData.Entry("4", typeof(float)),
                new MhwMultiStructData.Entry("5", typeof(float)),
                new MhwMultiStructData.Entry("6", typeof(float)),
                new MhwMultiStructData.Entry("7", typeof(float))
            };

            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(CreateBase(N));

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex}) - Shelling Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Normal Ammo", typeof(uint)),
                    new MhwMultiStructData.Entry("Wide Shell", typeof(uint)),
                    new MhwMultiStructData.Entry("Long Shell", typeof(uint)),
                    new MhwMultiStructData.Entry("Shelling Charge Delay (Seconds)", typeof(float)),
                    new MhwMultiStructData.Entry("Shelling Charge Recoil Distance Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Wyvernfire Charging Time (Seconds)", typeof(float)),
                    new MhwMultiStructData.Entry("Wyvernfire Cooldown Time (Seconds)", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 8}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Shelling Count for [Shelling (N Times) -> Wyrmstake] (e.g. 2: Shelling (Twice), Then Wyrmstake)", typeof(uint)),
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
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Shell/Ammo Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Shell Damage".Out(out var shellDamage), typeof(void), subStruct: CreateShellInnerStruct(shellDamage)),
                    new MhwMultiStructData.Entry("Shell Fire Damage".Out(out var shellFireDamage), typeof(void), subStruct: CreateShellInnerStruct(shellFireDamage)),
                    new MhwMultiStructData.Entry("Shell Charged Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Full-burst Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Shell Unk 1", typeof(float)),
                    new MhwMultiStructData.Entry("Wyvernfire Damage".Out(out var wyvernfireDamage), typeof(void), subStruct: CreateShellInnerStruct(wyvernfireDamage)),
                    new MhwMultiStructData.Entry("Wyvernfire Fire Damage".Out(out var wyvernfireFireDamage), typeof(void), subStruct: CreateShellInnerStruct(wyvernfireFireDamage)),
                    new MhwMultiStructData.Entry("Wyrmstake Damage".Out(out var wyrmstakeDamage), typeof(void), subStruct: CreateShellInnerStruct(wyrmstakeDamage)),
                    new MhwMultiStructData.Entry("Wyrmstake Blast Damage".Out(out var wyrmstakeBlastDamage), typeof(void), subStruct: CreateShellInnerStruct(wyrmstakeBlastDamage)),
                    new MhwMultiStructData.Entry("Wyrmstake Blast Fire Damage".Out(out var wyrmstakeBlastFireDamage), typeof(void), subStruct: CreateShellInnerStruct(wyrmstakeBlastFireDamage)),
                    new MhwMultiStructData.Entry("Wyrmstake Add Damage".Out(out var wyrmstakeAddDamage), typeof(void), subStruct: CreateShellInnerStruct(wyrmstakeAddDamage))
                }, 3),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex}) - Shelling Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Yellow Gauge Debuff", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex}", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(uint))
                }, 3),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 179}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 10),

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
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex}) - Wyrmstake Blast Params", new List<MhwMultiStructData.Entry> {
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
                    new MhwMultiStructData.Entry("Full-burst Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Charge Shell Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Wyvernfire Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Wyrmstake Explosion Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Ally Attack Trigger Explosion", typeof(float)),
                    new MhwMultiStructData.Entry("Thorn Pod Base Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Thorn Pod Extra Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Bomb/Pierce Pod Base Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Bomb/Pierce Pod Extra Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Scatternut/Crystalburst/Torch Pod/Brightmoss Base Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Scatternut/Crystalburst/Torch Pod/Brightmoss Extra Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Puddle/Dragon Base Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Puddle/Dragon Pod Extra Duration", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 14}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Redpit Base Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Redpit Extra Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Stone Base Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Stone Extra Duration", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 5}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Action Param {++actionParamIndex}", actionParam, 1),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Shelling Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true)
            });

            return new MultiStruct("MHW_Editor.Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }

        private static MhwMultiStructData.StructData CreateShellInnerStruct(string name) {
            return new MhwMultiStructData.StructData(name, new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry($"{name} 1", typeof(float)),
                new MhwMultiStructData.Entry($"{name} 2", typeof(float)),
                new MhwMultiStructData.Entry($"{name} 3", typeof(float)),
                new MhwMultiStructData.Entry($"{name} 4", typeof(float)),
                new MhwMultiStructData.Entry($"{name} 5", typeof(float)),
                new MhwMultiStructData.Entry($"{name} 6", typeof(float)),
                new MhwMultiStructData.Entry($"{name} 7", typeof(float))
            }, 1, showVertically: true);
        }
    }
}