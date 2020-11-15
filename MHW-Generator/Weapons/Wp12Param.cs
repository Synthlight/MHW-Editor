using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class Wp12Param : WpParamBase, IMultiStruct {
        private const string N = "12";

        protected override List<MhwMultiStructData.StructData> CreateBase(string wpNum) {
            var structs = base.CreateBase(wpNum);

            structs.Add(new MhwMultiStructData.StructData($"W{wpNum}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry("Delay Between Shots: Rapid Fire +1", typeof(float)),
                new MhwMultiStructData.Entry("Extra Bullets: Rapid Fire +1", typeof(uint)),
                new MhwMultiStructData.Entry("Delay Between Shots: Rapid Fire +2", typeof(float)),
                new MhwMultiStructData.Entry("Extra Bullets: Rapid Fire +2", typeof(uint)),
                new MhwMultiStructData.Entry("Delay Between Shots: Rapid Fire +3", typeof(float)),
                new MhwMultiStructData.Entry("Extra Bullets: Rapid Fire +3", typeof(uint)),
                new MhwMultiStructData.Entry("Delay Between Shots: Rapid Fire +4", typeof(float)),
                new MhwMultiStructData.Entry("Extra Bullets: Rapid Fire +4", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {unkIndex += 9}", typeof(float)),
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
                new MhwMultiStructData.Entry("Rapid Fire Extra Round Damage Multiplier", typeof(float)),
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
                new MhwMultiStructData.Entry("Wyvernheart Ammo Cap", typeof(float)),
                new MhwMultiStructData.Entry("Delay Between Shots", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {unkIndex += 3}", typeof(float)),
                new MhwMultiStructData.Entry("Wyvernheart Ammo Recharge", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                new MhwMultiStructData.Entry("Wyvernheart Hit Count for Damage Bonus", typeof(byte)),
                new MhwMultiStructData.Entry("Hit for 1st Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(1st) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("Hit for 2nd Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(2nd) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("Hit for 3rd Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(3rd) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("Hit for 4th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(4th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("Hit for 5th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(5th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry($"Unk {unkIndex += 12}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                new MhwMultiStructData.Entry("Wyvernheart Mod Hit Count for Damage Bonus", typeof(byte)),
                new MhwMultiStructData.Entry("(Mod) Hit for 1st Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 1st) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 2nd Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 2nd) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 3rd Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 3rd) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 4th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 4th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 5th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 5th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 6th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 6th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 7th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 7th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 8th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 8th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 9th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 9th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod) Hit for 10th Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry("(Mod, 10th) Damage Bonus", typeof(ushort)),
                new MhwMultiStructData.Entry($"Unk {unkIndex += 22}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(ushort)),
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
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                new MhwMultiStructData.Entry("Wyrmsnipe Cooldown", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(uint)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(short))
            }, 1, showVertically: true));

            structs.Add(new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex}", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                new MhwMultiStructData.Entry("Unk 4", typeof(float)),
                new MhwMultiStructData.Entry("Unk 5", typeof(float))
            }, 16));

            structs.Add(new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex}", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                new MhwMultiStructData.Entry("Unk 4", typeof(float)),
                new MhwMultiStructData.Entry("Unk 5", typeof(float)),
                new MhwMultiStructData.Entry("Unk 6", typeof(float))
            }, 4));

            structs.Add(new MhwMultiStructData.StructData($"W{wpNum}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
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
                new MhwMultiStructData.Entry("Close range Up active range 1", typeof(float)),
                new MhwMultiStructData.Entry("Close range Up active range 2", typeof(float)),
                new MhwMultiStructData.Entry("Close range Up active range 3", typeof(float)),
                new MhwMultiStructData.Entry("Close range Up active range 4", typeof(float)),
                new MhwMultiStructData.Entry("Close range Up Modifier 1", typeof(float)),
                new MhwMultiStructData.Entry("Close range Up Modifier 2", typeof(float)),
                new MhwMultiStructData.Entry("Close range Up Modifier 3", typeof(float)),
                new MhwMultiStructData.Entry("Close range Up Modifier 4", typeof(float)),
                new MhwMultiStructData.Entry("Ranged Attack Up active distance 1", typeof(float)),
                new MhwMultiStructData.Entry("Ranged Attack Up active distance 2", typeof(float)),
                new MhwMultiStructData.Entry("Ranged Attack Up active distance 3", typeof(float)),
                new MhwMultiStructData.Entry("Ranged Attack Up active distance 4", typeof(float)),
                new MhwMultiStructData.Entry("Ranged Attack Up Modifier 1", typeof(float)),
                new MhwMultiStructData.Entry("Ranged Attack Up Modifier 2", typeof(float)),
                new MhwMultiStructData.Entry("Ranged Attack Up Modifier 3", typeof(float)),
                new MhwMultiStructData.Entry("Ranged Attack Up Modifier 4", typeof(float)),
                new MhwMultiStructData.Entry("Guard Angle (Both Sides)", typeof(float))
            }, 1, showVertically: true));

            structs.Add(new MhwMultiStructData.StructData("Number of Shield Mods Struct", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Number of Shield Mods", typeof(uint)).Out(out var count)
            }, 1, true).Out(out var countHolder));

            structs.Add(new MhwMultiStructData.StructData("Shield Mods", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Small", typeof(byte)),
                new MhwMultiStructData.Entry("Medium", typeof(byte)),
                new MhwMultiStructData.Entry("Large", typeof(byte))
            }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(countHolder, count)));

            structs.Add(new MhwMultiStructData.StructData($"W{wpNum}p Params (Special Scope Params)", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Special Scope: FoV Multiplier (From Base 3rd Person FoV)", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {unkIndex += 2}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                new MhwMultiStructData.Entry("Special Scope: Zoom Ratio When Focusing 1", typeof(float)),
                new MhwMultiStructData.Entry("Special Scope: Zoom Ratio When Focusing 2", typeof(float))
            }, 1, showVertically: true));

            unkIndex += 2;

            structs.Add(new MhwMultiStructData.StructData($"Unk Arr {++arrayIndex}", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Unk 1", typeof(float)),
                new MhwMultiStructData.Entry("Unk 2", typeof(float)),
                new MhwMultiStructData.Entry("Unk 3", typeof(float)),
                new MhwMultiStructData.Entry("Unk 4", typeof(float))
            }, 50));

            return structs;
        }

        public virtual MultiStruct Generate() { // .w12p
            var structs = CreateBase(N);

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"W{N}p Params ({++paramIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unkIndex}", typeof(float))
                }, 1, showVertically: true)
            });

            return new MultiStruct("Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}