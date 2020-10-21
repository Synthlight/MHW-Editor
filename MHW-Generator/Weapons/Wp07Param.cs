using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

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
                    new MhwMultiStructData.Entry("Normal Shell", typeof(uint)),
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
                    new MhwMultiStructData.Entry("Fullburst Rounds per Second (0.05 = 1200RPM)", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
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
                    new MhwMultiStructData.Entry("Wyrmstake Tick Raw Damage".Out(out var wyrmstakeDamage), typeof(void), subStruct: CreateShellInnerStruct(wyrmstakeDamage)),
                    new MhwMultiStructData.Entry("Wyrmstake Fixed Blast Damage".Out(out var wyrmstakeBlastDamage), typeof(void), subStruct: CreateShellInnerStruct(wyrmstakeBlastDamage)),
                    new MhwMultiStructData.Entry("Wyrmstake Fire Damage".Out(out var wyrmstakeBlastFireDamage), typeof(void), subStruct: CreateShellInnerStruct(wyrmstakeBlastFireDamage)),
                    new MhwMultiStructData.Entry("Wyrmstake Add Damage".Out(out var wyrmstakeAddDamage), typeof(void), subStruct: CreateShellInnerStruct(wyrmstakeAddDamage))
                }, 3),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex}) - Shelling Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Yellow Gauge Debuff", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Shelling Sharpness Usage", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Shell", typeof(uint)),
                    new MhwMultiStructData.Entry("Charged Shell", typeof(uint)),
                    new MhwMultiStructData.Entry("Full Burst (Per Shell)", typeof(uint)),
                    new MhwMultiStructData.Entry("Wyvernfire", typeof(uint)),
                    new MhwMultiStructData.Entry("Wyrmstake", typeof(uint)),
                    new MhwMultiStructData.Entry("Slinger Wyrmstake", typeof(uint))
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
                    new MhwMultiStructData.Entry("Uncharged Shelling Shots Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Full-burst Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Charge Shell Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Wyvernfire Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Wyrmstake Explosion Damage Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Ally Attack Trigger Explosion", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex}) - Wyrmstake Blast Duration per Pod", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Base", typeof(float)),
                    new MhwMultiStructData.Entry("Extra", typeof(float))
                }, 7),

                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex}) - Wyrmstake Blast Params", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {unkIndex += 21}", typeof(float)),
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

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
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