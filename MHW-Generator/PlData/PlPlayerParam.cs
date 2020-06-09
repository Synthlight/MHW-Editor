using System.Collections.Generic;
using System.Linq;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.PlData {
    public class PlPlayerParam : IMultiStruct {
        public MultiStruct Generate() { // .plp
            // 'Unk' counters.
            ushort unk                     = 0;
            ushort staminaConsumptionIndex = 0;
            ushort staminaTimeReduceIndex  = 0;
            uint   arrayIndex              = 0;
            uint   paramsIndex             = 0;
            uint   cdBlockIndex            = 0;
            uint   skippingAheadIndex      = 0;

            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("PLP", typeof(char), true, typeof(string), arrayCount: 4),
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true)
                }, 1),

                new MhwMultiStructData.StructData($"Player Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Gravity", typeof(float)),
                    new MhwMultiStructData.Entry("Gravity Speed Rate", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Player Params ({++paramsIndex}) - Unk Array ({++arrayIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(ushort))
                }, 12),

                new MhwMultiStructData.StructData($"Player Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(uint)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),

                    new MhwMultiStructData.Entry("Health Initial Value", typeof(float)),
                    new MhwMultiStructData.Entry("Health Max Value", typeof(float)),
                    new MhwMultiStructData.Entry("Health Damage Recovery Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Health Damage Recovery Wait Time", typeof(float)),
                    new MhwMultiStructData.Entry("Health Damage Recovery Interval", typeof(float)),
                    new MhwMultiStructData.Entry("Health Damage Recovery Value", typeof(float)),

                    new MhwMultiStructData.Entry("Stamina Initial Value", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Max Value", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Min Value", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Tired Value", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Auto Recover", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Auto Max Reduce", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Auto Max Reduce Time", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina IB Unknown", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Escape Dash Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Out of Battle Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Reduce Rate Limit Trigger", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Reduce Rate Limit Time", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Mount Endurance Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Stamina Consumption: Dodge", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Consumption: LS Counter", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Consumption: SA Wild Swing", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Consumption: Bow Shoot", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Consumption: Bow Charge Step", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Consumption: Claw Attack 1", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Consumption: Claw Attack 2", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Consumption: Claw Attack 3", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Consumption: Claw Attack 4", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Consumption: Unk{++staminaConsumptionIndex}", typeof(float)),

                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Time Reduce mCore: Hammer/Bow Charge Drain", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Time Reduce mCore: Lance's Power Guard", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Time Reduce mCore: Clutch Drain (Whilst Grappled)", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Time Reduce mCore: Clutch-Counter", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),
                    new MhwMultiStructData.Entry($"Stamina Time Reduce mCore: Unk{++staminaTimeReduceIndex}", typeof(float)),

                    new MhwMultiStructData.Entry("Mount Reduce Stamina mCore: Unk1", typeof(float)),
                    new MhwMultiStructData.Entry("Mount Reduce Stamina mCore: Unk2", typeof(float)),

                    new MhwMultiStructData.Entry("Mount Life Reduce Stamina mCore: Unk1", typeof(float)),
                    new MhwMultiStructData.Entry("Mount Life Reduce Stamina mCore: Unk2", typeof(float)),
                    new MhwMultiStructData.Entry("Mount Life Reduce Stamina mCore: Unk3", typeof(float)),
                    new MhwMultiStructData.Entry("Mount Life Reduce Stamina mCore: Unk4", typeof(float)),

                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry("Explosive HR Fixed Attack Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Explosive MR Fixed Attack Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Critical Attack Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Bad Critical Attack Rate", typeof(float)),

                    new MhwMultiStructData.Entry("Sharpness Recoil Reduction %", typeof(byte)),
                    new MhwMultiStructData.Entry("Sharpness Recoil Reduction Value", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(uint)),
                    new MhwMultiStructData.Entry("Physical Attack Rate Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Elemental Attack Rate Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Condition Elemental Attack Flat Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Bowgun Elemental Attack Rate Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Condition Attack Rate Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Stun Attack Rate Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Stamina Attack Rate Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Mount Attack Rate Limit", typeof(float)),
                    new MhwMultiStructData.Entry("Super Armor Stun Damage Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Hyper Armor Damage Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Hyper Armor Stun Damage Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Gunner Defense Rate", typeof(float)),
                    new MhwMultiStructData.Entry("Gunner Elemental Resistance Bonus", typeof(byte)),
                    new MhwMultiStructData.Entry("Lava Damage Interval Time", typeof(float)),
                    new MhwMultiStructData.Entry("Lava Damage Damage", typeof(float)),
                    new MhwMultiStructData.Entry("Acid Damage Interval Time", typeof(float)),
                    new MhwMultiStructData.Entry("Acid Damage Damage", typeof(float))
                }, 1, showVertically: true)
            };

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"CD Block ({++cdBlockIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk", typeof(uint), true)
                }, 4, true),

                new MhwMultiStructData.StructData($"Player Params ({++paramsIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry("Walk Turn Tilt (Bow)", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry("Run Turn Tilt (Bow)", typeof(float)),
                    new MhwMultiStructData.Entry("Run Turn Tilt Head (Bow)", typeof(float)),

                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(byte)),

                    new MhwMultiStructData.Entry("Walk Turn Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Walk Turn Speed (Room)", typeof(float)),
                    new MhwMultiStructData.Entry("Walk Stop Margin Time", typeof(float)),
                    new MhwMultiStructData.Entry("Female Motion Start Time", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry("Walk Motion Speed (Room)", typeof(float)),
                    new MhwMultiStructData.Entry("Walk Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Run Stop Margin Time", typeof(float)),
                    new MhwMultiStructData.Entry("Run Turn Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Run Turn Lever Angle", typeof(float)),
                    new MhwMultiStructData.Entry("Run Female Motion Start Time", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry("Run Motion Speed (Room)", typeof(float)),
                    new MhwMultiStructData.Entry("Run Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Dash Turn Speed", typeof(float)),
                    new MhwMultiStructData.Entry("Dash Motion Speed", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float)),
                    new MhwMultiStructData.Entry($"Unk {++unk}", typeof(float))
                }, 1, showVertically: true),

                new MhwMultiStructData.StructData($"Player Params ({++paramsIndex}) - Dodge IFrames", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Evasion 0", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion 1", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion 2", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion 3", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion 4", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion 5", typeof(float)),
                    new MhwMultiStructData.Entry("Evasion Mantle", typeof(float))
                }, 10),

                new MhwMultiStructData.StructData($"Player Params ({++paramsIndex}) - Evade Distance", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Distance 1", typeof(float)),
                    new MhwMultiStructData.Entry("Distance 2", typeof(float)),
                    new MhwMultiStructData.Entry("Distance 3", typeof(float))
                }, 11)
            });

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"Skipping Ahead ({++skippingAheadIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Raw Bytes", typeof(void), subStruct: new MhwMultiStructData.StructData($"Raw Bytes ({skippingAheadIndex})", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Byte", typeof(byte))
                    }, 7014))
                }, 1),

                new MhwMultiStructData.StructData($"Player Params ({++paramsIndex}) - HR/MR Augment Params", new List<MhwMultiStructData.Entry> {
                    // HR Augment.
                    new MhwMultiStructData.Entry("Wp HR Augment Attack Bonus (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Attack Bonus (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Attack Bonus (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Critical Bonus (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Critical Bonus (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Critical Bonus (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense Bonus (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense Bonus (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense Bonus (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense: Divine Blessing Chance (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense: Divine Blessing Chance (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense: Divine Blessing Chance (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense: Divine Blessing Reduction (1)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense: Divine Blessing Reduction (2)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense: Divine Blessing Reduction (3)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense Heal Damage Rate (1)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense Heal Damage Rate (2)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp HR Augment Defense Heal Damage Rate (3)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp HR Augment IB Unk", typeof(float)),
                    new MhwMultiStructData.Entry("Wp HR Augment Lifesteal Cooldown", typeof(float)),

                    // MR Augment now.
                    new MhwMultiStructData.Entry("Wp MR Augment Attack Bonus (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Attack Bonus (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Attack Bonus (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Attack Bonus (4)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Critical Bonus (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Critical Bonus (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Critical Bonus (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Critical Bonus (4)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense Bonus (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense Bonus (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense Bonus (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense Bonus (4)", typeof(byte)),

                    new MhwMultiStructData.Entry("Wp MR Augment Defense: Divine Blessing Chance (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense: Divine Blessing Chance (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense: Divine Blessing Chance (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense: Divine Blessing Chance (4)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense: Divine Blessing Reduction (1)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense: Divine Blessing Reduction (2)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense: Divine Blessing Reduction (3)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp MR Augment Defense: Divine Blessing Reduction (4)", typeof(float)),

                    new MhwMultiStructData.Entry("Wp MR Augment Health Percent (1)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp MR Augment Health Percent (2)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp MR Augment Health Percent (3)", typeof(float)),
                    new MhwMultiStructData.Entry("Wp MR Augment Health Percent (4)", typeof(float)),

                    new MhwMultiStructData.Entry("WP MR Wyrmstake Blast Health Regen", typeof(float)),

                    new MhwMultiStructData.Entry("Wp MR Augment Lifesteal Cooldown", typeof(float)),
                    new MhwMultiStructData.Entry("Wp MR Augment Element (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Element (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Element (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Element (4)", typeof(byte)),

                    new MhwMultiStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (4)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (1)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (2)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (3)", typeof(byte)),
                    new MhwMultiStructData.Entry("Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (4)", typeof(byte))
                }.Out(out var hrMwAugmentEntries), 1, showVertically: true)
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

            hrMwAugmentEntries.AddRange(weapons.Select(weapon => new MhwMultiStructData.Entry($"Wp MR Augment {weapon} Elemental Multiplier", typeof(float))).ToList());
            hrMwAugmentEntries.AddRange(new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (1)", typeof(float)),
                new MhwMultiStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (2)", typeof(float)),
                new MhwMultiStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (3)", typeof(float)),
                new MhwMultiStructData.Entry("Wp MR Augment Bow Coating Status Multiplier (4)", typeof(float))
            });

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"Skipping Ahead ({++skippingAheadIndex})", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Raw Bytes", typeof(void), subStruct: new MhwMultiStructData.StructData($"Raw Bytes ({skippingAheadIndex})", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Byte", typeof(byte))
                    }, 590))
                }, 1)
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

            var slingerCapacityEntries = slingerRocks.Select(slingerRock => new MhwMultiStructData.Entry($"Max Slinger Capacity: {slingerRock}", typeof(byte))).ToList();

            structs.AddRange(new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData($"Player Params ({++paramsIndex}) - Slinger Params", slingerCapacityEntries, 1, showVertically: true),

                new MhwMultiStructData.StructData("The Rest", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("The rest of the file as bytes.", typeof(void), true, subStruct: new MhwMultiStructData.StructData("End Junk", new List<MhwMultiStructData.Entry> {
                        new MhwMultiStructData.Entry("Unk", typeof(byte), true)
                    }, customSaveLoad: true))
                }, 1)
            });

            return new MultiStruct("MHW_Editor.PlData", "PlPlayerParam", new MhwMultiStructData(structs, "plp", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".plp"]));
        }
    }
}