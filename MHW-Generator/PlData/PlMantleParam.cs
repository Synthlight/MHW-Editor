using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.PlData {
    public class PlMantleParam : IMultiStruct {
        public MultiStruct Generate() { // .asp
            // 'Unk' counters.
            ushort i = 1;
            ushort k = 1;
            ushort m = 1;
            ushort n = 1;

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("ASP", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true)
                }, 1),

                new MhwMultiStructData.StructData("Mantle Params (1)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {i++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {i++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {i++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {i++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {i++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {i++}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {i++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {i++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {i}", typeof(float)),

                    new MhwMultiStructData.Entry("Ghillie Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Ghillie Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Ghillie Mantle: Unk1", typeof(float)),
                    new MhwMultiStructData.Entry("Ghillie Mantle: Unk2", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk1", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk2", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk3", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk4", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk5", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk6", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk7", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk8", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk9", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk10", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk11", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Unk12", typeof(float)),
                    new MhwMultiStructData.Entry("Temporal Mantle: Duration Decrease Per Hit", typeof(float)),

                    new MhwMultiStructData.Entry("Health Booster: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Health Booster: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Health Booster: Upgraded Duration", typeof(float)),

                    new MhwMultiStructData.Entry("Rocksteady Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Rocksteady Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Rocksteady Mantle: Unk1", typeof(float)),
                    new MhwMultiStructData.Entry("Rocksteady Mantle: Damage Resist", typeof(float)),
                    new MhwMultiStructData.Entry("Rocksteady Mantle: Unk2", typeof(float)),

                    new MhwMultiStructData.Entry("Challenger Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Challenger Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Challenger Mantle: Unk1", typeof(float)),
                    new MhwMultiStructData.Entry("Challenger Mantle: Unk2", typeof(float)),

                    new MhwMultiStructData.Entry("Vitality Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Vitality Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Vitality Mantle: Mantle Health", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Mantle Params (2)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Damage Reduction %", typeof(float))
                }, 5),

                new MhwMultiStructData.StructData("Mantle Params (3)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Dragonproof Mantle: Dragon Damage Multiplier", typeof(float)),

                    new MhwMultiStructData.Entry("Cleanser Booster: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Cleanser Booster: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Cleanser Booster: Upgraded Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Cleanser Booster: Unk1", typeof(float)),
                    new MhwMultiStructData.Entry("Cleanser Booster: Unk2", typeof(float)),
                    new MhwMultiStructData.Entry("Cleanser Booster: Unk3", typeof(float)),
                    new MhwMultiStructData.Entry("Cleanser Booster: Unk4", typeof(float)),

                    new MhwMultiStructData.Entry("Glider Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Glider Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Glider Mantle: Mount Multiplier", typeof(float)),

                    new MhwMultiStructData.Entry("Evasion Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion Mantle: Attack Boost Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion Mantle: Evasion Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry($"Evasion Mantle: Unk{k++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Evasion Mantle: Unk{k++}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Evasion Mantle: Unk{k++}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Evasion Mantle: Unk{k++}", typeof(ushort)),
                    new MhwMultiStructData.Entry($"Evasion Mantle: Unk{k++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Evasion Mantle: Unk{k}", typeof(ushort)),

                    new MhwMultiStructData.Entry("Impact Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Motion Value Needed for Light Attack Stun Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Motion Value Needed for Heavy Attack Stun Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Motion Value Needed for Extreme Attack Stun Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Weak Attack Stun Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Light Attack Stun Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Heavy Attack Stun Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Extreme Attack Stun Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Existing Stun Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Motion Value Needed for Light Attack Exhaust Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Motion Value Needed for Heavy Attack Exhaust Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Motion Value Needed for Extreme Attack Exhaust Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Weak Attack Exhaust Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Light Attack Exhaust Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Heavy Attack Exhaust Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Extreme Attack Exhaust Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Impact Mantle: Existing Exhaust Multiplier", typeof(float)),

                    new MhwMultiStructData.Entry("Apothecary Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Apothecary Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Apothecary Mantle: Status Multiplier: Poison", typeof(float)),
                    new MhwMultiStructData.Entry("Apothecary Mantle: Status Multiplier: Para", typeof(float)),
                    new MhwMultiStructData.Entry("Apothecary Mantle: Status Multiplier: Sleep", typeof(float)),
                    new MhwMultiStructData.Entry("Apothecary Mantle: Status Multiplier: Blast", typeof(float)),

                    new MhwMultiStructData.Entry("Immunity Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Immunity Mantle: Duration", typeof(float)),

                    new MhwMultiStructData.Entry("Affinity Booster: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Affinity Booster: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Affinity Booster: Buff Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Affinity Booster: Buff Affinity", typeof(int)),

                    new MhwMultiStructData.Entry("Bandit Mantle: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Bandit Mantle: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Bandit Mantle: Hits to Drop Shiny", typeof(float)),
                    new MhwMultiStructData.Entry($"Bandit Mantle: Unk{m++}", typeof(sbyte)),
                    new MhwMultiStructData.Entry($"Bandit Mantle: Unk{m++}", typeof(sbyte)),
                    new MhwMultiStructData.Entry($"Bandit Mantle: Unk{m++}", typeof(sbyte)),
                    new MhwMultiStructData.Entry($"Bandit Mantle: Unk{m++}", typeof(sbyte)),
                    new MhwMultiStructData.Entry($"Bandit Mantle: Unk{m++}", typeof(sbyte)),
                    new MhwMultiStructData.Entry($"Bandit Mantle: Unk{m++}", typeof(sbyte)),
                    new MhwMultiStructData.Entry($"Bandit Mantle: Unk{m++}", typeof(sbyte)),
                    new MhwMultiStructData.Entry($"Bandit Mantle: Unk{m}", typeof(sbyte)),

                    new MhwMultiStructData.Entry("Assassin's Hood: Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Assassin's Hood: Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Assassin's Hood: Sneak Attack Multiplier", typeof(float)),
                    new MhwMultiStructData.Entry("Assassin's Hood: Sneak Attack Multiplier (Sleeping)", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry("Assassin's Hood: Speed Multiplier 1", typeof(float)),
                    new MhwMultiStructData.Entry("Assassin's Hood: Speed Multiplier 2", typeof(float)),
                    new MhwMultiStructData.Entry("Assassin's Hood: Speed Multiplier 3", typeof(float)),
                    new MhwMultiStructData.Entry("Assassin's Hood: Speed Multiplier 4", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n++}", typeof(float)),
                    new MhwMultiStructData.Entry($"Assassin's Hood: Unk{n}", typeof(float))
                }, 1, showVertically: true)
            };

            return new MultiStruct("PlData", "PlMantleParam", new MhwMultiStructData(structs, "asp", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".asp"]));
        }
    }
}