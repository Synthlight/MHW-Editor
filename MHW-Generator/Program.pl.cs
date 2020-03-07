using System.Collections.Generic;
using System.Linq;
using MHW_Template;

namespace MHW_Generator {
    public static partial class Program {
        private const string SPACER_TEXT = "-------------------------------------------------------------------------------------------";
        private static MhwStructData.Entry Spacer => new MhwStructData.Entry(SPACER_TEXT, 3, typeof(byte), true, forceUnique: true);

        private static void GenCommonPl() {
            GenPlItemParam();
            GenPlPlayerParam();
            GenPlMantleParam();
            GenPlSkillParam();
            GenPlMusicSkillParam();
            GenWp10Param();
            GenWp11Param();
            GenWp13Param();
        }

        private static void GenWp10Param() {
            GeneratePlDataProps("MHW_Editor.Weapons", "Wp10Param", new MhwStructData { // .w10p
                size = 3408,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w10p"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Air-Time 1", 1153, typeof(float)),
                    new MhwStructData.Entry("Air-Time 2", 1157, typeof(float)),
                    new MhwStructData.Entry("Air-Time 3", 1161, typeof(float)),
                    new MhwStructData.Entry("Air-Time 4", 1165, typeof(float))
                }
            });
        }

        private static void GenWp11Param() {
            GeneratePlDataProps("MHW_Editor.Weapons", "Wp11Param", new MhwStructData { // .w11p
                size = 2736,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w11p"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Dragonpiercer X1", 1313, typeof(float)),
                    new MhwStructData.Entry("Dragonpiercer Y1", 1317, typeof(float)),
                    new MhwStructData.Entry("Dragonpiercer X2", 1321, typeof(float)),
                    new MhwStructData.Entry("Dragonpiercer Y2", 1325, typeof(float)),
                    Spacer,
                    new MhwStructData.Entry("Thousand Dragons X1", 2569, typeof(float)),
                    new MhwStructData.Entry("Thousand Dragons Y1", 2573, typeof(float)),
                    new MhwStructData.Entry("Thousand Dragons X2", 2577, typeof(float)),
                    new MhwStructData.Entry("Thousand Dragons Y2", 2581, typeof(float))
                }
            });
        }

        private static void GenWp13Param() {
            GeneratePlDataProps("MHW_Editor.Weapons", "Wp13Param", new MhwStructData { // .w13p
                size = 3200,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".w13p"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Shield 1 Small", 2238, typeof(byte)),
                    new MhwStructData.Entry("Shield 1 Medium", 2239, typeof(byte)),
                    new MhwStructData.Entry("Shield 1 Large", 2240, typeof(byte)),
                    Spacer,
                    new MhwStructData.Entry("Shield 2 Small", 2241, typeof(byte)),
                    new MhwStructData.Entry("Shield 2 Medium", 2242, typeof(byte)),
                    new MhwStructData.Entry("Shield 2 Large", 2243, typeof(byte)),
                    Spacer,
                    new MhwStructData.Entry("Shield 3 Small", 2244, typeof(byte)),
                    new MhwStructData.Entry("Shield 3 Medium", 2245, typeof(byte)),
                    new MhwStructData.Entry("Shield 3 Large", 2246, typeof(byte)),
                    Spacer,
                    new MhwStructData.Entry("Shield 4 Small", 2247, typeof(byte)),
                    new MhwStructData.Entry("Shield 4 Medium", 2248, typeof(byte)),
                    new MhwStructData.Entry("Shield 4 Large", 2249, typeof(byte))
                }
            });
        }

        private static void GenPlMusicSkillParam() {
            GenerateItemProps("MHW_Editor.PlData", "PlMusicSkillParam", new MhwStructData { // .mske
                size = 56,
                offsetInitial = 14,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".mske"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Duration", 0, typeof(float)),
                    new MhwStructData.Entry("Extension", 12, typeof(float)),
                    new MhwStructData.Entry("M1 Duration", 4, typeof(float)),
                    new MhwStructData.Entry("M1 Extension", 16, typeof(float)),
                    new MhwStructData.Entry("M2 Duration", 8, typeof(float)),
                    new MhwStructData.Entry("M2 Extension", 20, typeof(float)),
                    new MhwStructData.Entry("Effect", 24, typeof(float)),
                    new MhwStructData.Entry("Recast Effect", 28, typeof(float)),
                    new MhwStructData.Entry("Unk 1", 32, typeof(uint)),
                    new MhwStructData.Entry("Unk 2", 36, typeof(uint)),
                    new MhwStructData.Entry("Unk 3", 40, typeof(uint)),
                    new MhwStructData.Entry("Unk 4", 44, typeof(uint)),
                    new MhwStructData.Entry("Unk 5", 48, typeof(uint)),
                    new MhwStructData.Entry("Unk 6", 52, typeof(uint))
                }
            });
        }

        private static void GenPlSkillParam() {
            // 'Unk' counters.
            ushort i = 1;

            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Speed Eating 1 Drink Motion Speed", 8, typeof(float)),
                new MhwStructData.Entry("Speed Eating 2 Drink Motion Speed", 12, typeof(float)),
                new MhwStructData.Entry("Speed Eating 3 Drink Motion Speed", 16, typeof(float)),
                new MhwStructData.Entry("Speed Eating 1 Drink End Frame", 20, typeof(float)),
                new MhwStructData.Entry("Speed Eating 2 Drink End Frame", 24, typeof(float)),
                new MhwStructData.Entry("Speed Eating 3 Drink End Frame", 28, typeof(float)),
                new MhwStructData.Entry("Speed Eating 1 Heal Speed Rate", 32, typeof(float)),
                new MhwStructData.Entry("Speed Eating 2 Heal Speed Rate", 36, typeof(float)),
                new MhwStructData.Entry("Speed Eating 3 Heal Speed Rate", 40, typeof(float)),
                new MhwStructData.Entry("Speed Eating 1 Meat Motion Speed", 44, typeof(float)),
                new MhwStructData.Entry("Speed Eating 2 Meat Motion Speed", 48, typeof(float)),
                new MhwStructData.Entry("Speed Eating 3 Meat Motion Speed", 52, typeof(float)),
                new MhwStructData.Entry("Speed Eating 1 Meat Loop Count", 56, typeof(byte)),
                new MhwStructData.Entry("Speed Eating 2 Meat Loop Count", 57, typeof(byte)),
                new MhwStructData.Entry("Speed Eating 3 Meat Loop Count", 58, typeof(byte)),
                new MhwStructData.Entry("Speed Eating 1/2/3 Meat End Frame", 59, typeof(float)),
                new MhwStructData.Entry("Speed Eating 1 Tablet Motion Speed", 63, typeof(float)),
                new MhwStructData.Entry("Speed Eating 2 Tablet Motion Speed", 67, typeof(float)),
                new MhwStructData.Entry("Speed Eating 3 Tablet Motion Speed", 71, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Mud Motion Speed", 75, typeof(float)),
                new MhwStructData.Entry("Mud Trans Rate", 79, typeof(float)),
                new MhwStructData.Entry("Elemental Damage Defense %", 83, typeof(byte)),
                new MhwStructData.Entry("Elemental Damage Resist %", 84, typeof(byte)),
                new MhwStructData.Entry("Elemental Damage Resist", 85, typeof(byte)),
                new MhwStructData.Entry("Weakness Exploit Hit-Zone Threshold", 86, typeof(byte)),
                new MhwStructData.Entry("Latent Power Activation Time", 87, typeof(ushort)),
                new MhwStructData.Entry("Latent Power Total Damage to Trigger", 89, typeof(ushort)),
                new MhwStructData.Entry("Latent Power Secret Total Damage to Trigger", 91, typeof(ushort)),
                new MhwStructData.Entry("Heroics Activation Health %", 93, typeof(float)),
                new MhwStructData.Entry("Guts Health Threshold", 97, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Wide Range 1 Efficiency", 98, typeof(float)),
                new MhwStructData.Entry("Wide Range 2 Efficiency", 102, typeof(float)),
                new MhwStructData.Entry("Wide Range 3 Efficiency", 106, typeof(float)),
                new MhwStructData.Entry("Wide Range 4 Efficiency", 110, typeof(float)),
                new MhwStructData.Entry("Wide Range 5 Efficiency", 114, typeof(float)),
                new MhwStructData.Entry("Wide Range 1 Range", 118, typeof(float)),
                new MhwStructData.Entry("Wide Range 2 Range", 122, typeof(float)),
                new MhwStructData.Entry("Wide Range 3 Range", 126, typeof(float)),
                new MhwStructData.Entry("Wide Range 4 Range", 130, typeof(float)),
                new MhwStructData.Entry("Wide Range 5 Range", 134, typeof(float)),

                Spacer,

                new MhwStructData.Entry($"Unk{i++}", 138, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 142, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 146, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 150, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 154, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 158, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 162, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 166, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 170, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 174, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 178, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 182, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 186, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 190, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 194, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 198, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 202, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 206, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Focus (Gunlance, Charge Shot) Time Rate 1", 210, typeof(float)),
                new MhwStructData.Entry("Focus (Gunlance, Charge Shot) Time Rate 2", 214, typeof(float)),
                new MhwStructData.Entry("Focus (Gunlance, Charge Shot) Time Rate 3", 218, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Slash 2) Time Rate 1", 222, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Slash 2) Time Rate 2", 226, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Slash 2) Time Rate 3", 230, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Phial Charge Slash) Time Rate 1", 234, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Phial Charge Slash) Time Rate 2", 238, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Phial Charge Slash) Time Rate 3", 242, typeof(float)),

                Spacer
            };

            var weapons = new List<string> {
                "Great Sword",
                "Sword & Shield",
                "Dual Blades",
                "Long Sword",
                "Hammer",
                "Hunting Horn",
                "Lance",
                "Gunlance",
                "Switch Axe",
                "Charge Blade",
                "Insect Glaive",
                "Bow",
                "HBG",
                "LBG"
            };

            var weaponDrawParams = new List<string> {
                "Attack Power",
                "Stun",
                "Exhaust",
                "Param 4",
                "Param 5",
                "Param 6"
            };

            for (var x = 0; x < weapons.Count; x++) {
                entries.AddRange(weaponDrawParams.Select((param, s) => new MhwStructData.Entry($"Punishing Draw ({weapons[x]}) {param}", 246 + (ulong) s * 2 + (ulong) x * 12, typeof(ushort))));

                entries.Add(Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Razor Sharp: Sharpness No Reduce %", 414, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Gunlance Shot Sub Value", 415, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Gunlance Shot No Reduce %", 416, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Gun Ammo No Reduce %", 417, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Bow Coating No Reduce %", 418, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: IB Unk", 419, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("True Razor Sharp: Sharpness No Reduce %", 420, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Gunlance Shot Sub Value", 421, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Gunlance Shot No Reduce %", 422, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Gun Ammo No Reduce %", 423, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Bow Coating No Reduce %", 424, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: IB Unk", 425, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Minds Eye / Ballistics: Gun Critical Begin Wide Rate", 426, typeof(float)),
                new MhwStructData.Entry("Minds Eye / Ballistics: Gun Critical End Wide Rate", 430, typeof(float)),
                new MhwStructData.Entry("Minds Eye / Ballistics: Bow Critical Begin Wide Rate", 434, typeof(float)),
                new MhwStructData.Entry("Minds Eye / Ballistics: Bow Critical End Wide Rate", 438, typeof(float)),

                Spacer
            });

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Critical Element: ({weapon}) Rate", 442 + (ulong) x * 4, typeof(float))));
            entries.Add(new MhwStructData.Entry("Critical Element: Dragon Seal Rate", 498, typeof(float)));

            entries.Add(Spacer);

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"True Critical Element: ({weapon}) Rate", 502 + (ulong) x * 4, typeof(float))));
            entries.Add(new MhwStructData.Entry("True Critical Element: Dragon Seal Rate", 558, typeof(float)));

            entries.Add(Spacer);

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Critical Condition: ({weapon}) Rate", 562 + (ulong) x * 4, typeof(float))));

            entries.Add(Spacer);

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"True Critical Condition: ({weapon}) Rate", 618 + (ulong) x * 4, typeof(float))));

            entries.AddRange(new List<MhwStructData.Entry> {
                Spacer,

                new MhwStructData.Entry("Bludgeoner: Red Sharpness Attack Bonus (& BG Melee)", 674, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Orange Sharpness Attack Bonus", 676, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Yellow Sharpness Attack Bonus", 678, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Green Sharpness Attack Bonus", 680, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Blue Sharpness Attack Bonus", 682, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: White Sharpness Attack Bonus", 684, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Purple Sharpness Attack Bonus", 686, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Bowgun Melee Attack Stun Bonus", 688, typeof(ushort)),

                Spacer,

                new MhwStructData.Entry("Non-Elemental Boost: Attack Multiplier", 690, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Affinity Slider: Attack Up Activate Time", 694, typeof(float)),
                new MhwStructData.Entry("Affinity Slider: Attack Up Duration", 698, typeof(float)),
                new MhwStructData.Entry("Affinity Slider: Attack Critical Bonus", 702, typeof(byte)),

                Spacer
            });

            var artilleryBonusParams = new List<string> {
                "Gunlance Shell Attack Rate",
                "Gunlance WyvernFire Attack Rate",
                "Gunlance Wyrmstake Cannon Attack Rate",
                "Gunlance WyvernFire Cooldown Time Rate",
                "Charge Blade Impact Phial Attack Rate",
                "Bowgun Sticky Ammo Attack Rate",
                "Bowgun Kakusan? Attack Rate (Appears Unused?)",
                "Bowgun Wyvern Ammo Attack Rate",
                "LBG Wyvernblast Attack Rate (Appears Unused?)"
            };

            for (var x = 0; x < artilleryBonusParams.Count; x++) {
                for (var s = 0; s < 5; s++) {
                    entries.Add(new MhwStructData.Entry($"Artillery: {artilleryBonusParams[x]} {s + 1}", 703 + (ulong) s * 4 + (ulong) x * 20, typeof(float)));
                }

                entries.Add(Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Heavy Artillery: Ballista Attack Rate 1", 883, typeof(float)),
                new MhwStructData.Entry("Heavy Artillery: Ballista Attack Rate 2", 887, typeof(float)),
                new MhwStructData.Entry("Heavy Artillery: Cannon Attack Rate 1", 891, typeof(float)),
                new MhwStructData.Entry("Heavy Artillery: Cannon Attack Rate 2", 895, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Bombardier: Attack Rate 1", 899, typeof(float)),
                new MhwStructData.Entry("Bombardier: Attack Rate 2", 903, typeof(float)),
                new MhwStructData.Entry("Bombardier: Attack Rate 3", 907, typeof(float)),
                new MhwStructData.Entry("Bombardier: Attack Rate 4", 911, typeof(float)),
                new MhwStructData.Entry("Bombardier: Attack Rate 5", 915, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Capacity Boost: Gunlance Normal Bonus", 919, typeof(byte)),
                new MhwStructData.Entry("Capacity Boost: Gunlance Radiation Bonus", 920, typeof(byte)),
                new MhwStructData.Entry("Capacity Boost: Gunlance Scatter Bonus", 921, typeof(byte)),
                new MhwStructData.Entry("Capacity Boost: Charge Blade Shield Duration Bonus", 922, typeof(byte)),

                Spacer
            });

            for (var x = 0; x < 3; x++) {
                for (var s = 0; s < 4; s++) {
                    entries.Add(new MhwStructData.Entry($"Ammo Up {x + 1}: Capacity {s + 1} Limit", 923 + (ulong) s * 2 + (ulong) x * 8, typeof(sbyte)));
                    entries.Add(new MhwStructData.Entry($"Ammo Up {x + 1}: Capacity {s + 1} Bonus", 924 + (ulong) s * 2 + (ulong) x * 8, typeof(byte)));
                }

                entries.Add(Spacer);
            }

            var powerProlongerWeapons = new List<string> {
                "Dual Blades",
                "Long Sword",
                "Switch Axe",
                "Charge Blade",
                "Insect Glaive"
            };

            for (var x = 0; x < powerProlongerWeapons.Count; x++) {
                for (var s = 0; s < 3; s++) {
                    entries.Add(new MhwStructData.Entry($"Power Prolonger: {powerProlongerWeapons[x]} {s + 1}", 947 + (ulong) s * 4 + (ulong) x * 12, typeof(float)));
                }

                entries.Add(Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Health Auto Recover Interval", 1007, typeof(float)),
                new MhwStructData.Entry("Health Auto Recover Value", 1011, typeof(byte)),

                Spacer
            });

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Hasten Recovery: ({weapon}) Recovery Health", 1012 + (ulong) x, typeof(byte))));

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Hasten Recovery: Success Combo #", 1026, typeof(byte)),
                new MhwStructData.Entry("Hasten Recovery: Combo Duration", 1027, typeof(float)),
                new MhwStructData.Entry("Hasten Recovery: Combo Ignore Time", 1031, typeof(float)),

                Spacer,

                new MhwStructData.Entry($"Unk{i++}", 1035, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1036, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1040, typeof(float)),

                Spacer
            });

            var slingerRocks = new List<string> {
                "Stone",
                "Redpit",
                "Brightmoss",
                "Scatternut",
                "Unk 1",
                "Unk 2",
                "Unk 3",
                "Unk 4",
                "Unk 5",
                "Torch Pod",
                "Unk 6",
                "Unk 7",
                "Unk 8",
                "Unk 9",
                "Bomb Pod",
                "Piercing Pod",
                "Slinger Thorn",
                "Dragon Pod",
                "Unk 10",
                "Unk 11",
                "Unk 12",
                "Unk 13",
                "Unk 14",
                "Unk 15",
                "Unk 16",
                "Unk 17",
                "Crystalburst",
                "Puddle Pod",
                "Unk 18",
                "Unk 19",
                "Unk 20"
            };

            for (var x = 0; x < slingerRocks.Count; x++) {
                for (var s = 0; s < 5; s++) {
                    entries.Add(new MhwStructData.Entry($"Slinger Up {s + 1}: {slingerRocks[x]}", 1044 + (ulong) s + (ulong) x * 5, typeof(byte)));
                }

                entries.Add(Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Master Fisher: Add Hook Time", 1199, typeof(float)),
                new MhwStructData.Entry("Master Fisher: Big Fish Catch Rate", 1203, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Adrenaline: Stamina Rate", 1207, typeof(float)),

                Spacer
            });

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Elemental Airborne: ({weapon}) Rate", 1211 + (ulong) x * 4, typeof(float))));

            entries.AddRange(new List<MhwStructData.Entry> {
                Spacer,

                new MhwStructData.Entry($"Unk{i++}", 1267, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1268, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1269, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1270, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1271, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1272, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1273, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1274, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1275, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1276, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1277, typeof(float)),

                Spacer
            });

            for (var s = 0; s < weapons.Count; s++) {
                entries.AddRange(new List<MhwStructData.Entry> {
                    new MhwStructData.Entry($"Frostcraft: ({weapons[s]}) Level Multiplier (0-15%)", 1281 + (ulong) s * 28, typeof(float)),
                    new MhwStructData.Entry($"Frostcraft: ({weapons[s]}) Level Multiplier (16-45%)", 1285 + (ulong) s * 28, typeof(float)),
                    new MhwStructData.Entry($"Frostcraft: ({weapons[s]}) Level Multiplier (46-80%)", 1289 + (ulong) s * 28, typeof(float)),
                    new MhwStructData.Entry($"Frostcraft: ({weapons[s]}) Level Multiplier (81-100%)", 1293 + (ulong) s * 28, typeof(float)),
                    new MhwStructData.Entry($"Frostcraft: ({weapons[s]}) Recovery Speed: Unsheathed", 1297 + (ulong) s * 28, typeof(float)),
                    new MhwStructData.Entry($"Frostcraft: ({weapons[s]}) Recovery Speed: Sheathed", 1301 + (ulong) s * 28, typeof(float)),
                    new MhwStructData.Entry($"Frostcraft: ({weapons[s]}) Consumption per Hit", 1305 + (ulong) s * 28, typeof(float)),
                });

                entries.Add(Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry($"Unk{i++}", 1673, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1674, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1675, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Frostcraft: Bow: (Rapid Shot & Clutch Claw Arrow) Consumption per Hit", 1676, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bow: (Power Shot) Consumption per Hit", 1677, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bow: (Arc Shot) Consumption per Hit", 1678, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bow: (Dragonpiercer) Consumption per Hit", 1679, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bow: (Thousand Dragons) Consumption per Hit", 1680, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Frostcraft: Bowgun: (Normal Ammo) Consumption per Hit", 1681, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Pierce Ammo) Consumption per Hit", 1682, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Spread Ammo) Consumption per Hit", 1683, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Sticky Ammo) Consumption per Hit", 1684, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Cluster Ammo) Consumption per Hit", 1685, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Elemental Ammo) Consumption per Hit", 1686, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Status Ammo) Consumption per Hit", 1687, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Wyvern Ammo) Consumption per Hit", 1688, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Slicing Ammo) Consumption per Hit", 1689, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Frostcraft: HBG: (Wyvernheart) Consumption per Hit", 1690, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Wyvernsnipe) Consumption per Hit", 1691, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Wyvernsnipe Type 2) Consumption per Hit", 1692, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Claw Wyvernheart Gatling) Consumption per Hit", 1694, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Claw Wyvernheart Finish) Consumption per Hit", 1695, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Wyvernsnipe Claw) Consumption per Hit", 1696, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Frostcraft: LBG: (Wyvernblast) Consumption per Hit", 1693, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: LBG: (Wyvernblast Claw) Consumption per Hit", 1697, typeof(byte)),

                Spacer,

                new MhwStructData.Entry($"Unk{i++}", 1698, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1702, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1706, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1710, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1714, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1718, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1722, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1726, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1730, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1734, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1738, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1742, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1746, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1750, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1754, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1758, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1762, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1766, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1770, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1774, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1778, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1782, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1786, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1790, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1794, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1798, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1802, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1806, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1810, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1814, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1818, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1822, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1826, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1830, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1834, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1838, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1842, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1846, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1850, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1854, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1858, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1862, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1866, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1870, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1874, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1878, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1882, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1886, typeof(float)),

                Spacer
            });

            for (var s = 0; s < 6; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: Life Up {s + 1}", 1890 + (ulong) s * 2, typeof(ushort)));
            }

            entries.Add(Spacer);

            for (var s = 0; s < 3; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: Stamina Up {s + 1}", 1902 + (ulong) s * 2, typeof(ushort)));
            }

            entries.Add(Spacer);

            for (var s = 0; s < 4; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: Attack Up {s + 1}", 1908 + (ulong) s * 2, typeof(ushort)));
            }

            entries.Add(Spacer);

            for (var s = 0; s < 4; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: Defense Up {s + 1}", 1916 + (ulong) s * 2, typeof(ushort)));
            }

            entries.Add(Spacer);

            for (var s = 0; s < 4; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: All Resistances Up {s + 1}", 1924 + (ulong) s * 2, typeof(ushort)));
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                Spacer,

                new MhwStructData.Entry("Feline Polisher: % 1", 1932, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: % 2", 1933, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: % 3", 1934, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: Loop # 1", 1935, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: Loop # 2", 1936, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: Loop # 3", 1937, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Feline Rider: Attack Rate", 1938, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Heroics: Attack Rate", 1942, typeof(float)),
                new MhwStructData.Entry("Feline Heroics: Defense Rate", 1946, typeof(float)),
                new MhwStructData.Entry("Feline Heroics: Life Activation Threshold", 1950, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Feline Carving L: Lottery % 1", 1951, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Lottery % 2", 1952, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Lottery % 3", 1953, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Up % 1", 1954, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Up % 2", 1955, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Up % 3", 1956, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Up % 4", 1957, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Feline Carving S: Lottery %", 1958, typeof(byte)),
                new MhwStructData.Entry("Feline Carving S: Up %", 1959, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Feline Medic: Heal Rate", 1960, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Black Belt: Stamina Rate", 1964, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Special Attack: Condition Attack Bonus", 1968, typeof(ushort)),
                new MhwStructData.Entry("Feline Special Attack: Capture Attack Rate", 1970, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Defense S: %", 1974, typeof(byte)),
                new MhwStructData.Entry("Feline Defense S: Damage Rate", 1976, typeof(float)),
                new MhwStructData.Entry("Feline Defense L: %", 1975, typeof(byte)),
                new MhwStructData.Entry("Feline Defense L: Damage Rate", 1980, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Harvest: Cooldown Multiplier", 1984, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Sharpshooter: Shell Attack Rate", 1988, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Escape Artist: Dash Stamina Rate", 1992, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Delivery: Dash Stamina Rate", 1996, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Riser S: IFrames", 2000, typeof(float)),
                new MhwStructData.Entry("Feline Riser L: IFrames", 2004, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Temper: Shell Attack Rate", 2008, typeof(float)),
                new MhwStructData.Entry("Feline Temper: Blur Level Bonus", 2012, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Feline Cliffhanger: Stamina Rate", 2013, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Slugger: Stun Attack Rate", 2017, typeof(float)),

                Spacer
            });

            var felineBombardierParams = new List<string> {
                "Ballista",
                "Cannon",
                "Gunlance Shell",
                "Gunlance WyvernFire",
                "Gunlance Wyrmstake Cannon",
                "Charge Blade Impact Phial",
                "Bowgun Sticky Ammo",
                "Bowgun Wyvern Ammo"
            };

            entries.AddRange(felineBombardierParams.Select((felineBombardier, x) => new MhwStructData.Entry($"Feline Bombardier: {felineBombardier} Attack Rate", 2021 + (ulong) x * 4, typeof(float))));

            entries.AddRange(new List<MhwStructData.Entry> {
                Spacer,

                new MhwStructData.Entry("Feline Moxie: Health Threshold", 2053, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Feline Dungmaster: Escape % Bonus", 2054, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Feline Provoker: Rate", 2055, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Cool Cat: Power UP Time Needed", 2059, typeof(float)),
                new MhwStructData.Entry("Feline Cool Cat: Power UP Duration", 2063, typeof(float)),
                new MhwStructData.Entry("Feline Cool Cat: Attack Bonus", 2067, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Booster: Attack Bonus", 2071, typeof(float)),
                new MhwStructData.Entry("Feline Booster: Defense Bonus", 2075, typeof(float)),
                new MhwStructData.Entry("Feline Booster: Duration", 2079, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Groomer: Defense Down Duration Multiplier", 2083, typeof(float)),
                new MhwStructData.Entry("Feline Groomer: Element Blight Recovery Multiplier", 2087, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Feline Parting Gift: Radius", 2091, typeof(float)),
                new MhwStructData.Entry("Feline Parting Gift: Recovery Value", 2095, typeof(ushort)),

                Spacer
            });

            for (var s = 0; s < 5; s++) {
                entries.Add(new MhwStructData.Entry($"Feline Recoil: Attack Multiplier {s + 1}", 2097 + (ulong) s * 4, typeof(float)));
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                Spacer,

                new MhwStructData.Entry($"Unk{i++}", 2117, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Music Skill: Bless: Random Rate", 2121, typeof(float)),
                new MhwStructData.Entry("Music Skill: Bless: Damage Cut Rate", 2125, typeof(float)),
                new MhwStructData.Entry("Music Skill: Extend: Time", 2129, typeof(float)),
                new MhwStructData.Entry("Music Skill: Extend: Time Master", 2133, typeof(float)),
                new MhwStructData.Entry("Music Skill: Extend: Time MR Master", 2137, typeof(float)),
                new MhwStructData.Entry("Music Skill: Major Heal: Rand Rate", 2141, typeof(float)),
                new MhwStructData.Entry("Music Skill: Major Heal: Rand Master Rate", 2145, typeof(float)),
                new MhwStructData.Entry("Music Skill: Major Heal: Rand MR Master Rate", 2149, typeof(float)),
                new MhwStructData.Entry("Music Skill: Heal 0: Minor", 2153, typeof(float)),
                new MhwStructData.Entry("Music Skill: Heal 0: Major", 2157, typeof(float)),
                new MhwStructData.Entry("Music Skill: Heal 1: Minor", 2161, typeof(float)),
                new MhwStructData.Entry("Music Skill: Heal 1: Major", 2165, typeof(float)),
                new MhwStructData.Entry("Music Skill: Heal 2: Minor", 2169, typeof(float)),
                new MhwStructData.Entry("Music Skill: Heal 2: Major", 2173, typeof(float)),
                new MhwStructData.Entry("Music Skill: Hp Up 0", 2177, typeof(uint)),
                new MhwStructData.Entry("Music Skill: Hp Up 1", 2181, typeof(uint)),
                new MhwStructData.Entry("Music Skill: Mantle Duration", 2185, typeof(float)),
                new MhwStructData.Entry("Music Skill: Mantle Duration Put", 2189, typeof(float)),
                new MhwStructData.Entry("Music Skill: Stamina Up Rate", 2193, typeof(float)),

                Spacer,

                new MhwStructData.Entry($"Unk{i++}", 2197, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 2201, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 2205, typeof(uint)),
                new MhwStructData.Entry($"Unk{i++}", 2209, typeof(uint)),
                new MhwStructData.Entry($"Unk{i++}", 2213, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 2217, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 2221, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 2225, typeof(uint)),
                new MhwStructData.Entry($"Unk{i++}", 2229, typeof(uint)),
                new MhwStructData.Entry($"Unk{i++}", 2233, typeof(float)),
                new MhwStructData.Entry($"Unk{i}", 2237, typeof(float))
            });

            GeneratePlDataProps("MHW_Editor.PlData", "PlSkillParam", new MhwStructData { // .plsp
                size = 2256,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plsp"],
                entries = entries
            });
        }

        private static void GenPlMantleParam() {
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

                Spacer,

                new MhwStructData.Entry("Ghillie Mantle: Cooldown", 44, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Duration", 48, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Unk1", 52, typeof(float)),
                new MhwStructData.Entry("Ghillie Mantle: Unk2", 56, typeof(float)),

                Spacer,

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

                Spacer,

                new MhwStructData.Entry("Health Booster: Cooldown", 120, typeof(float)),
                new MhwStructData.Entry("Health Booster: Duration", 124, typeof(float)),
                new MhwStructData.Entry("Health Booster: Upgraded Duration", 128, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Rocksteady Mantle: Cooldown", 132, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Duration", 136, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Unk1", 140, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Damage Resist", 144, typeof(float)),
                new MhwStructData.Entry("Rocksteady Mantle: Unk2", 148, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Challenger Mantle: Cooldown", 152, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Duration", 156, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Unk1", 160, typeof(float)),
                new MhwStructData.Entry("Challenger Mantle: Unk2", 164, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Vitality Mantle: Cooldown", 168, typeof(float)),
                new MhwStructData.Entry("Vitality Mantle: Duration", 172, typeof(float)),
                new MhwStructData.Entry("Vitality Mantle: Mantle Health", 176, typeof(float)),

                Spacer
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

                    Spacer
                });
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Dragonproof Mantle: Cooldown", 228, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Duration", 232, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Damage Reduction %", 236, typeof(float)),
                new MhwStructData.Entry("Dragonproof Mantle: Dragon Damage Multiplier", 240, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Cleanser Booster: Cooldown", 244, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Duration", 248, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Upgraded Duration", 252, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk1", 256, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk2", 260, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk3", 264, typeof(float)),
                new MhwStructData.Entry("Cleanser Booster: Unk4", 268, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Glider Mantle: Cooldown", 272, typeof(float)),
                new MhwStructData.Entry("Glider Mantle: Duration", 276, typeof(float)),
                new MhwStructData.Entry("Glider Mantle: Mount Multiplier", 280, typeof(float)),

                Spacer,

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

                Spacer,

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

                Spacer,

                new MhwStructData.Entry("Apothecary Mantle: Cooldown", 387, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Duration", 391, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Poison", 395, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Para", 399, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Sleep", 403, typeof(float)),
                new MhwStructData.Entry("Apothecary Mantle: Status Multiplier: Blast", 407, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Immunity Mantle: Cooldown", 411, typeof(float)),
                new MhwStructData.Entry("Immunity Mantle: Duration", 415, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Affinity Booster: Cooldown", 419, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Duration", 423, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Buff Duration", 427, typeof(float)),
                new MhwStructData.Entry("Affinity Booster: Buff Affinity", 431, typeof(int)),

                Spacer,

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

                Spacer,

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

            GeneratePlDataProps("MHW_Editor.PlData", "PlMantleParam", new MhwStructData { // .asp
                size = 560,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".asp"],
                entries = entries
            });
        }

        private static void GenPlPlayerParam() {
            // 'Unk' counters.
            ushort i = 1;
            ushort j = 1;
            ushort k = 1;
            ushort n = 1;

            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry($"Unk{i++}", 8, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 12, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 16, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 20, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 24, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 28, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 32, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 36, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 40, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 44, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 48, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 52, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 56, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 60, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 64, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 68, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 72, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 76, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 80, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 84, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 88, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 92, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 96, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 100, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 104, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 108, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 112, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 116, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 120, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 124, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 128, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 132, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 136, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 140, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 144, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 148, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 152, typeof(uint)),
                new MhwStructData.Entry($"Unk{i++}", 156, typeof(uint)),
                new MhwStructData.Entry($"Unk{i++}", 160, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 164, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 168, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 172, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 176, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 180, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 184, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 188, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 192, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 196, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 200, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 204, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 208, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 212, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 216, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 220, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 224, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 228, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 232, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 236, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 237, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 239, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 241, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 245, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 246, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 248, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 250, typeof(ushort)),
                new MhwStructData.Entry($"Unk{i++}", 252, typeof(float)),

                Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                Spacer,

                new MhwStructData.Entry("Health Initial Value", 408, typeof(float)),
                new MhwStructData.Entry("Health Max Value", 412, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Rate", 416, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Wait Time", 420, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Interval", 424, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Value", 428, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Stamina Initial Value", 432, typeof(float)),
                new MhwStructData.Entry("Stamina Max Value", 436, typeof(float)),
                new MhwStructData.Entry("Stamina Min Value", 440, typeof(float)),
                new MhwStructData.Entry("Stamina Tired Value", 444, typeof(float)),
                new MhwStructData.Entry("Stamina Auto Recover", 448, typeof(float)),
                new MhwStructData.Entry("Stamina Auto Max Reduce", 452, typeof(float)),
                new MhwStructData.Entry("Stamina Auto Max Reduce Time", 456, typeof(float)),
                new MhwStructData.Entry("Stamina IB Unknown", 460, typeof(float)),
                new MhwStructData.Entry("Stamina Escape Dash Rate", 464, typeof(float)),
                new MhwStructData.Entry("Stamina Out of Battle Rate", 468, typeof(float)),
                new MhwStructData.Entry("Stamina Reduce Rate Limit Trigger", 472, typeof(float)),
                new MhwStructData.Entry("Stamina Reduce Rate Limit Time", 476, typeof(float)),
                new MhwStructData.Entry("Stamina Mount Endurance Rate", 480, typeof(float)),

                new MhwStructData.Entry("Stamina Consumption: Dodge", 484, typeof(float)),
                new MhwStructData.Entry("Stamina Consumption: LS Counter", 488, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 492, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 496, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 500, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 504, typeof(float)),
                new MhwStructData.Entry("Stamina Consumption: Bow Shoot", 508, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 512, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 516, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 520, typeof(float)),
                new MhwStructData.Entry("Stamina Consumption: Bow Charge Step", 524, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 528, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: IB Unk{j++}", 532, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: IB Unk{j++}", 536, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: IB Unk{j++}", 540, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: IB Unk{j++}", 544, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j++}", 548, typeof(float)),
                new MhwStructData.Entry($"Stamina Consumption: Unk{j}", 552, typeof(float)),

                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 556, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 560, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 564, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 568, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 572, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 576, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 580, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 584, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 588, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 592, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 596, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 600, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 604, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 608, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 612, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 616, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 620, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k}", 624, typeof(float)),

                Spacer,

                new MhwStructData.Entry("Mount Reduce Stamina mCore: Unk1", 628, typeof(float)),
                new MhwStructData.Entry("Mount Reduce Stamina mCore: Unk2", 632, typeof(float)),

                new MhwStructData.Entry("Mount Life Reduce Stamina mCore: Unk1", 636, typeof(float)),
                new MhwStructData.Entry("Mount Life Reduce Stamina mCore: Unk2", 640, typeof(float)),
                new MhwStructData.Entry("Mount Life Reduce Stamina mCore: Unk3", 644, typeof(float)),
                new MhwStructData.Entry("Mount Life Reduce Stamina mCore: Unk4", 648, typeof(float)),

                Spacer,

                new MhwStructData.Entry($"Unk{i++}", 652, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 656, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 660, typeof(float)),
                new MhwStructData.Entry("Explosive HR Fixed Attack Rate", 664, typeof(float)),
                new MhwStructData.Entry("Explosive MR Fixed Attack Rate", 668, typeof(float)),
                new MhwStructData.Entry("Critical Attack Rate", 672, typeof(float)),
                new MhwStructData.Entry("Bad Critical Attack Rate", 676, typeof(float)),

                new MhwStructData.Entry("Sharpness Recoil Reduction %", 680, typeof(byte)),
                new MhwStructData.Entry("Sharpness Recoil Reduction Value", 681, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 682, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 686, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 690, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 694, typeof(float)),
                new MhwStructData.Entry($"Unk{i}", 698, typeof(uint)),
                new MhwStructData.Entry("Physical Attack Rate Limit", 702, typeof(float)),
                new MhwStructData.Entry("Elemental Attack Rate Limit", 706, typeof(float)),
                new MhwStructData.Entry("Condition Attack Flat Limit", 710, typeof(float)),
                new MhwStructData.Entry("Bowgun Elemental Attack Rate Limit", 714, typeof(float)),
                new MhwStructData.Entry("Condition Attack Rate Limit", 718, typeof(float)),
                new MhwStructData.Entry("Stun Attack Rate Limit", 722, typeof(float)),
                new MhwStructData.Entry("Stamina Attack Rate Limit", 726, typeof(float)),
                new MhwStructData.Entry("Mount Attack Rate Limit", 730, typeof(float)),
                new MhwStructData.Entry("Super Armor Stun Damage Rate", 734, typeof(float)),
                new MhwStructData.Entry("Hyper Armor Damage Rate", 738, typeof(float)),
                new MhwStructData.Entry("Hyper Armor Stun Damage Rate", 742, typeof(float)),
                new MhwStructData.Entry("Gunner Defense Rate", 746, typeof(float)),
                new MhwStructData.Entry("Gunner Elemental Resistance Bonus", 750, typeof(byte)),
                new MhwStructData.Entry("Lava Damage Interval Time", 751, typeof(float)),
                new MhwStructData.Entry("Lava Damage Damage", 755, typeof(float)),
                new MhwStructData.Entry("Acid Damage Interval Time", 759, typeof(float)),
                new MhwStructData.Entry("Acid Damage Damage", 763, typeof(float)),

                Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                Spacer
            };

            var iFrameEntries = new List<string> {
                "Normal",
                "Step",
                "Sword & Shield Back Step",
                "Dual Blades Demon Mode Step",
                "Long Sword Counter",
                "Bow Charge Step",
                "HBG Roll Dodge",
                "LBG Side Dodge",
                "Dual Blades Demon Mode Slinger Evade",
                "Dual Blades Slinger Evade"
            };

            var iFrameSubEntries = new List<string> {
                "Evasion 0",
                "Evasion 1",
                "Evasion 2",
                "Evasion 3",
                "Evasion 4",
                "Evasion 5",
                "Evasion Mantle"
            };

            for (var x = 0; x < iFrameEntries.Count; x++) {
                entries.AddRange(iFrameSubEntries.Select((sub, s) => new MhwStructData.Entry($"Dodge IFrames: {iFrameEntries[x]}: {sub}", 1157 + (ulong) s * 4 + (ulong) x * 28, typeof(float))));
            }

            entries.Add(Spacer);

            var evadeDistanceEntries = new List<string> {
                "Normal",
                "Step",
                "Sword & Shield Back Step",
                "Dual Blades DemonMode Step",
                "Long Sword Counter",
                "Insect Glaive Air Dodge",
                "Bow Charge Step",
                "HBG Roll Dodge",
                "LBG Side Dodge",
                "Dual Blades Demon Mode Slinger Evade",
                "Dual Blades Slinger Evade"
            };

            var evadeDistanceSubEntries = new List<string> {
                "Distance 1",
                "Distance 2",
                "Distance 3"
            };

            for (var x = 0; x < evadeDistanceEntries.Count; x++) {
                entries.AddRange(evadeDistanceSubEntries.Select((sub, s) => new MhwStructData.Entry($"Evade: {evadeDistanceEntries[x]}: {sub}", 1437 + (ulong) s * 4 + (ulong) x * 12, typeof(float))));
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                Spacer,

                // HR Augment.
                new MhwStructData.Entry("Wp HR Augment Attack Bonus (1)", 8571, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Attack Bonus (2)", 8572, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Attack Bonus (3)", 8573, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Critical Bonus (1)", 8574, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Critical Bonus (2)", 8575, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Critical Bonus (3)", 8576, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense Bonus (1)", 8577, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense Bonus (2)", 8578, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense Bonus (3)", 8579, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense: Divine Blessing Chance (1)", 8580, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense: Divine Blessing Chance (2)", 8581, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense: Divine Blessing Chance (3)", 8582, typeof(byte)),
                new MhwStructData.Entry("Wp HR Augment Defense: Divine Blessing Reduction (1)", 8583, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Defense: Divine Blessing Reduction (2)", 8587, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Defense: Divine Blessing Reduction (3)", 8591, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Defense Heal Damage Rate (1)", 8595, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Defense Heal Damage Rate (2)", 8599, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Defense Heal Damage Rate (3)", 8603, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment IB Unk", 8607, typeof(float)),
                new MhwStructData.Entry("Wp HR Augment Lifesteal Cooldown", 8611, typeof(float)),

                Spacer,

                // MR Augment now.
                new MhwStructData.Entry("Wp MR Augment Attack Bonus (1)", 8615, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Attack Bonus (2)", 8616, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Attack Bonus (3)", 8617, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Attack Bonus (4)", 8618, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Critical Bonus (1)", 8619, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Critical Bonus (2)", 8620, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Critical Bonus (3)", 8621, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Critical Bonus (4)", 8622, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense Bonus (1)", 8623, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense Bonus (2)", 8624, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense Bonus (3)", 8625, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense Bonus (4)", 8626, typeof(byte)),

                new MhwStructData.Entry("Wp MR Augment Defense: Divine Blessing Chance (1)", 8627, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense: Divine Blessing Chance (2)", 8628, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense: Divine Blessing Chance (3)", 8629, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense: Divine Blessing Chance (4)", 8630, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Defense: Divine Blessing Reduction (1)", 8631, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Defense: Divine Blessing Reduction (2)", 8635, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Defense: Divine Blessing Reduction (3)", 8639, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Defense: Divine Blessing Reduction (4)", 8643, typeof(float)),

                new MhwStructData.Entry("Wp MR Augment Health Percent (1)", 8647, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Health Percent (2)", 8651, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Health Percent (3)", 8655, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Health Percent (4)", 8659, typeof(float)),

                new MhwStructData.Entry($"IB Unk{n}", 8663, typeof(float)),

                new MhwStructData.Entry("Wp MR Augment Lifesteal Cooldown", 8667, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Element (1)", 8671, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Element (2)", 8672, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Element (3)", 8673, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Element (4)", 8674, typeof(byte)),

                Spacer,

                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (1)", 8675, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (2)", 8676, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (3)", 8677, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (4)", 8678, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (1)", 8679, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (2)", 8680, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (3)", 8681, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (4)", 8682, typeof(byte)),

                Spacer
            });

            var weapons = new List<string> {
                "Great Sword",
                "Sword & Shield",
                "Dual Blades",
                "Long Sword",
                "Hammer",
                "Hunting Horn",
                "Lance",
                "Gunlance",
                "Switch Axe",
                "Charge Blade",
                "Insect Glaive",
                "Bow",
                "HBG",
                "LBG"
            };

            entries.AddRange(weapons.Select((weapon, s) => new MhwStructData.Entry($"Wp MR Augment {weapon} Elemental Multiplier", 8683 + (ulong) s * 4, typeof(float))));

            entries.AddRange(new List<MhwStructData.Entry> {
                Spacer,

                new MhwStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (1)", 8739, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (2)", 8743, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (3)", 8747, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (4)", 8751, typeof(float)),

                Spacer,
                new MhwStructData.Entry("------Skipping the rest.", 3, typeof(byte), true, forceUnique: true)
            });

            GeneratePlDataProps("MHW_Editor.PlData", "PlPlayerParam", new MhwStructData { // .plp
                size = 20640,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plp"],
                entries = entries
            });
        }

        private static void GenPlItemParam() {
            GeneratePlDataProps("MHW_Editor.PlData", "PlItemParam", new MhwStructData { // .plip
                size = 512,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plip"],
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Powder Radius", 8, typeof(float)),
                    new MhwStructData.Entry("Potion Power", 12, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 16, typeof(float)),
                    new MhwStructData.Entry("Unk3", 20, typeof(float)),
                    new MhwStructData.Entry("Unk4", 24, typeof(float)),
                    new MhwStructData.Entry("Mega Potion Power", 28, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 32, typeof(float)),
                    new MhwStructData.Entry("Unk6", 36, typeof(float)),
                    new MhwStructData.Entry("Unk7", 40, typeof(float)),
                    new MhwStructData.Entry("Nutrients Power", 44, typeof(byte)),
                    new MhwStructData.Entry("Mega Nutrients Power", 45, typeof(byte)),
                    new MhwStructData.Entry("Unk9", 46, typeof(byte)),
                    new MhwStructData.Entry("Mega Dash Juice Stamina Power", 47, typeof(float)),
                    new MhwStructData.Entry("Dash Juice Stamina Power", 51, typeof(float)),
                    new MhwStructData.Entry("Both Dash Juice Duration", 55, typeof(ushort)),
                    new MhwStructData.Entry("Both Dash Juice Power", 57, typeof(byte)),
                    new MhwStructData.Entry("Immunizer Power", 58, typeof(float)),
                    new MhwStructData.Entry("Immunizer Duration", 62, typeof(ushort)),
                    new MhwStructData.Entry("Astera Jerky Power", 64, typeof(float)),
                    new MhwStructData.Entry("Astera Jerky Duration", 68, typeof(ushort)),
                    new MhwStructData.Entry("Herbal Medicine Power", 70, typeof(ushort)),
                    new MhwStructData.Entry("Sushifish Scale Power", 72, typeof(uint)),
                    new MhwStructData.Entry("Great Sushifish Scale Power", 76, typeof(uint)),
                    new MhwStructData.Entry("Great Sushifish Scale Duration", 80, typeof(float)),
                    new MhwStructData.Entry("Cool Drink Duration", 84, typeof(ushort)),
                    new MhwStructData.Entry("Hot Drink Duration", 86, typeof(ushort)),
                    new MhwStructData.Entry("Might Seed Duration", 88, typeof(ushort)),
                    new MhwStructData.Entry("Might Seed Power", 90, typeof(ushort)),
                    new MhwStructData.Entry("Might Pill Duration", 92, typeof(ushort)),
                    new MhwStructData.Entry("Might Pill Power", 94, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Seed Duration", 96, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Seed Power", 98, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Pill Duration", 100, typeof(ushort)),
                    new MhwStructData.Entry("Adamant Pill Power", 102, typeof(float)),
                    new MhwStructData.Entry("Demondrug Power", 106, typeof(byte)),
                    new MhwStructData.Entry("Mega Demondrug Power", 107, typeof(byte)),
                    new MhwStructData.Entry("Armorskin Power", 108, typeof(byte)),
                    new MhwStructData.Entry("Mega Armorskin Power", 109, typeof(byte)),
                    new MhwStructData.Entry("Unk16", 110, typeof(ushort)),
                    new MhwStructData.Entry("Lifepowder Power", 112, typeof(ushort)),
                    new MhwStructData.Entry("Dust of Life Power", 114, typeof(ushort)),
                    new MhwStructData.Entry("Herbal Powder Power", 116, typeof(ushort)),
                    new MhwStructData.Entry("Demon Powder Power", 118, typeof(ushort)),
                    new MhwStructData.Entry("Demon Powder Duration", 120, typeof(ushort)),
                    new MhwStructData.Entry("Hardshell Powder Power", 122, typeof(ushort)),
                    new MhwStructData.Entry("Hardshell Powder Duration", 124, typeof(ushort)),
                    new MhwStructData.Entry("Demon Ammo Power", 126, typeof(ushort)),
                    new MhwStructData.Entry("Demon Ammo Duration", 128, typeof(ushort)),
                    new MhwStructData.Entry("Armor Ammo Power", 130, typeof(ushort)),
                    new MhwStructData.Entry("Armor Ammo Duration", 132, typeof(ushort)),
                    new MhwStructData.Entry("Ration Power", 134, typeof(ushort)),
                    new MhwStructData.Entry("Well Done Steak Multiplier", 136, typeof(uint)),
                    new MhwStructData.Entry("Well Done Steak Stamina Bonus", 140, typeof(float)),
                    new MhwStructData.Entry("Unk23", 144, typeof(float)),
                    new MhwStructData.Entry("Unk24", 148, typeof(float)),
                    new MhwStructData.Entry("Burnt Meat Stamina Recovery", 152, typeof(ushort)),
                    new MhwStructData.Entry("Unk26", 154, typeof(short)),
                    new MhwStructData.Entry("Unk27", 156, typeof(byte)),
                    new MhwStructData.Entry("Unk28", 157, typeof(float)),
                    new MhwStructData.Entry("Unk29", 161, typeof(float)),
                    new MhwStructData.Entry("Unk30", 165, typeof(float)),
                    new MhwStructData.Entry("Unk31", 169, typeof(float)),
                    new MhwStructData.Entry("Unk32", 173, typeof(float)),
                    new MhwStructData.Entry("Unk33", 177, typeof(float)),
                    new MhwStructData.Entry("Unk34", 181, typeof(float)),
                    new MhwStructData.Entry("Unk35", 185, typeof(float)),
                    new MhwStructData.Entry("Unk36", 189, typeof(float)),
                    new MhwStructData.Entry("Unk37", 193, typeof(float)),
                    new MhwStructData.Entry("Unk38", 197, typeof(float)),
                    new MhwStructData.Entry("Whetstone Sharpness Restored", 201, typeof(uint)),
                    new MhwStructData.Entry("Whetstone Cycles", 205, typeof(uint)),
                    new MhwStructData.Entry("Whetfish Scale Sharpness Restored", 209, typeof(uint)),
                    new MhwStructData.Entry("Whetfish Scale Cycles", 213, typeof(byte)),
                    new MhwStructData.Entry("Whetfish Scale Plus Cycles", 214, typeof(byte)),
                    new MhwStructData.Entry("Whetfish Scale Consume %", 215, typeof(byte)),
                    new MhwStructData.Entry("Powertalon Power", 216, typeof(byte)),
                    new MhwStructData.Entry("Powercharm Power", 217, typeof(byte)),
                    new MhwStructData.Entry("Armortalon Power", 218, typeof(byte)),
                    new MhwStructData.Entry("Armorcharm Power", 219, typeof(byte)),
                    new MhwStructData.Entry("Unk49", 220, typeof(byte)),
                    new MhwStructData.Entry("Unk50", 221, typeof(float)),
                    new MhwStructData.Entry("Unk51", 225, typeof(float)),
                    new MhwStructData.Entry("Unk52", 229, typeof(float)),
                    new MhwStructData.Entry("Unk53", 233, typeof(float)),
                    new MhwStructData.Entry("Unk54", 237, typeof(float)),
                    new MhwStructData.Entry("Unk55", 241, typeof(float)),
                    new MhwStructData.Entry("Unk56", 245, typeof(float)),
                    new MhwStructData.Entry("Unk57", 249, typeof(float)),
                    new MhwStructData.Entry("Unk58", 253, typeof(float)),
                    new MhwStructData.Entry("Unk59", 257, typeof(float)),
                    new MhwStructData.Entry("Unk60", 261, typeof(float)),
                    new MhwStructData.Entry("Unk61", 265, typeof(float)),
                    new MhwStructData.Entry("Unk62", 269, typeof(float)),
                    new MhwStructData.Entry("Unk63", 273, typeof(float)),
                    new MhwStructData.Entry("Unk64", 277, typeof(float)),
                    new MhwStructData.Entry("Unk65", 281, typeof(float)),
                    new MhwStructData.Entry("Unk66", 285, typeof(float)),
                    new MhwStructData.Entry("Unk67", 289, typeof(float)),
                    new MhwStructData.Entry("Unk68", 293, typeof(float)),
                    new MhwStructData.Entry("Unk69", 297, typeof(float)),
                    new MhwStructData.Entry("Unk70", 301, typeof(float)),
                    new MhwStructData.Entry("Unk71", 305, typeof(float)),
                    new MhwStructData.Entry("Unk72", 309, typeof(float)),
                    new MhwStructData.Entry("Unk73", 313, typeof(float)),
                    new MhwStructData.Entry("Unk74", 317, typeof(float)),
                    new MhwStructData.Entry("Unk75", 321, typeof(float)),
                    new MhwStructData.Entry("Unk76", 325, typeof(float)),
                    new MhwStructData.Entry("Unk77", 329, typeof(float)),
                    new MhwStructData.Entry("Unk78", 337, typeof(float)),
                    new MhwStructData.Entry("Unk79", 341, typeof(float)),
                    new MhwStructData.Entry("Unk80", 345, typeof(float)),
                    new MhwStructData.Entry("Unk81", 349, typeof(float)),
                    new MhwStructData.Entry("Unk82", 353, typeof(float)),
                    new MhwStructData.Entry("Unk83", 357, typeof(float)),
                    new MhwStructData.Entry("Unk84", 361, typeof(float)),
                    new MhwStructData.Entry("Unk85", 365, typeof(float)),
                    new MhwStructData.Entry("Unk86", 369, typeof(float)),
                    new MhwStructData.Entry("Unk87", 373, typeof(float)),
                    new MhwStructData.Entry("Unk88", 377, typeof(float)),
                    new MhwStructData.Entry("Unk89", 381, typeof(float)),
                    new MhwStructData.Entry("Unk90", 385, typeof(float)),
                    new MhwStructData.Entry("Unk91", 389, typeof(float)),
                    new MhwStructData.Entry("Unk92", 393, typeof(float)),
                    new MhwStructData.Entry("Unk93", 397, typeof(float)),
                    new MhwStructData.Entry("Unk94", 401, typeof(float)),
                    new MhwStructData.Entry("Unk95", 405, typeof(float)),
                    new MhwStructData.Entry("Unk96", 409, typeof(float)),
                    new MhwStructData.Entry("Unk97", 413, typeof(float)),
                    new MhwStructData.Entry("Unk98", 417, typeof(float)),
                    new MhwStructData.Entry("Unk99", 417, typeof(float)),
                    new MhwStructData.Entry("Unk100", 421, typeof(float)),
                    new MhwStructData.Entry("Unk101", 425, typeof(float)),
                    new MhwStructData.Entry("Unk102", 429, typeof(float)),
                    new MhwStructData.Entry("Unk103", 433, typeof(float)),
                    new MhwStructData.Entry("Unk104", 437, typeof(float)),
                    new MhwStructData.Entry("Unk105", 441, typeof(float)),
                    new MhwStructData.Entry("Deathcream: 455-499 are fishing rumble", 445, typeof(byte)),
                    new MhwStructData.Entry("and skipped for now.", 446, typeof(uint)),
                    new MhwStructData.Entry("Unk106", 500, typeof(float)),
                    new MhwStructData.Entry("Unk107", 504, typeof(float)),
                    new MhwStructData.Entry("Unk108", 508, typeof(float))
                }
            });
        }

        public static void GeneratePlDataProps(string @namespace, string className, MhwStructData structData) {
            GenerateItemProps(@namespace, className, structData);

            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, $"{className}Internal", new PlDataItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });
        }
    }
}