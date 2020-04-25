using System.Collections.Generic;
using System.Linq;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.PlData {
    public class PlSkillParam : IVerticalStruct {
        public VerticalStruct Generate() { // .plsp
            // 'Unk' counters.
            ushort i = 1;
            ushort j = 1;

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
                VerticalStruct.Spacer,

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
                VerticalStruct.Spacer,

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
                VerticalStruct.Spacer,

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
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Focus (Gunlance, Charge Shot) Time Rate 1", 210, typeof(float)),
                new MhwStructData.Entry("Focus (Gunlance, Charge Shot) Time Rate 2", 214, typeof(float)),
                new MhwStructData.Entry("Focus (Gunlance, Charge Shot) Time Rate 3", 218, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Slash 2) Time Rate 1", 222, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Slash 2) Time Rate 2", 226, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Slash 2) Time Rate 3", 230, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Phial Charge Slash) Time Rate 1", 234, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Phial Charge Slash) Time Rate 2", 238, typeof(float)),
                new MhwStructData.Entry("Focus (Charge Blade, Phial Charge Slash) Time Rate 3", 242, typeof(float)),
                VerticalStruct.Spacer
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

                entries.Add(VerticalStruct.Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Razor Sharp: Sharpness No Reduce %", 414, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Gunlance Shot Sub Value", 415, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Gunlance Shot No Reduce %", 416, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Gun Ammo No Reduce %", 417, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Bow Coating No Reduce %", 418, typeof(byte)),
                new MhwStructData.Entry("Razor Sharp: Guard Consumption %", 419, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("True Razor Sharp: Sharpness No Reduce %", 420, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Gunlance Shot Sub Value", 421, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Gunlance Shot No Reduce %", 422, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Gun Ammo No Reduce %", 423, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Bow Coating No Reduce %", 424, typeof(byte)),
                new MhwStructData.Entry("True Razor Sharp: Guard Consumption %", 425, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Minds Eye / Ballistics: Gun Critical Begin Wide Rate", 426, typeof(float)),
                new MhwStructData.Entry("Minds Eye / Ballistics: Gun Critical End Wide Rate", 430, typeof(float)),
                new MhwStructData.Entry("Minds Eye / Ballistics: Bow Critical Begin Wide Rate", 434, typeof(float)),
                new MhwStructData.Entry("Minds Eye / Ballistics: Bow Critical End Wide Rate", 438, typeof(float)),
                VerticalStruct.Spacer
            });

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Critical Element: ({weapon}) Rate", 442 + (ulong) x * 4, typeof(float))));
            entries.Add(new MhwStructData.Entry("Critical Element: Dragon Seal Rate", 498, typeof(float)));

            entries.Add(VerticalStruct.Spacer);

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"True Critical Element: ({weapon}) Rate", 502 + (ulong) x * 4, typeof(float))));
            entries.Add(new MhwStructData.Entry("True Critical Element: Dragon Seal Rate", 558, typeof(float)));

            entries.Add(VerticalStruct.Spacer);

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Critical Condition: ({weapon}) Rate", 562 + (ulong) x * 4, typeof(float))));

            entries.Add(VerticalStruct.Spacer);

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"True Critical Condition: ({weapon}) Rate", 618 + (ulong) x * 4, typeof(float))));

            entries.AddRange(new List<MhwStructData.Entry> {
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Bludgeoner: Red Sharpness Attack Bonus (& BG Melee)", 674, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Orange Sharpness Attack Bonus", 676, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Yellow Sharpness Attack Bonus", 678, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Green Sharpness Attack Bonus", 680, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Blue Sharpness Attack Bonus", 682, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: White Sharpness Attack Bonus", 684, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Purple Sharpness Attack Bonus", 686, typeof(ushort)),
                new MhwStructData.Entry("Bludgeoner: Bowgun Melee Attack Stun Bonus", 688, typeof(ushort)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Non-Elemental Boost: Attack Multiplier", 690, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Affinity Slider: Attack Up Activate Time", 694, typeof(float)),
                new MhwStructData.Entry("Affinity Slider: Attack Up Duration", 698, typeof(float)),
                new MhwStructData.Entry("Affinity Slider: Attack Critical Bonus", 702, typeof(byte)),
                VerticalStruct.Spacer
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

                entries.Add(VerticalStruct.Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Heavy Artillery: Ballista Attack Rate 1", 883, typeof(float)),
                new MhwStructData.Entry("Heavy Artillery: Ballista Attack Rate 2", 887, typeof(float)),
                new MhwStructData.Entry("Heavy Artillery: Cannon Attack Rate 1", 891, typeof(float)),
                new MhwStructData.Entry("Heavy Artillery: Cannon Attack Rate 2", 895, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Bombardier: Attack Rate 1", 899, typeof(float)),
                new MhwStructData.Entry("Bombardier: Attack Rate 2", 903, typeof(float)),
                new MhwStructData.Entry("Bombardier: Attack Rate 3", 907, typeof(float)),
                new MhwStructData.Entry("Bombardier: Attack Rate 4", 911, typeof(float)),
                new MhwStructData.Entry("Bombardier: Attack Rate 5", 915, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Capacity Boost: Gunlance Normal Bonus", 919, typeof(byte)),
                new MhwStructData.Entry("Capacity Boost: Gunlance Radiation Bonus", 920, typeof(byte)),
                new MhwStructData.Entry("Capacity Boost: Gunlance Scatter Bonus", 921, typeof(byte)),
                new MhwStructData.Entry("Capacity Boost: Charge Blade Shield Duration Bonus", 922, typeof(byte)),
                VerticalStruct.Spacer
            });

            for (var x = 0; x < 3; x++) {
                for (var s = 0; s < 4; s++) {
                    entries.Add(new MhwStructData.Entry($"Ammo Up {x + 1}: Capacity {s + 1} Limit", 923 + (ulong) s * 2 + (ulong) x * 8, typeof(sbyte)));
                    entries.Add(new MhwStructData.Entry($"Ammo Up {x + 1}: Capacity {s + 1} Bonus", 924 + (ulong) s * 2 + (ulong) x * 8, typeof(byte)));
                }

                entries.Add(VerticalStruct.Spacer);
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

                entries.Add(VerticalStruct.Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Health Auto Recover Interval", 1007, typeof(float)),
                new MhwStructData.Entry("Health Auto Recover Value", 1011, typeof(byte)),
                VerticalStruct.Spacer
            });

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Hasten Recovery: ({weapon}) Recovery Health", 1012 + (ulong) x, typeof(byte))));

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Hasten Recovery: Success Combo #", 1026, typeof(byte)),
                new MhwStructData.Entry("Hasten Recovery: Combo Duration", 1027, typeof(float)),
                new MhwStructData.Entry("Hasten Recovery: Combo Ignore Time", 1031, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry($"Unk{i++}", 1035, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1036, typeof(float)),
                new MhwStructData.Entry($"Unk{i++}", 1040, typeof(float)),
                VerticalStruct.Spacer
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

                entries.Add(VerticalStruct.Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Master Fisher: Add Hook Time", 1199, typeof(float)),
                new MhwStructData.Entry("Master Fisher: Big Fish Catch Rate", 1203, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Adrenaline: Stamina Rate", 1207, typeof(float)),
                VerticalStruct.Spacer
            });

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Elemental Airborne: ({weapon}) Rate", 1211 + (ulong) x * 4, typeof(float))));

            entries.AddRange(new List<MhwStructData.Entry> {
                VerticalStruct.Spacer,

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
                VerticalStruct.Spacer
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

                entries.Add(VerticalStruct.Spacer);
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                new MhwStructData.Entry($"Unk{i++}", 1673, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1674, typeof(byte)),
                new MhwStructData.Entry($"Unk{i++}", 1675, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Frostcraft: Bow: (Rapid Shot & Clutch Claw Arrow) Consumption per Hit", 1676, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bow: (Power Shot) Consumption per Hit", 1677, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bow: (Arc Shot) Consumption per Hit", 1678, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bow: (Dragonpiercer) Consumption per Hit", 1679, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bow: (Thousand Dragons) Consumption per Hit", 1680, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Frostcraft: Bowgun: (Normal Ammo) Consumption per Hit", 1681, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Pierce Ammo) Consumption per Hit", 1682, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Spread Ammo) Consumption per Hit", 1683, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Sticky Ammo) Consumption per Hit", 1684, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Cluster Ammo) Consumption per Hit", 1685, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Elemental Ammo) Consumption per Hit", 1686, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Status Ammo) Consumption per Hit", 1687, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Wyvern Ammo) Consumption per Hit", 1688, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: Bowgun: (Slicing Ammo) Consumption per Hit", 1689, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Frostcraft: HBG: (Wyvernheart) Consumption per Hit", 1690, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Wyvernsnipe) Consumption per Hit", 1691, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Wyvernsnipe Type 2) Consumption per Hit", 1692, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Claw Wyvernheart Gatling) Consumption per Hit", 1694, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Claw Wyvernheart Finish) Consumption per Hit", 1695, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: HBG: (Wyvernsnipe Claw) Consumption per Hit", 1696, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Frostcraft: LBG: (Wyvernblast) Consumption per Hit", 1693, typeof(byte)),
                new MhwStructData.Entry("Frostcraft: LBG: (Wyvernblast Claw) Consumption per Hit", 1697, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry($"Unk Safi {j++}", 1698, typeof(byte), addOffset: 1),
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
                new MhwStructData.Entry("Offensive Guard", 1882, typeof(float)),
                new MhwStructData.Entry("Coalescence", 1886, typeof(float), addOffset: -1),
                VerticalStruct.Spacer,

                new MhwStructData.Entry($"Unk Safi {j++}", 1891, typeof(float)),
                new MhwStructData.Entry($"Unk Safi {j++}", 1895, typeof(float)),
                new MhwStructData.Entry($"Unk Safi {j++}", 1899, typeof(float)),
                new MhwStructData.Entry($"Unk Safi {j++}", 1903, typeof(uint)),
                new MhwStructData.Entry($"Unk Safi {j++}", 1907, typeof(uint)),
                new MhwStructData.Entry($"Unk Safi {j++}", 1911, typeof(float)),
                new MhwStructData.Entry("Set(3) Elemental Bonus", 1915, typeof(float)),
                new MhwStructData.Entry("Set(5) Elemental Bonus", 1919, typeof(float)),
                new MhwStructData.Entry("Set(3) Status Bonus", 1923, typeof(float)),
                new MhwStructData.Entry("Set(5) Status Bonus", 1927, typeof(float)),
                new MhwStructData.Entry("Set(3) Affinity Bonus", 1931, typeof(uint)),
                new MhwStructData.Entry("Set(5) Affinity Bonus", 1935, typeof(uint)),
                VerticalStruct.Spacer
            });

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Safi'Jiva Seal: ({weapon}) Hit Combo to Heal", 1939 + (ulong) x, typeof(byte))));

            entries.Add(VerticalStruct.Spacer);

            entries.AddRange(weapons.Select((weapon, x) => new MhwStructData.Entry($"Safi'Jiva Seal: ({weapon}) HP Lost Per Hit", 1953 + (ulong) x * 4, typeof(float))));

            entries.AddRange(new List<MhwStructData.Entry> {
                VerticalStruct.Spacer,

                new MhwStructData.Entry($"Unk Safi {j++}", 2009, typeof(float)),
                new MhwStructData.Entry($"Unk Safi {j++}", 2013, typeof(float)),
                new MhwStructData.Entry($"Unk Safi {j++}", 2017, typeof(float)),
                new MhwStructData.Entry($"Unk Safi {j++}", 2021, typeof(float)),
                new MhwStructData.Entry("Set(3) Elemental Limit", 2025, typeof(float)),
                new MhwStructData.Entry("Set(5) Elemental Limit", 2029, typeof(float)),
                new MhwStructData.Entry("Set(3) Bowgun Elemental Limit", 2033, typeof(float)),
                new MhwStructData.Entry("Set(5) Bowgun Elemental Limit", 2037, typeof(float)),
                new MhwStructData.Entry("Set(3) Status Limit", 2041, typeof(float)),
                new MhwStructData.Entry("Set(5) Status Limit", 2045, typeof(float), addOffset: 159),
                VerticalStruct.Spacer
            });

            for (var s = 0; s < 6; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: Life Up {s + 1}", 1890 + (ulong) s * 2, typeof(ushort)));
            }

            entries.Add(VerticalStruct.Spacer);

            for (var s = 0; s < 3; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: Stamina Up {s + 1}", 1902 + (ulong) s * 2, typeof(ushort)));
            }

            entries.Add(VerticalStruct.Spacer);

            for (var s = 0; s < 4; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: Attack Up {s + 1}", 1908 + (ulong) s * 2, typeof(ushort)));
            }

            entries.Add(VerticalStruct.Spacer);

            for (var s = 0; s < 4; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: Defense Up {s + 1}", 1916 + (ulong) s * 2, typeof(ushort)));
            }

            entries.Add(VerticalStruct.Spacer);

            for (var s = 0; s < 4; s++) {
                entries.Add(new MhwStructData.Entry($"Food Effect: All Resistances Up {s + 1}", 1924 + (ulong) s * 2, typeof(ushort)));
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Polisher: % 1", 1932, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: % 2", 1933, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: % 3", 1934, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: Loop # 1", 1935, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: Loop # 2", 1936, typeof(byte)),
                new MhwStructData.Entry("Feline Polisher: Loop # 3", 1937, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Rider: Attack Rate", 1938, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Heroics: Attack Rate", 1942, typeof(float)),
                new MhwStructData.Entry("Feline Heroics: Defense Rate", 1946, typeof(float)),
                new MhwStructData.Entry("Feline Heroics: Life Activation Threshold", 1950, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Carving L: Lottery % 1", 1951, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Lottery % 2", 1952, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Lottery % 3", 1953, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Up % 1", 1954, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Up % 2", 1955, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Up % 3", 1956, typeof(byte)),
                new MhwStructData.Entry("Feline Carving L: Up % 4", 1957, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Carving S: Lottery %", 1958, typeof(byte)),
                new MhwStructData.Entry("Feline Carving S: Up %", 1959, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Medic: Heal Rate", 1960, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Black Belt: Stamina Rate", 1964, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Special Attack: Condition Attack Bonus", 1968, typeof(ushort)),
                new MhwStructData.Entry("Feline Special Attack: Capture Attack Rate", 1970, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Defense S: %", 1974, typeof(byte)),
                new MhwStructData.Entry("Feline Defense S: Damage Rate", 1976, typeof(float)),
                new MhwStructData.Entry("Feline Defense L: %", 1975, typeof(byte)),
                new MhwStructData.Entry("Feline Defense L: Damage Rate", 1980, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Harvest: Cooldown Multiplier", 1984, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Sharpshooter: Shell Attack Rate", 1988, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Escape Artist: Dash Stamina Rate", 1992, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Delivery: Dash Stamina Rate", 1996, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Riser S: IFrames", 2000, typeof(float)),
                new MhwStructData.Entry("Feline Riser L: IFrames", 2004, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Temper: Shell Attack Rate", 2008, typeof(float)),
                new MhwStructData.Entry("Feline Temper: Blur Level Bonus", 2012, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Cliffhanger: Stamina Rate", 2013, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Slugger: Stun Attack Rate", 2017, typeof(float)),
                VerticalStruct.Spacer
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
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Moxie: Health Threshold", 2053, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Dungmaster: Escape % Bonus", 2054, typeof(byte)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Provoker: Rate", 2055, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Cool Cat: Power UP Time Needed", 2059, typeof(float)),
                new MhwStructData.Entry("Feline Cool Cat: Power UP Duration", 2063, typeof(float)),
                new MhwStructData.Entry("Feline Cool Cat: Attack Bonus", 2067, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Booster: Attack Bonus", 2071, typeof(float)),
                new MhwStructData.Entry("Feline Booster: Defense Bonus", 2075, typeof(float)),
                new MhwStructData.Entry("Feline Booster: Duration", 2079, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Groomer: Defense Down Duration Multiplier", 2083, typeof(float)),
                new MhwStructData.Entry("Feline Groomer: Element Blight Recovery Multiplier", 2087, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Feline Parting Gift: Radius", 2091, typeof(float)),
                new MhwStructData.Entry("Feline Parting Gift: Recovery Value", 2095, typeof(ushort)),
                VerticalStruct.Spacer
            });

            for (var s = 0; s < 5; s++) {
                entries.Add(new MhwStructData.Entry($"Feline Recoil: Attack Multiplier {s + 1}", 2097 + (ulong) s * 4, typeof(float)));
            }

            entries.AddRange(new List<MhwStructData.Entry> {
                VerticalStruct.Spacer,

                new MhwStructData.Entry($"Unk{i++}", 2117, typeof(float)),
                VerticalStruct.Spacer,

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
                VerticalStruct.Spacer,

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

            return new VerticalStruct("MHW_Editor.PlData", "PlSkillParam", new MhwStructData {
                size = 2400,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plsp"],
                ext = "plsp",
                entries = entries
            });
        }
    }
}