using System.Collections.Generic;
using System.Linq;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.PlData {
    public class PlSkillParam : IMultiStruct {
        public MultiStruct Generate() { // .plsp
            // 'Unk' counters.
            ushort i           = 0;
            ushort j           = 0;
            uint   paramsIndex = 0;

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("PLS", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true)
                }, 1),

                new MhwMultiStructData.StructData($"Skill Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Speed Eating 1 Drink Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 2 Drink Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 3 Drink Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 1 Drink End Frame", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 2 Drink End Frame", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 3 Drink End Frame", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 1 Heal Speed Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 2 Heal Speed Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 3 Heal Speed Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 1 Meat Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 2 Meat Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 3 Meat Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 1 Meat Loop Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Speed Eating 2 Meat Loop Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Speed Eating 3 Meat Loop Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Speed Eating 1/2/3 Meat End Frame", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 1 Tablet Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 2 Tablet Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Speed Eating 3 Tablet Motion Speed", typeof(float)),

                    new MhwMultiStructData.Entry("Mud Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Mud Trans Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Elemental Damage Defense %", typeof(byte)),
                    new MhwMultiStructData.Entry("Elemental Damage Resist %", typeof(byte)),
                    new MhwMultiStructData.Entry("Elemental Damage Resist", typeof(byte)),
                    new MhwMultiStructData.Entry("Weakness Exploit Hit-Zone Threshold", typeof(byte)),
                    new MhwMultiStructData.Entry("Latent Power Activation Time", typeof(ushort)),
                    new MhwMultiStructData.Entry("Latent Power Total Damage to Trigger", typeof(ushort)),
                    new MhwMultiStructData.Entry("Latent Power Secret Total Damage to Trigger", typeof(ushort)),
                    new MhwMultiStructData.Entry("Heroics Activation Health %", typeof(float)),
                    new MhwMultiStructData.Entry("Guts Health Threshold", typeof(byte))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Wide Range", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level 1", typeof(float)),
                    new MhwMultiStructData.Entry("Level 2", typeof(float)),
                    new MhwMultiStructData.Entry("Level 3", typeof(float)),
                    new MhwMultiStructData.Entry("Level 4", typeof(float)),
                    new MhwMultiStructData.Entry("Level 5", typeof(float))
                }, 2),

                new MhwMultiStructData.StructData($"Skill Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Focus", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Time Rate 1", typeof(float)),
                    new MhwMultiStructData.Entry("Time Rate 2", typeof(float)),
                    new MhwMultiStructData.Entry("Time Rate 3", typeof(float))
                }, 3),

                new MhwMultiStructData.StructData("Punishing Draw", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Attack Power", typeof(ushort)),
                    new MhwMultiStructData.Entry("Stun", typeof(ushort)),
                    new MhwMultiStructData.Entry("Exhaust", typeof(ushort)),
                    new MhwMultiStructData.Entry("Param 4", typeof(ushort)),
                    new MhwMultiStructData.Entry("Param 5", typeof(ushort)),
                    new MhwMultiStructData.Entry("Param 6", typeof(ushort))
                }, 14),

                new MhwMultiStructData.StructData("Razor Sharp", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Sharpness No Reduce %", typeof(byte)),
                    new MhwMultiStructData.Entry("Gunlance Shot Sub Value", typeof(byte)),
                    new MhwMultiStructData.Entry("Gunlance Shot No Reduce %", typeof(byte)),
                    new MhwMultiStructData.Entry("Gun Ammo No Reduce %", typeof(byte)),
                    new MhwMultiStructData.Entry("Bow Coating No Reduce %", typeof(byte)),
                    new MhwMultiStructData.Entry("Guard Consumption %", typeof(byte))
                }, 2),

                new MhwMultiStructData.StructData("Minds Eye / Ballistics", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Critical Begin Wide Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Critical End Wide Rate", typeof(float))
                }, 2)
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

            var criticalConditionEntries = weapons.Select(weapon => new MhwMultiStructData.Entry(weapon, typeof(float))).ToList();
            var criticalElementEntries = new List<MhwMultiStructData.Entry>(criticalConditionEntries) {
                new MhwMultiStructData.Entry("Dragon Seal Rate", typeof(float))
            };

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Critical Element Multipliers", criticalElementEntries, 2),

                new MhwMultiStructData.StructData("Critical Condition Multipliers", criticalConditionEntries, 2)
            });

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"Skill Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Bludgeoner: Red Sharpness Attack Bonus (& BG Melee)", typeof(ushort)),
                    new MhwMultiStructData.Entry("Bludgeoner: Orange Sharpness Attack Bonus", typeof(ushort)),
                    new MhwMultiStructData.Entry("Bludgeoner: Yellow Sharpness Attack Bonus", typeof(ushort)),
                    new MhwMultiStructData.Entry("Bludgeoner: Green Sharpness Attack Bonus", typeof(ushort)),
                    new MhwMultiStructData.Entry("Bludgeoner: Blue Sharpness Attack Bonus", typeof(ushort)),
                    new MhwMultiStructData.Entry("Bludgeoner: White Sharpness Attack Bonus", typeof(ushort)),
                    new MhwMultiStructData.Entry("Bludgeoner: Purple Sharpness Attack Bonus", typeof(ushort)),
                    new MhwMultiStructData.Entry("Bludgeoner: Bowgun Melee Attack Stun Bonus", typeof(ushort)),

                    new MhwMultiStructData.Entry("Non-Elemental Boost: Attack Multiplier", typeof(float)),

                    new MhwMultiStructData.Entry("Affinity Slider: Attack Up Activate Time", typeof(float)),
                    new MhwMultiStructData.Entry("Affinity Slider: Attack Up Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Affinity Slider: Attack Critical Bonus", typeof(byte))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Artillery", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level 1", typeof(float)),
                    new MhwMultiStructData.Entry("Level 2", typeof(float)),
                    new MhwMultiStructData.Entry("Level 3", typeof(float)),
                    new MhwMultiStructData.Entry("Level 4", typeof(float)),
                    new MhwMultiStructData.Entry("Level 5", typeof(float))
                }, 9),

                new MhwMultiStructData.StructData($"Skill Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Heavy Artillery: Ballista Attack Rate 1", typeof(float)),
                    new MhwMultiStructData.Entry("Heavy Artillery: Ballista Attack Rate 2", typeof(float)),
                    new MhwMultiStructData.Entry("Heavy Artillery: Cannon Attack Rate 1", typeof(float)),
                    new MhwMultiStructData.Entry("Heavy Artillery: Cannon Attack Rate 2", typeof(float)),

                    new MhwMultiStructData.Entry("Bombardier: Attack Rate 1", typeof(float)),
                    new MhwMultiStructData.Entry("Bombardier: Attack Rate 2", typeof(float)),
                    new MhwMultiStructData.Entry("Bombardier: Attack Rate 3", typeof(float)),
                    new MhwMultiStructData.Entry("Bombardier: Attack Rate 4", typeof(float)),
                    new MhwMultiStructData.Entry("Bombardier: Attack Rate 5", typeof(float)),

                    new MhwMultiStructData.Entry("Capacity Boost: Gunlance Normal Bonus", typeof(byte)),
                    new MhwMultiStructData.Entry("Capacity Boost: Gunlance Radiation Bonus", typeof(byte)),
                    new MhwMultiStructData.Entry("Capacity Boost: Gunlance Scatter Bonus", typeof(byte)),
                    new MhwMultiStructData.Entry("Capacity Boost: Charge Blade Shield Duration Bonus", typeof(byte))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData("Ammo Up", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Capacity 1 Limit", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Capacity 1 Bonus", typeof(byte)),
                    new MhwMultiStructData.Entry("Capacity 2 Limit", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Capacity 2 Bonus", typeof(byte)),
                    new MhwMultiStructData.Entry("Capacity 3 Limit", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Capacity 3 Bonus", typeof(byte)),
                    new MhwMultiStructData.Entry("Capacity 4 Limit", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Capacity 4 Bonus", typeof(byte))
                }, 3),

                new MhwMultiStructData.StructData("Power Prolonger", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level 1", typeof(float)),
                    new MhwMultiStructData.Entry("Level 2", typeof(float)),
                    new MhwMultiStructData.Entry("Level 3", typeof(float))
                }, 5),

                new MhwMultiStructData.StructData($"Skill Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Health Auto Recover Interval", typeof(float)),
                    new MhwMultiStructData.Entry("Health Auto Recover Value", typeof(byte))
                }.Out(out var temp1), 1, showVertically: true)
            });

            var healthRecoveryEntries = weapons.Select(weapon => new MhwMultiStructData.Entry($"Hasten Recovery: ({weapon}) Recovery Health", typeof(byte))).ToList();
            temp1.AddRange(healthRecoveryEntries);

            temp1.AddRange(new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Hasten Recovery: Success Combo #", typeof(byte)),
                new MhwMultiStructData.Entry("Hasten Recovery: Combo Duration", typeof(float)),
                new MhwMultiStructData.Entry("Hasten Recovery: Combo Ignore Time", typeof(float)),

                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(float))
            });

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Slinger Up", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Level 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Level 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Level 4", typeof(byte)),
                    new MhwMultiStructData.Entry("Level 5", typeof(byte))
                }, 31),

                new MhwMultiStructData.StructData($"Skill Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Master Fisher: Add Hook Time", typeof(float)),
                    new MhwMultiStructData.Entry("Master Fisher: Big Fish Catch Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Adrenaline: Stamina Rate", typeof(float))
                }.Out(out var temp2), 1, showVertically: true)
            });

            var elementalAirborneEntries = weapons.Select(weapon => new MhwMultiStructData.Entry($"Elemental Airborne: ({weapon}) Rate", typeof(float))).ToList();
            temp2.AddRange(elementalAirborneEntries);

            temp2.AddRange(new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                new MhwMultiStructData.Entry($"Unk{++i}", typeof(float))
            });

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Frostcraft (1)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Level Multiplier (0-15%)", typeof(float)),
                    new MhwMultiStructData.Entry("Level Multiplier (16-45%)", typeof(float)),
                    new MhwMultiStructData.Entry("Level Multiplier (46-80%)", typeof(float)),
                    new MhwMultiStructData.Entry("Level Multiplier (81-100%)", typeof(float)),
                    new MhwMultiStructData.Entry("Recovery Speed: Unsheathed", typeof(float)),
                    new MhwMultiStructData.Entry("Recovery Speed: Sheathed", typeof(float)),
                    new MhwMultiStructData.Entry("Consumption per Hit", typeof(float))
                }, 14),

                new MhwMultiStructData.StructData("Frostcraft (2)", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(byte)),

                    new MhwMultiStructData.Entry("Frostcraft: Bow: (Rapid Shot & Clutch Claw Arrow) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bow: (Power Shot) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bow: (Arc Shot) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bow: (Dragonpiercer) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bow: (Thousand Dragons) Consumption per Hit", typeof(byte)),

                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Normal Ammo) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Pierce Ammo) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Spread Ammo) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Sticky Ammo) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Cluster Ammo) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Elemental Ammo) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Status Ammo) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Wyvern Ammo) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: Bowgun: (Slicing Ammo) Consumption per Hit", typeof(byte)),

                    new MhwMultiStructData.Entry("Frostcraft: HBG: (Wyvernheart) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: HBG: (Wyvernsnipe) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: HBG: (Wyvernsnipe Type 2) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: HBG: (Claw Wyvernheart Gatling) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: HBG: (Claw Wyvernheart Finish) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: HBG: (Wyvernsnipe Claw) Consumption per Hit", typeof(byte)),

                    new MhwMultiStructData.Entry("Frostcraft: LBG: (Wyvernblast) Consumption per Hit", typeof(byte)),
                    new MhwMultiStructData.Entry("Frostcraft: LBG: (Wyvernblast Claw) Consumption per Hit", typeof(byte))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Skill Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk Safi {++j}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry("Offensive Guard", typeof(float)),
                    new MhwMultiStructData.Entry("Coalescence", typeof(float)),

                    new MhwMultiStructData.Entry($"Unk Safi {++j}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk Safi {++j}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk Safi {++j}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk Safi {++j}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk Safi {++j}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk Safi {++j}", typeof(float)),
                    new MhwMultiStructData.Entry("Set(3) Elemental Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Set(5) Elemental Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Set(3) Status Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Set(5) Status Bonus", typeof(float)),
                    new MhwMultiStructData.Entry("Set(3) Affinity Bonus", typeof(uint)),
                    new MhwMultiStructData.Entry("Set(5) Affinity Bonus", typeof(uint))
                }.Out(out var temp3), 1, showVertically: true)
            });

            var safiSealEntries = weapons.Select(weapon => new MhwMultiStructData.Entry($"Safi'Jiva Seal: ({weapon}) Hit Combo to Heal", typeof(byte))).ToList();
            safiSealEntries.AddRange(weapons.Select(weapon => new MhwMultiStructData.Entry($"Safi'Jiva Seal: ({weapon}) HP Lost Per Hit", typeof(float))));
            temp3.AddRange(safiSealEntries);

            temp3.AddRange(new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Safi: Recovery Interval", typeof(float)),
                new MhwMultiStructData.Entry("Safi: Recovery Amount", typeof(float)),
                new MhwMultiStructData.Entry("Safi: Recovery Time", typeof(float)),
                new MhwMultiStructData.Entry($"Unk Safi {++j}", typeof(float)),
                new MhwMultiStructData.Entry("Set(3) Elemental Limit", typeof(float)),
                new MhwMultiStructData.Entry("Set(5) Elemental Limit", typeof(float)),
                new MhwMultiStructData.Entry("Set(3) Bowgun Elemental Limit", typeof(float)),
                new MhwMultiStructData.Entry("Set(5) Bowgun Elemental Limit", typeof(float)),
                new MhwMultiStructData.Entry("Set(3) Status Limit", typeof(float)),
                new MhwMultiStructData.Entry("Set(5) Status Limit", typeof(float))
            });

            var foodEffectsEntries = new List<MhwMultiStructData.Entry>();
            for (var s = 0; s < 6; s++) {
                foodEffectsEntries.Add(new MhwMultiStructData.Entry($"Food Effect: Life Up {s + 1}", typeof(ushort)));
            }
            for (var s = 0; s < 3; s++) {
                foodEffectsEntries.Add(new MhwMultiStructData.Entry($"Food Effect: Stamina Up {s + 1}", typeof(ushort)));
            }
            for (var s = 0; s < 4; s++) {
                foodEffectsEntries.Add(new MhwMultiStructData.Entry($"Food Effect: Attack Up {s + 1}", typeof(ushort)));
            }
            for (var s = 0; s < 4; s++) {
                foodEffectsEntries.Add(new MhwMultiStructData.Entry($"Food Effect: Defense Up {s + 1}", typeof(ushort)));
            }
            for (var s = 0; s < 4; s++) {
                foodEffectsEntries.Add(new MhwMultiStructData.Entry($"Food Effect: All Resistances Up {s + 1}", typeof(ushort)));
            }

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Food Effects", foodEffectsEntries, 1, showVertically: true),

                new MhwMultiStructData.StructData("Feline Skill", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Feline Polisher: % 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Polisher: % 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Polisher: % 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Polisher: Loop # 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Polisher: Loop # 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Polisher: Loop # 3", typeof(byte)),

                    new MhwMultiStructData.Entry("Feline Rider: Attack Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Heroics: Attack Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Feline Heroics: Defense Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Feline Heroics: Life Activation Threshold", typeof(byte)),

                    new MhwMultiStructData.Entry("Feline Carving L: Lottery % 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Carving L: Lottery % 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Carving L: Lottery % 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Carving L: Up % 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Carving L: Up % 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Carving L: Up % 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Carving L: Up % 4", typeof(byte)),

                    new MhwMultiStructData.Entry("Feline Carving S: Lottery %", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Carving S: Up %", typeof(byte)),

                    new MhwMultiStructData.Entry("Feline Medic: Heal Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Black Belt: Stamina Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Special Attack: Condition Attack Bonus", typeof(ushort)),
                    new MhwMultiStructData.Entry("Feline Special Attack: Capture Attack Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Defense S: %", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Defense L: %", typeof(byte)),
                    new MhwMultiStructData.Entry("Feline Defense S: Damage Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Feline Defense L: Damage Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Harvest: Cooldown Multiplier", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Sharpshooter: Shell Attack Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Escape Artist: Dash Stamina Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Delivery: Dash Stamina Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Riser S: IFrames", typeof(float)),
                    new MhwMultiStructData.Entry("Feline Riser L: IFrames", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Temper: Shell Attack Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Feline Temper: Blur Level Bonus", typeof(byte)),

                    new MhwMultiStructData.Entry("Feline Cliffhanger: Stamina Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Feline Slugger: Stun Attack Rate", typeof(float))
                }.Out(out var felineSkillEntries), 1, showVertically: true)
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

            felineSkillEntries.AddRange(felineBombardierParams.Select((felineBombardier, x) => new MhwMultiStructData.Entry($"Feline Bombardier: {felineBombardier} Attack Rate", typeof(float))));

            felineSkillEntries.AddRange(new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Feline Moxie: Health Threshold", typeof(byte)),

                new MhwMultiStructData.Entry("Feline Dungmaster: Escape % Bonus", typeof(byte)),

                new MhwMultiStructData.Entry("Feline Provoker: Rate", typeof(float)),

                new MhwMultiStructData.Entry("Feline Cool Cat: Power UP Time Needed", typeof(float)),
                new MhwMultiStructData.Entry("Feline Cool Cat: Power UP Duration", typeof(float)),
                new MhwMultiStructData.Entry("Feline Cool Cat: Attack Bonus", typeof(float)),

                new MhwMultiStructData.Entry("Feline Booster: Attack Bonus", typeof(float)),
                new MhwMultiStructData.Entry("Feline Booster: Defense Bonus", typeof(float)),
                new MhwMultiStructData.Entry("Feline Booster: Duration", typeof(float)),

                new MhwMultiStructData.Entry("Feline Groomer: Defense Down Duration Multiplier", typeof(float)),
                new MhwMultiStructData.Entry("Feline Groomer: Element Blight Recovery Multiplier", typeof(float)),

                new MhwMultiStructData.Entry("Feline Parting Gift: Radius", typeof(float)),
                new MhwMultiStructData.Entry("Feline Parting Gift: Recovery Value", typeof(ushort))
            });

            for (var s = 0; s < 5; s++) {
                felineSkillEntries.Add(new MhwMultiStructData.Entry($"Feline Recoil: Attack Multiplier {s + 1}", typeof(float)));
            }

            felineSkillEntries.AddRange(new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Feline Tailor", typeof(float))
            });

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"Skill Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Music Skill: Bless: Random Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Bless: Damage Cut Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Extend: Time", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Extend: Time Master", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Extend: Time MR Master", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Major Heal: Rand Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Major Heal: Rand Master Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Major Heal: Rand MR Master Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Heal 0: Minor", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Heal 0: Major", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Heal 1: Minor", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Heal 1: Major", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Heal 2: Minor", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Heal 2: Major", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Hp Up 0", typeof(uint)),
                    new MhwMultiStructData.Entry("Music Skill: Hp Up 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Music Skill: Mantle Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Mantle Duration Put", typeof(float)),
                    new MhwMultiStructData.Entry("Music Skill: Stamina Up Rate", typeof(float)),

                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk{++i}", typeof(float))
                }, 1, showVertically: true)
            });

            return new MultiStruct("PlData", "PlSkillParam", new MhwMultiStructData(structs, "plsp", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plsp"]));
        }
    }
}