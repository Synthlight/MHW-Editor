using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.PlData {
    public class PlPlayerParam : IVerticalStruct {
        public VerticalStruct Generate() { // .plp
            // 'Unk' counters.
            ushort i = 1;
            ushort j = 1;
            ushort k = 1;
            ushort n = 1;

            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Gravity", 8, typeof(float)),
                new MhwStructData.Entry("Gravity Speed Rate", 12, typeof(float)),
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
                VerticalStruct.Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Health Initial Value", 408, typeof(float)),
                new MhwStructData.Entry("Health Max Value", 412, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Rate", 416, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Wait Time", 420, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Interval", 424, typeof(float)),
                new MhwStructData.Entry("Health Damage Recovery Value", 428, typeof(float)),
                VerticalStruct.Spacer,

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
                new MhwStructData.Entry("Stamina Time Reduce mCore: Lance's Power Guard", 588, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 592, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 596, typeof(float)),
                new MhwStructData.Entry("Stamina Time Reduce mCore: Clutch-Counter", 600, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 604, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 608, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 612, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 616, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k++}", 620, typeof(float)),
                new MhwStructData.Entry($"Stamina Time Reduce mCore: Unk{k}", 624, typeof(float)),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Mount Reduce Stamina mCore: Unk1", 628, typeof(float)),
                new MhwStructData.Entry("Mount Reduce Stamina mCore: Unk2", 632, typeof(float)),

                new MhwStructData.Entry("Mount Life Reduce Stamina mCore: Unk1", 636, typeof(float)),
                new MhwStructData.Entry("Mount Life Reduce Stamina mCore: Unk2", 640, typeof(float)),
                new MhwStructData.Entry("Mount Life Reduce Stamina mCore: Unk3", 644, typeof(float)),
                new MhwStructData.Entry("Mount Life Reduce Stamina mCore: Unk4", 648, typeof(float)),
                VerticalStruct.Spacer,

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
                new MhwStructData.Entry($"Unk{i++}", 698, typeof(uint)),
                new MhwStructData.Entry("Physical Attack Rate Limit", 702, typeof(float)),
                new MhwStructData.Entry("Elemental Attack Rate Limit", 706, typeof(float)),
                new MhwStructData.Entry("Condition Elemental Attack Flat Limit", 710, typeof(float)),
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
                VerticalStruct.Spacer,
                new MhwStructData.Entry("Walk Turn Tilt (Bow)", 791, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 795, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 799, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 803, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Run Turn Tilt (Bow)", 807, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Run Turn Tilt Head (Bow)", 811, typeof(float), true, forceUnique: true),
                VerticalStruct.Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Walk Turn Speed", 953, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Walk Turn Speed (Room)", 957, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Walk Stop Margin Time", 961, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Female Motion Start Time", 965, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 969, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 973, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Walk Motion Speed (Room)", 977, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Walk Motion Speed", 981, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Run Stop Margin Time", 985, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Run Turn Speed", 989, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Run Turn Lever Angle", 993, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Run Female Motion Start Time", 997, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1001, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1005, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Run Motion Speed (Room)", 1009, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Run Motion Speed", 1013, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Dash Turn Speed", 1017, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry("Dash Motion Speed", 1021, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1025, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1029, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1033, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1037, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1041, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1045, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1049, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1053, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1057, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1061, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1065, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1069, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1073, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1077, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1081, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i++}", 1085, typeof(float), true, forceUnique: true),
                new MhwStructData.Entry($"Unk{i}", 1089, typeof(float), true, forceUnique: true),
                VerticalStruct.Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
                VerticalStruct.Spacer
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

            entries.Add(VerticalStruct.Spacer);

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
                VerticalStruct.Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true, addOffset: 12),
                VerticalStruct.Spacer,

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
                VerticalStruct.Spacer,

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
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (1)", 8675, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (2)", 8676, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (3)", 8677, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (4)", 8678, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (1)", 8679, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (2)", 8680, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (3)", 8681, typeof(byte)),
                new MhwStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (4)", 8682, typeof(byte)),
                VerticalStruct.Spacer
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
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (1)", 8739, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (2)", 8743, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (3)", 8747, typeof(float)),
                new MhwStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (4)", 8751, typeof(float)),
                VerticalStruct.Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true),
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

            entries.AddRange(slingerRocks.Select((slingerRock, x) => new MhwStructData.Entry($"Max Slinger Capacity: {slingerRock}", 9345 + (ulong) x, typeof(byte))));

            entries.AddRange(new List<MhwStructData.Entry> {
                VerticalStruct.Spacer,
                new MhwStructData.Entry("------Skipping ahead.", 3, typeof(byte), true, forceUnique: true, addOffset: 40),
                VerticalStruct.Spacer,

                new MhwStructData.Entry("Gesture: Dragoon Jump Loop Time", 17801, typeof(float)),
                new MhwStructData.Entry("Gesture: Dragoon Jump Meteor Start", 17805, typeof(float)),
                new MhwStructData.Entry("Gesture: Dragoon Jump Meteor Duration", 17809, typeof(float)),
                VerticalStruct.Spacer,
                new MhwStructData.Entry("------Skipping the rest.", 3, typeof(byte), true, forceUnique: true),
                VerticalStruct.Spacer
            });

            return new VerticalStruct("MHW_Editor.PlData", "PlPlayerParam", new MhwStructData {
                size = 20640,
                offsetInitial = 0,
                entryCountOffset = -1,
                uniqueIdFormula = "0",
                encryptionKey = EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plp"],
                entries = entries
            });
        }
    }
}