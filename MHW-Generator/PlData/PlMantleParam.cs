using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.PlData {
    public class PlMantleParam : IVerticalStruct {
        public VerticalStruct Generate() { // .asp
            // 'Unk' counters.
            ushort i = 1;
            ushort k = 1;
            ushort m = 1;
            ushort n = 1;

            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry($"Unk: Unk{i++}", 8, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 12, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 16, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 20, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 24, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 28, typeof(uint)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 32, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i++}", 36, typeof(float)),
                new MhwStructData.Entry($"Unk: Unk{i}", 40, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Ghillie Mantle: Cooldown", 44, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Duration", 48, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Unk1", 52, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Unk2", 56, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Temporal Mantle: Cooldown", 60, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Duration", 64, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk1", 68, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk2", 72, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk3", 76, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk4", 80, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk5", 84, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk6", 88, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk7", 92, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk8", 96, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk9", 100, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk10", 104, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk11", 108, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Unk12", 112, typeof(float)),
                new MhwStructData.Entry("Temporal Mantle: Duration Decrease Per Hit", 116, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Health Booster: Cooldown", 120, typeof(float)),
                new MhwStructData.Entry("Health Booster: Duration", 124, typeof(float)),
                new MhwStructData.Entry("Health Booster: Upgraded Duration", 128, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Rocksteady Mantle: Cooldown", 132, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Duration", 136, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Unk1", 140, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Damage Resist", 144, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Unk2", 148, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Challenger Mantle: Cooldown", 152, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Duration", 156, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Unk1", 160, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Unk2", 164, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Vitality Mantle: Cooldown", 168, typeof(float)),
                new MhwStructData.Entry("Vitality Mantle: Duration", 172, typeof(float)),
                new MhwStructData.Entry("Vitality Mantle: Mantle Health", 176, typeof(float)),
                VerticalStruct.Spacer
            };

            const ulong elementalStartOffset = 180;

            var elementMantles = new List<string> {
                "Fireproof Mantle",
                "Waterproof Mantle",
                "Iceproof Mantle",
                "Thunderproof Mantle"
            };

            for (var s = 0; s < elementMantles.Count; s++) {
                entries.AddRange(new List<MhwStructData.Entry> {
                    new MhwStructData.Entry($"{elementMantles[s]}: Cooldown", elementalStartOffset + (ulong) s * 12, typeof(float)),
                    new MhwStructData.Entry($"{elementMantles[s]}: Duration", elementalStartOffset + 4 + (ulong) s * 12, typeof(float)),
                    new MhwStructData.Entry($"{elementMantles[s]}: Damage Reduction %", elementalStartOffset + 8 + (ulong) s * 12, typeof(float)),
                    VerticalStruct.Spacer
                });
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Dragonproof Mantle: Cooldown", 228, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Duration", 232, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Damage Reduction %", 236, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Dragon Damage Multiplier", 240, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Cleanser Booster: Cooldown", 244, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Duration", 248, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Upgraded Duration", 252, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk1", 256, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk2", 260, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk3", 264, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk4", 268, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Glider Mantle: Cooldown", 272, typeof(float)),
                new MhwStructData.Entry("Glider Mantle: Duration", 276, typeof(float)),
                new MhwStructData.Entry("Glider Mantle: Mount Multiplier", 280, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Evasion Mantle: Cooldown", 284, typeof(float)),
                new MhwStructData.Entry("Evasion Mantle: Duration", 288, typeof(float)),
                new MhwStructData.Entry("Evasion Mantle: Attack Boost Duration", 292, typeof(float)),
                new MhwStructData.Entry("Evasion Mantle: Evasion Multiplier", 296, typeof(float)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 300, typeof(float)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 304, typeof(byte)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 305, typeof(ushort)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 307, typeof(ushort)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k++}", 309, typeof(float)),
                new MhwStructData.Entry($"Evasion Mantle: Unk{k}", 313, typeof(ushort)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Impact Mantle: Cooldown", 315, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Duration", 319, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Motion Value Needed for Light Attack Stun Bonus", 323, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Motion Value Needed for Heavy Attack Stun Bonus", 327, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Motion Value Needed for Extreme Attack Stun Bonus", 331, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Weak Attack Stun Bonus", 335, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Light Attack Stun Bonus", 339, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Heavy Attack Stun Bonus", 343, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Extreme Attack Stun Bonus", 347, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Existing Stun Multiplier", 351, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Motion Value Needed for Light Attack Exhaust Bonus", 355, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Motion Value Needed for Heavy Attack Exhaust Bonus", 359, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Motion Value Needed for Extreme Attack Exhaust Bonus", 363, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Weak Attack Exhaust Bonus", 367, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Light Attack Exhaust Bonus", 371, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Heavy Attack Exhaust Bonus", 375, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Extreme Attack Exhaust Bonus", 379, typeof(float)),
                new MhwStructData.Entry("Impact Mantle: Existing Exhaust Multiplier", 383, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Apothecary Mantle: Cooldown", 387, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Duration", 391, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Poison", 395, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Para", 399, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Sleep", 403, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Blast", 407, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Immunity Mantle: Cooldown", 411, typeof(float)),
                new MhwStructData.Entry("Immunity Mantle: Duration", 415, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Affinity Booster: Cooldown", 419, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Duration", 423, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Buff Duration", 427, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Buff Affinity", 431, typeof(int)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Bandit Mantle: Cooldown", 435, typeof(float)),
                new MhwStructData.Entry("Bandit Mantle: Duration", 439, typeof(float)),
                new MhwStructData.Entry("Bandit Mantle: Hits to Drop Shiny", 443, typeof(float)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 447, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 448, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 449, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 450, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 451, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 452, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m++}", 453, typeof(sbyte)),
                new MhwStructData.Entry($"Bandit Mantle: Unk{m}", 454, typeof(sbyte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Assassin's Hood: Cooldown", 455, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Duration", 459, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Sneak Attack Multiplier", 463, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Sneak Attack Multiplier (Sleeping)", 467, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 471, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 1", 475, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 2", 479, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 3", 483, typeof(float)),
                new MhwStructData.Entry("Assassin's Hood: Speed Multiplier 4", 487, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 491, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 495, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 499, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 503, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 507, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 511, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 515, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 519, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 523, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 527, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 531, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 535, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 539, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n++}", 543, typeof(float)),
                new MhwStructData.Entry($"Assassin's Hood: Unk{n}", 547, typeof(float))
            });

            return new VerticalStruct("MHW_Editor.PlData", "PlMantleParam", new MhwStructData {
                size = 560,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".asp"],
                entries = entries
            });
        }
    }
}